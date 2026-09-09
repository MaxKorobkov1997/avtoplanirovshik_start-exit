using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace avtoplanirovshik_start_exit.git
{
    public partial class FormMainMtnu : Form
    {
        FormStyle style;
        AppSettings appSettings;
        private Form activeForm;
        public FormMainMtnu()
        {
            InitializeComponent();
        }

        private void FormMainMtnu_Load(object sender, EventArgs e)
        {
            LoadSettings();
            button1.Font = Static.font;
            button2.Font = Static.font;
            button3.Font = Static.font;
            clock.Font = Static.font;
            button1.Click += (c, e) => OpenChildForm(new Form1(this), c);
            button2.Click += (c, e) => OpenChildForm(new Form2(), c);
            button3.Click += (c, e) => OpenChildForm(new Form3(), c);
            //button4.Click += (c, e) => OpenChildForm(new Form4(), c);
            timer1.Tick += timer1_Tick;
            style = new FormStyle(this);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //Console.WriteLine($"D: {now.ToString("D")}"); //D: 6 января 2022 г.
            //Console.WriteLine($"d: {now.ToString("d")}"); //d: 06.01.2022
            //Console.WriteLine($"F: {now.ToString("F")}"); //F: 6 января 2022 г. 14:45:20
            //Console.WriteLine($"f: {now:f}"); //f: 6 января 2022 г. 14:45
            //Console.WriteLine($"G: {now:G}"); //G: 06.01.2022 14:45:20
            //Console.WriteLine($"g: {now:g}"); //g: 06.01.2022 14:45
            //Console.WriteLine($"M: {now:M}"); //M: 6 января
            //Console.WriteLine($"O: {now:O}"); //O: 2022-01-06T14:45:20.3942344+04:00
            //Console.WriteLine($"o: {now:o}"); //o: 2022-01-06T14:45:20.3942344+04:00
            //Console.WriteLine($"R: {now:R}"); //R: Thu, 06 Jan 2022 14:45:20 GMT
            //Console.WriteLine($"s: {now:s}"); //s: 2022-01-06T14:45:20
            clock.Text = $"{now:T} {now:dddd}"; //T: 14:45:20
            //Console.WriteLine($"t: {now:t}"); //t: 14:45
            //Console.WriteLine($"U: {now:U}"); //U: 6 января 2022 г. 10:45:20
            //Console.WriteLine($"u: {now:u}"); //u: 2022-01-06 14:45:20
            //Console.WriteLine($"Y: {now:Y}"); //Y: январь 2022 г.
            if ($"{now:T}" == appSettings.StartTime.Replace(" ", ""))
                if (check($"{now:dddd}"))
                    start_exit_proc(Static.file_start, true);
            if ($"{now:T}" == appSettings.StopTime.Replace(" ", ""))
                if (check($"{now:dddd}"))
                    start_exit_proc(Static.file_exit, false);
        }
        private void start_exit_proc(string filePath, bool isStart)
        {
            if (!File.Exists(filePath)) return;

            foreach (var line in File.ReadLines(filePath))
            {
                string path = line.Trim();
                if (string.IsNullOrEmpty(path)) continue;

                if (isStart)
                {
                    try
                    {
                        var startInfo = new ProcessStartInfo(path)
                        {
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            ErrorDialog = false
                        };
                        Process.Start(startInfo);
                    }
                    catch (Exception ex)
                    {
                        // Лучше логировать в файл, а не в консоль
                        Debug.WriteLine($"Не удалось запустить {path}: {ex.Message}");
                    }
                }
                else
                {
                    // Для завершения берём имя процесса без пути и расширения
                    string processName = Path.GetFileNameWithoutExtension(path);
                    if (string.IsNullOrEmpty(processName)) continue;

                    var processes = Process.GetProcessesByName(processName);
                    foreach (var proc in processes)
                    {
                        try
                        {
                            proc.Kill();
                        }
                        catch (Exception) { /* процесс уже умер */ }
                    }
                }
            }
        }

        bool check(string text)
        {
            Dictionary<string, bool> days = new Dictionary<string, bool>
            {
                ["понедельник"] = appSettings.Monday,
                ["вторник"] = appSettings.Tuesday,
                ["среда"] = appSettings.Wednesday,
                ["четверг"] = appSettings.Thursday,
                ["пятница"] = appSettings.Friday,
                ["суббота"] = appSettings.Saturday,
                ["воскресенье"] = appSettings.Saturday
            };
            bool pr = days[text];
            if (pr)
                return true;
            else
                return false;
        }

        public void LoadSettings()
        {
            if (!File.Exists(Static.settingsPath)) return; // первый запуск — всё по умолчанию

            try
            {
                appSettings = new AppSettings();
                var json = File.ReadAllText(Static.settingsPath);
                var settings = System.Text.Json.JsonSerializer.Deserialize<AppSettings>(json);

                if (settings != null)
                {
                     appSettings.Monday = settings.Monday;
                     appSettings.Thursday = settings.Tuesday;
                     appSettings.Wednesday = settings.Wednesday;
                     appSettings.Thursday = settings.Thursday;
                     appSettings.Friday = settings.Friday;
                     appSettings.Saturday= settings.Saturday;
                     appSettings.Sunday = settings.Sunday;

                    appSettings.StartTime = settings.StartTime ?? "";
                    appSettings.StopTime = settings.StopTime ?? "";
                }
            }
            catch
            {
                // файл повреждён — игнорируем, оставляем по умолчанию
            }
        }
    }
}
