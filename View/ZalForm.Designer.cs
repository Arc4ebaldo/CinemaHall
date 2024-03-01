namespace test2.View
{
    partial class ZalForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            TransBtn = new Button();
            image1 = new PictureBox();
            SotrudBtn = new Button();
            MovieBtn = new Button();
            BiletBtn = new Button();
            SeansBtn = new Button();
            ZalBtn = new Button();
            VnizBtn = new PictureBox();
            MaxBtn = new PictureBox();
            MinBtn = new PictureBox();
            CloseBtn = new PictureBox();
            Save = new Button();
            AllFilms = new DataGridView();
            Название = new Label();
            Edit = new Button();
            Delete = new Button();
            Add = new Button();
            capacity = new TextBox();
            label2 = new Label();
            Nazvanie = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VnizBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllFilms).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(TransBtn);
            panel1.Controls.Add(image1);
            panel1.Controls.Add(SotrudBtn);
            panel1.Controls.Add(MovieBtn);
            panel1.Controls.Add(BiletBtn);
            panel1.Controls.Add(SeansBtn);
            panel1.Controls.Add(ZalBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 661);
            panel1.TabIndex = 0;
            // 
            // TransBtn
            // 
            TransBtn.Cursor = Cursors.Hand;
            TransBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            TransBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            TransBtn.FlatStyle = FlatStyle.Flat;
            TransBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TransBtn.ForeColor = Color.FromArgb(15, 15, 15);
            TransBtn.Location = new Point(11, 564);
            TransBtn.Name = "TransBtn";
            TransBtn.Size = new Size(228, 55);
            TransBtn.TabIndex = 70;
            TransBtn.Text = "ТРАНЗАКЦИИ";
            TransBtn.UseVisualStyleBackColor = true;
            TransBtn.Click += TransBtn_Click;
            // 
            // image1
            // 
            image1.Image = Properties.Resources.cinema;
            image1.Location = new Point(12, 12);
            image1.Name = "image1";
            image1.Size = new Size(228, 142);
            image1.SizeMode = PictureBoxSizeMode.StretchImage;
            image1.TabIndex = 64;
            image1.TabStop = false;
            // 
            // SotrudBtn
            // 
            SotrudBtn.Cursor = Cursors.Hand;
            SotrudBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            SotrudBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            SotrudBtn.FlatStyle = FlatStyle.Flat;
            SotrudBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SotrudBtn.ForeColor = Color.FromArgb(15, 15, 15);
            SotrudBtn.Location = new Point(11, 484);
            SotrudBtn.Name = "SotrudBtn";
            SotrudBtn.Size = new Size(228, 55);
            SotrudBtn.TabIndex = 69;
            SotrudBtn.Text = "СОТРУДНИКИ";
            SotrudBtn.UseVisualStyleBackColor = true;
            SotrudBtn.Click += SotrudBtn_Click;
            // 
            // MovieBtn
            // 
            MovieBtn.BackColor = Color.Crimson;
            MovieBtn.Cursor = Cursors.Hand;
            MovieBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            MovieBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            MovieBtn.FlatStyle = FlatStyle.Flat;
            MovieBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MovieBtn.ForeColor = Color.FromArgb(15, 15, 15);
            MovieBtn.Location = new Point(12, 181);
            MovieBtn.Name = "MovieBtn";
            MovieBtn.Size = new Size(228, 55);
            MovieBtn.TabIndex = 65;
            MovieBtn.Text = "ФИЛЬМЫ";
            MovieBtn.UseVisualStyleBackColor = false;
            MovieBtn.Click += MovieBtn_Click;
            // 
            // BiletBtn
            // 
            BiletBtn.Cursor = Cursors.Hand;
            BiletBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            BiletBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            BiletBtn.FlatStyle = FlatStyle.Flat;
            BiletBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BiletBtn.ForeColor = Color.FromArgb(15, 15, 15);
            BiletBtn.Location = new Point(12, 408);
            BiletBtn.Name = "BiletBtn";
            BiletBtn.Size = new Size(228, 55);
            BiletBtn.TabIndex = 68;
            BiletBtn.Text = "БИЛЕТЫ";
            BiletBtn.UseVisualStyleBackColor = true;
            BiletBtn.Click += BiletBtn_Click;
            // 
            // SeansBtn
            // 
            SeansBtn.BackColor = Color.Crimson;
            SeansBtn.Cursor = Cursors.Hand;
            SeansBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            SeansBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            SeansBtn.FlatStyle = FlatStyle.Flat;
            SeansBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SeansBtn.ForeColor = Color.FromArgb(15, 15, 15);
            SeansBtn.Location = new Point(11, 259);
            SeansBtn.Name = "SeansBtn";
            SeansBtn.Size = new Size(228, 55);
            SeansBtn.TabIndex = 66;
            SeansBtn.Text = "СЕАНСЫ";
            SeansBtn.UseVisualStyleBackColor = false;
            SeansBtn.Click += SeansBtn_Click;
            // 
            // ZalBtn
            // 
            ZalBtn.BackColor = Color.Khaki;
            ZalBtn.Cursor = Cursors.Hand;
            ZalBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            ZalBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            ZalBtn.FlatStyle = FlatStyle.Flat;
            ZalBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ZalBtn.ForeColor = Color.FromArgb(15, 15, 15);
            ZalBtn.Location = new Point(12, 335);
            ZalBtn.Name = "ZalBtn";
            ZalBtn.Size = new Size(228, 55);
            ZalBtn.TabIndex = 67;
            ZalBtn.Text = "ЗАЛЫ";
            ZalBtn.UseVisualStyleBackColor = false;
            // 
            // VnizBtn
            // 
            VnizBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VnizBtn.Cursor = Cursors.Hand;
            VnizBtn.Image = Properties.Resources.minus;
            VnizBtn.Location = new Point(1278, 6);
            VnizBtn.Name = "VnizBtn";
            VnizBtn.Size = new Size(16, 16);
            VnizBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            VnizBtn.TabIndex = 60;
            VnizBtn.TabStop = false;
            VnizBtn.Click += VnizBtn_Click;
            // 
            // MaxBtn
            // 
            MaxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaxBtn.Cursor = Cursors.Hand;
            MaxBtn.Image = Properties.Resources.expand;
            MaxBtn.Location = new Point(1322, 6);
            MaxBtn.Name = "MaxBtn";
            MaxBtn.Size = new Size(16, 16);
            MaxBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MaxBtn.TabIndex = 59;
            MaxBtn.TabStop = false;
            MaxBtn.Click += MaxBtn_Click;
            // 
            // MinBtn
            // 
            MinBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinBtn.Cursor = Cursors.Hand;
            MinBtn.Image = Properties.Resources.collapse;
            MinBtn.Location = new Point(1300, 6);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(16, 16);
            MinBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinBtn.TabIndex = 58;
            MinBtn.TabStop = false;
            MinBtn.Click += MinBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Image = Properties.Resources.cross;
            CloseBtn.Location = new Point(1344, 6);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(16, 16);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 57;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(40, 40, 40);
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Century Gothic", 12F);
            Save.ForeColor = Color.LightGray;
            Save.Location = new Point(688, 614);
            Save.Name = "Save";
            Save.Size = new Size(107, 30);
            Save.TabIndex = 56;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = false;
            // 
            // AllFilms
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(15, 15, 15);
            AllFilms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllFilms.BackgroundColor = Color.White;
            AllFilms.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle2.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllFilms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle3.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllFilms.DefaultCellStyle = dataGridViewCellStyle3;
            AllFilms.GridColor = Color.FromArgb(15, 15, 15);
            AllFilms.Location = new Point(298, 136);
            AllFilms.Name = "AllFilms";
            AllFilms.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AllFilms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AllFilms.Size = new Size(1015, 457);
            AllFilms.TabIndex = 55;
            // 
            // Название
            // 
            Название.AutoSize = true;
            Название.Font = new Font("Century Gothic", 12F);
            Название.ForeColor = Color.DimGray;
            Название.Location = new Point(298, 37);
            Название.Name = "Название";
            Название.Size = new Size(180, 21);
            Название.TabIndex = 51;
            Название.Text = "Дата и время начала";
            // 
            // Edit
            // 
            Edit.BackColor = Color.FromArgb(40, 40, 40);
            Edit.FlatAppearance.BorderSize = 0;
            Edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Font = new Font("Century Gothic", 12F);
            Edit.ForeColor = Color.LightGray;
            Edit.Location = new Point(439, 614);
            Edit.Name = "Edit";
            Edit.Size = new Size(101, 30);
            Edit.TabIndex = 50;
            Edit.Text = "Изменить";
            Edit.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(40, 40, 40);
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Century Gothic", 12F);
            Delete.ForeColor = Color.LightGray;
            Delete.Location = new Point(565, 614);
            Delete.Name = "Delete";
            Delete.Size = new Size(101, 30);
            Delete.TabIndex = 49;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(40, 40, 40);
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Add.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Century Gothic", 12F);
            Add.ForeColor = Color.LightGray;
            Add.Location = new Point(314, 614);
            Add.Name = "Add";
            Add.Size = new Size(101, 30);
            Add.TabIndex = 48;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = false;
            // 
            // capacity
            // 
            capacity.BorderStyle = BorderStyle.None;
            capacity.Cursor = Cursors.IBeam;
            capacity.Font = new Font("Century Gothic", 12F);
            capacity.Location = new Point(660, 91);
            capacity.Name = "capacity";
            capacity.Size = new Size(122, 20);
            capacity.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(660, 37);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 52;
            label2.Text = "Вместимость";
            // 
            // Nazvanie
            // 
            Nazvanie.BorderStyle = BorderStyle.None;
            Nazvanie.Cursor = Cursors.IBeam;
            Nazvanie.Font = new Font("Century Gothic", 12F);
            Nazvanie.Location = new Point(298, 91);
            Nazvanie.Name = "Nazvanie";
            Nazvanie.Size = new Size(122, 20);
            Nazvanie.TabIndex = 63;
            // 
            // ZalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1364, 661);
            Controls.Add(Nazvanie);
            Controls.Add(VnizBtn);
            Controls.Add(MaxBtn);
            Controls.Add(MinBtn);
            Controls.Add(CloseBtn);
            Controls.Add(Save);
            Controls.Add(AllFilms);
            Controls.Add(label2);
            Controls.Add(Название);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(capacity);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ZalForm";
            Text = "ZalForm";
            Load += ZalForm_Load;
            MouseDown += ZalForm_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ((System.ComponentModel.ISupportInitialize)VnizBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllFilms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox VnizBtn;
        private PictureBox MaxBtn;
        private PictureBox MinBtn;
        private PictureBox CloseBtn;
        private Button Save;
        private DataGridView AllFilms;
        private Label Название;
        private Button Edit;
        private Button Delete;
        private Button Add;
        private TextBox capacity;
        private Label label2;
        private TextBox Nazvanie;
        private Button TransBtn;
        private PictureBox image1;
        private Button SotrudBtn;
        private Button MovieBtn;
        private Button BiletBtn;
        private Button SeansBtn;
        private Button ZalBtn;
    }
}