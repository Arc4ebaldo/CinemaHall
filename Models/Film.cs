using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2.Models
{
    
    public partial class Film
    {
        public Film()
        {
        }

        public Film(string? title, string? director, string? genre, TimeOnly? duration, DateOnly? releaseYear, string? descript)
        {
            Title = title;
            Director = director;
            Genre = genre;
            Duration = duration;
            ReleaseYear = releaseYear;
            Descript = descript;
        }

        public int FilmId { get; set; }

        public string? Title { get; set; }

        public string? Director { get; set; }

        public string? Genre { get; set; }

        public TimeOnly? Duration { get; set; }

        public DateOnly? ReleaseYear { get; set; }

        public string? Descript { get; set; }

        public virtual ICollection<Sean>? Seans { get; set; } = new List<Sean>();
    }

}
