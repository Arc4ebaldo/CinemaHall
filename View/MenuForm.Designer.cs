namespace test2.View
{
    partial class MenuForm
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
            PanelBar = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            FilmBtn = new Button();
            SeansBtn = new Button();
            ZalBtn = new Button();
            BiletBtn = new Button();
            SotrudBtn = new Button();
            TransBtn = new Button();
            PanelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // PanelBar
            // 
            PanelBar.BackColor = Color.Khaki;
            PanelBar.Controls.Add(pictureBox3);
            PanelBar.Controls.Add(pictureBox1);
            PanelBar.Dock = DockStyle.Top;
            PanelBar.Location = new Point(0, 0);
            PanelBar.Name = "PanelBar";
            PanelBar.Size = new Size(900, 40);
            PanelBar.TabIndex = 0;
            PanelBar.MouseMove += PanelBar_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.minus;
            pictureBox3.Location = new Point(853, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(18, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.cross;
            pictureBox1.Location = new Point(877, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.zal;
            pictureBox5.Location = new Point(0, 40);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(900, 515);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // FilmBtn
            // 
            FilmBtn.BackColor = Color.Crimson;
            FilmBtn.FlatAppearance.BorderSize = 0;
            FilmBtn.FlatAppearance.MouseDownBackColor = Color.Khaki;
            FilmBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);
            FilmBtn.FlatStyle = FlatStyle.Flat;
            FilmBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FilmBtn.Location = new Point(141, 106);
            FilmBtn.Name = "FilmBtn";
            FilmBtn.Size = new Size(162, 52);
            FilmBtn.TabIndex = 0;
            FilmBtn.Text = "ФИЛЬМЫ";
            FilmBtn.UseVisualStyleBackColor = false;
            FilmBtn.Click += FilmBtn_Click;
            // 
            // SeansBtn
            // 
            SeansBtn.BackColor = Color.Crimson;
            SeansBtn.FlatAppearance.MouseDownBackColor = Color.Khaki;
            SeansBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);
            SeansBtn.FlatStyle = FlatStyle.Flat;
            SeansBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SeansBtn.Location = new Point(141, 229);
            SeansBtn.Name = "SeansBtn";
            SeansBtn.Size = new Size(162, 52);
            SeansBtn.TabIndex = 1;
            SeansBtn.Text = "СЕАНСЫ";
            SeansBtn.UseVisualStyleBackColor = false;
            SeansBtn.Click += SeansBtn_Click;
            // 
            // ZalBtn
            // 
            ZalBtn.BackColor = Color.Crimson;
            ZalBtn.FlatAppearance.MouseDownBackColor = Color.Khaki;
            ZalBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);
            ZalBtn.FlatStyle = FlatStyle.Flat;
            ZalBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ZalBtn.Location = new Point(141, 337);
            ZalBtn.Name = "ZalBtn";
            ZalBtn.Size = new Size(162, 52);
            ZalBtn.TabIndex = 2;
            ZalBtn.Text = "ЗАЛЫ";
            ZalBtn.UseVisualStyleBackColor = false;
            ZalBtn.Click += ZalBtn_Click;
            // 
            // BiletBtn
            // 
            BiletBtn.BackColor = Color.Crimson;
            BiletBtn.FlatAppearance.MouseDownBackColor = Color.Khaki;
            BiletBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);
            BiletBtn.FlatStyle = FlatStyle.Flat;
            BiletBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BiletBtn.Location = new Point(611, 337);
            BiletBtn.Name = "BiletBtn";
            BiletBtn.Size = new Size(162, 52);
            BiletBtn.TabIndex = 3;
            BiletBtn.Text = "БИЛЕТЫ";
            BiletBtn.UseVisualStyleBackColor = false;
            BiletBtn.Click += BiletBtn_Click;
            // 
            // SotrudBtn
            // 
            SotrudBtn.BackColor = Color.Crimson;
            SotrudBtn.FlatAppearance.MouseDownBackColor = Color.Khaki;
            SotrudBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);
            SotrudBtn.FlatStyle = FlatStyle.Flat;
            SotrudBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SotrudBtn.Location = new Point(611, 106);
            SotrudBtn.Name = "SotrudBtn";
            SotrudBtn.Size = new Size(162, 52);
            SotrudBtn.TabIndex = 4;
            SotrudBtn.Text = "СОТРУДНИКИ";
            SotrudBtn.UseVisualStyleBackColor = false;
            SotrudBtn.Click += SotrudBtn_Click;
            // 
            // TransBtn
            // 
            TransBtn.BackColor = Color.Crimson;
            TransBtn.FlatAppearance.MouseDownBackColor = Color.Khaki;
            TransBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 28);
            TransBtn.FlatStyle = FlatStyle.Flat;
            TransBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TransBtn.Location = new Point(611, 229);
            TransBtn.Name = "TransBtn";
            TransBtn.Size = new Size(162, 52);
            TransBtn.TabIndex = 5;
            TransBtn.Text = "ТРАНЗАКЦИИ";
            TransBtn.UseVisualStyleBackColor = false;
            TransBtn.Click += TransBtn_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(900, 555);
            Controls.Add(TransBtn);
            Controls.Add(SotrudBtn);
            Controls.Add(BiletBtn);
            Controls.Add(ZalBtn);
            Controls.Add(SeansBtn);
            Controls.Add(FilmBtn);
            Controls.Add(pictureBox5);
            Controls.Add(PanelBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            PanelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Button FilmBtn;
        private Button SeansBtn;
        private Button ZalBtn;
        private Button BiletBtn;
        private Button SotrudBtn;
        private Button TransBtn;
    }
}