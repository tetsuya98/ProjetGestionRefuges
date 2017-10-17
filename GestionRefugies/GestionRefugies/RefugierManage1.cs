using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRefugies
{
    partial class RefugierManage
    {
        public static void modifRefugier()
        {
            /* 
public static void ajouterRefugier(){
            string sqlCommand = "INSERT INTO refugies (clef, prenom, nom, nationalite, mdp, camps_id, sexe, dateNais, adresse) VALUES ('clefy', 'prenom', 'nom', 'nationalite', 'mdp', 1, 'F', 'dateNais', 'Adresse')";
            MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            MySqlDataReader read = cmd.ExecuteReader(); 
            read.Read();
            read.Close();
        }

---------------------------------------------------------------Nom----------------------------------------------------------------
public static void modifierRefugierNom(string id,string Nom)
		{
            	string sqlCommand = ("update refugies set nom ="+ Nom + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}
---------------------------------------------------------------Prenom-------------------------------------------------------------

public static void modifierRefugierPrenom(string id,string Prenom)
		{
            	string sqlCommand = ("update refugies set prenom ="+ Prenom + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}
---------------------------------------------------------------NATIONALITE--------------------------------------------------------

public static void modifierRefugierNation(string id,string Nationalite)
		{
           	string sqlCommand = ("update refugies set nationalite ="+ Nationalite + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}
---------------------------------------------------------------SEXE---------------------------------------------------------------

public static void modifierRefugierSexe(string id,string Sexe)
		{
           	string sqlCommand = ("update refugies set sexe =" + Sexe + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
           	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}


---------------------------------------------------------------ADRESSE------------------------------------------------------------

public static void modifierRefugierAdresse(string id,string Adresse)
		{	
            	string sqlCommand = ("update refugies set adresse ="+ Adresse + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
           	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}


---------------------------------------------------------Refugier-Suppréssion--------------------------------------------------------


Public static void SupprimerRefugier(string id)
		{
          	string sqlCommand = ("DELETE from refuiges WHERE id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
		}
Public static bool(string prenom, string nom, string sexe,date dateNais)
        {
            
            
            
        }
Dans une class partiel de celle de roman .*/

        }
    }
}
