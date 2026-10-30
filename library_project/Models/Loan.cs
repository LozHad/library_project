using System;
using System.Collections.Generic;

namespace library_project.Models;

public partial class Loan
{
    public long Id { get; set; }

    public long IdUser { get; set; }

    public long IdBook { get; set; }

    public DateOnly DateOfIssue { get; set; }

    public DateOnly DateOfPlanningReturn { get; set; }

    public DateOnly? DateOfReturn { get; set; }

    public short IdStatus { get; set; }

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
