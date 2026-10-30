using System;
using System.Collections.Generic;

namespace library_project.Models;

public partial class Status
{
    public short Id { get; set; }

    public string Status1 { get; set; } = null!;

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
