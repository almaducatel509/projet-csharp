/*
 * Created by SharpDevelop.
 * User: Fl3m
 * Date: 14-Oct-21
 * Time: 2:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using HopitalEspoirDelmas.dossierTr;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.consultationTr;

namespace HopitalEspoirDelmas.container
{
	/// Description of dossiers.
	public partial class dossiers : Panel
	{
		DossiersTraitement dosr = null;
		ConsultationTraitement cons = new ConsultationTraitement();
		NewConsultation consul = new NewConsultation();
		public dossiers()
		{
			InitializeComponent();
			
			if(btEnregistrerD.Enabled = true){
				btModifierD.Enabled = false;
			}
			
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.combCompAss.Items.AddRange(ContratTraitement.getNomComp());
			
		}
		
		
		public dossiers(DossiersTraitement dosrs){
			bool t = false;
			InitializeComponent();
			this.dosr = dosrs;
			txNomPat.Text = dosrs.NomPatient;
			txtpren.Text = dosrs.Prenom;
			txAd.Text = ""+dosrs.Adres;
			combSx.SelectedItem = dosrs.Sexe;
			combTrait.Text = dosrs.TrtSuivi;
			txPersnr.Text = dosrs.PersResp;
			txtMemo.Text = dosrs.Memo;
			combCompAss.Text = dosrs.CompAssure;
			datNaissc.Text = dosrs.DateNaiss;
			txAg.Text = dosrs.Age.ToString();
			tEm.Text = dosrs.Mail;
			maskT.Text = dosrs.NumeroPers;
			maskTp.Text =  dosrs.Telephone;
			
		}
		
		
		bool affectation(){
			bool tester = false;
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			
			
			if(DbHopitalEs.stringOnly(txNomPat.Text, "nomPatient"))
		 	{
		 		dosr.NomPatient = 	txNomPat.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
		 	
		 	
		 	if(DbHopitalEs.stringOnly(txtpren.Text, "prenom"))
		 	{
		 		dosr.Prenom = txtpren.Text;
				tester = true;		 		
		 	}else
		 	{
		 		tester = false;
		 	}

			if(DbHopitalEs.stringOnly(txAd.Text, "adres"))
		 	{
		 		dosr.Adres = txAd.Text;
				tester = true;		 		
		 	}else
		 	{
		 		return false;
		 	}
			
			
		 	dosr.Sexe = ""+combSx.SelectedItem;
		 	dosr.TrtSuivi = ""+combTrait.SelectedItem;
		 	
			if(DbHopitalEs.stringOnly (	txPersnr.Text, "persResp"))
		 	{
		 		dosr.PersResp = 	txPersnr.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			
			
			dosr.Memo = txtMemo.Text;			
			dosr.CompAssure = ""+combCompAss.SelectedItem;
			
		 	dosr.DateNaiss = datNaissc.Text;
		 	
		 	
			if(DbHopitalEs.numberOnly(txAg.Text, "age")){	
		 		
				dosr.Age = int.Parse(txAg.Text);
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
		
		 	if(DbHopitalEs.stringOnly (	txPersnr.Text, "persResp"))
		 	{
		 		dosr.Mail = tEm.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			
		 	if(DbHopitalEs.numberOnly(txAg.Text, "age")){	
		 		
				dosr.NumeroPers = maskT.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			if(DbHopitalEs.numberOnly(txAg.Text, "age")){	
		 		
				dosr.Telephone = maskTp.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
		 	
			
			
			return tester;
		}
		void BtEnregistrerDClick(object sender, EventArgs e)
		{
			
			btEnregistrerD.BackColor = System.Drawing.Color.DarkTurquoise;
		
			bool tester = false;  
			bool modification = dosr != null;
			if(!modification){
				dosr = new DossiersTraitement();
			}
		 	tester = affectation();
		 	
		 	if(tester)
			{
				if(!modification && ViewDossiers.EnregistrerPatient(dosr) == 1)
				{
				
					MessageBox.Show("Patient enregistrer avec succes!","EnregistrerPatient");
					
				}
			}
		 	
			
		   }
		
		void BtRetour1Click(object sender, EventArgs e)
		{
			this.Hide();
			dossiers dos = new dossiers();
			dos.Visible = false;
				    	
		}
		void TxAnnuleClick(object sender, EventArgs e)
		{
//			password.ResetText();
			
			txNomPat.ResetText();
			txtpren.ResetText();
			txAd.ResetText();
			combSx.ResetText();
			combTrait.ResetText();
			txPersnr.ResetText();
			txtMemo.ResetText();
			combCompAss.ResetText();
			datNaissc.ResetText();
			txAg.ResetText();
			tEm.ResetText();
			maskT.ResetText();
			maskTp.ResetText();
		}
		void PasswordTextChanged(object sender, EventArgs e)
		{
	
		}
		void MaskedTextBox2MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
	
		}
		void BtAfficherDClick(object sender, EventArgs e)
		{
			btAfficherD.BackColor = System.Drawing.Color.PaleTurquoise;
			souspanelDos.Visible = false;
			souspaneldos2.Visible = false;
			this.Hide();
			NewDossier nwd = new NewDossier();
			nwd.Show();
			
			
			
			
	}
		void BtModifierDClick(object sender, EventArgs e)
		{
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			btModifierD.BackColor = System.Drawing.Color.Turquoise;
			
			
			bool edit = dosr != null;
			dosr = !edit ? new DossiersTraitement() : dosr;
			if(MessageBox.Show("Voulez-vous vraiment modifier Ce dossier?", "Confimer",
			                   
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
								
			{
				
					if (edit) {
						affectation();
						ViewDossiers.updateD(dosr);
						MessageBox.Show("Modification!", "Succes");
						
						//this.Hide();
					}
					
			
				NewDossier nd = new NewDossier();
				nd.Show();	
		}
	}
		void MaskedTextBox1MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
	
		}
		void BtSuvisPClick(object sender, EventArgs e)
		{
			//btSuvisP.BackColor = System.Drawing.Color.MediumTurquoise;
			
			souspanelDos.Visible = false;
			souspaneldos2.Visible = false;
		}
		void BtImprimerPClick(object sender, EventArgs e)
		{
			//btImprimerP.BackColor = System.Drawing.Color.LightSeaGreen;
			
			souspanelDos.Visible = false;
			souspaneldos2.Visible = false;
		}
		void DatNaisscValueChanged(object sender, EventArgs e)
		{
			DateTime time_start = Convert.ToDateTime(datNaissc.Value);
			DateTime time_end = DateTime.Today;
			TimeSpan span = time_end.Subtract(time_start);
			var joursTot = span.TotalDays;
			var anneeTot = Math.Truncate(joursTot/365);
			txAg.Text = Convert.ToString(anneeTot);
		}
	}
}
