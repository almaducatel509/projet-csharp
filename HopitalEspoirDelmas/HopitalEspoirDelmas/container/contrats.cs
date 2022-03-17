/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 27/09/2021
 * Time: 23:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.contratTr;
namespace HopitalEspoirDelmas.container
{
	/// <summary>
	/// Description of contrats.
	/// </summary>
	public partial class contrats : Panel
	{
		public contrats()
		{
			
			InitializeComponent();
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			if(btEnregistrerC.Enabled= true){
				btModifierC.Enabled= false;
			}
		}
		
		ContratTraitement contr = null;
		public contrats(ContratTraitement cntra){
			this.contr = cntra;
			InitializeComponent();
			txNomCompAs.Text = cntra.NomCompAs;
			txSigle.Text = cntra.SigleCompAs;
			txNmD.Text = cntra.NomDir;
			txAdres.Text = cntra.Adresse;
			mskTl.Text = cntra.Tlf;
			txMail.Text =cntra.Email;
			txPc.Text = ""+cntra.PourcentageCons;
			txPch.Text = ""+cntra.PourcentageChambre;
			txPouHop.Text = ""+cntra.PourcentageHosp;
			combEt.SelectedItem = cntra.Etat;
			
		}
		
		
		bool affectation(){
			bool tester = false;
			contr.NomCompAs = txNomCompAs.Text;
				
			
			if(DbHopitalEs.stringOnly(txSigle.Text, "sigleCompAs")){
				
				contr.SigleCompAs = txSigle.Text;
				tester = true;
			}else{
				return false;
			}
			
			if(DbHopitalEs.stringOnly(txNmD.Text, "nomDir")){
				
				contr.NomDir = txNmD.Text;
				tester = true;
			}else{
				return false;
			}
			
			if(DbHopitalEs.stringOnly(txAdres.Text, "adresse")){
				
				contr.Adresse = txAdres.Text;
				tester = true;
			}else{
				return false;
			}
			if(DbHopitalEs.stringOnly(mskTl.Text, "tlf")){
				contr.Tlf = mskTl.Text;
				tester = true;
			}else{
				return false;
			}
			
			if(DbHopitalEs.stringOnly(txMail.Text, "email")){
				
				contr.Email = txMail.Text;
				tester = true;
			}else{
				return false;
			}
			
			if(DbHopitalEs.numberOnly(txPc.Text, "pourcentageCons")){
				contr.PourcentageCons = double.Parse(txPc.Text);
				tester = true;
			}else{
				return false;
			}
			
			if(DbHopitalEs.numberOnly(txPch.Text, "pourcentageChambre")){
				contr.PourcentageChambre = double.Parse(txPch.Text);
				tester = true;
			}else{
				return false;
			}
			
			if(DbHopitalEs.numberOnly(txPouHop.Text, "pourcentageHosp")){
				contr.PourcentageHosp = double.Parse(txPouHop.Text);
				tester = true;
			}else{
				return false;
			}
			
			contr.Etat = ""+combEt.SelectedItem;
			return tester;
			
		}
		
		public void BtEnregistrerCClick(object sender, EventArgs e)
		{
			
			
			bool tester = false;
			bool modification = contr != null;
			if(!modification){
				
				contr = new ContratTraitement();
			}
			tester = affectation();
			
			if(tester)
			{
				if(!modification && ViewContrat.EnregistrerContrat(contr) == 1)
				{
					MessageBox.Show("contrat enregistrer avec succes!","EnregistrerContrat");
					
				}
				
				
			}			
		}
		void TxAdresTextChanged(object sender, EventArgs e)
		{
	
		}
		void BtCancel1Click(object sender, EventArgs e)
		{
			txNomCompAs.ResetText();
			txNmD.ResetText();
			txPc.ResetText();
			txSigle.ResetText();
			txPouHop.ResetText();
			txPch.ResetText();
			txAdres.ResetText();
			mskTl.ResetText();
			txMail.ResetText();
			combEt.ResetText();
		}
		void BtSuivant1Click(object sender, EventArgs e)
		{
			this.Hide();
			contrats cnt = new contrats();
			cnt.Visible = false;
		}
		void BtSupprClick(object sender, EventArgs e)
		{
		}
		void BtAfficherCClick(object sender, EventArgs e)
		{
			souspanelCont.Visible = false;
			souspanelCont2.Visible = false;
			this.Hide();
			//ViewContrat.updateContr(contr);
			
			
			NewContrat nwc = new NewContrat();
			nwc.Show();
		}
		void BtModifierCClick(object sender, EventArgs e)
		{
			bool edit = contr != null;
			contr = !edit ? new ContratTraitement() : contr;
			
			if(MessageBox.Show("Voulez-vous vraiment modifier Ce contrat?", "Confimer",
			                   
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
			{
				if (edit) {
						affectation();
						ViewContrat.updateContr(contr);
						MessageBox.Show("Modification!", "Succes");
						//this.Hide();
						
					}
					
				
				NewContrat nc = new NewContrat();
				nc.Show();	
			}
				
		}
		void MskTlMaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
	
		}
		void TxNmDTextChanged(object sender, EventArgs e)
		{
	
		}
		void TxNomDClick(object sender, EventArgs e)
		{
	
		}
	}
}
