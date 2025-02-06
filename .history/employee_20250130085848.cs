//exercice 2
using System;
class Employee
{


    public string Matricule;
    public string Nom;
    public string Prenom;
    public DateTime DateNaissance;
    public DateTime DateEmbauche;
    public static DateTime Now;
    public float Salaire;


    public void Test()
    {

        Livre monLivre = new Livre("100", "Antoine", "Saint-Exupéry", 2500);



    }
    public Employee(string Matricule, string Nom, string Prenom, float Salaire, DateTime DateNaissance, DateTime DateEmbauche)
    {
        this.Matricule = Matricule;
        this.Nom = Nom;
        this.Prenom = Prenom;
        this.Salaire = Salaire;
        this.DateEmbauche = DateEmbauche;
        this.DateNaissance = DateNaissance;

    }

    public int Age()
    {

        return DateTime.Now.Year - DateNaissance.Year;
    }
    public int Anciennete() //j'allais mettre void a la place du int
    {
        // date now - date embauche 
        return DateTime.Now.Year - DateEmbauche.Year;
    }




    public void AugmentationDuSalaire()
    {
        int anciennete = Anciennete();

        if (anciennete < 5)
        {
            Salaire = Salaire  1.02f;
        }

        else if (anciennete < 10)
        {
            Salaire = Salaire * 5%;  //sur stackoverflow j'ai vu qu'on pouvait utiliser F pour les pourcentages 
        }
        else
        {
            Salaire = Salaire * 10%; 
        }
        // je ne sais pas si je dois utiliser 1.10, 1.5, 1.02

    }
    public void AfficherEmployé()
    {
        Console.WriteLine($"Matricule : {Matricule}");
        Console.WriteLine($"Nom : {Nom}");
        Console.WriteLine($"Salaire : {Salaire}");
        Console.WriteLine($"Âge : {Age()} ans");
        Console.WriteLine($"Ancienneté : {Anciennete()} ans");

    }



}