class Livre {
    // public string Titre { get; set; }
    // public string Auteur { get; set; }

    public string Titre;
    public string Auteur;
    public string Nom;
    public string Prenom;
    public float Price; 

    public Livre (string Titre, string Auteur, string Nom, string Prenom, float Price)
        {
            this.Titre = Titre ;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Auteur = Auteur;

        }
}