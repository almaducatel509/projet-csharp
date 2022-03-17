/*
 * Created by SharpDevelop.
 * User: Fl3m
 * Date: 14-Oct-21
 * Time: 2:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using System.Collections.Generic;
using System.Windows.Forms;
namespace HopitalEspoirDelmas.consultationTr
{
	/// Description of ViewConsultation.
	
	public class ViewConsultation
	{
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
		
		public ViewConsultation()
		{
		}
		
		ConsultationTraitement cons = new ConsultationTraitement();
		public static int EnregistrerConsultation(ConsultationTraitement cons){
			int consl = 0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			String prepareRequest = "insert into consultation (consultationServices, " +
				"idChambre, motifCons, dureeHosp, dateConsul, medecin,noDossPat,"+
				"paiementConsAss, necHospitalisation,hospAss, dateHospitalisation)"+ " values (@consultationServices,"+
				"@idChambre,@motifCons,@dureeHosp,@dateConsul,@medecin,@noDossPat,@paiementConsAss," +
				" @necHospitalisation,@hospAss, @dateHospitalisation)";
			//Recuperation de la connection
			 con = DbHopitalEs.Connection();
			
			//con = new MySqlConnection();
			//comd = new MySqlCommand(prepareRequest, con);
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			//comd.Parameters.AddWithValue("IdCons", cons.Idcons);
			comd.Parameters.AddWithValue("noDossPat", cons.NoDosspat);
			comd.Parameters.AddWithValue("consultationServices", cons.ConsultationServices);
			comd.Parameters.AddWithValue("motifCons", cons.MotifCons);
			comd.Parameters.AddWithValue("paiementConsAss", cons.PaiementConsAss);
			comd.Parameters.AddWithValue("dureeHosp", cons.DureeHosp);
			comd.Parameters.AddWithValue("medecin", cons.Medecin);
			comd.Parameters.AddWithValue("necHospitalisation", cons.NecHospitalisation);
			comd.Parameters.AddWithValue("hospAss", cons.HospAss);
			comd.Parameters.AddWithValue("idChambre", cons.IdChambre);
			comd.Parameters.AddWithValue("dateConsul", cons.DateConsul);
			comd.Parameters.AddWithValue("dateHospitalisation", cons.DateHospitalisation);
			
			
			consl = comd.ExecuteNonQuery();
			consl =1;
			con.Close();
			
			return consl;
			
			
		}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
			
			return consl;
	}
		
		public static List<ConsultationTraitement> getAll()
		{
				List<ConsultationTraitement> consl = new List<ConsultationTraitement>();
		
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			String prepareRequest = "SELECT * FROM CONSULTATION";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			
			if(readr.HasRows)
			{
				while(readr.Read())
				{
					ConsultationTraitement cons = new ConsultationTraitement();
					cons.Idcons = int.Parse(readr["idCons"].ToString());
					cons.NoDosspat = int.Parse(readr["noDossPat"].ToString());
					cons.ConsultationServices = readr["consultationServices"].ToString();
					cons.DureeHosp = int.Parse(readr["dureeHosp"].ToString());
					cons.MotifCons = readr["motifCons"].ToString();
					cons.HospAss = readr["hospAss"].ToString();
					cons.DateConsul = readr["dateConsul"].ToString().Split(' ')[0];
					cons.Medecin = readr["medecin"].ToString();
					cons.IdChambre = readr["idChambre"].ToString();
					cons.PaiementConsAss = readr["paiementConsAss"].ToString();
					cons.NecHospitalisation = readr["necHospitalisation"].ToString();
					cons.DateHospitalisation = readr["dateHospitalisation"].ToString().Split(' ')[0];
	
					consl.Add(cons);
				}
			}
			readr.Close();
			con.Close();
			return consl;
		}
		
		public  ConsultationTraitement getById(String idCons)
		{
			MySqlConnection con = DbHopitalEs.Connection();
			con.Open();
			ConsultationTraitement cons = new ConsultationTraitement();
			String prepareRequest = "SELECT * FROM consultation where idCons = @idCons";
			comd.Parameters.AddWithValue("@idCons", idCons);
			MySqlDataReader readr = comd.ExecuteReader();
			
			if(readr.HasRows)
			{
				if(readr.Read())
				{
					
					cons.Idcons = int.Parse(readr["idCons"].ToString());
					cons.NoDosspat = int.Parse(readr["noDossPat"].ToString());
					cons.ConsultationServices = readr["consultationServices"].ToString();
					cons.DureeHosp = int.Parse(readr["dureeHosp"].ToString());
					cons.MotifCons = readr["motifCons"].ToString();
					cons.HospAss = readr["hospAss"].ToString();
					cons.DateConsul = readr["dateConsul"].ToString();
					cons.Medecin = readr["medecin"].ToString();
					cons.IdChambre = readr["idChambre"].ToString();
					cons.PaiementConsAss = readr["paiementConsAss"].ToString();
					cons.NecHospitalisation = readr["necHospitalisation"].ToString();
					cons.DateHospitalisation = readr["dateHospitalisation"].ToString();
				}
			}
			readr.Close();
			con.Close();
			return cons;
		}
		
		public static int updateCons (ConsultationTraitement cons){
			
			int c =0;
			MySqlConnection con = DbHopitalEs.Connection();
			//con.Open();
			
			try
			{
			//preparation de la requete
			
			String prepareRequest = "update consultation set consultationServices = @consultationServices," +
				"motifCons = @motifCons,dureeHosp =@dureeHosp,noDossPat=@noDossPat,hospAss=@hospAss," +
				"dateConsul = @dateConsul,medecin = @medecin, dateHospitalisation = @dateHospitalisation,"+
				"paiementConsAss = @paiementConsAss, necHospitalisation = @necHospitalisation where idCons=@idCons";
			//Recuperation de la connection
			
					
			//comd = new MySqlCommand(prepareRequest, con);
			 MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			comd.Parameters.AddWithValue("idCons", cons.Idcons);
			comd.Parameters.AddWithValue("noDossPat", cons.NoDosspat);
			comd.Parameters.AddWithValue("consultationServices", cons.ConsultationServices);
			comd.Parameters.AddWithValue("paiementConsAss", cons.PaiementConsAss);
			comd.Parameters.AddWithValue("motifCons", cons.MotifCons);
			comd.Parameters.AddWithValue("necHospitalisation", cons.NecHospitalisation);
			comd.Parameters.AddWithValue("hospAss", cons.HospAss);
			comd.Parameters.AddWithValue("idChambre", cons.IdChambre);
			comd.Parameters.AddWithValue("dureeHosp", cons.DureeHosp);
			comd.Parameters.AddWithValue("medecin", cons.Medecin);
			comd.Parameters.AddWithValue("dateConsul", cons.DateConsul);
			comd.Parameters.AddWithValue("dateHospitalisation", cons.DateHospitalisation);
			
			
			
			c = comd.ExecuteNonQuery();
			con.Close();
			c=1;
			return c;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		
			return c;
		}
		
	}
}