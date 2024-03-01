using test2.Models;
using test2.Repositories;

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

            Film newFilm = new Film(
                Title.Text,
                Director.Text,
                Genre.Text,
                TimeOnly.Parse(Duration.Text),
                DateOnly.Parse(ReleaseDate.Text),
                Description.Text
                );
            db.Films.Add(newFilm);
            db.SaveChanges();
            AllFilms.DataSource = db.Films.ToList();
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
    }
}
