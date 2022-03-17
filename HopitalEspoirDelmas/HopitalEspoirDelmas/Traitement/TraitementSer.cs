/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 06/10/2021
 * Time: 20:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HopitalEspoirDelmas.baseHopital;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace HopitalEspoirDelmas.Traitement
{
	/// <summary>
	/// Description of TraitementSer.
	/// </summary>
	public class TraitementSer
	{
		private int idService;
		private String nomService;
		private String nomChefService;
		private double prixConsultation;
		private String Etat;
		private String Description;
		private String CouvrirParAssurance;
		
		public TraitementSer()
		{
		}
		
		
		
		
		
		public TraitementSer(int idService,String nomService,String nomChefService,double prixConsultation,String Etat,String Description,String CouvrirParAssurance){
			this.idService = idService;
			this.nomService = nomService;
			this.nomChefService = nomChefService;
			this.prixConsultation = prixConsultation;
			this.Etat = Etat;
			this.Description = Description;
			this.CouvrirParAssurance = CouvrirParAssurance;
		}
		
		public int IdService{
			get;
			set;
		}
		
		public String NomService{
			get;
			set;
		}
		
		public String NomChefService{
			get;
			set;
		}
		
		public double PrixConsultation{
			get;
			set;
		}
		
		public String etat{
			get;
			set;
		}
		
		public String description{
			get;
			set;
		}
		
		public String couvrirParAssurance{
			get;
			set;
		}
		
		public static string[] getNom(){
			List<string> ns = new List<string>();
			MySqlConnection con = DbHopitalEs.Connection();
			String prepareRequest = "select nomService FROM services";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			while(readr.Read())
			{
				ns.Add(readr["nomService"].ToString());
			}
			
			readr.Close();
			con.Close();
			return ns.ToArray();
		}
	}
}
