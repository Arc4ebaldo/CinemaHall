namespace test2.View
{
    partial class TransForm
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
            SotrudBtn = new Button();
            BiletBtn = new Button();
            ZalBtn = new Button();
            SeansBtn = new Button();
            MovieBtn = new Button();
            image1 = new PictureBox();
            TipyTrans = new ComboBox();
            DataTime = new MaskedTextBox();
            VnizBtn = new PictureBox();
            MaxBtn = new PictureBox();
            MinBtn = new PictureBox();
            CloseBtn = new PictureBox();
            Save = new Button();
            AllTrans = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Edit = new Button();
            Delete = new Button();
            Add = new Button();
            label4 = new Label();
            Amount = new MaskedTextBox();
            TransID = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VnizBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllTrans).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(TransBtn);
            panel1.Controls.Add(SotrudBtn);
            panel1.Controls.Add(BiletBtn);
            panel1.Controls.Add(ZalBtn);
            panel1.Controls.Add(SeansBtn);
            panel1.Controls.Add(MovieBtn);
            panel1.Controls.Add(image1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 661);
            panel1.TabIndex = 0;
            // 
            // TransBtn
            // 
            TransBtn.BackColor = Color.Khaki;
            TransBtn.Cursor = Cursors.Hand;
            TransBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            TransBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            TransBtn.FlatStyle = FlatStyle.Flat;
            TransBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TransBtn.ForeColor = Color.FromArgb(15, 15, 15);
            TransBtn.Location = new Point(11, 579);
            TransBtn.Name = "TransBtn";
            TransBtn.Size = new Size(228, 55);
            TransBtn.TabIndex = 13;
            TransBtn.Text = "ТРАНЗАКЦИИ";
            TransBtn.UseVisualStyleBackColor = false;
            // 
            // SotrudBtn
            // 
            SotrudBtn.Cursor = Cursors.Hand;
            SotrudBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            SotrudBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            SotrudBtn.FlatStyle = FlatStyle.Flat;
            SotrudBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SotrudBtn.ForeColor = Color.FromArgb(15, 15, 15);
            SotrudBtn.Location = new Point(11, 499);
            SotrudBtn.Name = "SotrudBtn";
            SotrudBtn.Size = new Size(228, 55);
            SotrudBtn.TabIndex = 12;
            SotrudBtn.Text = "СОТРУДНИКИ";
            SotrudBtn.UseVisualStyleBackColor = true;
            SotrudBtn.Click += SotrudBtn_Click;
            // 
            // BiletBtn
            // 
            BiletBtn.Cursor = Cursors.Hand;
            BiletBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            BiletBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            BiletBtn.FlatStyle = FlatStyle.Flat;
            BiletBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BiletBtn.ForeColor = Color.FromArgb(15, 15, 15);
            BiletBtn.Location = new Point(12, 423);
            BiletBtn.Name = "BiletBtn";
            BiletBtn.Size = new Size(228, 55);
            BiletBtn.TabIndex = 11;
            BiletBtn.Text = "БИЛЕТЫ";
            BiletBtn.UseVisualStyleBackColor = true;
            BiletBtn.Click += BiletBtn_Click;
            // 
            // ZalBtn
            // 
            ZalBtn.Cursor = Cursors.Hand;
            ZalBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            ZalBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            ZalBtn.FlatStyle = FlatStyle.Flat;
            ZalBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ZalBtn.ForeColor = Color.FromArgb(15, 15, 15);
            ZalBtn.Location = new Point(12, 350);
            ZalBtn.Name = "ZalBtn";
            ZalBtn.Size = new Size(228, 55);
            ZalBtn.TabIndex = 10;
            ZalBtn.Text = "ЗАЛЫ";
            ZalBtn.UseVisualStyleBackColor = true;
            ZalBtn.Click += ZalBtn_Click;
            // 
            // SeansBtn
            // 
            SeansBtn.Cursor = Cursors.Hand;
            SeansBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            SeansBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            SeansBtn.FlatStyle = FlatStyle.Flat;
            SeansBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SeansBtn.ForeColor = Color.FromArgb(15, 15, 15);
            SeansBtn.Location = new Point(11, 274);
            SeansBtn.Name = "SeansBtn";
            SeansBtn.Size = new Size(228, 55);
            SeansBtn.TabIndex = 9;
            SeansBtn.Text = "СЕАНСЫ";
            SeansBtn.UseVisualStyleBackColor = true;
            SeansBtn.Click += SeansBtn_Click;
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
            MovieBtn.Location = new Point(12, 196);
            MovieBtn.Name = "MovieBtn";
            MovieBtn.Size = new Size(228, 55);
            MovieBtn.TabIndex = 8;
            MovieBtn.Text = "ФИЛЬМЫ";
            MovieBtn.UseVisualStyleBackColor = false;
            MovieBtn.Click += MovieBtn_Click;
            // 
            // image1
            // 
            image1.Image = Properties.Resources.cinema;
            image1.Location = new Point(12, 27);
            image1.Name = "image1";
            image1.Size = new Size(228, 142);
            image1.SizeMode = PictureBoxSizeMode.StretchImage;
            image1.TabIndex = 7;
            image1.TabStop = false;
            // 
            // TipyTrans
            // 
            TipyTrans.FormattingEnabled = true;
            TipyTrans.Location = new Point(764, 83);
            TipyTrans.Name = "TipyTrans";
            TipyTrans.Size = new Size(121, 23);
            TipyTrans.TabIndex = 2;
            // 
            // DataTime
            // 
            DataTime.Cursor = Cursors.IBeam;
            DataTime.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DataTime.Location = new Point(551, 78);
            DataTime.Mask = "00/00/0000 90:00";
            DataTime.Name = "DataTime";
            DataTime.Size = new Size(147, 27);
            DataTime.TabIndex = 1;
            DataTime.ValidatingType = typeof(DateTime);
            // 
            // VnizBtn
            // 
            VnizBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VnizBtn.Cursor = Cursors.Hand;
            VnizBtn.Image = Properties.Resources.minus;
            VnizBtn.Location = new Point(1276, 4);
            VnizBtn.Name = "VnizBtn";
            VnizBtn.Size = new Size(16, 16);
            VnizBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            VnizBtn.TabIndex = 43;
            VnizBtn.TabStop = false;
            VnizBtn.Click += VnizBtn_Click;
            // 
            // MaxBtn
            // 
            MaxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaxBtn.Cursor = Cursors.Hand;
            MaxBtn.Image = Properties.Resources.expand;
            MaxBtn.Location = new Point(1320, 4);
            MaxBtn.Name = "MaxBtn";
            MaxBtn.Size = new Size(16, 16);
            MaxBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MaxBtn.TabIndex = 42;
            MaxBtn.TabStop = false;
            MaxBtn.Click += MaxBtn_Click;
            // 
            // MinBtn
            // 
            MinBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinBtn.Cursor = Cursors.Hand;
            MinBtn.Image = Properties.Resources.collapse;
            MinBtn.Location = new Point(1298, 4);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(16, 16);
            MinBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinBtn.TabIndex = 41;
            MinBtn.TabStop = false;
            MinBtn.Click += MinBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Image = Properties.Resources.cross;
            CloseBtn.Location = new Point(1342, 4);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(16, 16);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 40;
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
            Save.Location = new Point(702, 612);
            Save.Name = "Save";
            Save.Size = new Size(107, 30);
            Save.TabIndex = 38;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = false;
            // 
            // AllTrans
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle1.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(15, 15, 15);
            AllTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AllTrans.BackgroundColor = Color.White;
            AllTrans.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle2.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            AllTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            AllTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle3.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AllTrans.DefaultCellStyle = dataGridViewCellStyle3;
            AllTrans.GridColor = Color.FromArgb(15, 15, 15);
            AllTrans.Location = new Point(312, 134);
            AllTrans.Name = "AllTrans";
            AllTrans.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(15, 15, 15);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            AllTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            AllTrans.Size = new Size(1015, 457);
            AllTrans.TabIndex = 37;
            AllTrans.RowHeaderMouseClick += AllTrans_RowHeaderMouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(967, 35);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 33;
            label3.Text = "Сумма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(764, 35);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 32;
            label2.Text = "Тип транзакции";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(551, 35);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 31;
            label1.Text = "Дата и время";
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
            Edit.Location = new Point(453, 612);
            Edit.Name = "Edit";
            Edit.Size = new Size(101, 30);
            Edit.TabIndex = 30;
            Edit.Text = "Изменить";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
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
            Delete.Location = new Point(579, 612);
            Delete.Name = "Delete";
            Delete.Size = new Size(101, 30);
            Delete.TabIndex = 29;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
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
            Add.Location = new Point(328, 612);
            Add.Name = "Add";
            Add.Size = new Size(101, 30);
            Add.TabIndex = 28;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(328, 35);
            label4.Name = "label4";
            label4.Size = new Size(164, 21);
            label4.TabIndex = 46;
            label4.Text = "Номер транзакции";
            // 
            // Amount
            // 
            Amount.Location = new Point(967, 83);
            Amount.Mask = "00000";
            Amount.Name = "Amount";
            Amount.Size = new Size(100, 23);
            Amount.TabIndex = 3;
            Amount.ValidatingType = typeof(int);
            // 
            // TransID
            // 
            TransID.Location = new Point(329, 83);
            TransID.Mask = "00000";
            TransID.Name = "TransID";
            TransID.Size = new Size(100, 23);
            TransID.TabIndex = 0;
            TransID.ValidatingType = typeof(int);
            // 
            // TransForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1364, 661);
            Controls.Add(TransID);
            Controls.Add(Amount);
            Controls.Add(label4);
            Controls.Add(TipyTrans);
            Controls.Add(DataTime);
            Controls.Add(VnizBtn);
            Controls.Add(MaxBtn);
            Controls.Add(MinBtn);
            Controls.Add(CloseBtn);
            Controls.Add(Save);
            Controls.Add(AllTrans);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransForm";
            Text = "TransForm";
            Load += TransForm_Load;
            MouseDown += TransForm_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ((System.ComponentModel.ISupportInitialize)VnizBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllTrans).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox TipyTrans;
        private MaskedTextBox DataTime;
        private PictureBox VnizBtn;
        private PictureBox MaxBtn;
        private PictureBox MinBtn;
        private PictureBox CloseBtn;
        private Button Save;
        private DataGridView AllTrans;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Edit;
        private Button Delete;
        private Button Add;
        private Button TransBtn;
        private Button SotrudBtn;
        private Button BiletBtn;
        private Button ZalBtn;
        private Button SeansBtn;
        private Button MovieBtn;
        private PictureBox image1;
        private Label label4;
        private MaskedTextBox Amount;
        private MaskedTextBox TransID;
    }
}