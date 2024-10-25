internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit paiement1 = new CarteCredit(50.0, "Achat sur Amazon", 590320);
        CarteCredit paiement2 = new CarteCredit(20.0, "Achat sur eBay", 244920);
        CarteCredit paiement3 = new CarteCredit(100.0, "Achat sur Fnac", 495930);

        paiement1.AfficherDetails();
        paiement2.AfficherDetails();
        paiement3.AfficherDetails();
    }
}