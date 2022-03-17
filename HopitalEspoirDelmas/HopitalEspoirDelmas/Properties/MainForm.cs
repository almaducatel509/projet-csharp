/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 07/10/2021
 * Time: 22:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using HopitalEspoirDelmas.utilisateursTr;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
namespace HopitalEspoirDelmas.Properties.MainForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static UtilisateursTraitement user = null;
		
		//MySqlConnection con = null;
		//MySqlCommand comd = null;
		MySqlDataReader readr = null;
		//MySqlDataAdapter adap = null;
		NewUtilisateurs nwu = new NewUtilisateurs();
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		public static string toSqlDate(string csdate){
			if(Regex.Match(csdate, "^([0-9]{2}[/-]){2}[0-9]{4}$").Success){
				csdate = Regex.Replace(csdate, "^([0-9]{2})[/-]([0-9]{2})[/-]([0-9]{4})$", "$3-$2-$1");
			}
			if(Regex.Match(csdate, "^[0-9]{4}([/-][0-9]{2}){2}$").Success){
				csdate = Regex.Replace(csdate, "^([0-9]{4})[/-]([0-9]{2})[/-]([0-9]{2})$", "$1-$2-$3");
			}
			return csdate;
		}
		
		public static string toCSDate(string sqldate){
			if(Regex.Match(sqldate, "^[0-9]{4}([/-][0-9]{2}){2}$").Success){
				sqldate = Regex.Replace(sqldate, "^([0-9]{4})[/-]([0-9]{2})[/-]([0-9]{2})$", "$3/$2/$1");
			}
			return sqldate;
		}
		
		void BtLoginClick(object sender, EventArgs e)
		{
			UtilisateursTraitement util = new UtilisateursTraitement();
			MySqlConnection con = DbHopitalEs.Connection();
			
			MySqlCommand comd = new MySqlCommand("SELECT * FROM Utilisateurs where Pseudo='"+txAdmin.Text+"' "+
			                                     "and motDPass = '"+txPassword.Text+"' ", con);

			
			MySqlDataReader readr = comd.ExecuteReader();
			if (readr.HasRows && readr.Read()) {
				
				user = util;
				
				user.IdEmp = int.Parse(readr["idEmp"].ToString());
				user.ModuleAcces = readr["moduleAcces"].ToString();
				user.Pseudo = readr["Pseudo"].ToString();
				user.MotDPass = readr["motDPass"].ToString();
				user.Etat = readr["Etat"].ToString();
				if(user.Etat.Equals("Actif")){
					menuPrincipal me = new menuPrincipal();
					me.Show();
					this.Hide();
				}
				else{
					MessageBox.Show("Connection echouer, votre etat est inactif");
				}
				
			}
					
			 else{
				MessageBox.Show("Connection echouer");
			}
			
			
		}
		
		protected override void OnLoad(EventArgs e)
        {
            base.OnLoad (e);

            this.Location = new System.Drawing.Point(
                System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2,
                System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2);

        }
	
		void Label1Click(object sender, EventArgs e)
		{

		}
		void SousPanelLoginPaint(object sender, PaintEventArgs e)
		{
	
		}
			
			
				}
			
		}
	    	
	    	
			
	    	
	    	
		
	

