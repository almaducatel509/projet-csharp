/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 27/09/2021
 * Time: 23:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using HopitalEspoirDelmas.ChambreTr;
using HopitalEspoirDelmas.baseHopital;

namespace HopitalEspoirDelmas.container
{
	/// <summary>
	/// Description of chambre.
	/// </summary>
	public partial class chambre : Panel
	{
		
		ChambreTraitement chb = null;
		ViewChambre vch = new ViewChambre();
		
		public chambre()
		{
			
			InitializeComponent();
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			
			if(btEnregistrer.Enabled= true){
				btModifier.Enabled= false;
			}
			
			
		}
		public chambre(ChambreTraitement chmb){
			bool test = false;
			InitializeComponent();
			this.chb = chmb;
			txChb.Text= chmb.NomChambre;
			combCh.SelectedItem = chmb.TypeChambre;
			txPrixL.Text = ""+chmb.PrixLocationParJour;
			combEta.SelectedItem = chmb.Etat;
			txConsCh.Text = chmb.ConstituantChambre;
			txDescr.Text = chmb.Description;
			combEta.SelectedItem = chmb.Etat;
			
			if(chmb.CouvrirParAssurance.Equals("Oui")){
				
				btAss1.Checked = true;
				test = true;
			}
			else if(chmb.CouvrirParAssurance.Equals("Non"))
			{
				btAss2.Checked = true;
				
				test = true;
			}else
			{
				test = false;
			}
			
		}
		
		bool affectation(){
			bool tester = false;
			
			if(DbHopitalEs.stringOnly(txChb.Text, "nomChambre")){
				chb.NomChambre = txChb.Text;
				tester = true;
			}else{
				return false;
			}
			
			chb.TypeChambre = ""+combCh.SelectedItem;
			
			if(DbHopitalEs.numberOnly(txPrixL.Text, "prixLocationParJour")){
				
			 			chb.PrixLocationParJour = Double.Parse(txPrixL.Text);
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			
			if(DbHopitalEs.stringOnly(txConsCh.Text, "constituantsChambre")){
				chb.ConstituantChambre = txConsCh.Text;
				tester = true;
			}else{
				return false;
			}
			
			chb.CouvrirParAssurance = txAss.Text;
			
			if(DbHopitalEs.boutonRadio(btAss1.Checked, btAss2.Checked, "couvrirParAssurance"))
			{
				if(btAss1.Checked)
				{
					chb.CouvrirParAssurance = "Oui";
				}else if(btAss2.Checked)
				{
					chb.CouvrirParAssurance = "Non";
					tester = true;
				}
				
		 	}else
		 	{
		 		return false;
		 	}
			
			if(DbHopitalEs.stringOnly(txConsCh.Text, "description")){
				chb.Description = txDescr.Text;
				tester = true;
			}else{
				return false;
			}
			
			chb.Etat = ""+combEta.SelectedItem;
			
			return tester;
		}
		
		void BtEnregistrerClick(object sender, EventArgs e)
		{
			
			bool tester = false;
			bool modification = chb != null;
			if(!modification){
				chb = new ChambreTraitement();
				
			}
			tester = affectation();
				
			
			if(tester)
			{
				if(!modification && ViewChambre.EnregistrerChambre(chb) == 1)
				{
					MessageBox.Show("Chambre enregistrer avec succes!","EnregistrerChambre");
					
				}
				
				
			}			
			
			
		 }
		void BtRetourClick(object sender, EventArgs e)
		{
			this.Hide();
			chambre ch = new chambre();
			//ch.Visible = true;
			NewChambre nwc = new NewChambre();
			ch.Enabled = true;
			
			
			
		}
		void BtCancelClick(object sender, EventArgs e)
		{
			txDescr.ResetText();
			txPrixL.ResetText();
			txChb.ResetText();
			txConsCh.ResetText();
			combCh.ResetText();
			combEta.ResetText();
			btAss1.ResetText();
			btAss2.ResetText();
			
			
		}
		void BtAfficherClick(object sender, EventArgs e)
		{
			souspanelch1.Visible = false;
			souspanelCh2.Visible = false;
			this.Hide();
			
			//ViewChambre.updateCh(chb);
			NewChambre nwc = new NewChambre();
			nwc.Show();
		}
		void BtModifierClick(object sender, EventArgs e)
		{
			
			bool edit = chb != null;
			
			chb = !edit ? new ChambreTraitement() : chb;
			
			if(MessageBox.Show("Voulez-vous vraiment modifier Cette chambre?", "Confimer",
			                   
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
								
			{
				
					if (edit) {
						affectation();
						ViewChambre.updateCh(chb);
						MessageBox.Show("Modification!", "Succes");
						//this.Hide();
					}
					
			
				NewChambre nch = new NewChambre();
				nch.Show();	
			}
			
			
				
						
			
		}
		void PanelChambrePaint(object sender, PaintEventArgs e)
		{
	
		}
		void PhotoChClick(object sender, EventArgs e)
		{
	
		}
		void Souspanelch1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void SouspanelCh2Paint(object sender, PaintEventArgs e)
		{
	
		}
		
		
	}
}
