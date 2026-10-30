using System;
using System.Collections.Generic;

namespace library_project.Models;

public partial class Book
{
    public long Id { get; set; }

    public string Isbn { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int IdAuthor { get; set; }

    public short IdGenres { get; set; }

    public short IdPublisher { get; set; }

    public short YearOfPublication { get; set; }

    public short Lists { get; set; }

    public short CopiesTotal { get; set; }

    public short CopiesAvaliable { get; set; }

    public string Annotation { get; set; } = null!;

    public string? Image { get; set; }

    public virtual Author IdAuthorNavigation { get; set; } = null!;

    public virtual Genre IdGenresNavigation { get; set; } = null!;

    public virtual Publisher IdPublisherNavigation { get; set; } = null!;
}
