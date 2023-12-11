public class Etudiant
{
    public int NumeroEtudiant { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public Etudiant(int numero, string nom, string prenom)
    {
        NumeroEtudiant = numero;
        Nom = nom;
        Prenom = prenom;
    }
}

