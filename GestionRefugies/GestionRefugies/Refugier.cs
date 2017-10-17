using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    partial class Refugier
    {
        private int id;
        private string nom;
        private string prenom;
        private string sexe;
        private int age;
        private int secteur;
        private int maison;



        public int Id
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

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
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



        public Refugier(int iD, string noM, string prenoM, string sexE, int agE, int secteuR, int maisoN) // constructeur de base du refugier
        {
            Id = iD;
            Nom = noM;
            Prenom = prenoM;
            Sexe = sexE;
            Age = agE;
            Secteur = secteuR;
            Maison = maisoN;

        }

        public int Test_Name(string name) //test de la validité du nom du refugier
        {


            return (0);
        }


    }
}
