using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test2.DTO;
using test2.Services;

namespace test2.View
{
    public partial class BiletForm : Form
    {
        public BiletForm()
        {
            InitializeComponent();
        }

        private TicketService ticketService = new();
        private string ID;

        private void BiletForm_Load(object sender, EventArgs e)
        {
            AllTicket.DataSource = ticketService.GetAllTickets();
            Valid.DataSource = new List<String>() { "Действителен", "Не действителен" };
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
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

        private void BiletForm_MouseDown(object sender, MouseEventArgs e)
        {
            AllTicket.AutoGenerateColumns = false;
            AllTicket.Columns["IDPole"].DataPropertyName = "Id";
            AllTicket.Columns["StatusPole"].DataPropertyName = "Valid";
            AllTicket.Columns["PricePole"].DataPropertyName = "Price";
            AllTicket.Columns["SeatPole"].DataPropertyName = "SeatAdress";
            AllTicket.Columns["SeansPole"].DataPropertyName = "SeansId";
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ZalBtn_Click_1(object sender, EventArgs e)
        {
            ZalForm m = new ZalForm();
            m.Show();
            this.Close();
        }

        private void SotrudBtn_Click_1(object sender, EventArgs e)
        {
            SotrudForm m = new SotrudForm();
            m.Show();
            this.Close();
        }

        private void TransBtn_Click_1(object sender, EventArgs e)
        {
            TransForm m = new TransForm();
            m.Show();
            this.Close();
        }

        private void SeansBtn_Click_1(object sender, EventArgs e)
        {
            SeansForm m = new SeansForm();
            m.Show();
            this.Close();
        }

        private void MovieBtn_Click_1(object sender, EventArgs e)
        {
            FilmForm m = new FilmForm();
            m.Show();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            TicketDTO newTicket = new TicketDTO(
                Valid.Text,
                PriceLine.Text,
                SeatAdress.Text,
                Seans.Text
                );
            ticketService.CreateTicket(newTicket);
            AllTicket.DataSource = ticketService.GetAllTickets();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ticketService.DeleteTicketById(int.Parse(ID));
            AllTicket.DataSource = ticketService.GetAllTickets();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            TicketDTO newTicket = new TicketDTO(
                ID,
                PriceLine.Text,
                SeatAdress.Text,
                Seans.Text
                );
            ticketService.UpdateTicket(newTicket);
            AllTicket.DataSource = ticketService.GetAllTickets();
        }

        private void AllTicket_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = AllTicket.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            Valid.Text = selectedCells[1].Value.ToString();
            PriceLine.Text = selectedCells[2].Value.ToString();
            SeatAdress.Text = selectedCells[3].Value.ToString();
            Seans.Text = selectedCells[4].Value.ToString();
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

        private void FindBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
