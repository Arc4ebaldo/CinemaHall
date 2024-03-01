using System.Runtime.InteropServices;
using test2.Models;
using test2.Repositories;
using test2.View;

namespace test2
{
    public partial class FilmForm : Form
    {
        private BaseDbContext db = new();
        public FilmForm()
        {
            InitializeComponent();
        }

        private int id;

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Film film = db.Films.Where(f => f.FilmId == id).First();
            db.Films.Remove(film);
            db.SaveChanges();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Film film = db.Films.Where(f => f.FilmId == id).First();
            db.Films.Update(film);
            db.SaveChanges();
        }

        private void FilmForm_Load(object sender, EventArgs e)
        {

        }


        private void AllFilms_MouseClick(object sender, MouseEventArgs e)
        {
            AllFilms.DataSource = db.Films.ToList();
        }

        private void AllFilms_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(AllFilms.SelectedCells[0].Value.ToString());
                Title.Text = AllFilms.SelectedCells[1].Value.ToString();
                Director.Text = AllFilms.SelectedCells[2].Value.ToString();
                Genre.Text = AllFilms.SelectedCells[1].Value.ToString();
                Title.Text = AllFilms.SelectedCells[1].Value.ToString();
                Title.Text = AllFilms.SelectedCells[1].Value.ToString();
                Title.Text = AllFilms.SelectedCells[1].Value.ToString();

            }
            catch (Exception)
            {

            }
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
    }
}
