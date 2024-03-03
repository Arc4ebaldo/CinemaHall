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
    public partial class TransForm : Form
    {
        public TransForm()
        {
            InitializeComponent();
        }

        private TransactionService transactionService = new();
        private string ID;

        private void TransForm_Load(object sender, EventArgs e)
        {
            AllTrans.DataSource = transactionService.GetAllTransactions();
            TipyTrans.DataSource = new List<string>() { "Наличка", "Перевод", "QR код", "Картой" };
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

        private void SotrudBtn_Click(object sender, EventArgs e)
        {
            SotrudForm m = new SotrudForm();
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

        private void TransForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            TransactionDTO newTrans = new TransactionDTO(
                DataTime.Text,
                TipyTrans.Text,
                Amount.Text
                );
            transactionService.CreateTransaction(newTrans);
            AllTrans.DataSource = transactionService.GetAllTransactions();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            transactionService.DeleteTransactionById(int.Parse(ID));
            AllTrans.DataSource = transactionService.GetAllTransactions();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            TransactionDTO newTrans = new TransactionDTO(
                ID,
                DataTime.Text,
                TipyTrans.Text,
                Amount.Text
                );
            transactionService.UpdateTransaction(newTrans);
            AllTrans.DataSource = transactionService.GetAllTransactions();
        }

        private void AllTrans_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = AllTrans.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            TransID.Text = selectedCells[0].Value.ToString();
            DataTime.Text = selectedCells[1].Value.ToString();
            TipyTrans.Text = selectedCells[2].Value.ToString();
            Amount.Text = selectedCells[3].Value.ToString();
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

    }
}
