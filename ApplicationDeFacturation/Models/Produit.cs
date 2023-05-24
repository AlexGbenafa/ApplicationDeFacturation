using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class Produit
    {
        //Attributs
        private int idProduit { get;}
        private string nomProduit { get;}
        private decimal quantiteProduit { get; }

        private decimal prixProduit { get; }

        private static int dernierIdProduit = 0;

        //Constructeur
        public Produit(string unNomProduit, decimal unPrixProduit, decimal uneQuantiteProduit)
        {
            idProduit = dernierIdProduit++;
            nomProduit = unNomProduit;
            prixProduit = unPrixProduit;
            quantiteProduit = uneQuantiteProduit;
        }
    }
}
