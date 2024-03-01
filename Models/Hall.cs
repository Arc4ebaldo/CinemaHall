using System;
using System.Collections.Generic;

namespace test2.Models;

public partial class Hall
{
    public int HallId { get; set; }

    public string? Capacity { get; set; }

    public string? Namy { get; set; }

    public virtual ICollection<Sean> Seans { get; set; } = new List<Sean>();
}
