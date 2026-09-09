using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace avtoplanirovshik_start_exit.git
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            del(Static.file_exit, listBox1.SelectedItem.ToString());
        }

        private void del(string file, string a)
        {
            // Читаем все строки из файла
            if (string.IsNullOrEmpty(a)) return;

            var lines = File.ReadAllLines(file).ToList();
            lines.RemoveAll(line => line.Trim() == a.Trim());
            File.WriteAllLines(file, lines);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Font = Static.font;
            button1.Font = Static.font;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Chit(Static.file_start).ToArray());
        }

        private List<string> Chit(string str)
        {
            List<string> a = new List<string>();
            using (StreamReader sr = new StreamReader(str, Encoding.GetEncoding("UTF-8")))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    a.Add(line);
            }
            return a;
        }
    }
}
