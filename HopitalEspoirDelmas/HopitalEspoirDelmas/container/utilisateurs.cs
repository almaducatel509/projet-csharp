/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 28/09/2021
 * Time: 00:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using HopitalEspoirDelmas.utilisateursTr;
using HopitalEspoirDelmas.baseHopital;

namespace HopitalEspoirDelmas.container
{
	/// <summary>
	/// Description of utilisateurs.
	/// </summary>
	public partial class utilisateurs : Panel
	{
		UtilisateursTraitement util = null;
		ViewUtilisateurs vwu = new ViewUtilisateurs();
		public utilisateurs()
		{
			
			InitializeComponent();
			privileges.setOptions(new string[]{
				"Gestion Utilisateurs",
				"Gestion Dossiers",
				"Gestion Chambres",
				"Gestion Services",
				"Gestion Contrats",
				"Gestion Personels",
				"Gestion Consultations"				
            });
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			
			if(btEnregistrerU.Enabled= true){
				btModifierU.Enabled= false;
			}
			
		}
		
		public utilisateurs (UtilisateursTraitement ut){
			bool test = false;
			InitializeComponent();
			privileges.setOptions(new string[]{
				"Gestion Utilisateurs",
				"Gestion Dossiers",
				"Gestion Chambres",
				"Gestion Services",
				"Gestion Contrats",
				"Gestion Personels",
				"Gestion Consultations"				
            });
			this.util = ut;
			txPs.Text = ut.Pseudo;
			txtpas.Text = ut.MotDPass;
			privileges.Text = ut.ModuleAcces;
			
			if(ut.Etat.Equals("Actif")){
				
				btAc.Checked = true;
				test = true;
			}
			else if(ut.Etat.Equals("Inactif"))
			{
				btInact.Checked = true;
				
				test = true;
			}else
			{
				test = false;
			}
	
		   
			
			
		}
		
		bool affectation(){
			
			btEnregistrerU.BackColor = System.Drawing.Color.DarkTurquoise;
			
			 bool tester = false;  
		 	
			util.Pseudo = txPs.Text;
			
			 
			util.ModuleAcces = privileges.Text;
			
			
			if(DbHopitalEs.stringOnly (	txPs.Text, "pseudo"))
		 	{
		 		util.Pseudo = 	txPs.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			
			if(DbHopitalEs.numberOnly (	txtpas.Text, "motDpass"))
		 	{
		 		util.MotDPass = 	txtpas.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			
			if(DbHopitalEs.boutonRadio(btAc.Checked, btInact.Checked, "etat"))
			{
				if(btAc.Checked)
				{
					util.Etat = "Actif";
				}else if(btInact.Checked)
				{
					util.Etat = "Inactif";
				}
				tester = true;
		 	}else
		 	{
		 		return false;
		 	}
		 	
			return tester;
									
			
		}
		void BtRetour1Click(object sender, EventArgs e)
		{
			this.Hide();
			utilisateurs ut = new utilisateurs();
			ut.Visible = false;
			
			
		}
		void TxAnnuleClick(object sender, EventArgs e)
		{
			txPs.ResetText();
			txtpas.ResetText();
			//combAc.ResetText();
			
		}
		void BtEnregistrerUClick(object sender, EventArgs e)
		{
			bool tester = false;
			bool modification = util != null;
			if(!modification){
				util = new UtilisateursTraitement();	
			}
			tester = affectation();
			
			if(tester)
			{
				if(!modification && ViewUtilisateurs.EnregistrerUtilisateur(util) == 1)
				{
					MessageBox.Show("Utilisateur enregistrer avec succes!","EnregistrerUtilisateur");
					
				}
		
		}
	}
		void BtAfficherUClick(object sender, EventArgs e)
		{
			
			souspanelUtli.Visible = false;
			souspanelUtil2.Visible = false;
			this.Hide();
			//ViewUtilisateurs.updateUtlis(util);
			NewUtilisateurs nwu = new NewUtilisateurs();
		
			nwu.Show();
		}
		void BtModifierUClick(object sender, EventArgs e)
		{
			
			bool edit = util != null;
			
			util = !edit ? new UtilisateursTraitement() : util;
			
			if(MessageBox.Show("Voulez-vous vraiment modifier Cet utilisateur?", "Confimer",
			                   
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
								
			{
				
					if (edit) {
						affectation();
						ViewUtilisateurs.updateUtlis(util);
						MessageBox.Show("Modification!", "Succes");
						
					}
					
			
				NewUtilisateurs nwu = new NewUtilisateurs();
				nwu.Show();	
			}
			
			
		}
		void PrivilegesLoad(object sender, EventArgs e)
		{
	
		}
		void TxPsTextChanged(object sender, EventArgs e)
		{
	
		}
		
	}
}