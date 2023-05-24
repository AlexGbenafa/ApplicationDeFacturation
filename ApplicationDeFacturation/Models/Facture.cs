using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class Facture
    {
        //Attributs
        private int idFacture { get; }
        private Client client { get; set; }
        private DateOnly dateDelivranceFacture { get; set; }
        private decimal montantFacture { get; set; }
        private Panier panier { get; set; }
        private EtatFacture etatFacture { get; set; }

        private static int dernierIdFacture = 0;
        private DateOnly laDate;
        private int v;
        private EtatFacture.status etatFacture1;

        //Constructeur
        public Facture( DateOnly uneDateDelivranceFacture, decimal unMontantFacture, Panier unPanier, EtatFacture unEtatFacture)
        {
            idFacture = dernierIdFacture++;
            //client = unClient;
            dateDelivranceFacture = uneDateDelivranceFacture;
            montantFacture = unMontantFacture;
            panier = unPanier;
            etatFacture = unEtatFacture;
        }

        public Facture(DateOnly laDate, int v, Panier panier, EtatFacture.status etatFacture1)
        {
            this.laDate = laDate;
            this.v = v;
            this.panier = panier;
            this.etatFacture1 = etatFacture1;
        }
    }
}
