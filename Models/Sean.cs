namespace test2.Models;

public partial class Sean
{
    public int SeansId { get; set; }

    public DateOnly? StartDatetime { get; set; }

    public TimeOnly? Duration { get; set; }

    public int? HallId { get; set; }

    public int? FilmId { get; set; }

    public virtual Film? Film { get; set; }

    public virtual Hall? Hall { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
