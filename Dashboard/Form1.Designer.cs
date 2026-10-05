namespace Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label27 = new Label();
            label18 = new Label();
            dataGridView2 = new DataGridView();
            ColBarang = new DataGridViewTextBoxColumn();
            ColStok = new DataGridViewTextBoxColumn();
            ColMin = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            label17 = new Label();
            label16 = new Label();
            panel7 = new Panel();
            label14 = new Label();
            label13 = new Label();
            panel6 = new Panel();
            label11 = new Label();
            label10 = new Label();
            panel9 = new Panel();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            ColNo = new DataGridViewTextBoxColumn();
            ColJam = new DataGridViewTextBoxColumn();
            ColKasir = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            label9 = new Label();
            Bar0 = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            label15 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label25 = new Label();
            label26 = new Label();
            panelGrafik = new Panel();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label23 = new Label();
            label24 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panelGrafik.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Yellow;
            label27.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label27.ForeColor = Color.Black;
            label27.ImageAlign = ContentAlignment.BottomRight;
            label27.Location = new Point(868, 21);
            label27.Name = "label27";
            label27.Size = new Size(36, 37);
            label27.TabIndex = 19;
            label27.Text = "A";
            // 
            // label18
            // 
            label18.Dock = DockStyle.Top;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(341, 21);
            label18.TabIndex = 14;
            label18.Text = "Stok hampir habis";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(17, 27, 58);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(17, 27, 58);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(143, 163, 214);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ColBarang, ColStok, ColMin });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(17, 27, 58);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(42, 61, 122);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.FromArgb(27, 42, 92);
            dataGridView2.Location = new Point(0, 21);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.Size = new Size(341, 138);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // ColBarang
            // 
            ColBarang.HeaderText = "Barang";
            ColBarang.Name = "ColBarang";
            // 
            // ColStok
            // 
            ColStok.HeaderText = "Stok";
            ColStok.Name = "ColStok";
            // 
            // ColMin
            // 
            ColMin.HeaderText = "Min";
            ColMin.Name = "ColMin";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 27, 58);
            panel4.Controls.Add(dataGridView2);
            panel4.Controls.Add(label18);
            panel4.Location = new Point(563, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(341, 159);
            panel4.TabIndex = 11;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(255, 201, 60);
            label17.ForeColor = Color.FromArgb(10, 17, 40);
            label17.Location = new Point(11, 47);
            label17.Name = "label17";
            label17.Size = new Size(86, 15);
            label17.TabIndex = 0;
            label17.Text = "Stok minimum";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(10, 17, 40);
            label16.Location = new Point(11, 62);
            label16.Name = "label16";
            label16.Size = new Size(97, 28);
            label16.TabIndex = 1;
            label16.Text = "4 Barang";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 201, 60);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label17);
            panel7.Location = new Point(739, 80);
            panel7.Name = "panel7";
            panel7.Size = new Size(165, 127);
            panel7.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 47);
            label14.Name = "label14";
            label14.Size = new Size(79, 15);
            label14.TabIndex = 0;
            label14.Text = "Barang keluar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(11, 62);
            label13.Name = "label13";
            label13.Size = new Size(36, 28);
            label13.TabIndex = 1;
            label13.Text = "95";
            label13.Click += label13_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(17, 27, 58);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(563, 80);
            panel6.Name = "panel6";
            panel6.Size = new Size(165, 127);
            panel6.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 47);
            label11.Name = "label11";
            label11.Size = new Size(82, 15);
            label11.TabIndex = 0;
            label11.Text = "Barang masuk";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(11, 62);
            label10.Name = "label10";
            label10.Size = new Size(48, 28);
            label10.TabIndex = 1;
            label10.Text = "120";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(17, 27, 58);
            panel9.Controls.Add(label10);
            panel9.Controls.Add(label11);
            panel9.Location = new Point(383, 80);
            panel9.Name = "panel9";
            panel9.Size = new Size(165, 127);
            panel9.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(17, 27, 58);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(13, 47);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 0;
            label5.Text = "Penjualan hari ini";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(238, 242, 255);
            label7.Location = new Point(11, 62);
            label7.Name = "label7";
            label7.Size = new Size(36, 25);
            label7.TabIndex = 1;
            label7.Text = "Rp";
            label7.Click += label7_Click_2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(238, 242, 255);
            label8.Location = new Point(11, 90);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 2;
            label8.Text = "2.450.000";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 27, 58);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(207, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 127);
            panel2.TabIndex = 12;
            // 
            // label12
            // 
            label12.BackColor = Color.FromArgb(17, 27, 58);
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(341, 21);
            label12.TabIndex = 5;
            label12.Text = "Transaksi terbaru";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(17, 27, 58);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(17, 27, 58);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(143, 163, 214);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNo, ColJam, ColKasir, ColTotal });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(17, 27, 58);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(42, 61, 122);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(27, 42, 92);
            dataGridView1.Location = new Point(0, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(341, 138);
            dataGridView1.TabIndex = 0;
            // 
            // ColNo
            // 
            ColNo.HeaderText = "No";
            ColNo.Name = "ColNo";
            ColNo.ReadOnly = true;
            // 
            // ColJam
            // 
            ColJam.HeaderText = "Jam";
            ColJam.Name = "ColJam";
            ColJam.ReadOnly = true;
            // 
            // ColKasir
            // 
            ColKasir.HeaderText = "Kasir";
            ColKasir.Name = "ColKasir";
            ColKasir.ReadOnly = true;
            // 
            // ColTotal
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 201, 60);
            ColTotal.DefaultCellStyle = dataGridViewCellStyle9;
            ColTotal.HeaderText = "Total";
            ColTotal.Name = "ColTotal";
            ColTotal.ReadOnly = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(207, 426);
            panel5.Name = "panel5";
            panel5.Size = new Size(341, 159);
            panel5.TabIndex = 11;
            // 
            // label9
            // 
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(341, 21);
            label9.TabIndex = 2;
            label9.Text = "Penjualan 7 hari terakhir";
            // 
            // Bar0
            // 
            Bar0.BackColor = Color.FromArgb(42, 61, 122);
            Bar0.Location = new Point(11, 58);
            Bar0.Name = "Bar0";
            Bar0.Size = new Size(40, 60);
            Bar0.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 61, 122);
            panel3.Location = new Point(57, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(40, 60);
            panel3.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(42, 61, 122);
            panel8.Location = new Point(103, 58);
            panel8.Name = "panel8";
            panel8.Size = new Size(40, 60);
            panel8.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(42, 61, 122);
            panel10.Location = new Point(149, 58);
            panel10.Name = "panel10";
            panel10.Size = new Size(40, 60);
            panel10.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(42, 61, 122);
            panel11.Location = new Point(195, 58);
            panel11.Name = "panel11";
            panel11.Size = new Size(40, 60);
            panel11.TabIndex = 4;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(42, 61, 122);
            panel13.Location = new Point(241, 58);
            panel13.Name = "panel13";
            panel13.Size = new Size(40, 60);
            panel13.TabIndex = 5;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(42, 61, 122);
            panel14.Location = new Point(287, 58);
            panel14.Name = "panel14";
            panel14.Size = new Size(40, 60);
            panel14.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(11, 131);
            label15.Name = "label15";
            label15.Size = new Size(28, 15);
            label15.TabIndex = 6;
            label15.Text = "Sen";
            label15.Click += label15_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(57, 131);
            label19.Name = "label19";
            label19.Size = new Size(24, 15);
            label19.TabIndex = 7;
            label19.Text = "Sel";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(103, 131);
            label20.Name = "label20";
            label20.Size = new Size(28, 15);
            label20.TabIndex = 8;
            label20.Text = "Rab";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(149, 131);
            label21.Name = "label21";
            label21.Size = new Size(32, 15);
            label21.TabIndex = 9;
            label21.Text = "Kam";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(195, 131);
            label22.Name = "label22";
            label22.Size = new Size(30, 15);
            label22.TabIndex = 10;
            label22.Text = "Jum";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(241, 131);
            label25.Name = "label25";
            label25.Size = new Size(27, 15);
            label25.TabIndex = 11;
            label25.Text = "Sab";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(287, 131);
            label26.Name = "label26";
            label26.Size = new Size(28, 15);
            label26.TabIndex = 14;
            label26.Text = "Min";
            // 
            // panelGrafik
            // 
            panelGrafik.BackColor = Color.FromArgb(17, 27, 58);
            panelGrafik.Controls.Add(label26);
            panelGrafik.Controls.Add(label25);
            panelGrafik.Controls.Add(label22);
            panelGrafik.Controls.Add(label21);
            panelGrafik.Controls.Add(label20);
            panelGrafik.Controls.Add(label19);
            panelGrafik.Controls.Add(label15);
            panelGrafik.Controls.Add(panel14);
            panelGrafik.Controls.Add(panel13);
            panelGrafik.Controls.Add(panel11);
            panelGrafik.Controls.Add(panel10);
            panelGrafik.Controls.Add(panel8);
            panelGrafik.Controls.Add(panel3);
            panelGrafik.Controls.Add(Bar0);
            panelGrafik.Controls.Add(label9);
            panelGrafik.Location = new Point(207, 232);
            panelGrafik.Name = "panelGrafik";
            panelGrafik.Size = new Size(341, 159);
            panelGrafik.TabIndex = 10;
            panelGrafik.Paint += panelGrafik_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Yellow;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1044, 43);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 9;
            label6.Text = "A";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(207, 58);
            label4.Name = "label4";
            label4.Size = new Size(155, 19);
            label4.TabIndex = 7;
            label4.Text = "Jum'at, 2 Oktober 2026";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(198, 21);
            label2.Name = "label2";
            label2.Size = new Size(177, 37);
            label2.TabIndex = 6;
            label2.Text = "Halo, Admin";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label23.Location = new Point(10, 20);
            label23.Name = "label23";
            label23.Size = new Size(76, 37);
            label23.TabIndex = 10;
            label23.Text = "SMK";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Yellow;
            label24.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label24.ForeColor = Color.Black;
            label24.ImageAlign = ContentAlignment.BottomRight;
            label24.Location = new Point(90, 20);
            label24.Name = "label24";
            label24.Size = new Size(81, 37);
            label24.TabIndex = 11;
            label24.Text = "Mart";
            label24.Click += label24_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 79);
            button1.Name = "button1";
            button1.Size = new Size(183, 32);
            button1.TabIndex = 12;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(-3, 117);
            button2.Name = "button2";
            button2.Size = new Size(184, 32);
            button2.TabIndex = 13;
            button2.Text = "Penjualan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 155);
            button3.Name = "button3";
            button3.Size = new Size(185, 32);
            button3.TabIndex = 14;
            button3.Text = "Data Barang";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(-3, 193);
            button4.Name = "button4";
            button4.Size = new Size(185, 32);
            button4.TabIndex = 15;
            button4.Text = "Gudang";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(-3, 231);
            button5.Name = "button5";
            button5.Size = new Size(185, 32);
            button5.TabIndex = 16;
            button5.Text = "Laporan";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(-3, 269);
            button6.Name = "button6";
            button6.Size = new Size(185, 32);
            button6.TabIndex = 17;
            button6.Text = "Pengguna";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(-2, 574);
            button7.Name = "button7";
            button7.Size = new Size(185, 32);
            button7.TabIndex = 18;
            button7.Text = "Keluar";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 26, 62);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 619);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(713, 595);
            label3.Name = "label3";
            label3.Size = new Size(81, 12);
            label3.TabIndex = 5;
            label3.Text = "SMKMart | V 0.1.0";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(207, 595);
            label1.Name = "label1";
            label1.Size = new Size(103, 12);
            label1.TabIndex = 3;
            label1.Text = "@ 2026 SMKMart.com";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 17, 40);
            ClientSize = new Size(920, 617);
            Controls.Add(label27);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel9);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panelGrafik);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dash";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panelGrafik.ResumeLayout(false);
            panelGrafik.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label27;
        private Label label18;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ColBarang;
        private DataGridViewTextBoxColumn ColStok;
        private DataGridViewTextBoxColumn ColMin;
        private Panel panel4;
        private Label label17;
        private Label label16;
        private Panel panel7;
        private Label label14;
        private Label label13;
        private Panel panel6;
        private Label label11;
        private Label label10;
        private Panel panel9;
        private Label label5;
        private Label label7;
        private Label label8;
        private Panel panel2;
        private Label label12;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColNo;
        private DataGridViewTextBoxColumn ColJam;
        private DataGridViewTextBoxColumn ColKasir;
        private DataGridViewTextBoxColumn ColTotal;
        private Panel panel5;
        private Label label9;
        private Panel Bar0;
        private Panel panel3;
        private Panel panel8;
        private Panel panel10;
        private Panel panel11;
        private Panel panel13;
        private Panel panel14;
        private Label label15;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label25;
        private Label label26;
        private Panel panelGrafik;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label23;
        private Label label24;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Panel panel1;
        private Label label3;
        private Label label1;
    }
}
