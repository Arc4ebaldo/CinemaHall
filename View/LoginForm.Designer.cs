namespace test2.View
{
    partial class LoginForm
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
            panel1 = new Panel();
            LogLabel1 = new Label();
            pictureBox1 = new PictureBox();
            LogtextBox = new TextBox();
            PasstextBox = new TextBox();
            LogLabel2 = new Label();
            LoginBtn = new Button();
            ExitBtn = new PictureBox();
            MiniBtn = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MiniBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(LogLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // LogLabel1
            // 
            LogLabel1.AutoSize = true;
            LogLabel1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LogLabel1.Location = new Point(23, 240);
            LogLabel1.Name = "LogLabel1";
            LogLabel1.Size = new Size(191, 32);
            LogLabel1.TabIndex = 1;
            LogLabel1.Text = "CINEMA HALL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cinema;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LogtextBox
            // 
            LogtextBox.BackColor = Color.FromArgb(15, 15, 15);
            LogtextBox.BorderStyle = BorderStyle.FixedSingle;
            LogtextBox.Cursor = Cursors.IBeam;
            LogtextBox.Font = new Font("Segoe UI", 14.25F);
            LogtextBox.ForeColor = Color.Gray;
            LogtextBox.Location = new Point(311, 95);
            LogtextBox.Name = "LogtextBox";
            LogtextBox.Size = new Size(425, 33);
            LogtextBox.TabIndex = 1;
            LogtextBox.Text = "ЛОГИН";
            LogtextBox.Enter += LogtextBox_Enter;
            LogtextBox.Leave += LogtextBox_Leave;
            // 
            // PasstextBox
            // 
            PasstextBox.BackColor = Color.FromArgb(15, 15, 15);
            PasstextBox.BorderStyle = BorderStyle.FixedSingle;
            PasstextBox.Cursor = Cursors.IBeam;
            PasstextBox.Font = new Font("Segoe UI", 14.25F);
            PasstextBox.ForeColor = Color.Gray;
            PasstextBox.Location = new Point(311, 166);
            PasstextBox.Name = "PasstextBox";
            PasstextBox.Size = new Size(425, 33);
            PasstextBox.TabIndex = 2;
            PasstextBox.Text = "ПАРОЛЬ";
            PasstextBox.Enter += PasstextBox_Enter;
            PasstextBox.Leave += PasstextBox_Leave;
            // 
            // LogLabel2
            // 
            LogLabel2.AutoSize = true;
            LogLabel2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogLabel2.ForeColor = Color.DimGray;
            LogLabel2.Location = new Point(426, 41);
            LogLabel2.Name = "LogLabel2";
            LogLabel2.Size = new Size(210, 33);
            LogLabel2.TabIndex = 2;
            LogLabel2.Text = "АВТОРИЗАЦИЯ";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(40, 40, 40);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            LoginBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginBtn.ForeColor = Color.LightGray;
            LoginBtn.Location = new Point(311, 252);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(425, 40);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "ВОЙТИ";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click_1;
            // 
            // ExitBtn
            // 
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.Image = Properties.Resources.cross;
            ExitBtn.Location = new Point(761, 12);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(16, 16);
            ExitBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitBtn.TabIndex = 4;
            ExitBtn.TabStop = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // MiniBtn
            // 
            MiniBtn.Cursor = Cursors.Hand;
            MiniBtn.Image = Properties.Resources.minus;
            MiniBtn.Location = new Point(739, 12);
            MiniBtn.Name = "MiniBtn";
            MiniBtn.Size = new Size(16, 16);
            MiniBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MiniBtn.TabIndex = 5;
            MiniBtn.TabStop = false;
            MiniBtn.Click += MiniBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(MiniBtn);
            Controls.Add(ExitBtn);
            Controls.Add(LoginBtn);
            Controls.Add(LogLabel2);
            Controls.Add(PasstextBox);
            Controls.Add(LogtextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            MouseDown += LoginForm_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MiniBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label LogLabel1;
        private PictureBox pictureBox1;
        private TextBox LogtextBox;
        private TextBox PasstextBox;
        private Label LogLabel2;
        private Button LoginBtn;
        private PictureBox ExitBtn;
        private PictureBox MiniBtn;
    }
}