/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 05/10/2021
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.ChambreTr;
using MySql.Data.MySqlClient;
namespace HopitalEspoirDelmas.container
{
	/// <summary>
	/// Description of ChambreTraitement.
	/// </summary>
	public class ChambreTraitement
	{
		private int idChambre;
		private String nomChambre;
		private String typeChambre;
		private String couvrirParAssurance;
		private double prixLocationParJour;
		private String etat;
		private String constituantChambre;
		private String description;
		
		public ChambreTraitement()
		{
		}
		
		public ChambreTraitement(int idChambre, String nomChambre, String typeChambre, String couvrirParAssurance, 
		                         double prixLocationParJour, String etat, String constituantChambre, String description){
			
			this.idChambre = idChambre;
			this.nomChambre = nomChambre;
			this.typeChambre = typeChambre;
			this.couvrirParAssurance = couvrirParAssurance;
			this.prixLocationParJour = prixLocationParJour;
			this.etat = etat;
			this.constituantChambre = constituantChambre;
			this.description = description;
			
			
			
		}
		
		public int IdChambre{
			get;
			set;
		}
		
		public String NomChambre{
			get;
			set;
		}
		
		public String TypeChambre{
			get;
			set;
		}
		
		public String CouvrirParAssurance{
			get;
			set;
		}
		
		public double PrixLocationParJour{
			get;
			set;
		}
		
		public String Etat{
			get;
			set;
		}
		
		public String ConstituantChambre{
			get;
			set;
		}
		
		public String Description{
			get;
			set;
		}
		
		public static string[] getId(){
			List<string> r = new List<string>();
			MySqlConnection con = DbHopitalEs.Connection();
			String prepareRequest = "select idChambre FROM chambre";
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			while(readr.Read())
			{
				r.Add(readr["idChambre"].ToString());
			}
			
			readr.Close();
			con.Close();
			return r.ToArray();
		}
	}
}
