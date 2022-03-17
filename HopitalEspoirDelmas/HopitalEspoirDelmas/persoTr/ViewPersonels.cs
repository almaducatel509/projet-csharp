/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 11/10/2021
 * Time: 01:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using System.Windows.Forms;
using HopitalEspoirDelmas.container;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace HopitalEspoirDelmas.persoTr
{
	/// <summary>
	/// Description of ViewPersonels.
	/// </summary>
	public class ViewPersonels
	{
		public ViewPersonels()
		{
		}
		
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
			
			PersonelsTraitement pers = new PersonelsTraitement();
			public static int EnregistrerPersonel(PersonelsTraitement pers){
			int per =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			String prepareRequest = "insert into personels (nom, prenom,"+
				"adresse, sexe, categorie, nifCin, nombreAnneeExp, domaineEtude, niveauEtude,"+
			"specialisation, dateNaissance, servicesAffectes, email, telephone, etat)"+"values (@nom, @prenom,"+
				"@adresse, @sexe, @categorie, @nifCin, @nombreAnneeExp, @domaineEtude, @niveauEtude, @specialisation,"+
				"@dateNaissance, @servicesAffectes, @email, @telephone, @etat)";
			//Recuperation de la connection
			 con = DbHopitalEs.Connection();
			
			
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			//comd.Parameters.AddWithValue("idPersonel", null);
			comd.Parameters.AddWithValue("nom", pers.Nom);
			comd.Parameters.AddWithValue("prenom", pers.Prenom);
			comd.Parameters.AddWithValue("adresse", pers.Adresse);
			comd.Parameters.AddWithValue("sexe", pers.Sexe);
			comd.Parameters.AddWithValue("categorie", pers.Categorie);
			comd.Parameters.AddWithValue("nifCin", pers.NifCin);
			comd.Parameters.AddWithValue("nombreAnneeExp", pers.NombreAnneeExp);
			comd.Parameters.AddWithValue("domaineEtude", pers.DomaineEtude);
			comd.Parameters.AddWithValue("niveauEtude", pers.NiveauEtude);
			comd.Parameters.AddWithValue("specialisation", pers.Specialisation);
			comd.Parameters.AddWithValue("dateNaissance", pers.DateNaissance);
			comd.Parameters.AddWithValue("servicesAffectes", pers.ServicesAffectes);
			comd.Parameters.AddWithValue("email", pers.Email);
			comd.Parameters.AddWithValue("telephone", pers.Telephone);
			comd.Parameters.AddWithValue("etat", pers.Etat);
			
			
			per = comd.ExecuteNonQuery();
			con.Close();
			return per;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return per;
		}

			
		public static List<PersonelsTraitement> getAll()
		{
			List<PersonelsTraitement> per = new List<PersonelsTraitement>();
		
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM PERSONELS";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				while(readr.Read())
				{
					PersonelsTraitement pers = new PersonelsTraitement();
					pers.IdPersonel = int.Parse(readr["idPersonel"].ToString());
					pers.Nom = readr["nom"].ToString();
					pers.Prenom = readr["prenom"].ToString();
					pers.Adresse = readr["adresse"].ToString();
					pers.Sexe = readr["sexe"].ToString();
					pers.Categorie = readr["categorie"].ToString();
					pers.NifCin = readr["nifCin"].ToString();
					pers.NombreAnneeExp = int.Parse(readr["nombreAnneeExp"].ToString());
					pers.DomaineEtude = readr["domaineEtude"].ToString();
					pers.NiveauEtude = readr["niveauEtude"].ToString();
					pers.Specialisation = readr["specialisation"].ToString();
					pers.DateNaissance = readr["dateNaissance"].ToString();
					pers.ServicesAffectes = readr["servicesAffectes"].ToString();
					pers.Email = readr["email"].ToString();
					pers.Telephone = readr["telephone"].ToString();
					pers.Etat = readr["etat"].ToString();
					per.Add(pers);
				}
				
			}
			readr.Close();
			con.Close();
			return per;
		}
			
		public  PersonelsTraitement getById(String idPersonel)
		{
			PersonelsTraitement pers = new PersonelsTraitement();
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM personels where idPersonel = @idPersonel";
			comd.Parameters.AddWithValue("@idPersonel", idPersonel);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				if(readr.Read())
				{
					
					pers.IdPersonel = int.Parse(readr["idPersonel"].ToString());
					pers.Nom = readr["nom"].ToString();
					pers.Prenom = readr["prenom "].ToString();
					pers.Adresse = readr["adresse"].ToString();
					pers.Sexe = readr["sexe"].ToString();
					pers.Categorie = readr["categorie"].ToString();
					pers.NifCin = readr["nifCin"].ToString();
					pers.NombreAnneeExp = int.Parse(readr["nombreAnneeExp"].ToString());
					pers.DomaineEtude = readr["domaineEtude"].ToString();
					pers.NiveauEtude = readr["niveauEtude"].ToString();
					pers.Specialisation = readr["specialisation"].ToString();
					pers.DateNaissance = readr["dateNaissance"].ToString();
					pers.ServicesAffectes = readr["servicesAffectes"].ToString();
					pers.Email = readr["email"].ToString();
					pers.Telephone = readr["telephone"].ToString();
					pers.Etat = readr["etat"].ToString();
					
				}
			}
			readr.Close();
			con.Close();
			return pers;
		}
		
		public static int updateP (PersonelsTraitement pers){
			
			int per =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			String prepareRequest = "update personels set nom=@nom, prenom = @prenom,"+
				"adresse = @adresse, sexe = @sexe, categorie = @categorie, nifCin = @nifCin," +
				"nombreAnneeExp = @nombreAnneeExp," + "domaineEtude = @domaineEtude, niveauEtude = @niveauEtude,"+
				"specialisation = @specialisation, dateNaissance = @dateNaissance, " +
				"servicesAffectes = @servicesAffectes, email = @email, telephone = @telephone,"+
				"etat = @etat  where idPersonel=@idPersonel";
			//Recuperation de la connection
			
			
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			
			comd.Parameters.AddWithValue("nom", pers.Nom);
			comd.Parameters.AddWithValue("prenom", pers.Prenom);
			comd.Parameters.AddWithValue("adresse", pers.Adresse);
			comd.Parameters.AddWithValue("sexe", pers.Sexe);
			comd.Parameters.AddWithValue("categorie", pers.Categorie);
			comd.Parameters.AddWithValue("nifCin", pers.NifCin);
			comd.Parameters.AddWithValue("nombreAnneeExp", pers.NombreAnneeExp);
			comd.Parameters.AddWithValue("domaineEtude", pers.DomaineEtude);
			comd.Parameters.AddWithValue("niveauEtude", pers.NiveauEtude);
			comd.Parameters.AddWithValue("specialisation", pers.Specialisation);
			comd.Parameters.AddWithValue("dateNaissance", pers.DateNaissance);
			comd.Parameters.AddWithValue("servicesAffectes", pers.ServicesAffectes);
			comd.Parameters.AddWithValue("email", pers.Email);
			comd.Parameters.AddWithValue("telephone", pers.Telephone);
			comd.Parameters.AddWithValue("etat", pers.Etat);
			comd.Parameters.AddWithValue("idPersonel", pers.IdPersonel);
			
			
			per = comd.ExecuteNonQuery();
			
			
					
				per = 1;
				con.Close();
				return per;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return per;
		}
		
		
		public  PersonelsTraitement getBySup (String idPersonel)
		{
			ViewPersonels vwc = new ViewPersonels();
			PersonelsTraitement pers = new PersonelsTraitement();
			NewPersonel nwc= new NewPersonel();
			MySqlConnection con = DbHopitalEs.Connection();
			
			String prepareRequest = "Delete FROM personels where idPersonel = @idPersonel";
			comd.Parameters.AddWithValue("@idPersonel", idPersonel);
			MySqlDataReader readr = comd.ExecuteReader();
			if(readr.HasRows)
			{
				if(readr.Read()){
					pers.IdPersonel = int.Parse(readr["idPersonel"].ToString());
					pers.Nom = readr["Nom"].ToString();
					pers.NombreAnneeExp = int.Parse(readr["nombreAnneeExp"].ToString());
					pers.Adresse = readr["adresse"].ToString();
					pers.Categorie = readr["categorie"].ToString();
					pers.DateNaissance = readr["DateNaissance"].ToString();
					pers.DomaineEtude = readr["DomaineEtude"].ToString();
					pers.NifCin = readr["NifCin"].ToString();
					pers.Etat = readr["Etat"].ToString();
					pers.NiveauEtude = readr["NiveauEtude"].ToString();
					pers.Prenom = readr["Prenom"].ToString();
				}
			}
			
			readr.Close();
			con.Close();
			return pers;
			
	}
		
		public  int DelPersonel (String idPersonel)
		{
			int n = 0;
			MySqlConnection con = DbHopitalEs.Connection();
			
			String prepareRequest = "Delete FROM personels where idPersonel = @idPersonel";
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			
			comd.Parameters.AddWithValue("@idPersonel", idPersonel);
			n = comd.ExecuteNonQuery();
			
			con.Close();
			return n;
			
		}
			
		
}
	
}
	
	

