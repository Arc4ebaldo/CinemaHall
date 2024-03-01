using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace test2.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LogtextBox_Enter(object sender, EventArgs e)
        {
            if (LogtextBox.Text == "ЛОГИН")
            {
                LogtextBox.Text = "";
                LogtextBox.ForeColor = Color.LightGray;
            }
        }

        private void LogtextBox_Leave(object sender, EventArgs e)
        {
            if (LogtextBox.Text == "")
            {
                LogtextBox.Text = "ЛОГИН";
                LogtextBox.ForeColor = Color.DimGray;
            }
        }

        private void PasstextBox_Enter(object sender, EventArgs e)
        {
            if (PasstextBox.Text == "ПАРОЛЬ")
            {
                PasstextBox.Text = "";
                PasstextBox.ForeColor = Color.LightGray;
            }
        }

        private void PasstextBox_Leave(object sender, EventArgs e)
        {
            if (PasstextBox.Text == "")
            {
                PasstextBox.Text = "ПАРОЛЬ";
                PasstextBox.ForeColor = Color.DimGray;
            }
        }



        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (LogtextBox.Text != "admin" && PasstextBox.Text != "1")
            {
                MessageBox.Show("Введен неверный логин/пароль");
            }
            else
            {
                MenuForm m = new MenuForm();
                m.Show();
                this.Hide();
            }
        }
    }
}
