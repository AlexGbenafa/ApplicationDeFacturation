using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class AjoutFacture
    {
        public void AjouterFacture()
        {
            int arret = 0;

            AjoutClient ajoutClient = new AjoutClient();
            AjoutFacture ajoutFacture = new AjoutFacture();
            

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
                ajoutClient.AjouterClient();
                ajoutFacture.AjouterFacture();
            }

            DateOnly laDate = DateOnly.FromDateTime(DateTime.Now);
            //Facture facture = new Facture();

        }
    }
}
