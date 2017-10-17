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
            
            public static void ajouterRefugier()
            {
                string sqlCommand = "INSERT INTO refugies (clef, prenom, nom, nationalite, mdp, camps_id, sexe, dateNais, adresse) VALUES ('clefy', 'prenom', 'nom', 'nationalite', 'mdp', 1, 'F', 'dateNais', 'Adresse')";
                MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
                MySqlDataReader read = cmd.ExecuteReader();
                read.Read();
                read.Close();
            }      
    }
}
