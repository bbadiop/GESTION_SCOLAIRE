using Gestion_Scolaire.Models;
using System.Collections.Generic;

namespace GestionScolaire.Models
{
    public class Classe
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }

        // Relation 1:N avec Étudiant
        public ICollection<Etudiant> Etudiants { get; set; }

        // Relation N:N avec Cours
        public ICollection<Cours> Cours { get; set; }
    }
}