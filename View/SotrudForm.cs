using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2.View
{
    public partial class SotrudForm : Form
    {
        public SotrudForm()
        {
            InitializeComponent();
        }

        private void SotrudForm_Load(object sender, EventArgs e)
        {

        }

        private void MovieBtn_Click(object sender, EventArgs e)
        {
            FilmForm m = new FilmForm();
            m.Show();
            this.Close();
        }

        private void SeansBtn_Click(object sender, EventArgs e)
        {
            SeansForm m = new SeansForm();
            m.Show();
            this.Close();
        }

        private void ZalBtn_Click(object sender, EventArgs e)
        {
            ZalForm m = new ZalForm();
            m.Show();
            this.Close();
        }

        private void BiletBtn_Click(object sender, EventArgs e)
        {
            BiletForm m = new BiletForm();
            m.Show();
            this.Close();
        }

        private void TransBtn_Click(object sender, EventArgs e)
        {
            TransForm m = new TransForm();
            m.Show();
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VnizBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int lx, ly;
        int sw, sh;
        private void MaxBtn_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void SotrudForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
