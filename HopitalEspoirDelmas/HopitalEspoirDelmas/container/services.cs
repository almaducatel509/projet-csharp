
using System;
using System.Windows.Forms;
using HopitalEspoirDelmas.Traitement;
using HopitalEspoirDelmas.ServiceType;
using HopitalEspoirDelmas.baseHopital;

namespace HopitalEspoirDelmas.container
{
	/// <summary>
	/// Description of services.
	/// </summary>
	public partial class services : Panel
	{
		
		TraitementSer trs = null;
		
		public services()
		{
			
			InitializeComponent();
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			if(btEnregistrer.Enabled= true){
				btModifier.Enabled= false;
			}
		}
		public services(TraitementSer servi){
			
			bool t = false;
			this.trs = servi;
			InitializeComponent();
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			txNomSer.Text = servi.NomService;
			txNomCh.Text = servi.NomChefService;
			txPrix.Text = ""+servi.PrixConsultation;
			combEt.SelectedItem = servi.etat;
			txDescrip.Text = servi.description;
			
			if(servi.couvrirParAssurance.Equals("Oui")){
				
				btAss1.Checked = true;
				t = true;
			}
			else if(servi.couvrirParAssurance.Equals("Non"))
			{
				btAss2.Checked = true;
				
				t = true;
			}else
			{
				t = false;
			}
			
		
		}
		
		bool affectation(){
			
			bool tester = false;
		if(DbHopitalEs.stringOnly(txNomSer.Text, "nomService"))
		 {
			if(DbHopitalEs.serviceExiste (txNomSer.Text, "nomService"))
		 	{
		 		trs.NomService = txNomSer.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			
			
		}
		 	if(DbHopitalEs.stringOnly(txNomCh.Text, "nomChefService"))
		 	{
		 		trs.NomChefService = txNomCh.Text;
				tester = true;		 		
		 	}else
		 	{
		 		return false;
		 	}
		 	
		 	if(DbHopitalEs.numberOnly(txPrix.Text, "prixConsultation")){
		 		trs.PrixConsultation = Double.Parse(txPrix.Text);
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
		 	trs.etat = ""+combEt.SelectedItem;
		 	if(DbHopitalEs.stringOnly(txDescrip.Text, "description"))
		 	{
		 		trs.description = txDescrip.Text;
				tester = true;		 		
		 	}else
		 	{
		 		return false;
		 	}
		 	
		 	
		 	
			trs.couvrirParAssurance = txAss.Text;
			if(DbHopitalEs.boutonRadio(btAss1.Checked, btAss2.Checked, "CouvrirParAssurance"))
			{
				if(btAss1.Checked)
				{
					trs.couvrirParAssurance = "Oui";
				}else if(btAss2.Checked)
				{
					trs.couvrirParAssurance = "Non";
				}
				tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			
			return tester;
			
		}
		public void BtEnregistrerClick(object sender, EventArgs e)
		{
			
		 	bool tester = false;
		 	bool modification = trs != null;
			if(!modification){
				trs = new TraitementSer();
				
			}
		 	tester = affectation();
		 	  
		 	  
		 	if(tester)
			{
				if(ViewService.EnregistrerService(trs) == 1)
				{
					MessageBox.Show("Service enregistrer avec succes!","EnregistrerService");
					
				}
			}
	}

		 
		void BtCancelClick(object sender, EventArgs e)
		{
			txNomSer.ResetText();
			txNomCh.ResetText();
			txPrix.ResetText();
			combEt.ResetText();
			txDescrip.ResetText();
			btAss1.ResetText();
			btAss2.ResetText();
		}
		void BtRetourClick(object sender, EventArgs e)
		{
			
			
			this.Hide();
			services ser = new services();
			ser.Visible = false;
			
		}
		void BtAfficherClick(object sender, EventArgs e)
		{
			souspanelSer.Visible = false;
			souspanelSer2.Visible = false;
			this.Hide();
			//ViewService.updateSer(trs);
			NewService nwc = new NewService();
			nwc.Show();
			
		}
		void BtModifierClick(object sender, EventArgs e)
		{
			
			
			bool edit = trs != null;
			trs = !edit ? new TraitementSer() : trs;
			if(MessageBox.Show("Voulez-vous vraiment modifier Ce Service?", "Confimer",
			                   
				MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
								
			{
				
					if (edit) {
						affectation();
						ViewService.updateSer(trs);
						MessageBox.Show("Modification!", "Succes");
						//this.Hide();
					}
					
			
				NewService ns = new NewService();
				ns.Show();	
		}
		
		
	}
		
		
		void SouspanelSer2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void CombEtSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void TxDescripTextChanged(object sender, EventArgs e)
		{
	
		}
		void TxAssClick(object sender, EventArgs e)
		{
	
		}
}

}