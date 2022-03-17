/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 05/10/2021
 * Time: 17:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using HopitalEspoirDelmas.ServiceType;
using HopitalEspoirDelmas.container;
using System.Windows.Forms;
using HopitalEspoirDelmas.Traitement;
using HopitalEspoirDelmas.contratTr;

namespace HopitalEspoirDelmas.baseHopital
{
	/// <summary>
	/// Description of DbHopitalEs.
	/// </summary>
	public class DbHopitalEs
	{
		TraitementSer trs = new TraitementSer();
		ChambreTraitement chb = new ChambreTraitement();
		static MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
     	MySqlDataAdapter adap = null;
		
		public DbHopitalEs()
		{
		}
		
		public static MySqlConnection Connection(){
			
			
			con = new MySqlConnection("Server = localhost;Database = hopitalespoir; Uid=root;");
			con.Open();
			return con;
		}
		
		public static bool characterChaine(string str1, string str2){
			
			if(str1.ToUpper().Equals(str2.ToUpper()))
			{
				return true;
				
			}
			
			return false;
		}
		
		//Verification pour la radioButton
		
		public static bool boutonRadio(bool btAss1, bool btAss2, string name)
		{
			if(!(btAss1 || btAss2))
			{
				
				return false;
				
			}
			
			return true;
		}
		

		
		public static bool stringOnly(string stl, string name){
			if(!Regex.IsMatch(stl, @"[^\d]+"))
			{
				MessageBox.Show("Ce champ doit contenir que des lettres", name);
				return false;
				
			}
		
			return true;
		}
		
		public static bool numberOnly(string stl, string name){
			if(stl == null || !Regex.IsMatch(stl, @"^[0-9]+(\.[0-9]{1,2})?$"))
			{
				MessageBox.Show("Ce champ doit contenir que des chiffres", name);
				return false;
				
				
			}
			
			return true;
		}
		
		public static bool serviceExiste(string idService, string name){
			if(idService != null)
			{
				foreach(TraitementSer trs in ViewService.getAll())
				{
					if(!(characterChaine(idService, trs.IdService.ToString())) && (characterChaine(name, trs.NomService)))
					{
						MessageBox.Show("Ce service existe deja!", name);
						return false;
					}
					
				}
			}
			
			else
			{
				foreach(TraitementSer trs in ViewService.getAll())
				{
					if(characterChaine(trs.NomService, name))
					{
						MessageBox.Show("Ce service existe deja!", name);
						return false;
					}
				}
			}
			
			return true;
		}
		
		
			
}
}
