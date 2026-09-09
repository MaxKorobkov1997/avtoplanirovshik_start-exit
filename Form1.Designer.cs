namespace avtoplanirovshik_start_exit.git
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            clock_zapuska = new Label();
            clock_dalit = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            proc_del_button = new Button();
            proc_del = new TextBox();
            label1 = new Label();
            checkBoxAutostart = new CheckBox();
            SuspendLayout();
            // 
            // clock_zapuska
            // 
            clock_zapuska.AutoSize = true;
            clock_zapuska.BackColor = SystemColors.ActiveCaptionText;
            clock_zapuska.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clock_zapuska.ForeColor = SystemColors.ButtonFace;
            clock_zapuska.Location = new Point(79, 60);
            clock_zapuska.Margin = new Padding(4, 0, 4, 0);
            clock_zapuska.Name = "clock_zapuska";
            clock_zapuska.Size = new Size(257, 24);
            clock_zapuska.TabIndex = 1;
            clock_zapuska.Text = "Время запуска приложения";
            // 
            // clock_dalit
            // 
            clock_dalit.AutoSize = true;
            clock_dalit.BackColor = SystemColors.ActiveCaptionText;
            clock_dalit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clock_dalit.ForeColor = SystemColors.ButtonFace;
            clock_dalit.Location = new Point(79, 135);
            clock_dalit.Margin = new Padding(4, 0, 4, 0);
            clock_dalit.Name = "clock_dalit";
            clock_dalit.Size = new Size(285, 24);
            clock_dalit.TabIndex = 2;
            clock_dalit.Text = "Время вырубания приложения";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.ActiveCaptionText;
            maskedTextBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox1.ForeColor = SystemColors.ButtonFace;
            maskedTextBox1.Location = new Point(372, 60);
            maskedTextBox1.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox1.Mask = "00:00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(116, 33);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.Click += maskedTextBox1_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = SystemColors.ActiveCaptionText;
            maskedTextBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox2.ForeColor = SystemColors.ButtonFace;
            maskedTextBox2.Location = new Point(372, 135);
            maskedTextBox2.Margin = new Padding(4, 3, 4, 3);
            maskedTextBox2.Mask = "00:00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(116, 33);
            maskedTextBox2.TabIndex = 7;
            maskedTextBox2.Click += maskedTextBox2_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(83, 273);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(575, 87);
            button2.TabIndex = 9;
            button2.Text = "Выбор программы на\nавтовключения";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ActiveCaptionText;
            checkBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(84, 195);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 28);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Понедельник";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = SystemColors.ActiveCaptionText;
            checkBox5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox5.ForeColor = SystemColors.ButtonFace;
            checkBox5.Location = new Point(84, 237);
            checkBox5.Margin = new Padding(4, 3, 4, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(105, 28);
            checkBox5.TabIndex = 11;
            checkBox5.Text = "Пятница";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = SystemColors.ActiveCaptionText;
            checkBox4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox4.ForeColor = SystemColors.ButtonFace;
            checkBox4.Location = new Point(536, 195);
            checkBox4.Margin = new Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(103, 28);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Четверг";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = SystemColors.ActiveCaptionText;
            checkBox3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox3.ForeColor = SystemColors.ButtonFace;
            checkBox3.Location = new Point(392, 195);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(86, 28);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Среда";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = SystemColors.ActiveCaptionText;
            checkBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox2.ForeColor = SystemColors.ButtonFace;
            checkBox2.Location = new Point(270, 195);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 28);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Вторник";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = SystemColors.ActiveCaptionText;
            checkBox7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox7.ForeColor = SystemColors.ButtonFace;
            checkBox7.Location = new Point(360, 237);
            checkBox7.Margin = new Padding(4, 3, 4, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(147, 28);
            checkBox7.TabIndex = 15;
            checkBox7.Text = "Воскресенье";
            checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = SystemColors.ActiveCaptionText;
            checkBox6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox6.ForeColor = SystemColors.ButtonFace;
            checkBox6.Location = new Point(226, 237);
            checkBox6.Margin = new Padding(4, 3, 4, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(104, 28);
            checkBox6.TabIndex = 16;
            checkBox6.Text = "Суббота";
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // proc_del_button
            // 
            proc_del_button.BackColor = SystemColors.ActiveCaptionText;
            proc_del_button.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            proc_del_button.ForeColor = SystemColors.ButtonFace;
            proc_del_button.Location = new Point(247, 504);
            proc_del_button.Margin = new Padding(4, 3, 4, 3);
            proc_del_button.Name = "proc_del_button";
            proc_del_button.Size = new Size(239, 60);
            proc_del_button.TabIndex = 17;
            proc_del_button.Text = "Сохранить";
            proc_del_button.UseVisualStyleBackColor = false;
            proc_del_button.Click += proc_del_button_Click;
            // 
            // proc_del
            // 
            proc_del.BackColor = SystemColors.ActiveCaptionText;
            proc_del.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            proc_del.ForeColor = SystemColors.ButtonFace;
            proc_del.Location = new Point(84, 450);
            proc_del.Margin = new Padding(4, 3, 4, 3);
            proc_del.Multiline = true;
            proc_del.Name = "proc_del";
            proc_del.Size = new Size(573, 47);
            proc_del.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(79, 380);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(427, 48);
            label1.TabIndex = 19;
            label1.Text = "Напишите процесс который нужно завершить\nпо истечении времени";
            // 
            // checkBoxAutostart
            // 
            checkBoxAutostart.AutoSize = true;
            checkBoxAutostart.BackColor = SystemColors.ActiveCaptionText;
            checkBoxAutostart.ForeColor = SystemColors.ButtonFace;
            checkBoxAutostart.Location = new Point(16, 12);
            checkBoxAutostart.Name = "checkBoxAutostart";
            checkBoxAutostart.Size = new Size(98, 19);
            checkBoxAutostart.TabIndex = 20;
            checkBoxAutostart.Text = "Автозагрузка";
            checkBoxAutostart.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(723, 628);
            Controls.Add(checkBoxAutostart);
            Controls.Add(clock_dalit);
            Controls.Add(clock_zapuska);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Controls.Add(maskedTextBox2);
            Controls.Add(proc_del);
            Controls.Add(button2);
            Controls.Add(proc_del_button);
            Controls.Add(checkBox1);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox7);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox3);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(4, 29);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Padding = new Padding(4, 3, 4, 3);
            Text = "Автозапуск";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.Label clock_zapuska;
        private System.Windows.Forms.Label clock_dalit;
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
        private ContextMenuStrip contextMenuStrip1;
        private CheckBox checkBoxAutostart;

    }
}