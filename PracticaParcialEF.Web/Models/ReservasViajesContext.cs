using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PracticaParcialEF.Web.Models;

public partial class ReservasViajesContext : DbContext
{
    public ReservasViajesContext(DbContextOptions<ReservasViajesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Destino> Destinos { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Destino>(entity =>
        {
            entity.HasKey(e => e.IdDestino);

            entity.ToTable("Destino");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.IdReserva);

            entity.ToTable("Reserva");

            entity.HasOne(d => d.IdDestinoNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reserva_Destino");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
