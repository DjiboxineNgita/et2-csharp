using comptebancaire;
using comptebancaire.compte;

public class Program
{
    public static void Main(string[] args)
    {
        run();
    }

    public static void run()
    {
        Boolean isRunning = true;
        
        Console.WriteLine("Creer un compte bancaire \n\n\n");
        Console.WriteLine("\t1- Compte principale");
        Console.WriteLine("\t2- Compte mobile");
        Console.WriteLine("\t3- Compte epargne\n");
        Console.Write("Entrer un nombre pour choisir le type: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("\n\nEntrer votre nom: ");
        string name = Console.ReadLine();
        Console.WriteLine("\n\nprocessing...");
        
        Thread.Sleep(500);
        CompteBancaire compte = null;
        string typeCompte = null;
        switch (choice)
        {
            case 1:
                compte = new ComptePrincipale(name, "compte_principale_01");
                typeCompte = "principale";
                break;
            case 2:
                compte = new CompteMobile(name, "compte_mobile_01");
                typeCompte = "mobile";
                break;
            case 3:
                compte = new CompteEpargne(name, "compte_epargne_01");
                typeCompte = "epargne";
                break;
            default:
                throw new Exception("Choix invalide");
                Thread.Sleep(500);
                run();
        }
        Console.WriteLine("\nCompte " + typeCompte + " crée avec succès\n\n\n");

        while(isRunning)
        {
            Console.WriteLine("\t1- Debiter compte");
            Console.WriteLine("\t2- Crediter mobile");
            Console.WriteLine("\t3- Consulter solde");
            Console.WriteLine("\t4- Faire un pret\n");
            Console.Write("Entrer un nombre pour choisir : ");

            int choice2 = int.Parse(Console.ReadLine());

            switch(choice2)
            {
                case 1:
                    Console.Write("\n\n\t\tSomme: ");
                    double somme1 = double.Parse(Console.ReadLine());
                    compte.debiter(somme1);
                    break;
                case 2:
                    Console.Write("\n\n\t\tSomme: ");
                    double somme2 = double.Parse(Console.ReadLine());
                    compte.crediter(somme2);
                    break;
                case 3:
                    Console.Write("\n\n\t\tSolde: " + compte.consulterSolde() + "\n\n");
                    break;
                case 4:
                    Console.WriteLine("\t\t\tNot implemented yet");
                    break;
                default:
                    Console.WriteLine("\t\t\nInvalid choice. End of program");
                    isRunning = false;
                    break;
            }
        }
    }
}
