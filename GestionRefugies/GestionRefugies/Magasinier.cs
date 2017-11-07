using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    public class Magasinier : User
    {
        #region champs
        //declarer les champs

        private string adresse;

        #endregion

        #region constructeur

        //declarer le constructeur

        public Magasinier(string nom, string prenom, string password, string adresse) : base (nom, prenom, password)
        {
            this.Id = "Mag" + nom + prenom[0];
            this.adresse = adresse;
        } 

        #endregion

        #region Accesseur

        //accesseur 

        public string Adresse
        {
            get
            {
                return adresse;
            }
            set
            {
                adresse = value;
            }
        }

        #endregion

        #region methode

         
        #endregion


    }
}
