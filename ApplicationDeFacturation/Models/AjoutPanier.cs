using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class AjoutPanier
    {
        public Panier? AjouterPanier()
        {
            AjoutProduit ajoutProduit = new AjoutProduit();

            Produit? unProduit = ajoutProduit.AjouterProduit();

            if (unProduit != null)
            {
                DateOnly laDate = DateOnly.FromDateTime(DateTime.Now);
                Panier panier = new Panier(unProduit, laDate);
                return panier;
            }

            return null;
        }
    }
}
