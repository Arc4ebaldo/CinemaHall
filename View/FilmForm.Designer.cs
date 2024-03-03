namespace test2
{
    partial class FilmForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Title = new TextBox();
            Description = new TextBox();
            Director = new TextBox();
            Add = new Button();
            Delete = new Button();
            Edit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            filmBindingSource = new BindingSource(components);
            AllFilms = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            TransBtn = new Button();
            SotrudBtn = new Button();
            BiletBtn = new Button();
            ZalBtn = new Button();
            SeansBtn = new Button();
            MovieBtn = new Button();
            image1 = new PictureBox();
            ReleaseDate = new DateTimePicker();
            CloseBtn = new PictureBox();
            MinBtn = new PictureBox();
            MaxBtn = new PictureBox();
            VnizBtn = new PictureBox();
            Duration = new MaskedTextBox();
            Genre = new ComboBox();
            Print = new Button();
            Poisk = new Button();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllFilms).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VnizBtn).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Cursor = Cursors.IBeam;
            Title.Font = new Font("Century Gothic", 12F);
            Title.ForeColor = Color.FromArgb(15, 15, 15);
            Title.Location = new Point(317, 78);
            Title.Name = "Title";
            Title.Size = new Size(145, 27);
            Title.TabIndex = 0;
            // 
            // Description
            // 
            Description.BorderStyle = BorderStyle.FixedSingle;
            Description.Cursor = Cursors.IBeam;
            Description.Font = new Font("Century Gothic", 12F);
            Description.Location = new Point(1192, 78);
            Description.Name = "Description";
            Description.Size = new Size(140, 27);
            Description.TabIndex = 5;
            // 
            // Director
            // 
            Director.BorderStyle = BorderStyle.FixedSingle;
            Director.Cursor = Cursors.IBeam;
            Director.Font = new Font("Century Gothic", 12F);
            Director.ForeColor = Color.FromArgb(15, 15, 15);
            Director.Location = new Point(488, 78);
            Director.Name = "Director";
            Director.Size = new Size(122, 27);
            Director.TabIndex = 1;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(40, 40, 40);
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Add.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Century Gothic", 14.25F);
            Add.ForeColor = Color.LightGray;
            Add.Location = new Point(317, 608);
            Add.Name = "Add";
            Add.Size = new Size(110, 30);
            Add.TabIndex = 6;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(40, 40, 40);
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("Century Gothic", 14.25F);
            Delete.ForeColor = Color.LightGray;
            Delete.Location = new Point(576, 608);
            Delete.Name = "Delete";
            Delete.Size = new Size(110, 30);
            Delete.TabIndex = 7;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.FromArgb(40, 40, 40);
            Edit.FlatAppearance.BorderSize = 0;
            Edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.Font = new Font("Century Gothic", 14.25F);
            Edit.ForeColor = Color.LightGray;
            Edit.Location = new Point(448, 608);
            Edit.Name = "Edit";
            Edit.Size = new Size(110, 30);
            Edit.TabIndex = 8;
            Edit.Text = "Изменить";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(317, 31);
            label1.Name = "label1";
            label1.Size = new Size(101, 22);
            label1.TabIndex = 9;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(488, 31);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 10;
            label2.Text = "Режиссер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(640, 31);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 11;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(794, 31);
            label4.Name = "label4";
            label4.Size = new Size(198, 22);
            label4.TabIndex = 12;
            label4.Text = "Продолжительность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(1011, 31);
            label5.Name = "label5";
            label5.Size = new Size(127, 22);
            label5.TabIndex = 13;
            label5.Text = "Год выпуска";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(1192, 31);
            label6.Name = "label6";
            label6.Size = new Size(110, 22);
            label6.TabIndex = 14;
            label6.Text = "Описание";
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Models.Film);
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
            AllFilms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            AllFilms.Location = new Point(317, 130);
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
            AllFilms.TabIndex = 15;
            AllFilms.RowHeaderMouseClick += AllFilms_RowHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(pictureBox1);
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
            panel1.Size = new Size(286, 661);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Khaki;
            pictureBox1.Image = Properties.Resources.film_img;
            pictureBox1.Location = new Point(30, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TransBtn
            // 
            TransBtn.Cursor = Cursors.Hand;
            TransBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            TransBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            TransBtn.FlatStyle = FlatStyle.Flat;
            TransBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TransBtn.ForeColor = Color.FromArgb(15, 15, 15);
            TransBtn.Location = new Point(29, 583);
            TransBtn.Name = "TransBtn";
            TransBtn.Size = new Size(228, 55);
            TransBtn.TabIndex = 6;
            TransBtn.Text = "ТРАНЗАКЦИИ";
            TransBtn.UseVisualStyleBackColor = true;
            TransBtn.Click += TransBtn_Click;
            // 
            // SotrudBtn
            // 
            SotrudBtn.Cursor = Cursors.Hand;
            SotrudBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            SotrudBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            SotrudBtn.FlatStyle = FlatStyle.Flat;
            SotrudBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SotrudBtn.ForeColor = Color.FromArgb(15, 15, 15);
            SotrudBtn.Location = new Point(29, 503);
            SotrudBtn.Name = "SotrudBtn";
            SotrudBtn.Size = new Size(228, 55);
            SotrudBtn.TabIndex = 5;
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
            BiletBtn.Location = new Point(30, 427);
            BiletBtn.Name = "BiletBtn";
            BiletBtn.Size = new Size(228, 55);
            BiletBtn.TabIndex = 4;
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
            ZalBtn.Location = new Point(30, 354);
            ZalBtn.Name = "ZalBtn";
            ZalBtn.Size = new Size(228, 55);
            ZalBtn.TabIndex = 3;
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
            SeansBtn.Location = new Point(29, 278);
            SeansBtn.Name = "SeansBtn";
            SeansBtn.Size = new Size(228, 55);
            SeansBtn.TabIndex = 2;
            SeansBtn.Text = "СЕАНСЫ";
            SeansBtn.UseVisualStyleBackColor = true;
            SeansBtn.Click += SeansBtn_Click;
            // 
            // MovieBtn
            // 
            MovieBtn.BackColor = Color.Khaki;
            MovieBtn.BackgroundImageLayout = ImageLayout.None;
            MovieBtn.Cursor = Cursors.Hand;
            MovieBtn.FlatAppearance.MouseDownBackColor = Color.PaleVioletRed;
            MovieBtn.FlatAppearance.MouseOverBackColor = Color.Khaki;
            MovieBtn.FlatStyle = FlatStyle.Flat;
            MovieBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MovieBtn.ForeColor = Color.FromArgb(15, 15, 15);
            MovieBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MovieBtn.Location = new Point(30, 200);
            MovieBtn.Name = "MovieBtn";
            MovieBtn.Size = new Size(228, 55);
            MovieBtn.TabIndex = 1;
            MovieBtn.Text = "ФИЛЬМЫ";
            MovieBtn.UseVisualStyleBackColor = false;
            // 
            // image1
            // 
            image1.Image = Properties.Resources.cinema;
            image1.Location = new Point(30, 31);
            image1.Name = "image1";
            image1.Size = new Size(228, 142);
            image1.SizeMode = PictureBoxSizeMode.StretchImage;
            image1.TabIndex = 0;
            image1.TabStop = false;
            // 
            // ReleaseDate
            // 
            ReleaseDate.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ReleaseDate.CalendarForeColor = Color.FromArgb(15, 15, 15);
            ReleaseDate.CalendarTitleBackColor = Color.Khaki;
            ReleaseDate.Cursor = Cursors.Hand;
            ReleaseDate.Font = new Font("Century Gothic", 12F);
            ReleaseDate.Location = new Point(1011, 78);
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.Size = new Size(158, 27);
            ReleaseDate.TabIndex = 4;
            // 
            // CloseBtn
            // 
            CloseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Image = Properties.Resources.cross;
            CloseBtn.Location = new Point(1347, 0);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(16, 16);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 19;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // MinBtn
            // 
            MinBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinBtn.Cursor = Cursors.Hand;
            MinBtn.Image = Properties.Resources.collapse;
            MinBtn.Location = new Point(1303, 0);
            MinBtn.Name = "MinBtn";
            MinBtn.Size = new Size(16, 16);
            MinBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MinBtn.TabIndex = 20;
            MinBtn.TabStop = false;
            MinBtn.Click += MinBtn_Click;
            // 
            // MaxBtn
            // 
            MaxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaxBtn.Cursor = Cursors.Hand;
            MaxBtn.Image = Properties.Resources.expand;
            MaxBtn.Location = new Point(1325, 0);
            MaxBtn.Name = "MaxBtn";
            MaxBtn.Size = new Size(16, 16);
            MaxBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MaxBtn.TabIndex = 21;
            MaxBtn.TabStop = false;
            MaxBtn.Click += MaxBtn_Click;
            // 
            // VnizBtn
            // 
            VnizBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VnizBtn.Cursor = Cursors.Hand;
            VnizBtn.Image = Properties.Resources.minus;
            VnizBtn.Location = new Point(1281, 0);
            VnizBtn.Name = "VnizBtn";
            VnizBtn.Size = new Size(16, 16);
            VnizBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            VnizBtn.TabIndex = 22;
            VnizBtn.TabStop = false;
            VnizBtn.Click += VnizBtn_Click;
            // 
            // Duration
            // 
            Duration.BorderStyle = BorderStyle.FixedSingle;
            Duration.Cursor = Cursors.IBeam;
            Duration.Font = new Font("Century Gothic", 12F);
            Duration.ForeColor = Color.FromArgb(15, 15, 15);
            Duration.Location = new Point(794, 80);
            Duration.Mask = "00:00";
            Duration.Name = "Duration";
            Duration.Size = new Size(147, 27);
            Duration.TabIndex = 3;
            Duration.ValidatingType = typeof(DateTime);
            // 
            // Genre
            // 
            Genre.Font = new Font("Century Gothic", 12F);
            Genre.ForeColor = Color.FromArgb(15, 15, 15);
            Genre.FormattingEnabled = true;
            Genre.Location = new Point(640, 78);
            Genre.Name = "Genre";
            Genre.Size = new Size(121, 29);
            Genre.TabIndex = 2;
            // 
            // Print
            // 
            Print.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Print.BackColor = Color.FromArgb(40, 40, 40);
            Print.FlatAppearance.BorderSize = 0;
            Print.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Print.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Print.FlatStyle = FlatStyle.Flat;
            Print.Font = new Font("Century Gothic", 14.25F);
            Print.ForeColor = Color.LightGray;
            Print.Location = new Point(704, 608);
            Print.Name = "Print";
            Print.Size = new Size(119, 30);
            Print.TabIndex = 45;
            Print.Text = "Печать";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
            // 
            // Poisk
            // 
            Poisk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Poisk.BackColor = Color.FromArgb(40, 40, 40);
            Poisk.FlatAppearance.BorderSize = 0;
            Poisk.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            Poisk.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            Poisk.FlatStyle = FlatStyle.Flat;
            Poisk.Font = new Font("Century Gothic", 14.25F);
            Poisk.ForeColor = Color.LightGray;
            Poisk.Location = new Point(840, 608);
            Poisk.Name = "Poisk";
            Poisk.Size = new Size(119, 30);
            Poisk.TabIndex = 46;
            Poisk.Text = "Поиск";
            Poisk.UseVisualStyleBackColor = false;
            // 
            // FilmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1364, 661);
            Controls.Add(Poisk);
            Controls.Add(Print);
            Controls.Add(Genre);
            Controls.Add(Duration);
            Controls.Add(VnizBtn);
            Controls.Add(MaxBtn);
            Controls.Add(MinBtn);
            Controls.Add(CloseBtn);
            Controls.Add(ReleaseDate);
            Controls.Add(panel1);
            Controls.Add(AllFilms);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Edit);
            Controls.Add(Delete);
            Controls.Add(Add);
            Controls.Add(Director);
            Controls.Add(Description);
            Controls.Add(Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FilmForm";
            Text = "Film";
            Load += FilmForm_Load;
            MouseDown += FilmForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllFilms).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)VnizBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private TextBox Description;
        private TextBox Director;
        private Button Add;
        private Button Delete;
        private Button Edit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private BindingSource filmBindingSource;
        private DataGridView AllFilms;
        private Panel panel1;
        private Button MovieBtn;
        private PictureBox image1;
        private Button TransBtn;
        private Button SotrudBtn;
        private Button BiletBtn;
        private Button ZalBtn;
        private Button SeansBtn;
        private DateTimePicker ReleaseDate;
        private PictureBox CloseBtn;
        private PictureBox MinBtn;
        private PictureBox MaxBtn;
        private PictureBox VnizBtn;
        private MaskedTextBox Duration;
        private ComboBox Genre;
        private Button Print;
        private Button Poisk;
        private PictureBox pictureBox1;
    }
}
