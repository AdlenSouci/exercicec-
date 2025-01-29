
public void Afficher()
{

}

public void Test()
{

    Livre monLivre = new Livre("Le Petit Prince", "Antoine", "Saint-Exupéry", 10.5f);



}



class Livre
{
    // public string Titre { get; set; }
    // public string Auteur { get; set; }

    public string Titre;

    public string Nom;
    public string Prenom;
    public float Prix;

    public Livre(string Titre, string Nom, string Prenom, float Prix)
    {
        this.Titre = Titre;
        this.Nom = Nom;
        this.Prenom = Prenom;
        this.Prix = Prix;

    }


}