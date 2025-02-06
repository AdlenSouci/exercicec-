using System;

class Livre
{
    public string Titre;
    public string Nom;
    public string Prenom;
    public float Prix;

    public Livre(string titre, string nom, string prenom, float prix)
    {
        this.Titre = titre;
        this.Nom = nom;
        this.Prenom = prenom;
        this.Prix = prix;
    }

    public void Afficher()
    {
        Console.WriteLine($"Titre : {Titre}");
        Console.WriteLine($"Auteur : {Nom} {Prenom}");
        Console.WriteLine($"Prix : {Prix} €");
    }
}

partial class Program
{
    static void Main()
    {
        Livre monLivre = new Livre("Le Petit Prince", "Antoine", "de Saint-Exupéry", 10.5f);
        monLivre.Afficher();
    }
}
