/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 05/10/2021
 * Time: 14:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using HopitalEspoirDelmas.baseHopital;
using MySql.Data.MySqlClient;
namespace HopitalEspoirDelmas.container
	
{
	/// Description of DossiersTraitement.
	
	//NoDossier (automatique),
//Nom patient, Prénom, Sexe, Date Naissance, Age, Compagnie assuré, Personne responsable, numéro personne
//responsable, Adresse, téléphone, email, traitements suivis (liste des traitements suivis par un patient), Memo.
//	
	public class DossiersTraitement
	{
		
		
		private int noDossier;
		private String nomPatient;
		private String prenom;
		private String sexe;
		private  String dateNaiss;
		private int age;
		private String compAssure;
		private String persResp;
		private String numeroPers;
		private String adres;
		private String telephone;
		private String mail;
		private String trtSuivi;
		private String memo;
		
		public DossiersTraitement(){
			
		}
		
		public DossiersTraitement(int noDossier, String nomPatient, String prenom, String sexe,
		                         String dateNaiss, int age, String compAssure, String persResp,
		                        String numeroPers, String adres, String telephone, String mail,
		                       String trtSuivi, String memo){
			this.noDossier = noDossier;
			this.nomPatient = nomPatient;
			this.prenom = prenom;
			this.sexe = sexe;
			this.dateNaiss = dateNaiss;
			this.age =age;
			this.compAssure = compAssure;
			this.persResp = persResp;
			this.numeroPers = numeroPers;
			this.adres = adres;
			this.telephone = telephone;
			this.mail = mail;
			this.trtSuivi = trtSuivi;
			this.memo =memo;
		}
		public int NoDossier{
			get;
			set;
		}
		public String NomPatient{
			get;
			set;
		}
		public String Prenom{
			get;
			set;
		}
		public String Sexe{
			get;
			set;
		}
		public String DateNaiss{
			get;
			set;
		}
		public int Age{
			get;
			set;
		}
		public String CompAssure{
			get;
			set;
		}
		public String PersResp{
			get;
			set;
		}
		public String NumeroPers{
			get;
			set;
		}
		public String Adres{
			get;
			set;
		}
		public String Telephone{
			get;
			set;
		}
		public String Mail{
			get;
			set;
		}
		public String TrtSuivi{
			get;
			set;
		}
		public String Memo{
			get;
			set;
		}
		
		
		public static string[] getId(){
			List<string> dos = new List<string>();
			MySqlConnection con = DbHopitalEs.Connection();
			String prepareRequest = "select noDossier FROM dossiers";
			
			MySqlCommand comd = new MySqlCommand(prepareRequest, con);
			MySqlDataReader readr = comd.ExecuteReader();
			
			while(readr.Read())
			{
				dos.Add(readr["noDossier"].ToString());
			}
			
			readr.Close();
			con.Close();
			return dos.ToArray();
		}
		
		
		public static bool EstSurAssurance(int dosr){
			MySqlConnection con = DbHopitalEs.Connection();
			bool reponse = true;
			String prq = "select compAssure from  dossiers where noDossier=@dosr";
			MySqlCommand comd = new MySqlCommand(prq, con);
			comd.Parameters.AddWithValue("dosr", dosr);
			MySqlDataReader readr = comd.ExecuteReader();
			
			readr.Read();
			if(readr["compAssure"].ToString().Equals("Aucune")){
				reponse = false;
			}
			else{
				prq = "select etat from contrats where nomCompAs=@nca";
				comd = new MySqlCommand(prq, con);
				comd.Parameters.AddWithValue("nca", readr["compAssure"]);
				readr.Close();
				readr = comd.ExecuteReader();
				readr.Read();
				if(readr.HasRows){
					if(readr["etat"].ToString().Equals("Resilie")){
						reponse = false;
					}
					readr.Close();
				}
				else{
					reponse = false;
				}
			}
//			con.Close();
			return reponse;
		}
		
	}
}
