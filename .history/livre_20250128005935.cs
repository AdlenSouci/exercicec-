class Livre
{
    // public string Titre { get; set; }
    // public string Auteur { get; set; }

    public string Titre;
    public string Auteur;
    public string Nom;
    public string Prenom;
    public float Prix;

    public Livre(string Titre, string Auteur, string Nom, string Prenom, float Prix)
    {
        this.Titre = Titre;
        this.Nom = Nom;
        this.Prenom = Prenom;
        this.Auteur = this.Nom + " " + this.Prenom;
        this.Prix = Prix;

    }

    public void Afficher()
    {

    }

    public void Test()
    {
        Livre livre = new Livre("prince en carton", "adlen souci", "30");
        Livre monLivre = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard", "123456789", 10.5f);

      

    }
}