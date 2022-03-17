/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 05/10/2021
 * Time: 14:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using HopitalEspoirDelmas.baseHopital;
using MySql.Data.MySqlClient;
namespace HopitalEspoirDelmas.container
{
	/// Description of ContratTraitement.
	

	//Id contrat (automatique),
//Nom compagnie d’assurance, Sigle compagnie,
//Nom Directeur, adresse, téléphone, email, pourcentage paiement consultation assuré, pourcentage paiement
//chambre assuré, Pourcentage paiement hospitalisation assuré, Etat(E : En cours, R : Résilié).
	
	public class ContratTraitement
	{
		private int idContrats;
		private String nomCompAs;
		private String sigleCompAs;
		private String nomDir;
		private String adresse;
		private String tlf; 
		private String email;
		private double pourcentageCons;
		private double pourcentageChambre;
		private double pourcentageHosp;
		private String etat;
		
		public ContratTraitement(){
			
		}
		
		public ContratTraitement(int idContrats,String nomCompAs, String sigleCompAs,
		                         String nomDir, String adresse, String tlf, String email, 
		                        double pourcentageCons, double pourcentageChambre,
		                        double pourcentageHosp, String etat){
			this.idContrats = idContrats;
			this.nomCompAs = nomCompAs;
			this.sigleCompAs = sigleCompAs;
			this.nomDir = nomDir;
			this.adresse = adresse;
			this.tlf = tlf;
			this.email = email;
			this.pourcentageCons = pourcentageCons;
			this.pourcentageChambre = pourcentageChambre;
			this.pourcentageHosp = pourcentageHosp;
			this.etat = etat;
		} 
		
		public int IdContrats{
			get;
			set;
		}
		public String NomCompAs{
			get;
			set;
		}
		public String SigleCompAs{
			get;
			set;
		}
		public String NomDir{
			get;
			set;
		}
		public String Adresse{
			get;
			set;
		}
		public String Tlf{
			get;
			set;
		}
		public String Email{
			get;
			set;
		}
		public double PourcentageCons{
			get;
			set;
		}
		public double PourcentageChambre{
			get;
			set;
		}
		public double PourcentageHosp{
			get;
			set;
		}
		
		public String Etat{
			get;
			set;
		}
		
		public static string[] getIdC(){
			List<string> contr = new List<string>();
			MySqlConnection con = DbHopitalEs.Connection();
			String prepareRequest = "select idContrats FROM contrats";
			
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			while(readr.Read())
			{
				contr.Add(readr["idContrats"].ToString());
			}
			
			readr.Close();
			con.Close();
			return contr.ToArray();
		}
		
		public static string[] getNomComp(){
			List<string> contr = new List<string>();
			MySqlConnection con = DbHopitalEs.Connection();
			String prepareRequest = "select nomCompAs FROM contrats";
			
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			while(readr.Read())
			{
				contr.Add(readr["nomCompAs"].ToString());
			}
			
			readr.Close();
			con.Close();
			return contr.ToArray();
		}
	}
}
