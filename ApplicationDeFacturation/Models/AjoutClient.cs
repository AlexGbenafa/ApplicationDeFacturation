using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class AjoutClient
    {

        public void AjouterClient()
        {
            int arret = 0;
            string nomClient = String.Empty;
            string prenomClient = String.Empty;
            string mailClient = String.Empty;
            string addresseClient = String.Empty;
            string numTelClient = String.Empty;

            do
            {
                Console.WriteLine("Voulez vous enregistrer un client? : ");
                Console.WriteLine("(1) enregistrer, (0) quitter : ");

                //CONTROLE DE SAISIE
                try
                {
                    arret = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Saisie incorrecte! Veuillez saisir (0) ou (1)!");
                }
            } while (arret != 0 && arret != 1);

            while (arret == 1)
            {
                do
                {
                    Console.WriteLine("Nom du client:");
                    nomClient = Console.ReadLine()!;
                    if (String.IsNullOrEmpty(nomClient))
                    {
                        Console.WriteLine("Veuillez entrer un nom!");
                    }
                }
                while (String.IsNullOrEmpty(nomClient) || String.IsNullOrWhiteSpace(nomClient));

                do
                {
                    Console.WriteLine("Prenom du client:");
                    prenomClient = Console.ReadLine()!;
                    if (String.IsNullOrEmpty(prenomClient))
                    {
                        Console.WriteLine("Veuillez entrer un prenom!");
                    }
                }
                while (String.IsNullOrEmpty(prenomClient) || String.IsNullOrWhiteSpace(prenomClient));

                do
                {
                    Console.WriteLine("Mail du client :");
                    mailClient = Console.ReadLine()!;
                    if (String.IsNullOrEmpty(mailClient))
                    {
                        Console.WriteLine("Veuillez entrer un mail!");
                    }
                }
                while (String.IsNullOrEmpty(mailClient) || String.IsNullOrWhiteSpace(mailClient));

                do
                {
                    Console.WriteLine("Addresse du client :");
                    addresseClient = Console.ReadLine()!;
                    if (String.IsNullOrEmpty(addresseClient))
                    {
                        Console.WriteLine("Veuillez entrer une addresse!");
                    }
                }
                while (String.IsNullOrEmpty(addresseClient) || String.IsNullOrWhiteSpace(addresseClient));

                do
                {
                    Console.WriteLine("Numero de telephone du client :");
                    numTelClient = Console.ReadLine()!;
                    if (String.IsNullOrEmpty(numTelClient))
                    {
                        Console.WriteLine("Veuillez entrer un numero de telephone!");
                    }
                }
                while (String.IsNullOrEmpty(numTelClient) || String.IsNullOrWhiteSpace(numTelClient));
            }

            DateOnly laDate = DateOnly.FromDateTime(DateTime.Now);
            Client client = new Client(nomClient,prenomClient,mailClient,addresseClient,numTelClient);

        }
    }
}