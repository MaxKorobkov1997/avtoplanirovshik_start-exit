namespace avtoplanirovshik_start_exit
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clock_zapuska = new System.Windows.Forms.Label();
            this.clock_dalit = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.proc_del_button = new System.Windows.Forms.Button();
            this.proc_del = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formStyle1 = new avtoplanirovshik_start_exit.FormStyle(this.components);
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Location = new System.Drawing.Point(120, 24);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(35, 13);
            this.clock.TabIndex = 0;
            this.clock.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // clock_zapuska
            // 
            this.clock_zapuska.AutoSize = true;
            this.clock_zapuska.Location = new System.Drawing.Point(13, 96);
            this.clock_zapuska.Name = "clock_zapuska";
            this.clock_zapuska.Size = new System.Drawing.Size(0, 13);
            this.clock_zapuska.TabIndex = 1;
            // 
            // clock_dalit
            // 
            this.clock_dalit.AutoSize = true;
            this.clock_dalit.Location = new System.Drawing.Point(14, 127);
            this.clock_dalit.Name = "clock_dalit";
            this.clock_dalit.Size = new System.Drawing.Size(35, 13);
            this.clock_dalit.TabIndex = 2;
            this.clock_dalit.Text = "label2";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(251, 93);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(251, 139);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(493, 75);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Понедельник";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(17, 218);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 17);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Пятница";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(405, 181);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(68, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Четверг";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(281, 181);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 17);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Среда";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(177, 181);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Вторник";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(220, 218);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(93, 17);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "Воскресенье";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(117, 218);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(67, 17);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "Суббота";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // proc_del_button
            // 
            this.proc_del_button.Location = new System.Drawing.Point(158, 451);
            this.proc_del_button.Name = "proc_del_button";
            this.proc_del_button.Size = new System.Drawing.Size(205, 52);
            this.proc_del_button.TabIndex = 17;
            this.proc_del_button.Text = "Сохранить";
            this.proc_del_button.UseVisualStyleBackColor = true;
            this.proc_del_button.Click += new System.EventHandler(this.proc_del_button_Click);
            // 
            // proc_del
            // 
            this.proc_del.Location = new System.Drawing.Point(17, 404);
            this.proc_del.Multiline = true;
            this.proc_del.Name = "proc_del";
            this.proc_del.Size = new System.Drawing.Size(409, 41);
            this.proc_del.TabIndex = 18;
            this.proc_del.TextChanged += new System.EventHandler(this.proc_del_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // formStyle1
            // 
            this.formStyle1.Form = this;
            this.formStyle1.Formstyle = avtoplanirovshik_start_exit.FormStyle.fStyle.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proc_del);
            this.Controls.Add(this.proc_del_button);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.clock_dalit);
            this.Controls.Add(this.clock_zapuska);
            this.Controls.Add(this.clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clock_zapuska;
        private System.Windows.Forms.Label clock_dalit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button proc_del_button;
        private System.Windows.Forms.TextBox proc_del;
        private System.Windows.Forms.Label label1;
        private FormStyle formStyle1;
    }
}

