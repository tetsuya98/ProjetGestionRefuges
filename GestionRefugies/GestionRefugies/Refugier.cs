using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    partial class Refugier : User
    {

        private string sexe;
        private DateTime date_nais;
        
        private int maison;
        private DateTime date_nais;
        private string nationalite;


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

    
        public int Secteur
        {
            get
            {
                return secteur;
            }

            set
            {
                secteur = value;
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

      


            return (0);
        }

        


    }
}
