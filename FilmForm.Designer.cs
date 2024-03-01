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
            Title = new TextBox();
            Description = new TextBox();
            ReleaseDate = new TextBox();
            Duration = new TextBox();
            Genre = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AllFilms).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Location = new Point(81, 58);
            Title.Name = "Title";
            Title.Size = new Size(100, 23);
            Title.TabIndex = 0;
            // 
            // Description
            // 
            Description.Location = new Point(669, 58);
            Description.Name = "Description";
            Description.Size = new Size(100, 23);
            Description.TabIndex = 1;
            // 
            // ReleaseDate
            // 
            ReleaseDate.Location = new Point(551, 58);
            ReleaseDate.Name = "ReleaseDate";
            ReleaseDate.Size = new Size(100, 23);
            ReleaseDate.TabIndex = 2;
            // 
            // Duration
            // 
            Duration.Location = new Point(434, 58);
            Duration.Name = "Duration";
            Duration.Size = new Size(100, 23);
            Duration.TabIndex = 3;
            // 
            // Genre
            // 
            Genre.Location = new Point(318, 58);
            Genre.Name = "Genre";
            Genre.Size = new Size(100, 23);
            Genre.TabIndex = 4;
            // 
            // Director
            // 
            Director.Location = new Point(199, 58);
            Director.Name = "Director";
            Director.Size = new Size(100, 23);
            Director.TabIndex = 5;
            // 
            // Add
            // 
            Add.Location = new Point(224, 415);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 6;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(378, 415);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 7;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(551, 415);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 23);
            Edit.TabIndex = 8;
            Edit.Text = "Изменить";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 40);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 10;
            label2.Text = "Режиссер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 41);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "Жанр";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 40);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 12;
            label4.Text = "Продолжительность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 41);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 13;
            label5.Text = "Год выпуска";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(669, 41);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 14;
            label6.Text = "Описание";
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Models.Film);
            // 
            // AllFilms
            // 
            AllFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllFilms.Location = new Point(50, 128);
            AllFilms.Name = "AllFilms";
            AllFilms.ReadOnly = true;
            AllFilms.Size = new Size(1015, 222);
            AllFilms.TabIndex = 15;
            AllFilms.SelectionChanged += AllFilms_SelectionChanged;
            AllFilms.MouseClick += AllFilms_MouseClick;
            // 
            // FilmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 507);
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
            Controls.Add(Genre);
            Controls.Add(Duration);
            Controls.Add(ReleaseDate);
            Controls.Add(Description);
            Controls.Add(Title);
            Name = "FilmForm";
            Text = "Film";
            Load += FilmForm_Load;
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)AllFilms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Title;
        private TextBox Description;
        private TextBox ReleaseDate;
        private TextBox Duration;
        private TextBox Genre;
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
    }
}
