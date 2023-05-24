using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class AjoutProduit
    {
        public Produit? AjouterProduit()
        {
            int arret = 0;

            string nomProduit = String.Empty;
            decimal quantiteProduit = 0;
            decimal prixProduit = 0;

            do
            {
                Console.WriteLine("Voulez-vous enregistrer un produit ?");
                Console.WriteLine("(1) Oui, (0) Non");

                // Contrôle de la saisie
                try
                {
                    arret = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Saisie incorrecte ! Veuillez saisir (0) ou (1).");
                }
            } while (arret != 0 && arret != 1);

            if (arret == 1)
            {
                do
                {
                    Console.WriteLine("Nom du produit :");
                    nomProduit = Console.ReadLine()!;
                    if (String.IsNullOrEmpty(nomProduit))
                    {
                        Console.WriteLine("Veuillez entrer un nom !");
                    }
                } while (String.IsNullOrEmpty(nomProduit) || String.IsNullOrWhiteSpace(nomProduit));

                bool isValidInput = false;

                do
                {
                    Console.WriteLine("Quantité de produit :");
                    string input = Console.ReadLine()!;

                    if (Decimal.TryParse(input, out quantiteProduit) && quantiteProduit > 0)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez entrer une quantité valide et supérieure à zéro !");
                    }
                } while (!isValidInput);

                isValidInput = false;

                do
                {
                    Console.WriteLine("Prix du produit :");
                    string input = Console.ReadLine()!;

                    if (Decimal.TryParse(input, out prixProduit) && prixProduit > 0)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez entrer un prix valide et supérieur à zéro !");
                    }
                } while (!isValidInput);

                DateOnly laDate = DateOnly.FromDateTime(DateTime.Now);
                Produit produit = new Produit(nomProduit, prixProduit, quantiteProduit);

                return produit;
            }

            return null;
        }
    }
}
