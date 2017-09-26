using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    class Refugier
    {
        private int id;
        private string nom;
        private string prenom;
        private string sexe;
        private int age;
        private int secteur;
        private int maison;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public int Age { get => age; set => age = value; }
        public int Secteur { get => secteur; set => secteur = value; }
        public int Maison { get => maison; set => maison = value; }

        public Refugier(int iD, string noM, string prenoM, string sexE, int agE, int secteuR, int maisoN)
        {
            Id = iD;
            Nom = noM;
            Prenom = prenoM;
            Sexe = sexE;
            Age = agE;
            Secteur = secteuR;
            Maison = maisoN;

        }
    }
}
