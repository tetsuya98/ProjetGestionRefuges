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
        private int age;
        private int secteur;
        private int maison;



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

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
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



        public Refugier(string nom, string prenom,string motdepasse, string sexe, int age, int secteur, int maison):base(nom, prenom, motdepasse)// constructeur de base du refugier
        {
            
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
            this.Age = age;
            this.Secteur = secteur;
            this.Maison = maison;
            this.Id = "Ref" + Nom + Prenom[0];
        }

        public int Test_Name(string name) //test de la validité du nom du refugier
        {


            return (0);
        }

        


    }
}
