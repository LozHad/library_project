using System;
using System.Collections.Generic;

namespace library_project.Models;

public partial class Publisher
{
    public short Id { get; set; }

    public string Publisher1 { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
