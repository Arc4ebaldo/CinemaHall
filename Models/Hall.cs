namespace test2.Models;

public partial class Hall
{
    public int HallId { get; set; }

    public int? Capacity { get; set; }

    public string? Namy { get; set; }

    public virtual ICollection<Sean> Seans { get; set; } = new List<Sean>();

    public Hall (int capacity, string name, ICollection<Sean> seansList) {
        this.Capacity = capacity;
        this.Namy = name;
        this.Seans = seansList;
    }
}
