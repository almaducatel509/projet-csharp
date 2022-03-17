/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 31/10/2021
 * Time: 05:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.container;
using HopitalEspoirDelmas.baseHopital;
namespace HopitalEspoirDelmas.utilisateursTr
{
	/// <summary>
	/// Description of NewUtilisateurs.
	/// </summary>
	public partial class NewUtilisateurs : Panel
	{
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
		ViewUtilisateurs vwu = new ViewUtilisateurs();
		//UtilisateursTraitement util = new UtilisateursTraitement();
		public NewUtilisateurs()
		{
			
			InitializeComponent();
			foreach(UtilisateursTraitement util in ViewUtilisateurs.getAll())
			{
				this.dataUtil.Rows.Add(util.IdEmp,util.Pseudo,util.Etat,util.ModuleAcces);
			}
			
		}
		bool tester = false;
		void BtAjoutUtClick(object sender, EventArgs e)
		{
			barOutils.Visible=false;
			UtilisateursTraitement util = new UtilisateursTraitement();
			ViewUtilisateurs vwu = new ViewUtilisateurs();
			utilisateurs ut = new utilisateurs();
			panelUtil.Controls.Add(ut);
			ut.BringToFront();

			if(tester)
			{
				if(ViewUtilisateurs.EnregistrerUtilisateur(util) == 1)
				{
				MessageBox.Show("Utilisateur enregistrer avec succes!","EnregistrerUtilisateur");
				}
				
			}
		}
		void BtModUtClick(object sender, EventArgs e)
		{
			
				barOutils.Visible=false;
				MySqlConnection con = DbHopitalEs.Connection();
				int modUt =dataUtil.CurrentCell.RowIndex;
				String idEmp = ""+dataUtil.Rows[modUt].Cells[0].Value;
				UtilisateursTraitement util = new UtilisateursTraitement();
				
				
				util.IdEmp = int.Parse(dataUtil.Rows[modUt].Cells[0].Value.ToString());
				util.Pseudo = ""+dataUtil.Rows[modUt].Cells[1].Value;
				util.Etat = ""+dataUtil.Rows[modUt].Cells[2].Value;
				util.ModuleAcces = ""+dataUtil.Rows[modUt].Cells[3].Value;
				
						utilisateurs ut = new utilisateurs(util);
						panelUtil.Controls.Add(ut);
						ut.BringToFront();
						
		}
		void BtSupUtClick(object sender, EventArgs e)
		{
			barOutils.Visible=false;
			MySqlConnection con = DbHopitalEs.Connection();
			int supUt =dataUtil.CurrentCell.RowIndex;
			String pseudo = ""+dataUtil.Rows[supUt].Cells[0].Value;
			
				
			
				if(MessageBox.Show("Voulez-vous vraiment supprimer Cet Utilisateur?", "Confimer",
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
				{
				
					ViewUtilisateurs vu = new ViewUtilisateurs();
					if (vu.DelUtilisateur(pseudo) == 1) {
						MessageBox.Show("Suppression!", "Succes");
					}
					
				this.Hide();
				NewUtilisateurs	 nu = new NewUtilisateurs();
				nu.Show();
				}
		}
		void BtDesacClick(object sender, EventArgs e)
		{
			
		}
		void BtRetUtClick(object sender, EventArgs e)
		{
			this.Hide();
			NewUtilisateurs nwu = new NewUtilisateurs();
			nwu.Visible = false;
		}
		void DataUtilCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int utAf = dataUtil.CurrentCell.RowIndex;
			String pseudo = ""+dataUtil.Rows[utAf].Cells[0].Value;
			if(e.ColumnIndex == 4){
				DbHopitalEs.Connection();
			}
		}
	}
}
