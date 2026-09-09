using System.Reflection.Emit;

namespace avtoplanirovshik_start_exit.git
{
    partial class FormMainMtnu
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
            panel2 = new Panel();
            panelMenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            clock = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(224, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(715, 583);
            panel2.TabIndex = 2;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(224, 654);
            panelMenu.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(3, 220);
            button3.Name = "button3";
            button3.Padding = new Padding(12, 0, 0, 0);
            button3.Size = new Size(218, 63);
            button3.TabIndex = 2;
            button3.Text = "Удалить из Автовыхода";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(0, 151);
            button2.Name = "button2";
            button2.Padding = new Padding(12, 0, 0, 0);
            button2.Size = new Size(221, 63);
            button2.TabIndex = 1;
            button2.Text = "Удалить из Авто загрузки";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 82);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(218, 63);
            button1.TabIndex = 0;
            button1.Text = "Автозагрузка";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(clock);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelMenu);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 654);
            panel1.TabIndex = 3;
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.BackColor = Color.Black;
            clock.ForeColor = Color.Transparent;
            clock.Location = new Point(495, 16);
            clock.Name = "clock";
            clock.Size = new Size(38, 15);
            clock.TabIndex = 3;
            clock.Text = "label2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // FormMainMtnu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(939, 654);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "FormMainMtnu";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "FormMainMtnu";
            Load += FormMainMtnu_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panelMenu;
        public System.Reflection.Emit.Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
    }
}