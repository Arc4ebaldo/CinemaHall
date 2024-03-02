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

     
    }
}
