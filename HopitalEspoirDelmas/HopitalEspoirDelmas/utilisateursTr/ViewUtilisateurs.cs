/*
 * Created by SharpDevelop.
 * User: Fl3m
 * Date: 15-Oct-21
 * Time: 3:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HopitalEspoirDelmas.utilisateursTr
{
	/// Description of ViewUtilisateurs.
	
	public class ViewUtilisateurs
	{
		public ViewUtilisateurs()
		{
		}
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
			
			UtilisateursTraitement util = new UtilisateursTraitement();
			public static int EnregistrerUtilisateur(UtilisateursTraitement util){
			int uti =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			
			try
			{
			//preparation de la requete
			String prepareRequest = "insert into utilisateurs (pseudo, motDPass,"+
				"etat, moduleAcces)"+"values(@pseudo,@motDPass,@etat,@moduleAcces)";
			//Recuperation de la connection
			 con = DbHopitalEs.Connection();
			
			
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			comd.Parameters.AddWithValue("IdEmp", null);
			comd.Parameters.AddWithValue("pseudo", util.Pseudo);
			comd.Parameters.AddWithValue("motDPass", util.MotDPass);
			comd.Parameters.AddWithValue("etat", util.Etat);
			comd.Parameters.AddWithValue("moduleAcces", util.ModuleAcces);
			MessageBox.Show("modul"+util.ModuleAcces);
			
			
			
			uti = comd.ExecuteNonQuery();
			con.Close();
			return uti;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return uti;
		}

			
		public static List<UtilisateursTraitement> getAll()
		{
			List<UtilisateursTraitement> uti = new List<UtilisateursTraitement>();
		
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM UTILISATEURS";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				while(readr.Read())
				{
					UtilisateursTraitement util = new UtilisateursTraitement();
					util.IdEmp = int.Parse(readr["idEmp"].ToString());
					util.Pseudo= readr["pseudo"].ToString();
					util.MotDPass = readr["motDPass"].ToString();
					util.Etat = readr["etat"].ToString();
					util.ModuleAcces = readr["moduleAcces"].ToString();
					
					uti.Add(util);
				}
				
			}
			readr.Close();
			con.Close();
			return uti;
		}
			
		public  UtilisateursTraitement getById(String idEmp)
		{
			UtilisateursTraitement util = new UtilisateursTraitement();
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM Utilisateurs where idEmp = @idEmp";
			comd.Parameters.AddWithValue("@idEmp", idEmp);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				if(readr.Read())
				{
					
					util.IdEmp = int.Parse(readr["idEmp"].ToString());
					util.Pseudo= readr["pseudo"].ToString();
					util.MotDPass = readr["motDPass"].ToString();
					util.Etat = readr["etat"].ToString();
					util.ModuleAcces = readr["moduleAcces"].ToString();
					
				}
			}
			readr.Close();
			con.Close();
			return util;
		}
		
		public static int updateUtlis (UtilisateursTraitement util){
			
			int u =0;
			MySqlConnection con = DbHopitalEs.Connection();
			
			try
			{
				//preparation de la requete
				String prepareRequest = "update utilisateurs set pseudo = @pseudo,motDPass = @motDPass,"+
					"etat = @etat,moduleAcces = @moduleAcces where idEmp = @idEmp";
				
				//Recuperation de la connection
			
				 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
				comd.Parameters.AddWithValue("idEmp", util.IdEmp);
				comd.Parameters.AddWithValue("pseudo", util.Pseudo);
				comd.Parameters.AddWithValue("motDPass", util.MotDPass);
				comd.Parameters.AddWithValue("etat", util.Etat);
				comd.Parameters.AddWithValue("moduleAcces", util.ModuleAcces);
				u = comd.ExecuteNonQuery();
				u=1;
				con.Close();
				return u;
				}
				catch(Exception exc)
				{
					MessageBox.Show(exc.Message);
				}
			
				return u;
		}
		
		
		public  int DelUtilisateur (String pseudo)
		{
			int f = 0;
			MySqlConnection con = DbHopitalEs.Connection();
			
			String prepareRequest = "Delete FROM utilisateurs where pseudo = @pseudo";
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			
			comd.Parameters.AddWithValue("@pseudo", pseudo);
			f = comd.ExecuteNonQuery();
			
			con.Close();
			return f;
		}
	}
}
