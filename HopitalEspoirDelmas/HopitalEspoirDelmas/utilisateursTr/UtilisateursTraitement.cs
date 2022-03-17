/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 05/10/2021
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System; 
namespace HopitalEspoirDelmas.container
{
	
	
	public class UtilisateursTraitement
	{
		private int idEmp;
		private String pseudo;
		private String motDPass;
		private String etat;
		private String moduleAcces;
		
		public UtilisateursTraitement(){
			
		}
		
		public UtilisateursTraitement(int idEmp, String pseudo, String motDPass, String etat, String moduleAcces){
			this.idEmp = idEmp;
			this.pseudo = pseudo;
			this.motDPass = motDPass;
			this.etat =etat;
			this.moduleAcces = moduleAcces;
		}
		public int IdEmp{
			get;
			set;
		}
		public String Pseudo{
			get;
			set;
		}
		public String MotDPass{
			get;
			set;
		}
		public String Etat{
			get;
			set;
		}
		public String ModuleAcces{
			get;
			set;
		}
		
		
	}
}
