using Gestion_Scolaire.Models;
using System.Collections.Generic;

public class Matiere
{
    public int Id { get; set; }
    public string NomMatière { get; set; }

    // Relation N:N avec Cours
    public ICollection<Cours> Cours { get; set; }

    // Relation N:N avec Professeur
    public ICollection<Professeur> Professeurs { get; set; }
}