/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 05/10/2021
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HopitalEspoirDelmas.baseHopital;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
namespace HopitalEspoirDelmas.container
{
	/// <summary>
	/// Description of PersonelsTraitement.
	/// </summary>
	public class PersonelsTraitement
	{
		public PersonelsTraitement()
		{
		}
		
		private int idPersonel;
		private String nom;
		private String prenom;
		private String sexe;
		private String adresse;
		private String domaineEtude;
		private String niveauEtude;
		private String specialisation;
		private int nombreAnneeExp;
		private String telephone;
		private String dateNaissance;
		private String servicesAffectes;
		private String email;
		private String nifCin;
		private String etat;
		private String categorie;
		
		public PersonelsTraitement(int idPersonel, String nom, String prenom, String sexe, String adresse,
		                           String domaineEtude,String niveauEtude, String specialisation, int nombreAnneeExp,
		                           String telephone, String dateNaissance, String servicesAffectes,String email,
		                           String nifCin, String etat, String categorie){
			
			
			this.idPersonel = idPersonel;
			this.nom = nom;
			this.prenom = prenom;
			this.sexe = sexe;
			this.adresse = adresse;
			this.domaineEtude = domaineEtude;
			this.niveauEtude = niveauEtude;
			this.specialisation = specialisation;
			this.nombreAnneeExp = nombreAnneeExp;
			this.telephone = telephone;
			this.dateNaissance = dateNaissance;
			this.servicesAffectes = servicesAffectes;
			this.email = email;
			this.nifCin = nifCin;
			this.etat = etat;
			this.categorie = categorie;
		}
		
		
		public int IdPersonel{
			get;
			set;
		}
		public String Nom{
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
		public String Adresse{
			get;
			set;
		}
		public String DomaineEtude{
			get;
			set;
		}
		public String NiveauEtude{
			get;
			set;
		}
		public String Specialisation{
			get;
			set;
		}
		public int NombreAnneeExp{
			get;
			set;
		}
		public String Telephone{
			get;
			set;
		}
		
		public String DateNaissance{
			get;
			set;
		}
		public String ServicesAffectes{
			get;
			set;
		}
		public String Email{
			get;
			set;
		}
		public String NifCin{
			get;
			set;
		}
		public String Etat{
			get;
			set;
		}
		public String Tlf{
			get;
			set;
		}
		public String Categorie{
			get;
			set;
		}
		
		
		
		
	}
}
