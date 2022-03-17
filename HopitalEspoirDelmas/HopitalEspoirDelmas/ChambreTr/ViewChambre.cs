/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 09/10/2021
 * Time: 22:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using System.Windows.Forms;
using HopitalEspoirDelmas.container;
using System.Collections.Generic;
namespace HopitalEspoirDelmas.ChambreTr
{
	/// <summary>
	/// Description of ViewChambre.
	/// </summary>
	public class ViewChambre
	{
		public ViewChambre()
		{
		}
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
			ChambreTraitement chb = new ChambreTraitement();
			
			public static int EnregistrerChambre(ChambreTraitement chb){
			int ch =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			String prepareRequest = "insert into chambre (nomChambre, typeChambre, couvrirParAssurance,"+
				"prixLocationParJour, Etat, constituantsChambre,Description)"+ 
				" values(@nomChambre,@typeChambre,@couvrirParAssurance,"+
				"@prixLocationParJour,@Etat,@constituantsChambre, @Description)";
			//Recuperation de la connection
			 con = DbHopitalEs.Connection();
			

			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			//comd.Parameters.AddWithValue("idChambre", null);
			comd.Parameters.AddWithValue("nomChambre", chb.NomChambre);
			comd.Parameters.AddWithValue("typeChambre", chb.TypeChambre);
			comd.Parameters.AddWithValue("prixLocationParJour", chb.PrixLocationParJour);
			comd.Parameters.AddWithValue("Etat", chb.Etat);
			comd.Parameters.AddWithValue("Description", chb.Description);
			comd.Parameters.AddWithValue("constituantsChambre", chb.ConstituantChambre);
			comd.Parameters.AddWithValue("couvrirParAssurance", chb.CouvrirParAssurance);
			
			ch = comd.ExecuteNonQuery();
			con.Close();
			return ch;
			}
			catch(Exception exc)
			{
				MessageBox.Show("ERROR :: "+exc.Message);
			}
		
			return ch;
		}
		
			
		public static List<ChambreTraitement> getAll()
		{
			List<ChambreTraitement> ch = new List<ChambreTraitement>();
		
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM CHAMBRE";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				while(readr.Read())
				{
					ChambreTraitement chb = new ChambreTraitement();
					chb.IdChambre = int.Parse(readr["idChambre"].ToString());
					chb.NomChambre = readr["nomChambre"].ToString();
					chb.TypeChambre = readr["typeChambre"].ToString();
					chb.PrixLocationParJour = Double.Parse(readr["prixLocationParJour"].ToString());
					chb.ConstituantChambre = readr["constituantsChambre"].ToString();
					chb.Etat = readr["Etat"].ToString();
					chb.Description = readr["Description"].ToString();
					chb.CouvrirParAssurance = readr["couvrirParAssurance"].ToString();
					ch.Add(chb);
				}
			}
			readr.Close();
			con.Close();
			return ch;
		}
		
		public  ChambreTraitement getById(String idChambre)
		{
			ChambreTraitement chb = new ChambreTraitement();
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM CHAMBRE where idChambre = @idChambre";
			comd.Parameters.AddWithValue("@idChambre", idChambre);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				if(readr.Read())
				{
					
					chb.IdChambre = int.Parse(readr["idChambre"].ToString());
					chb.NomChambre = readr["nomChambre"].ToString();
					chb.TypeChambre = readr["typeChambre"].ToString();
					chb.PrixLocationParJour = Double.Parse(readr["prixLocationParJour"].ToString());
					chb.ConstituantChambre = readr["constituantsChambre"].ToString();
					chb.Etat = readr["Etat"].ToString();
					chb.Description = readr["Description"].ToString();
					chb.CouvrirParAssurance = readr["couvrirParAssurance"].ToString();
					
				}
			}
			readr.Close();
			con.Close();
			return chb;
		}
		
		public static int updateCh (ChambreTraitement chb){
			
			int ch =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			String prepareRequest = "update chambre set nomChambre=@nomChambre, typeChambre = @typeChambre,"+
				"couvrirParAssurance = @couvrirParAssurance, prixLocationParJour = @prixLocationParJour, " +
				"Etat = @Etat, constituantsChambre = @constituantsChambre,Description = @Description where idChambre=@idChambre";
			
			
			//Recuperation de la connection
			
			
						 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			comd.Parameters.AddWithValue("idChambre", chb.IdChambre);
			comd.Parameters.AddWithValue("nomChambre", chb.NomChambre);
			comd.Parameters.AddWithValue("typeChambre", chb.TypeChambre);
			comd.Parameters.AddWithValue("prixLocationParJour", chb.PrixLocationParJour);
			comd.Parameters.AddWithValue("Etat", chb.Etat);
			comd.Parameters.AddWithValue("Description", chb.Description);
			comd.Parameters.AddWithValue("constituantsChambre", chb.ConstituantChambre);
			comd.Parameters.AddWithValue("couvrirParAssurance", chb.CouvrirParAssurance);
			
			
			
			ch = comd.ExecuteNonQuery();
			ch = 1;
			con.Close();
			return ch;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return ch;
		}
		
		
		

		
		public  int DelChambre (String idChambre)
		{
			int n = 0;
			MySqlConnection con = DbHopitalEs.Connection();
			
			String prepareRequest = "Delete FROM chambre where idChambre = @idChambre";
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			
			comd.Parameters.AddWithValue("@idChambre", idChambre);
			n = comd.ExecuteNonQuery();
			
			con.Close();
			return n;
			
		}
	}
}
	

	