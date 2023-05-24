using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationDeFacturation.Models.EtatFacture;

namespace ApplicationDeFacturation.Models
{
    public class AjoutFacture
    {
        public void AjouterFacture()
        {
            int arret = 0;

            AjoutClient ajoutClient = new AjoutClient();
            AjoutPanier ajoutPanier = new AjoutPanier();
            Panier? panier = null;
            status etatFacture = new status();

            do
            {
                Console.WriteLine("Voulez vous creer une facture? : ");
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
                panier = ajoutPanier.AjouterPanier();

                Console.WriteLine("Statut de la facture : ");
                Console.WriteLine("0:Paye ");
                Console.WriteLine("1:Non paye ");
                Console.WriteLine("2:Abandone ");

                int choixStatut = Convert.ToInt32(Console.ReadLine());

                switch (choixStatut)
                {
                    case 0:
                        etatFacture = status.Paye;
                        break;

                    case 1:
                        etatFacture = status.Non_paye;
                        break;

                    case 2:
                        etatFacture = status.Abandonne;
                        break;
                }

                // Demander si l'utilisateur veut ajouter une autre facture
                Console.WriteLine("Voulez-vous ajouter une autre facture ?");
                Console.WriteLine("(1) Oui, (0) Non");
                arret = Convert.ToInt32(Console.ReadLine());
            }

            if (panier != null)
            {
                DateOnly laDate = DateOnly.FromDateTime(DateTime.Now);
                Facture facture = new Facture(laDate, 10000, panier, etatFacture);
            }
        }
    }
}
