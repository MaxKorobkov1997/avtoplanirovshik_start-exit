using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoplanirovshik_start_exit
{
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                //notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                // возвращаем отображение окна в панели
                ShowInTaskbar = true;
                //разворачиваем окно
                WindowState = FormWindowState.Normal;
            }
            Activate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Text = "Выбор программы на \nавтовключения";
            button2.Font = new Font("Microsoft Sans Serif", 14);
            checkBox1.Font = new Font("Microsoft Sans Serif", 14);
            checkBox2.Font = new Font("Microsoft Sans Serif", 14);
            checkBox3.Font = new Font("Microsoft Sans Serif", 14);
            checkBox4.Font = new Font("Microsoft Sans Serif", 14);
            checkBox5.Font = new Font("Microsoft Sans Serif", 14);
            checkBox6.Font = new Font("Microsoft Sans Serif", 14);
            checkBox7.Font = new Font("Microsoft Sans Serif", 14);
            proc_del.Font = new Font("Microsoft Sans Serif", 14);
            proc_del_button.Font = new Font("Microsoft Sans Serif", 14);
            timer1.Tick += new EventHandler(timer1_Tick);
            // делаем нашу иконку в трее
            notifyIcon1.Visible = true;
            // добавляем Эвент или событие по 2му клику мышки, 
            //вызывая функцию  notifyIcon1_MouseClick
            notifyIcon1.MouseClick += new MouseEventHandler(notifyIcon1_MouseClick);
            notifyIcon1.Icon = new Icon("icon.ico");
            // добавляем событие на изменение окна
            Resize += new EventHandler(Form1_Resize);
            clock.Font = new Font("Microsoft Sans Serif", 18);
            clock.Location = new Point(Width/2-clock.Right/2,50);
            clock_zapuska.Font = new Font("Microsoft Sans Serif", 14);
            clock_dalit.Font = new Font("Microsoft Sans Serif", 14);
            clock_zapuska.Text = "Время запуска\nприложения";
            clock_dalit.Text = "Время вырубания\nприложения";
            maskedTextBox1.Mask = "00:00:00";
            maskedTextBox2.Mask = "00:00:00";
            button2.Click += button2_Click;
            label1.Font = new Font("Microsoft Sans Serif", 14);
            label1.Text = "Напишите процесс который нужно завершить\nпо истечении времени";
            maskedTextBox1.Location = new Point(251,clock_zapuska.Location.Y);
            maskedTextBox2.Location = new Point(251, clock_dalit.Location.Y + clock_dalit.Height - maskedTextBox2.Height);
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
            if ($"{now:T}" == maskedTextBox1.Text.Replace(" ", ""))
                if (check($"{now:dddd}"))
                    start_exit_proc("avtosapusk.txt", true);
            if ($"{now:T}" == maskedTextBox2.Text.Replace(" ", ""))
                if (check($"{now:dddd}"))
                    start_exit_proc("exit.txt", false);
        }

        private void start_exit_proc(string str, bool prov)
        {
            try
            {
                using (StreamReader sr = new StreamReader(str, Encoding.GetEncoding("UTF-8")))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (prov)
                        {
                            ProcessStartInfo processStartInfo = new ProcessStartInfo();
                            processStartInfo.FileName = line;
                            processStartInfo.UseShellExecute = false;
                            Process.Start(processStartInfo);
                        }
                        if (!prov)
                        {
                            var pr = Process.GetProcessesByName(line);
                            foreach (Process process in pr)
                                process.Kill();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при запуске приложения: {ex.Message}");
            }
        }

        bool check(string text)
        {
            Dictionary<string, CheckBox> days = new Dictionary<string, CheckBox>
            {
                ["понедельник"] = checkBox1,
                ["вторник"] = checkBox2,
                ["среда"] = checkBox3,
                ["четверг"] = checkBox4,
                ["пятница"] = checkBox5,
                ["суббота"] = checkBox6,
                ["воскресенье"] = checkBox7
            };
            var pr = days[text];
            if (pr.Checked)
                return true;
            else 
                return false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void shapka_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void shapka_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void shapka_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*"; //  Укажите типы файлов, которые нужно показывать в окне выбора
            openFileDialog.Title = "Выберите файл";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                using (StreamWriter stream = new StreamWriter("avtosapusk.txt", true))
                    stream.WriteLine(filePath);
            }
        }

        private void proc_del_button_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter("exit.txt", true))
                stream.WriteLine(proc_del.Text);
            proc_del.Text = "";
        }

        private void proc_del_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
