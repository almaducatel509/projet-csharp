/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 12/10/2021
 * Time: 13:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HopitalEspoirDelmas.baseHopital;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.container;
using System.Windows.Forms;
using System.Collections.Generic;
namespace HopitalEspoirDelmas.contratTr
{
	/// <summary>
	/// Description of ViewContrat.
	/// </summary>
	public class ViewContrat
	{
		public ViewContrat()
		{
		}
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
     	MySqlDataAdapter adap = null;
		
			
			ContratTraitement contr = new ContratTraitement();
			public static int EnregistrerContrat(ContratTraitement contr){
			int cont =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			String prepareRequest = "insert into contrats (nomCompAs, sigleCompAs,"+
				"nomDir, adresse, tlf, email, pourcentageCons, pourcentageChambre, pourcentageHosp,"+
			"etat)"+"values(@nomCompAs,@sigleCompAs,@nomDir,@adresse,@tlf,@email,@pourcentageCons,@pourcentageChambre,"+
				"@pourcentageHosp,@etat)";
			//Recuperation de la connection
			 con = DbHopitalEs.Connection();
			
			 
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			//comd.Parameters.AddWithValue("idContrats", null);
			comd.Parameters.AddWithValue("nomCompAs", contr.NomCompAs);
			comd.Parameters.AddWithValue("sigleCompAs", contr.SigleCompAs);
			comd.Parameters.AddWithValue("nomDir", contr.NomDir);
			comd.Parameters.AddWithValue("adresse", contr.Adresse);
			comd.Parameters.AddWithValue("tlf", contr.Tlf);
			comd.Parameters.AddWithValue("email", contr.Email);
			comd.Parameters.AddWithValue("pourcentageCons", contr.PourcentageCons);
			comd.Parameters.AddWithValue("pourcentageChambre", contr.PourcentageChambre);
			comd.Parameters.AddWithValue("pourcentageHosp", contr.PourcentageHosp);
			comd.Parameters.AddWithValue("etat", contr.Etat);
			
			
			cont = comd.ExecuteNonQuery();
			cont =1;
			con.Close();
			return cont;
			}
			catch(Exception exc)
			{
				MessageBox.Show("Except :: "+exc.Message);
			}
		
			return cont;
		}

			
		public static List<ContratTraitement> getAll()
		{
			List<ContratTraitement> cont = new List<ContratTraitement>();
		
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM CONTRATS";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				while(readr.Read())
				{
					ContratTraitement contr = new ContratTraitement();
					contr.IdContrats = int.Parse(readr["idContrats"].ToString());
					contr.NomCompAs = readr["nomCompAs"].ToString();
					contr.NomDir = readr["nomDir"].ToString();
					contr.Adresse = readr["adresse"].ToString();
					contr.Email = readr["email"].ToString();
					contr.Tlf = readr["tlf"].ToString();
					contr.SigleCompAs = readr["sigleCompAs"].ToString();
					contr.PourcentageCons = double.Parse(readr["pourcentageCons"].ToString());
					contr.PourcentageChambre = double.Parse(readr["pourcentageChambre"].ToString());
					contr.PourcentageHosp = double.Parse(readr["pourcentageHosp"].ToString());
					contr.Etat = readr["etat"].ToString();
					cont.Add(contr);
				}
				
			}
			readr.Close();
			con.Close();
			return cont;
		}
			
		public  ContratTraitement getById(String idContrats)
		{
			ContratTraitement contr = new ContratTraitement();
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM contrats where idContrats = @idContrats";
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			comd.Parameters.AddWithValue("@idContrats", idContrats);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				if(readr.Read())
				{
					
					contr.IdContrats = int.Parse(readr["idContrats"].ToString());
					contr.NomCompAs = readr["nomCompAs"].ToString();
					contr.NomDir = readr["nomDir"].ToString();
					contr.Adresse = readr["adresse"].ToString();
					contr.Email = readr["email"].ToString();
					contr.Tlf = readr["tlf"].ToString();
					contr.SigleCompAs = readr["sigleCompAs"].ToString();
					contr.PourcentageCons = double.Parse(readr["pourcentageCons"].ToString());
					contr.PourcentageChambre = double.Parse(readr["pourcentageChambre"].ToString());
					contr.PourcentageHosp = double.Parse(readr["pourcentageHosp"].ToString());
					contr.Etat = readr["etat"].ToString();
				}
			}
			readr.Close();
			con.Close();
			return contr;
		}
		
		public static int updateContr (ContratTraitement contr){
			
			int cont =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			String prepareRequest = "update contrats set nomCompAs=@nomCompAs, sigleCompAs = @sigleCompAs,"+
				"nomDir = @nomDir, adresse = @adresse, tlf = @tlf, email = @email," +
				"pourcentageCons = @pourcentageCons, pourcentageChambre = @pourcentageChambre, pourcentageHosp = @pourcentageHosp,"+
				"etat = @etat where idContrats=@idContrats";
			//Recuperation de la connection
			
			
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			comd.Parameters.AddWithValue("idContrats", contr.IdContrats);
			comd.Parameters.AddWithValue("nomCompAs", contr.NomCompAs);
			comd.Parameters.AddWithValue("sigleCompAs", contr.SigleCompAs);
			comd.Parameters.AddWithValue("nomDir", contr.NomDir);
			comd.Parameters.AddWithValue("adresse", contr.Adresse);
			comd.Parameters.AddWithValue("tlf", contr.Tlf);
			comd.Parameters.AddWithValue("email", contr.Email);
			comd.Parameters.AddWithValue("pourcentageCons", contr.PourcentageCons);
			comd.Parameters.AddWithValue("pourcentageChambre", contr.PourcentageChambre);
			comd.Parameters.AddWithValue("pourcentageHosp", contr.PourcentageHosp);
			comd.Parameters.AddWithValue("etat", contr.Etat);
			//MessageBox.Show("idContrats"+contr.IdContrats);
			
			
			cont =comd.ExecuteNonQuery();
				
			
			
			con.Close();
			return cont;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return cont;
		}
		
		
		public  int DelService (String idContrats)
		{
			int n = 0;
			MySqlConnection con = DbHopitalEs.Connection();
			
			String prepareRequest = "Delete FROM contrats where idContrats = @idContrats";
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			
			comd.Parameters.AddWithValue("@idContrats", idContrats);
			n = comd.ExecuteNonQuery();
			
			con.Close();
			return n;
			
		}
			
			
			
		
	}
}
