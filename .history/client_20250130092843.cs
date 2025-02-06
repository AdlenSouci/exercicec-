//exercice 1


using System.Runtime.CompilerServices;

class Client
{
    // public string Titre { get; set; }
    // public string Auteur { get; set; }

    public string CIN;

    public string Nom;
    public string Prenom;
    public float Tel;

    public void Test()
    {
        Empl monLivre = new Employee("88", "Antoine", "Saint-camember", 0658794425);
    }
    public Client(string CIN, string Nom, string Prenom, float Tel)
    {
        this.CIN = CIN;
        this.Nom = Nom;
        this.Prenom = Prenom;
        this.Tel = Tel;
    }
    public Client(string CIN, string Nom, string Prenom)
    {
        this.CIN = CIN;
        this.Nom = Nom;
        this.Prenom = Prenom;
    }
    public void Afficher()
    {
        Console.WriteLine($"Cin : {CIN}");
        Console.WriteLine($"Nom : {Nom}");
        Console.WriteLine($"Prenom : {Prenom}");
        Console.WriteLine($"Tel : {Tel}");
    }


}

class Compte
{
    private int code;
    public int solde;

    public void Test()
    {
        Livre monLivre = new Livre("88", "Antoine", "Saint-camember", 0658794425);
    }

    public void Crediter()
    {

    }
    public void Debiter()
    {

    }

    public void ResumeCompte()
    {
        Console.WriteLine($"Solde : {solde}");
    }

}