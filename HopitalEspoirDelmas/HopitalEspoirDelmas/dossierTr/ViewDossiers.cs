/*
 * Created by SharpDevelop.
 * User: Fl3m
 * Date: 14-Oct-21
 * Time: 2:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HopitalEspoirDelmas.Properties.MainForm;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HopitalEspoirDelmas.dossierTr
{
	/// <summary>
	/// Description of ViewDossiers.
	/// </summary>
	public class ViewDossiers
	{
		public ViewDossiers()
		{
		}
		
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
			
			DossiersTraitement dosr = new DossiersTraitement();
			public static int EnregistrerPatient(DossiersTraitement dosr){
			int dos =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			
			try
			{
			//preparation de la requete
			String prepareRequest = "insert into dossiers (nomPatient, prenom,"+
				"sexe, dateNaiss, age, compAssure, persResp, numeroPers, adres,"+
			"telephone, mail, trtSuivi, memo)"+" values (@nomPatient,@prenom,@sexe,@dateNaiss,@age,@compAssure,"+
				"@persResp,@numeroPers,@adres,@telephone,@mail,@trtSuivi,@memo)";
			//Recuperation de la connection
			 con = DbHopitalEs.Connection();
			
			
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			
			//comd.Parameters.AddWithValue("noDossier", dosr.NoDossier);
			comd.Parameters.AddWithValue("nomPatient", dosr.NomPatient);
			comd.Parameters.AddWithValue("prenom", dosr.Prenom);
			comd.Parameters.AddWithValue("sexe", dosr.Sexe);
			comd.Parameters.AddWithValue("dateNaiss", MainForm.toSqlDate(dosr.DateNaiss));
			
			
			comd.Parameters.AddWithValue("age", dosr.Age);
			comd.Parameters.AddWithValue("compAssure", dosr.CompAssure);
			comd.Parameters.AddWithValue("persResp", dosr.PersResp);
			comd.Parameters.AddWithValue("numeroPers", dosr.NumeroPers);
			comd.Parameters.AddWithValue("adres", dosr.Adres);
			comd.Parameters.AddWithValue("trtSuivi", dosr.TrtSuivi);
			comd.Parameters.AddWithValue("mail", dosr.Mail);
			comd.Parameters.AddWithValue("telephone", dosr.Telephone);
			comd.Parameters.AddWithValue("memo", dosr.Memo);
			
			
			
			dos = comd.ExecuteNonQuery();
			con.Close();
			return dos;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return dos;
		}

			
		public static List<DossiersTraitement> getAll()
		{
			List<DossiersTraitement> dos = new List<DossiersTraitement>();
		
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM DOSSIERS";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				while(readr.Read())
				{
					DossiersTraitement dosr = new DossiersTraitement();
					dosr.NoDossier = int.Parse(readr["noDossier"].ToString());
					dosr.NomPatient = readr["nomPatient"].ToString();
					dosr.Prenom = readr["prenom"].ToString();
					dosr.Sexe = readr["sexe"].ToString();
					dosr.DateNaiss = readr["dateNaiss"].ToString().Split(' ')[0];
					dosr.Age = int.Parse(readr["age"].ToString());
					dosr.CompAssure = readr["compAssure"].ToString();
					dosr.PersResp = readr["persResp"].ToString();
					dosr.NumeroPers = readr["numeroPers"].ToString();
					dosr.Adres = readr["adres"].ToString();
					dosr.TrtSuivi = readr["trtSuivi"].ToString();
					dosr.Mail = readr["mail"].ToString();
					dosr.Telephone = readr["telephone"].ToString();
					dosr.Memo = readr["memo"].ToString();
					dos.Add(dosr);
				}
				
			}
			readr.Close();
			con.Close();
			return dos;
		}
			
		public  DossiersTraitement getById(String noDossier)
		{
			DossiersTraitement pers = new DossiersTraitement();
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM Dossier where noDossier = @noDossier";
			comd.Parameters.AddWithValue("@noDossier", noDossier);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				if(readr.Read())
				{
					
					
					dosr.NoDossier = int.Parse(readr["noDossier"].ToString());
					dosr.NomPatient = readr["nomPatient"].ToString();
					dosr.Prenom = readr["prenom"].ToString();
					dosr.Sexe = readr["sexe"].ToString();
					dosr.DateNaiss = readr["dateNaiss"].ToString();
					dosr.Age = int.Parse(readr["age"].ToString());
					dosr.CompAssure = readr["compAssure"].ToString();
					dosr.PersResp = readr["persResp"].ToString();
					dosr.NumeroPers = readr["numeroPers"].ToString();
					dosr.Adres = readr["adres"].ToString();
					dosr.TrtSuivi = readr["trtSuivi"].ToString();
					dosr.Mail = readr["mail"].ToString();
					dosr.Telephone = readr["telephone"].ToString();
					dosr.Memo = readr["memo"].ToString();
				}
			}
			readr.Close();
			con.Close();
			return dosr;
		}
		
		public static int updateD (DossiersTraitement dosr){
			
			int d =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			
			try
			{
			//preparation de la requete
			
			String prepareRequest = "update dossiers set nomPatient=@nomPatient,prenom = @prenom,"+
				"sexe =@sexe,dateNaiss = @dateNaiss,age = @age,"+
				"compAssure=@compAssure,persResp=@persResp,numeroPers = @numeroPers,adres = @adres,"+
				"telephone = @telephone,mail = @mail,trtSuivi = @trtSuivi,memo = @memo where noDossier=@noDossier";
			
			//Recuperation de la connection
		
			
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			
			comd.Parameters.AddWithValue("noDossier", dosr.NoDossier);
			comd.Parameters.AddWithValue("nomPatient", dosr.NomPatient);
			comd.Parameters.AddWithValue("prenom", dosr.Prenom);
			comd.Parameters.AddWithValue("sexe", dosr.Sexe);
			comd.Parameters.AddWithValue("dateNaiss", MainForm.toSqlDate(dosr.DateNaiss));
			comd.Parameters.AddWithValue("age", dosr.Age);
			comd.Parameters.AddWithValue("compAssure", dosr.CompAssure);
			comd.Parameters.AddWithValue("persResp", dosr.PersResp);
			comd.Parameters.AddWithValue("numeroPers", dosr.NumeroPers);
			comd.Parameters.AddWithValue("adres", dosr.Adres);
			comd.Parameters.AddWithValue("trtSuivi", dosr.TrtSuivi);
			comd.Parameters.AddWithValue("mail", dosr.Mail);
			comd.Parameters.AddWithValue("telephone", dosr.Telephone);
			comd.Parameters.AddWithValue("memo", dosr.Memo);
			//MessageBox.Show("noDossier"+dosr.NoDossier);
			
			d = comd.ExecuteNonQuery();
			d=1;
			con.Close();
			return d;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return d;
				
		}
		
	
		
		
	}
}
