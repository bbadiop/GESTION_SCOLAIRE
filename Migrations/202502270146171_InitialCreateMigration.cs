namespace Gestion_Scolaire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Professeur_Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatière = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prénom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(),
                        Prénom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        Sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        ClasseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClasseId, cascadeDelete: true)
                .Index(t => t.ClasseId);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoteValue = c.Single(nullable: false),
                        EtudiantId = c.Int(nullable: false),
                        MatiereId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.EtudiantId, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.MatiereId, cascadeDelete: true)
                .Index(t => t.EtudiantId)
                .Index(t => t.MatiereId);
            
            CreateTable(
                "dbo.CoursClasses",
                c => new
                    {
                        Cours_Id = c.Int(nullable: false),
                        Classe_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Cours_Id, t.Classe_Id })
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.Classe_Id, cascadeDelete: true)
                .Index(t => t.Cours_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.MatiereCours",
                c => new
                    {
                        Matiere_Id = c.Int(nullable: false),
                        Cours_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Matiere_Id, t.Cours_Id })
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id, cascadeDelete: true)
                .ForeignKey("dbo.Cours", t => t.Cours_Id, cascadeDelete: true)
                .Index(t => t.Matiere_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.ProfesseurMatieres",
                c => new
                    {
                        Professeur_Id = c.Int(nullable: false),
                        Matiere_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Professeur_Id, t.Matiere_Id })
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id, cascadeDelete: true)
                .Index(t => t.Professeur_Id)
                .Index(t => t.Matiere_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "MatiereId", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "EtudiantId", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "ClasseId", "dbo.Classes");
            DropForeignKey("dbo.ProfesseurMatieres", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseurMatieres", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.Classes", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.MatiereCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.MatiereCours", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.CoursClasses", "Cours_Id", "dbo.Cours");
            DropIndex("dbo.ProfesseurMatieres", new[] { "Matiere_Id" });
            DropIndex("dbo.ProfesseurMatieres", new[] { "Professeur_Id" });
            DropIndex("dbo.MatiereCours", new[] { "Cours_Id" });
            DropIndex("dbo.MatiereCours", new[] { "Matiere_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Classe_Id" });
            DropIndex("dbo.CoursClasses", new[] { "Cours_Id" });
            DropIndex("dbo.Notes", new[] { "MatiereId" });
            DropIndex("dbo.Notes", new[] { "EtudiantId" });
            DropIndex("dbo.Etudiants", new[] { "ClasseId" });
            DropIndex("dbo.Classes", new[] { "Professeur_Id" });
            DropTable("dbo.ProfesseurMatieres");
            DropTable("dbo.MatiereCours");
            DropTable("dbo.CoursClasses");
            DropTable("dbo.Notes");
            DropTable("dbo.Etudiants");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Matieres");
            DropTable("dbo.Cours");
            DropTable("dbo.Classes");
        }
    }
}
