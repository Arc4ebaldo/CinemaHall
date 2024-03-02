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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
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
            AllHall = new DataGridView();
            label1 = new Label();
            Edit = new Button();
            Delete = new Button();
            Add = new Button();
            label2 = new Label();
            HallName = new TextBox();
            Capasity = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VnizBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllHall).BeginInit();
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
            // AllHall
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle5.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(15, 15, 15);
            AllHall.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            AllHall.BackgroundColor = Color.White;
            AllHall.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle6.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            AllHall.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            AllHall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle7.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            AllHall.DefaultCellStyle = dataGridViewCellStyle7;
            AllHall.GridColor = Color.FromArgb(15, 15, 15);
            AllHall.Location = new Point(298, 136);
            AllHall.Name = "AllHall";
            AllHall.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            AllHall.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            AllHall.Size = new Size(1015, 457);
            AllHall.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(298, 37);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 51;
            label1.Text = "Название";
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
            Add.Click += Add_Click;
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
            // HallName
            // 
            HallName.BorderStyle = BorderStyle.None;
            HallName.Cursor = Cursors.IBeam;
            HallName.Font = new Font("Century Gothic", 12F);
            HallName.Location = new Point(298, 91);
            HallName.Name = "HallName";
            HallName.Size = new Size(141, 20);
            HallName.TabIndex = 1;
            // 
            // Capasity
            // 
            Capasity.Location = new Point(660, 88);
            Capasity.Mask = "00000";
            Capasity.Name = "Capasity";
            Capasity.Size = new Size(135, 23);
            Capasity.TabIndex = 61;
            Capasity.ValidatingType = typeof(int);
            // 
            // ZalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1364, 661);
            Controls.Add(Capasity);
            Controls.Add(HallName);
            Controls.Add(VnizBtn);
            Controls.Add(MaxBtn);
            Controls.Add(MinBtn);
            Controls.Add(CloseBtn);
            Controls.Add(Save);
            Controls.Add(AllHall);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(Add);
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
            ((System.ComponentModel.ISupportInitialize)AllHall).EndInit();
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
        private DataGridView AllHall;
        private Label label1;
        private Button Edit;
        private Button Delete;
        private Button Add;
        private Label label2;
        private Button TransBtn;
        private PictureBox image1;
        private Button SotrudBtn;
        private Button MovieBtn;
        private Button BiletBtn;
        private Button SeansBtn;
        private Button ZalBtn;
        private TextBox HallName;
        private MaskedTextBox Capasity;
    }
}