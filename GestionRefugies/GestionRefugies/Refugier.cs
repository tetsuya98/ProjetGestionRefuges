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

        public Refugier(string nom, string prenom, string sexe,string motdepasse, DateTime date,string nationalite):base(nom, prenom, motdepasse)// constructeur de base du refugier
        {
            
            this.Sexe = sexe;
            this.Date_nais = date;
            this.Nationalite = nationalite;

            this.Id = "Ref" + Nom + Prenom[0];
        }

      

        


    }
}
