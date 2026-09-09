using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace avtoplanirovshik_start_exit.git
{
    public partial class Form1 : Form
    {
        FormMainMtnu form;
        private const string RunKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
        private const string AppName = "avtoplanirovshik_start_exit";
        public Form1(FormMainMtnu formMainMtnu)
        {
            form = formMainMtnu;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.CheckedChanged += (s, e) => SaveSettings();
            checkBox2.CheckedChanged += (s, e) => SaveSettings();
            checkBox3.CheckedChanged += (s, e) => SaveSettings();
            checkBox4.CheckedChanged += (s, e) => SaveSettings();
            checkBox5.CheckedChanged += (s, e) => SaveSettings();
            checkBox6.CheckedChanged += (s, e) => SaveSettings();
            checkBox7.CheckedChanged += (s, e) => SaveSettings();
            maskedTextBox1.TextChanged += (s, e) => SaveSettings();
            maskedTextBox2.TextChanged += (s, e) => SaveSettings();
            checkBoxAutostart.Checked = IsInStartup();
            LoadSettings();

            // При изменении галочки сразу пишем в реестр
            checkBoxAutostart.CheckedChanged += (s, ev) =>
            {
                if (checkBoxAutostart.Checked)
                    AddToStartup();
                else
                    RemoveFromStartup();
            };
        }

        private void LoadSettings()
        {
            if (!File.Exists(Static.settingsPath)) return; // первый запуск — всё по умолчанию

            try
            {
                var json = File.ReadAllText(Static.settingsPath);
                var settings = System.Text.Json.JsonSerializer.Deserialize<AppSettings>(json);

                if (settings != null)
                {
                    checkBox1.Checked = settings.Monday;
                    checkBox2.Checked = settings.Tuesday;
                    checkBox3.Checked = settings.Wednesday;
                    checkBox4.Checked = settings.Thursday;
                    checkBox5.Checked = settings.Friday;
                    checkBox6.Checked = settings.Saturday;
                    checkBox7.Checked = settings.Sunday;

                    maskedTextBox1.Text = settings.StartTime ?? "";
                    maskedTextBox2.Text = settings.StopTime ?? "";
                }
            }
            catch
            {
                // файл повреждён — игнорируем, оставляем по умолчанию
            }
        }

        private void AddToStartup()
        {
            try
            {
                // Получаем путь к текущему exe
                string path = System.Reflection.Assembly.GetEntryAssembly().Location;
                using (var key = Registry.CurrentUser.CreateSubKey(RunKey))
                {
                    key.SetValue(AppName, $"\"{path}\"");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить в автозагрузку: " + ex.Message);
            }
        }

        // Удаляет из автозагрузки
        private void RemoveFromStartup()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(RunKey, true))
                {
                    if (key != null)
                        key.DeleteValue(AppName, false);
                }
            }
            catch { /* Игнорируем, если уже нет */ }
        }

        private bool IsInStartup()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RunKey))
            {
                return key?.GetValue(AppName) != null;
            }
        }


        private void SaveSettings()
        {
            var settings = new AppSettings
            {
                Monday = checkBox1.Checked,
                Tuesday = checkBox2.Checked,
                Wednesday = checkBox3.Checked,
                Thursday = checkBox4.Checked,
                Friday = checkBox5.Checked,
                Saturday = checkBox6.Checked,
                Sunday = checkBox7.Checked,

                StartTime = maskedTextBox1.Text.Trim(),
                StopTime = maskedTextBox2.Text.Trim()
            };

            File.WriteAllText(Static.settingsPath, System.Text.Json.JsonSerializer.Serialize(settings));
            form.LoadSettings();
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            Point mousePoint = Cursor.Position;

            // Преобразуем координаты экрана в координаты клиента MaskedTextBox
            Point clientPoint = maskedTextBox1.PointToClient(mousePoint);
            if (clientPoint.X > 70)
            {
                maskedTextBox1.Select(maskedTextBox1.Text.Replace(" :", "").Replace(" ", "").Length, 0);
                maskedTextBox1.Focus();
            }
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Select(maskedTextBox2.Text.Replace(" :", "").Replace(" ", "").Length, 0);
            maskedTextBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "Executables|*.exe|All files|*.*",
                Title = "Выберите файл для автозапуска"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Проверяем, нет ли уже такого пути
                var lines = File.Exists(Static.file_start) ? File.ReadAllLines(Static.file_start).ToList() : new List<string>();
                if (!lines.Contains(filePath))
                {
                    lines.Add(filePath);
                    File.WriteAllLines(Static.file_start, lines);
                }
            }
        }

        private void proc_del_button_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(Static.file_exit, true))
                stream.WriteLine(proc_del.Text);
            proc_del.Text = "";
            form.LoadSettings();
        }
    }
}
