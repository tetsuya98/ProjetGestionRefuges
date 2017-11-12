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

        public static bool ajouterRefugier(string nom, string prenom, string sexe, string mdp, DateTime date_naiss, string nationalite, int maison)
        {


            ///fctn verfi champs
            Refugier Ref = new Refugier(nom, prenom, mdp, sexe, date_naiss, nationalite, maison);




            ///finir la requete sql
            string sqlCommand = "INSERT INTO refugies (clef, prenom, nom, nationalite, mdp, sexe, dateNais, adresse) VALUES (" + Ref.Id + "," + Ref.Prenom + "," + Ref.Nom + "," + Ref.Nationalite + "," + Ref.Motdepasse + "," + Ref.Sexe + "," + Ref.Date_nais + ")";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            read.Close();
            return true;

            //Envoi des paramètres
            /* cmd.Parameters.Add(post.Name);
             cmd.Parameters.Add(post.Content);
             cmd.Parameters.Add(post.Author); */
            try
            {
                //Execution de la commande SQL qui peut provoquer des exceptions
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                //traitement de l'exception...
                return false;
            }
        }
    }
}
