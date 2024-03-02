using test2.Models;

namespace test2
{
    public partial class FilmForm : Form
    {
        private ApplicationContext db = new();
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
         }

        private void Edit_Click(object sender, EventArgs e)
        {
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
        }
    }
}
