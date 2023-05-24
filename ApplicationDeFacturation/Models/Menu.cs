using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class Menu
    {
        public void affichage()
        {
            int choixMenu;
            AjoutFacture ajoutFacture = new AjoutFacture();

            do
            {
                Console.WriteLine("1- AJOUTER FACTURE");
                Console.WriteLine("2- MODIFIER FACTURE");

                Console.WriteLine("0- QUITTER");

                Console.WriteLine("FAITES VOTRE CHOIX:");
                choixMenu = Convert.ToInt32(Console.ReadLine());

                switch (choixMenu)
                {
                    case 1:
                        ajoutFacture.AjouterFacture();
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                }

            } while (choixMenu != 0);

        }
    }
}
