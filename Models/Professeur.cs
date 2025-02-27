using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionScolaire.Models;

public class Professeur
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prénom { get; set; }
    public string Email { get; set; }
    public string Telephone { get; set; }

    // Relation N:N avec Matière
    public ICollection<Matiere> Matières { get; set; }

    // Relation N:N avec Classe
    public ICollection<Classe> Classes { get; set; }
}