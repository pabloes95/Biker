using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Biker.Modelo
{
    public partial class BikerContext : DbContext
    {
        public BikerContext()
            : base("name=BikerContext")
        {
        }

        public virtual DbSet<Bicicleta> Bicicletas { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Competicion> Competicions { get; set; }
        public virtual DbSet<Corredor> Corredors { get; set; }
        public virtual DbSet<Ruta> Rutas { get; set; }
        public virtual DbSet<RutaCompeticion> RutaCompeticions { get; set; }
        public virtual DbSet<RutaCorredor> RutaCorredors { get; set; }
        public virtual DbSet<Tipo> Tipoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bicicleta>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Corredors)
                .WithOptional(e => e.Categoria1)
                .HasForeignKey(e => e.Categoria);

            modelBuilder.Entity<Competicion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Competicion>()
                .Property(e => e.Premio)
                .IsUnicode(false);

            modelBuilder.Entity<Competicion>()
                .HasMany(e => e.RutaCompeticions)
                .WithRequired(e => e.Competicion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Corredor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Corredor>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Corredor>()
                .HasMany(e => e.RutaCorredors)
                .WithRequired(e => e.Corredor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ruta>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ruta>()
                .Property(e => e.Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<Ruta>()
                .Property(e => e.Distancia)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Ruta>()
                .HasMany(e => e.RutaCompeticions)
                .WithRequired(e => e.Ruta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ruta>()
                .HasMany(e => e.RutaCorredors)
                .WithRequired(e => e.Ruta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RutaCorredor>()
                .Property(e => e.Distancia)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Tipo>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Tipo>()
                .HasMany(e => e.Bicicletas)
                .WithOptional(e => e.Tipo1)
                .HasForeignKey(e => e.tipo);
        }
    }
}
