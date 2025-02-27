using System.Data.Entity;
using Gestion_Scolaire.Models;
using GestionScolaire.Models;

namespace GestionScolaire.Data
{
    internal class GestionScolaireContext : DbContext
    {
        public GestionScolaireContext() : base("ecoleconnect")
        {
        }

        // Définir les DbSet pour chaque modèle
        public DbSet<Etudiant> Étudiants { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Matiere> Matières { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Note> Notes { get; set; }

       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurer les relations N:N
            modelBuilder.Entity<Cours>()
                .HasMany(c => c.Classes)
                .WithMany(cl => cl.Cours)
                .Map(m =>
                {
                    m.ToTable("ClassesCours"); // Nom de la table de liaison
                    m.MapLeftKey("CoursId");
                    m.MapRightKey("ClasseId");
                });

            base.OnModelCreating(modelBuilder);
        }*/
    }
}