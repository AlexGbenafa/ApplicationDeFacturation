using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDeFacturation.Models
{
    public class Client
    {
        //Attributs
        private int idClient { get;}
        private string nomClient { get; set; }
        private string prenomClient { get; set; }
        private string mailClient { get; set; }
        private string addresseClient { get; set; }
        private string numTelClient { get; set; }

        private static int dernierIdClient = 0;

        //Constructeur
        public Client(string unNomClient, string unPrenomClient, string unMailClient, string uneAddresseClient, string unNumTelClient)
        {
            idClient = dernierIdClient++;
            nomClient = unNomClient;
            prenomClient = unPrenomClient;
            mailClient = unMailClient;
            addresseClient = unPrenomClient;
            numTelClient = unNumTelClient;
        }

        public int getIdClient()
        {
            return idClient;
        }

        public string getNomClient()
        {
            return nomClient;
        }

        public string getPrenomClient() { 
            return prenomClient;
        }

        public string getMailClient()
        {
            return mailClient;
        }

        public string getAddresseClient()
        {
            return addresseClient;
        }

        public string getNumTelClient()
        {
            return numTelClient;
        }
    }
}
