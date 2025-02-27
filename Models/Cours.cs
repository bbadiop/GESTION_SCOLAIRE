using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionScolaire.Models;

public class Cours
{
    public int Id { get; set; }
    public string NomCours { get; set; }
    public string Description { get; set; }

    // Relation N:N avec Classe
    public ICollection<Classe> Classes { get; set; }

    // Relation N:N avec Matière
    public ICollection<Matiere> Matières { get; set; }
}