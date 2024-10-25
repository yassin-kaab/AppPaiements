internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit paiement1 = new CarteCredit(50.0, "Achat sur Amazon", 590320);
        CarteCredit paiement2 = new CarteCredit(20.0, "Achat sur eBay", 244920);
        CarteCredit paiement3 = new CarteCredit(100.0, "Achat sur Uber", 495930);

        paiement1.AfficherDetails();
        paiement2.AfficherDetails();
        paiement3.AfficherDetails();
    
          Console.WriteLine(Console.ReadLine());

        
        PayPal paiement4 = new PayPal(150.0, "Paiement de Hotel", "yassin@gmail.com");
        PayPal paiement5 = new PayPal(75.0, "Achat sur BestBuy", "yassin@gmail.com");

        paiement4.AfficherDetails();
        paiement5.AfficherDetails();

          Console.WriteLine(Console.ReadLine());


        Utilisateur utilisateur = new Utilisateur("kaab");

        CarteCredit carte = new CarteCredit(50.0, "Achat sur Amazon", 584929);
        PayPal paypal = new PayPal(150.0, "Paiement de hotel", "kaab@gmail.com");

        utilisateur.AjouterPaiement(carte);
        utilisateur.AjouterPaiement(paypal);


    }

    
}