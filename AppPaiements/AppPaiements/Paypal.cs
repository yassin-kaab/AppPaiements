public class PayPal : Paiement
{
    public string Courriel { get; set; }

    public PayPal(double montant, string description, string email)
        : base(montant, description)
    {
        Courriel = email;
    }

    public override void AfficherDetails()
    {
        Console.WriteLine($"Paiement par PayPal: {Montant}, Description: {Description}, Email: {Courriel}");
    }
}
