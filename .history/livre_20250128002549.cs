class Livre {
    public string Titre { get; set; }
    public string Auteur { get; set; }

    public string Titre;
    public string Auteur { get; set; }

    public string Nom;
    public string Prenom
    public float Price; 

    public Livre (string Titre, string Auteur, float Price)
        {
            this.Titre = Titre ;
            this.Auteur = Auteur;

        }
}