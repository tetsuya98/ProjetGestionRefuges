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

        public static bool ajouterRefugier(Refugier Ref)
        {

            ///finir la requete sql
            string sqlCommand = "INSERT INTO refugies (id, prenom, nom, nationalite, sexe, dateNais, adresse) VALUES (?,?,?,?,?,?,?)";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
           
            cmd.CommandText = sqlCommand;

            //Envoi des paramètres
            cmd.Parameters.AddWithValue("@Id", Ref.Id);
            cmd.Parameters.AddWithValue("@nom", Ref.Nom);
            cmd.Parameters.AddWithValue("@prenom", Ref.Prenom);
            cmd.Parameters.AddWithValue("@nationalite", Ref.Nationalite);
            cmd.Parameters.AddWithValue("@sexe", Ref.Sexe);
            cmd.Parameters.AddWithValue("@Datenais", Ref.Date_nais);
            cmd.Parameters.AddWithValue("@maison",Ref.Adresse.ToString());
        
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
