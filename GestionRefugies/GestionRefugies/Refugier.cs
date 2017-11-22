using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    partial class Refugier
    {
        #region champs
        /// <summary>
        /// nom du refugier
        /// </summary>
        protected string nom;

        /// <summary>
        /// prénom du refugier
        /// </summary>
        protected string prenom;

        /// <summary>
        /// identifiant du refugier
        /// </summary>
        protected int id;

        /// <summary>
        /// sexe du refugier
        /// </summary>
        private string sexe;

        /// <summary>
        /// Date de naissance du refugier
        /// </summary>
        private DateTime date_nais;
        
        /// <summary>
        /// Adresse du refugier
        /// </summary>
        private int adresse;

        /// <summary>
        /// Nationnalité du refugier
        /// </summary>
        private string nationalite;
        #endregion

        #region propriete
        public string Nom
        {
            get
            {
                return nom;
            }
        }
        public string Prenom
        {
            get
            {
                return nom;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Sexe
        {
            get
            {
                return sexe;
            }
        }
        public DateTime Date_nais
        {
            get
            {
                return date_nais;
            }
        }
        public int Adresse
        {
            get
            {
                return adresse;
            }
        }
        public string Nationalite
        {
            get
            {
                return nationalite;
            }
        }
        #endregion

        #region methode
        public Refugier(string nom, string prenom,string motdepasse, string sexe, DateTime date_nais, string nationalite, int adresse, int id = 0)
        {
            
            this.nom = nom; 
            this.prenom = prenom;
            this.sexe = sexe;
            this.date_nais = date_nais;
            this.nationalite = nationalite;
            this.adresse = adresse;
            this.id = id;
        }
        #endregion
    }
}
