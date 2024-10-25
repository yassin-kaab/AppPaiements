public class Utilisateur
{
    public string Nom { get; set; }
    public List<Paiement> Paiements { get; set; }

    public Utilisateur(string nom)
    {
        Nom = nom;
        Paiements = new List<Paiement>();
    }

    public virtual void AjouterPaiement(Paiement paiement)
    {
        Paiements.Add(paiement);
        Console.WriteLine("Paiment valider");
    }

    public virtual void Afficherinfo()
    {
        Console.WriteLine($"Nom d'utilisateur: {Nom}");
        Console.WriteLine($"Paiement: {Paiements}");
        foreach (var paiement in Paiements)
        {
            paiement.AfficherDetails();
        }
    }
}

