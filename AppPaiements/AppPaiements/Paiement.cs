public class Paiement
{
    public double Montant { get; set; }
    public string Description { get; set; }

    public Paiement(double montant, string description)
    {
        Montant = montant;
        Description = description;
    }

    public virtual void AfficherDetails()
    {
        Console.WriteLine($"Montant est de:{Montant}, {Description}");
    }
}
