namespace halaman_login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            label9 = new Label();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(42, 103);
            label1.Name = "label1";
            label1.Size = new Size(243, 87);
            label1.TabIndex = 0;
            label1.Text = "Belanja kebutuhan \r\nsekolah, tanpa\r\nantre.";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 421);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 128);
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(91, 18);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 2;
            label4.Text = "Mart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(42, 18);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 1;
            label3.Text = "SMK";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(397, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 421);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(44, 305);
            button1.Name = "button1";
            button1.Size = new Size(287, 36);
            button1.TabIndex = 15;
            button1.Text = "Masuk";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click_1;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(189, 355);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(39, 15);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Daftar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 0, 64);
            label9.ForeColor = Color.White;
            label9.Location = new Point(83, 355);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 13;
            label9.Text = "Belum punya akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(237, 253);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 15);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Lupa kata sandi?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(280, 216);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 11;
            label8.Text = "Lihat";
            label8.Click += label8_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(256, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 10;
            textBox3.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(44, 253);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "ingat Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 212);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(44, 194);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "Password*";
            label7.Click += label7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 132);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 4;
            label6.Text = "Email*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 90);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 3;
            label2.Text = "Gunakan akun SMKMart kamu.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(50, 53);
            label5.Name = "label5";
            label5.Size = new Size(101, 37);
            label5.TabIndex = 2;
            label5.Text = "Masuk";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label label8;
        private TextBox textBox3;
        private LinkLabel linkLabel2;
        private Label label9;
        private Button button1;
    }
}
