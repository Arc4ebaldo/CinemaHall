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
    public partial class SotrudForm : Form
    {
        public SotrudForm()
        {
            InitializeComponent();
        }

        private string ID;
        private EmployeeService EmployeeService = new();

        private void SotrudForm_Load(object sender, EventArgs e)
        {
            AllEmployee.DataSource = EmployeeService.GetAllEmployees();
            Role.DataSource = new List<string>() { "Администратор", "Кассир", "Продавец", "Бухгалтер", "Охранник", "Киномеханик", "Уборщик" };
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

        private void Add_Click(object sender, EventArgs e)
        {
            EmployeeDTO newEmployee = new EmployeeDTO(
                FirstName.Text,
                LastName.Text,
                Role.Text
                );
            EmployeeService.CreateEmployee(newEmployee);
            AllEmployee.DataSource = EmployeeService.GetAllEmployees();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            EmployeeService.DeleteEmployeeById(int.Parse(ID));
            AllEmployee.DataSource = EmployeeService.GetAllEmployees();

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EmployeeDTO newEmployee = new EmployeeDTO(
                ID,
                FirstName.Text,
                LastName.Text,
                Role.Text
                );
            EmployeeService.UpdateEmployee(newEmployee);
            AllEmployee.DataSource = EmployeeService.GetAllEmployees();
        }

        private void AllEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = AllEmployee.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            Console.WriteLine(ID);
            FirstName.Text = selectedCells[1].Value.ToString();
            LastName.Text = selectedCells[2].Value.ToString();
            Role.Text = selectedCells[3].Value.ToString();
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
