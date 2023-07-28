using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.ConsoleApp.ScaffoldDB;

public partial class League
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
}
