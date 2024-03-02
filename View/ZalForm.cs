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
using test2.DTO;
using test2.Models;
using test2.Services;

namespace test2.View
{
    public partial class ZalForm : Form
    {
        public ZalForm()
        {
            InitializeComponent();
        }

        private HallService hallService = new();
        private string ID;
        private void ZalForm_Load(object sender, EventArgs e)
        {
            AllHall.DataSource = hallService.GetAllHalls();
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

        private void BiletBtn_Click(object sender, EventArgs e)
        {
            BiletForm m = new BiletForm();
            m.Show();
            this.Close();
        }

        private void SotrudBtn_Click(object sender, EventArgs e)
        {
            SotrudForm m = new SotrudForm();
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

        private void ZalForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            HallDTO newHall = new HallDTO(
                    Capasity.Text,
                    HallName.Text
                );
            hallService.CreateHall(newHall);
            AllHall.DataSource = hallService.GetAllHalls();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            hallService.DeleteHallById(int.Parse(ID));
            AllHall.DataSource = hallService.GetAllHalls();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            HallDTO newHall = new HallDTO(
                    ID,
                    Capasity.Text,
                    HallName.Text
                );
            hallService.UpdateHall(newHall);
            AllHall.DataSource = hallService.GetAllHalls();
        }

        private void AllHall_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = AllHall.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            Capasity.Text = selectedCells[1].Value.ToString();
            HallName.Text = selectedCells[2].Value.ToString();
        }
    }
}
