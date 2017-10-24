using MySql.Data.MySqlClient; //dans la console des package Update-Package -reinstall
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    partial class RefugierManage
    {
            
            public static bool ajouterRefugier(string nom,string prenom,string sexe,string id,string mdp, DateTime date_naiss, string nationalite)
            {


            ///fctn verfi champs
                Refugier Ref = new Refugier(nom, prenom, sexe, mdp, date_naiss, nationalite);
                



            ///finir la requete sql
                string sqlCommand = "INSERT INTO refugies (clef, prenom, nom, nationalite, mdp, sexe, dateNais, adresse) VALUES ("+Ref.Id+"," + Ref.Nom+ "," + Ref.Prenom + ","+Ref.Id+","+Ref.Nationalite +","+ Ref.Motdepasse + "," +Ref.Sexe+","+ Ref.Date_nais+")";
                MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
                MySqlDataReader read = cmd.ExecuteReader();
                read.Read();
                read.Close();
                return true;
            }
    }
}
