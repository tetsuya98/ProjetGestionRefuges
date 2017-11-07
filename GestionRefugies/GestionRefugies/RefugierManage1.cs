using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionRefugies
{
    partial class RefugierManage
    {
       
//---------------------------------------------------------------Nom----------------------------------------------------------------
public static void modifierRefugierNom(string id,string Nom)
		{
            	string sqlCommand = ("update refugies set nom ="+ Nom + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}
//---------------------------------------------------------------Prenom-------------------------------------------------------------

public static void modifierRefugierPrenom(string id,string Prenom)
		{
            	string sqlCommand = ("update refugies set prenom ="+ Prenom + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}
//---------------------------------------------------------------NATIONALITE--------------------------------------------------------

public static void modifierRefugierNation(string id,string Nationalite)
		{
           	string sqlCommand = ("update refugies set nationalite ="+ Nationalite + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}
//---------------------------------------------------------------SEXE---------------------------------------------------------------

public static void modifierRefugierSexe(string id,string Sexe)
		{
           	    string sqlCommand = ("update refugies set sexe =" + Sexe + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
           	    MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}


//---------------------------------------------------------------ADRESSE---------------------------------------------------------------

public static void modifierRefugierAdresse(string id,string Adresse)
		{	
            	string sqlCommand = ("update refugies set adresse ="+ Adresse + " where id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
           	    MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
        	}


//---------------------------------------------------------Refugier-Suppréssion--------------------------------------------------------


public static void SupprimerRefugier(string id)
		{
          	    string sqlCommand = ("DELETE from refuiges WHERE id = " + id);
            	MySqlCommand cmd = new MySqlCommand(sqlCommand, Database.getBD());
            	MySqlDataReader read = cmd.ExecuteReader();
            	read.Read();
            	read.Close();
		}
//--------------------------------------------Verification que le refugier n'est pas encore---------------------------------------------

//Dans une class partiel de celle de roman .

    }
}

