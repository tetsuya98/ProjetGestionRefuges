using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    class Magasinier
    {
        #region champs
        //declarer les champs

        private string nom;
        private string prenom;
        private string id;
        private string password;

        #endregion

        #region constructeur

        //declarer le constructeur

        public Magasinier(string nom, string prenom, string passwrod)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Id = id;
            this.Password = password;
        } 

        #endregion

        #region Accesseur

        //accesseur 

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                try
                {
                    nom = value;
                }
                catch (Exception e)
                {
                    throw new Exception = A
                }
                
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        #endregion

        #region methode

        //declarer les methodes

     /*   public void AjoutMag(string nom, string prenom, string id, string password)
        {
            //lié à la bdd
        }

        public void DeleteMag(string nom, string prenom, string id, string password)
        {
            //lié à la bdd
        }   */
         
        #endregion


    }
}
