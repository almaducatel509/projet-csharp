/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 06/10/2021
 * Time: 19:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.Traitement;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using System.Collections.Generic;
namespace HopitalEspoirDelmas.ServiceType
{
	/// <summary>
	/// Description of ViewService.
	/// </summary>
	public class ViewService
	{
		
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
		public ViewService()
		{
		}
		
		 TraitementSer trs = new TraitementSer();
		
		  public static int  EnregistrerService(TraitementSer trs){
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			int serv =0;
			
			try
			{
			//preparation de la requete
			String prepareRequest = "insert into services (nomService, prixConsultation, nomChefService,"+
				"Description, CouvrirParAssurance, Etat)"+ "values (@nomService,@prixConsultation,@nomChefService,"+
				"@Description,@CouvrirParAssurance,@Etat)";
			//Recuperation de la connection
			 con = DbHopitalEs.Connection();
			
			
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			//comd.Parameters.AddWithValue("IdService", null);
			comd.Parameters.AddWithValue("nomService", trs.NomService);
			comd.Parameters.AddWithValue("nomChefService", trs.NomChefService);
			comd.Parameters.AddWithValue("prixConsultation", trs.PrixConsultation);
			comd.Parameters.AddWithValue("Etat", trs.etat);
			comd.Parameters.AddWithValue("Description", trs.description);
			comd.Parameters.AddWithValue("CouvrirParAssurance", trs.couvrirParAssurance);
			
			serv = comd.ExecuteNonQuery();
			serv =1;
			con.Close();
			return serv;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
			
			return serv;
		}
			
		public static List<TraitementSer> getAll()
		{
			List<TraitementSer> servs = new List<TraitementSer>();
		
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM SERVICES";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				while(readr.Read())
				{
					TraitementSer trs = new TraitementSer();
					trs.IdService = int.Parse(readr["idService"].ToString());
					trs.NomService = readr["nomService"].ToString();
					trs.PrixConsultation = Double.Parse(readr["prixConsultation"].ToString());
					trs.NomChefService = readr["nomChefService"].ToString();
					trs.etat = readr["Etat"].ToString();
					trs.description = readr["Description"].ToString();
					trs.couvrirParAssurance = readr["CouvrirParAssurance"].ToString();
					servs.Add(trs);
				}
			}
			readr.Close();
			con.Close();
			return servs;
		}
		
		public  TraitementSer getById(String idService)
		{
			//MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			//TraitementSer trs = new TraitementSer();
			String prepareRequest = "SELECT * FROM SERVICES where idService = @idService";
			comd.Parameters.AddWithValue("@idService", idService);
			//MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				if(readr.Read())
				{
					
					trs.IdService = int.Parse(readr["idService"].ToString());
					trs.NomService = readr["nomService"].ToString();
					trs.PrixConsultation = Double.Parse(readr["prixConsultation"].ToString());
					trs.etat = readr["Etat"].ToString();
					trs.description = readr["Description"].ToString();
					trs.couvrirParAssurance = readr["CouvrirParAssurance"].ToString();
					trs.NomChefService = readr["nomChefService"].ToString();
					
				}
			}
			readr.Close();
			con.Close();
			return trs;
		}
		
		public static int updateSer (TraitementSer trs){
			
			int serv =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			String prepareRequest = "update services set nomService=@nomService, prixConsultation = @prixConsultation,"+
				"nomChefService = @nomChefService, Description = @Description, CouvrirParAssurance = @CouvrirParAssurance,"+
				"Etat = @Etat  where idService=@idService";
			
			
			//Recuperation de la connection
			
			
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			comd.Parameters.AddWithValue("nomService", trs.NomService);
			comd.Parameters.AddWithValue("nomChefService", trs.NomChefService);
			comd.Parameters.AddWithValue("prixConsultation", trs.PrixConsultation);
			comd.Parameters.AddWithValue("Etat", trs.etat);
			comd.Parameters.AddWithValue("Description", trs.description);
			comd.Parameters.AddWithValue("CouvrirParAssurance", trs.couvrirParAssurance);
			comd.Parameters.AddWithValue("idService", trs.IdService); 
			//MessageBox.Show("idService"+trs.IdService);
			
			serv = comd.ExecuteNonQuery();
			// MessageBox.Show("idService"+trs.IdService+" / "+serv);
			serv =1;
			con.Close();
			return serv;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return serv;
		}
		
		
		

		public  int DelService (String idService)
		{
			int n = 0;
			MySqlConnection con = DbHopitalEs.Connection();
			
			String prepareRequest = "Delete FROM services where idService = @idService";
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			
			comd.Parameters.AddWithValue("@idService", idService);
			n = comd.ExecuteNonQuery();
			
			con.Close();
			return n;
			
		}
	}
	
}

	



