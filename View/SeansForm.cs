using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
    public partial class SeansForm : Form
    {
        private SeansService seansService = new();
        private HallService hallService = new();
        private string ID;
        public SeansForm()
        {
            InitializeComponent();
        }


        private void SeansForm_Load(object sender, EventArgs e)
        {
            AllSeans.AutoGenerateColumns = false;
            AllSeans.DataSource = seansService.GetAllSeanses();
            AllSeans.Columns["IDPole"].DataPropertyName = "Id";
            AllSeans.Columns["DataTimePole"].DataPropertyName = "StartDatetime";
            AllSeans.Columns["NamePole"].DataPropertyName = "FilmName";
            AllSeans.Columns["HallPole"].DataPropertyName = "HallName";
            AllSeans.Columns["DurationPole"].DataPropertyName = "Duration";

            List<string> hallNames = new();
            foreach (HallDTO name in hallService.GetAllHalls())
            {
                hallNames.Add(name.Name);
            }
            HallList.DataSource = hallNames;


        }

        private void MovieBtn_Click(object sender, EventArgs e)
        {
            FilmForm m = new FilmForm();
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

        private void SeansForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Add_Click(object sender, EventArgs e)
        {

            SeansDTO newSeans = new SeansDTO(
                    StartDateTime.Text,
                    Duration.Text,
                    HallList.Text,
                    FilmTitle.Text
                );
            seansService.CreateSeans(newSeans);
            AllSeans.DataSource = seansService.GetAllSeanses();
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            seansService.DeleteSeansById(int.Parse(ID));
            AllSeans.DataSource = seansService.GetAllSeanses();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            SeansDTO newSeans = new SeansDTO(
                    ID,
                    StartDateTime.Text,
                    Duration.Text,
                    HallList.Text,
                    FilmTitle.Text
            );
            seansService.UpdateSeans(newSeans);
            AllSeans.DataSource = seansService.GetAllSeanses();
        }

        private string result = "";


        private void Print_Click(object sender, EventArgs e)
        {
            result = "Строка 1\n\n";

            result += "Строка 2\nСтрока 3";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void AllSeans_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = AllSeans.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            StartDateTime.Text = selectedCells[1].Value.ToString();
            Duration.Text = selectedCells[2].Value.ToString();
            HallList.Text = selectedCells[3].Value.ToString();
            FilmTitle.Text = selectedCells[4].Value.ToString();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
