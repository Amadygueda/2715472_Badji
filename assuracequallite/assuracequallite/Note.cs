public class Note
{
    public int NumeroEtudiant { get; set; }
    public int NumeroCours { get; set; }
    public double NoteObtenue { get; set; }

    public Note(int numEtudiant, int numCours, double note)
    {
        NumeroEtudiant = numEtudiant;
        NumeroCours = numCours;
        NoteObtenue = note;
    }
}


