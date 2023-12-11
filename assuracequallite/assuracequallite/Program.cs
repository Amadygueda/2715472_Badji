using System;
using System.Collections.Generic;

public class Program
{
    static List<Etudiant> etudiants = new List<Etudiant>();
    static List<Cours> cours = new List<Cours>();
    static List<Note> notes = new List<Note>();

    public static void Main()
    {
        // Ici, vous pouvez ajouter le code pour interagir avec l'utilisateur,
        // comme la création d'étudiants, de cours, et l'attribution de notes.
        // Exemple : Ajout d'un étudiant, d'un cours et d'une note.
        etudiants.Add(new Etudiant(1, "Dupont", "Jean"));
        cours.Add(new Cours(101, "INF101", "Introduction à la programmation"));
        notes.Add(new Note(1, 101, 85.5));

        // Affichage des données
        foreach (var etudiant in etudiants)
        {
            Console.WriteLine($"Etudiant: {etudiant.NumeroEtudiant}, {etudiant.Nom}, {etudiant.Prenom}");
        }

        // Plus de code pour la gestion des données...
    }
}
