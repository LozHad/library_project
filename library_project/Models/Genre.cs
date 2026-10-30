using System;
using System.Collections.Generic;

namespace library_project.Models;

public partial class Genre
{
    public short Id { get; set; }

    public string Genre1 { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
