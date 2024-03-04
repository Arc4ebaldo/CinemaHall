using System.Drawing.Printing;
using System.Runtime.InteropServices;
using test2.DTO;
using test2.Models;
using test2.Repositories;
using test2.Services;
using test2.View;

namespace test2
{
    public partial class FilmForm : Form
    {
        public FilmForm()
        {
            InitializeComponent();
        }

        private FilmService filmService = new();

        private void Add_Click(object sender, EventArgs e)
        {
            FilmDTO newFilm = new FilmDTO(
                    Title.Text,
                    Director.Text,
                    Genre.Text,
                    Duration.Text,
                    ReleaseDate.Text,
                    Description.Text
                );
            filmService.CreateFilm(newFilm);

            AllFilms.DataSource = filmService.GetAllFilms();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            filmService.DeleteFilmById(int.Parse(ID));
            AllFilms.DataSource = filmService.GetAllFilms();
        }

        private string ID;

        private void Edit_Click(object sender, EventArgs e)
        {
            FilmDTO newFilm = new FilmDTO(
                    ID,
                    Title.Text,
                    Director.Text,
                    Genre.Text,
                    Duration.Text,
                    ReleaseDate.Text,
                    Description.Text
                );
            filmService.UpdateFilm(newFilm);
            AllFilms.DataSource = filmService.GetAllFilms();
        }

        private void FilmForm_Load(object sender, EventArgs e)
        {
            AllFilms.AutoGenerateColumns = false;
            AllFilms.Columns["IDPole"].DataPropertyName = "Id";
            AllFilms.Columns["NamePole"].DataPropertyName = "Title";
            AllFilms.Columns["DirectorPole"].DataPropertyName = "Director";
            AllFilms.Columns["GenrePole"].DataPropertyName = "Genre";
            AllFilms.Columns["DurationPole"].DataPropertyName = "Duration";
            AllFilms.Columns["DataPole"].DataPropertyName = "ReleaseDate";
            AllFilms.Columns["DescriptionPole"].DataPropertyName = "Description";
            AllFilms.DataSource = filmService.GetAllFilms();
            Genre.DataSource = new List<string>() { "Боевик", "Комедия", "Ужасы", "Триллер", "Фантастика", "Драма", "Мультфильм" };
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

        private void FilmForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void TransBtn_Click(object sender, EventArgs e)
        {
            TransForm m = new TransForm();
            m.Show();
            this.Close();
        }


        private void AllFilms_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = AllFilms.SelectedCells;
            ID = selectedCells[0].Value.ToString();
            Title.Text = selectedCells[1].Value.ToString();
            Director.Text = selectedCells[2].Value.ToString();
            Genre.Text = selectedCells[3].Value.ToString();
            Duration.Text = selectedCells[4].Value.ToString();
            ReleaseDate.Text = selectedCells[5].Value.ToString();
            Description.Text = selectedCells[6].Value.ToString();
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
            List<FilmDTO> list = filmService.GetAllFilms();
            if (Title.Text.Length > 0)
            {
                foreach (var i in list)
                {
                    if (i.Title == Title.Text)
                    {
                        AllFilms.DataSource = new List<FilmDTO>() { i };
                        return;
                    }
                }
            }
            if (Director.Text.Length > 0)
            {
                List<FilmDTO> returnList = new List<FilmDTO>();
                foreach (var i in list)
                {
                    if (i.Director == Director.Text)
                    {
                        returnList.Add(i);
                    }
                }
                AllFilms.DataSource = returnList;
                return;
            }

        }
    }
}
