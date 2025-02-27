using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Scolaire.Models;

public class Note
{
    public int Id { get; set; }
    public float NoteValue { get; set; }

    // Relation 1:N avec Étudiant
    public int EtudiantId { get; set; }
    public Etudiant Etudiant { get; set; }

    // Relation 1:N avec Matière
    public int MatiereId { get; set; }
    public Matiere Matiere { get; set; }
}