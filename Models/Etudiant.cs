using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using GestionScolaire.Models;

namespace Gestion_Scolaire.Models
{
    public  class Etudiant
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        // Relation 1:N avec Classe
        public int ClasseId { get; set; }
        public  Classe Classe { get; set; }

        // Relation 1:N avec Note
        public ICollection<Note> Notes { get; set; }
    }
}
