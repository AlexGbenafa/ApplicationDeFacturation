using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class Panier
    {
        //Attributs
        private int idPanier { get; }
        private Produit produitPanier { get; set; }
        private DateOnly dateAjoutPanier { get; set; }

        private static int dernierIdPanier = 0;

        //Constructeur 
        public Panier(Produit unProduitPanier, DateOnly uneDateAjoutPanier)
        {
            idPanier = dernierIdPanier++;
            produitPanier = unProduitPanier;
            dateAjoutPanier = uneDateAjoutPanier;
        }


    }
}
