using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class AjoutProduit
    {
        public Produit AjouterProduit()
        {
            int arret = 0;
            bool isValidInput = false;

            string nomProduit = String.Empty;
            decimal quantiteProduit = 0;
            decimal prixProduit = 0;

            do
            {
                Console.WriteLine("Voulez vous enregistrer un produit? : ");
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
                    Console.WriteLine("Nom du produit:");
                    nomProduit = Console.ReadLine()!;
                    if (String.IsNullOrEmpty(nomProduit))
                    {
                        Console.WriteLine("Veuillez entrer un nom!");
                    }
                }
                while (String.IsNullOrEmpty(nomProduit) || String.IsNullOrWhiteSpace(nomProduit));

                do
                {
                    Console.WriteLine("Quantite de produit:");
                    string input = Console.ReadLine()!;

                    if (Decimal.TryParse(input, out quantiteProduit))
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez entrer une quantite valide!");
                    }
                }
                while (!isValidInput);


                do
                {
                    Console.WriteLine("Prix de produit:");
                    string input = Console.ReadLine()!;

                    if (Decimal.TryParse(input, out prixProduit))
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Veuillez entrer une quantite valide!");
                    }
                }
                while (!isValidInput);

                DateOnly laDate = DateOnly.FromDateTime(DateTime.Now);
                Produit produit = new Produit(nomProduit, prixProduit,quantiteProduit);

                return produit;

            }
        }
    }
}
