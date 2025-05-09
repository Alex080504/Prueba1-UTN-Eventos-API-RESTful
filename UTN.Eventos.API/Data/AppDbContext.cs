using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UTN.Eventos.Modelos;

    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<UTN.Eventos.Modelos.Evento> Eventos { get; set; } = default!;
        public DbSet<UTN.Eventos.Modelos.Participante> Participantes { get; set; } = default!;
        public DbSet<UTN.Eventos.Modelos.Inscripcion> Inscripciones { get; set; } = default!;
        public DbSet<UTN.Eventos.Modelos.Certificado> Certificados { get; set; } = default!;
        public DbSet<UTN.Eventos.Modelos.Ponente> Ponentes { get; set; } = default!;
        public DbSet<UTN.Eventos.Modelos.Sesion> Sesiones { get; set; } = default!;
        public DbSet<UTN.Eventos.Modelos.EventoPonente> EventosPonentes { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EventoPonente>()
            .HasKey(ep => new { ep.EventoId, ep.PonenteId });

        modelBuilder.Entity<EventoPonente>()
            .HasOne(ep => ep.Evento)
            .WithMany(e => e.EventosPonentes)
            .HasForeignKey(ep => ep.EventoId);

        modelBuilder.Entity<EventoPonente>()
            .HasOne(ep => ep.Ponente)
            .WithMany(p => p.EventosPonentes)
            .HasForeignKey(ep => ep.PonenteId);
    }

}
