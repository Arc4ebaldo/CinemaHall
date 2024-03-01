using System;
using System.Collections.Generic;

namespace test2.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public bool? Statue { get; set; }

    public int? Price { get; set; }

    public int? Seat { get; set; }

    public int? SeansId { get; set; }

    public virtual Sean? Seans { get; set; }
}
