/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 05/10/2021
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
namespace HopitalEspoirDelmas.container
{
	
	
	
	public class ConsultationTraitement
	{
		private int idcons;
		private int noDossPat;
		private String consultationServices;
		private String paiementConsAss;
		private String motifCons;
		private String necHospitalisation;
		private String hospAss;
		private String idChambre;
		private int dureeHosp;
		private String medecin;
		private string dateConsul;
		private String idContrats;
		private string dateHospitalisation;
		
		
		
		public ConsultationTraitement(){
			
		}
		
		public ConsultationTraitement(int idcons, int noDossPat, String consultationServices, String paiementConsAss,
		                            String motifCons, String necHospitalisation,String hospAss, String idChambre,int dureeHosp,
		                          String medecin,DateTime dateConsul, DateTime dateHospitalisation){
			this.idcons = idcons;
			this.noDossPat= noDossPat;
			this.consultationServices = consultationServices;
			this.paiementConsAss = paiementConsAss;
			this.motifCons = motifCons;
			this.necHospitalisation =necHospitalisation;
			this.hospAss = hospAss;
			this.idChambre = idChambre;
			this.dureeHosp = dureeHosp;
			this.medecin = medecin;
			this.dateConsul = dateConsul.ToString();
			this.idContrats = idContrats;
			this.dateHospitalisation = dateHospitalisation.ToString();
		}
		public int Idcons{
			get;
			set;
		}
		public int NoDosspat{
			get;
			set;
		}
		public String ConsultationServices{
			get;
			set;
		}
		public String PaiementConsAss{
			get;
			set;
		}
		public String MotifCons{
			get;
			set;
		}
		public String NecHospitalisation{
			get;
			set;
		}
		public String HospAss{
			get;
			set;
		}
		public String IdChambre{
			get;
			set;
		}
		public int DureeHosp{
			get;
			set;
		}
		public String Medecin{
			get;
			set;
		}
		public string DateConsul{
			get;
			set;
		}
		
		public string DateHospitalisation{
			get;
			set;
		}
		
		
	}
}
