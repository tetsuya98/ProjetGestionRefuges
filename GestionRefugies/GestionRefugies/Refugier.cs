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
        protected string id;

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
        public string Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }

    
    

        public int Maison
        {
            get
            {
                return maison;
            }

            set
            {
                maison = value;
            }
        }

        public DateTime Date_nais
        {
            get
            {
                return date_nais;
            }

            set
            {
                date_nais = value;
            }
        }

        public string Nationalite
        {
            get
            {
                return nationalite;
            }

            set
            {
                nationalite = value;
            }
        }
        #endregion

        #region methode
        public Refugier(string nom, string prenom,string motdepasse, string sexe, DateTime date_nais, string nationalite, int maison):base(nom, prenom, motdepasse)// constructeur de base du refugier
        {
            
            this.Nom = nom; 
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.date_nais = date_nais;
            this.nationalite = nationalite;
            this.Maison = maison;
            this.Id = "Ref" + Nom + Prenom[0];
        }
        #endregion
    }
}
