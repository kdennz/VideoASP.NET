using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication0.Models;

public partial class CrudCoreContext : DbContext
{
    public CrudCoreContext()
    {
    }

    public CrudCoreContext(DbContextOptions<CrudCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=KDEN\\SQLEXPRESS; DataBase=Crud_CORE;Integrated Security=true; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.IdPeople).HasName("PK__People__8DB1905631420268");

            entity.Property(e => e.NamePeople).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
