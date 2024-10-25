public class CarteCredit : Paiement
{
    public int NumeroCarte { get; set; }

    public CarteCredit(double montant, string description, int numeroCarte)
        : base(montant, description)
    {
        NumeroCarte = numeroCarte;
    }

    public override void AfficherDetails()
    {
        Console.WriteLine($"Paiement par Carte de crédit: {Montant}, Description: {Description}, Numéro: {NumeroCarte}");
    }
}
