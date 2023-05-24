using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class AjoutPanier
    {
        public void AjouterPanier()
        {
            AjoutProduit ajoutProduit = new AjoutProduit();

            ajoutProduit.AjouterProduit();

            DateOnly laDate = DateOnly.FromDateTime(DateTime.Now);
            Panier panier = new Panier(, laDate);
        }
    }
}
