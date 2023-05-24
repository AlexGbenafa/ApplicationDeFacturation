using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationDeFacturation.Models.EtatFacture;

namespace ApplicationDeFacturation.Models
{
    public class EtatDeFacture
    {
        public void EtatDeLaFacture() 
        {
            int choixStatut = Convert.ToInt32(Console.ReadLine());
            status EtatFacture = new status();

            switch (choixStatut)
            {
                case 0:
                    EtatFacture = status.Paye;
                    break;

                case 1: EtatFacture = status.Non_paye; break;

                case 2: EtatFacture = status.Abandonne; break;
            }
        }
    }
}
