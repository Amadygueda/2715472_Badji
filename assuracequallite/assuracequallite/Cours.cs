public class Cours
{
    public int NumeroCours { get; set; }
    public string Code { get; set; }
    public string Titre { get; set; }

    public Cours(int numero, string code, string titre)
    {
        NumeroCours = numero;
        Code = code;
        Titre = titre;
    }
}

