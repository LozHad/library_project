using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace library_project.Models;

public partial class LibraryDbContext : DbContext
{
    public LibraryDbContext()
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=library_db;Username=postgres;Password=1111;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("authors_pkey");

            entity.ToTable("authors");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Author1).HasColumnName("author");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("books_pkey");

            entity.ToTable("books");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Annotation).HasColumnName("annotation");
            entity.Property(e => e.CopiesAvaliable).HasColumnName("copies_avaliable");
            entity.Property(e => e.CopiesTotal).HasColumnName("copies_total");
            entity.Property(e => e.IdAuthor).HasColumnName("id_author");
            entity.Property(e => e.IdGenres).HasColumnName("id_genres");
            entity.Property(e => e.IdPublisher).HasColumnName("id_publisher");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Isbn).HasColumnName("isbn");
            entity.Property(e => e.Lists).HasColumnName("lists");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.YearOfPublication).HasColumnName("year_of_publication");

            entity.HasOne(d => d.IdAuthorNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdAuthor)
                .HasConstraintName("id_author");

            entity.HasOne(d => d.IdGenresNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdGenres)
                .HasConstraintName("id_genre");

            entity.HasOne(d => d.IdPublisherNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdPublisher)
                .HasConstraintName("id_publisher");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Genre1).HasColumnName("genre");
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("loans_pkey");

            entity.ToTable("loans");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfIssue).HasColumnName("date_of_issue");
            entity.Property(e => e.DateOfPlanningReturn).HasColumnName("date_of_planning_return");
            entity.Property(e => e.DateOfReturn).HasColumnName("date_of_return");
            entity.Property(e => e.IdBook).HasColumnName("id_book");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Loans)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("id_status");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Loans)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("id_user");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("publishers_pkey");

            entity.ToTable("publishers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Publisher1).HasColumnName("publisher");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Role1).HasColumnName("role");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("statuses_pkey");

            entity.ToTable("statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Status1).HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName).HasColumnName("first_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.LastName).HasColumnName("last_name");
            entity.Property(e => e.LibraryTicket).HasColumnName("library_ticket");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("id_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
