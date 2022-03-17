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
using HopitalEspoirDelmas.persoTr;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;
using HopitalEspoirDelmas.baseHopital;
namespace HopitalEspoirDelmas.container
	
{
	/// <summary>
	/// Description of personels.
	/// </summary>
	public partial class personels : Panel
	{
		
		PersonelsTraitement pers = null;
		public personels()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			if(btEnregistrerP.Enabled= true){
				btModifierP.Enabled= false;
			}
		}
		
		public personels(PersonelsTraitement person){
			
			bool t = false;
			this.pers = person;
			InitializeComponent();
			txNban.Text = person.NombreAnneeExp.ToString();
			txtpren.Text = person.Prenom;
			txNiE.Text = person.NiveauEtude;
			maskNif.Text = person.NifCin;
			txNomPr.Text = person.Nom;
			comSers.SelectedItem = person.ServicesAffectes;
			mskTel.Text = person.Telephone;
			combSp.SelectedItem = person.Sexe;
			txtDom.Text = person.DomaineEtude;
			combCat.SelectedItem = person.Categorie;
			txSpc.Text = person.Specialisation;
			txA.Text = person.Adresse;
			tEm.Text = person.Email;
			if(person.Etat.Equals("Actif")){
				
				btActif.Checked = true;
				t = true;
			}
			else if(person.Etat.Equals("Quitter"))
			{
				btQuit.Checked = true;
				
				t = true;
			}else
			{
				t = false;
			}
			
			
		}
		
		void NumberClick(object sender, EventArgs e)
		{
	
		}
		
		bool affectation(){
			bool tester = false;
			if(DbHopitalEs.stringOnly(txNomPr.Text, "nom"))
			{
				pers.Nom = txNomPr.Text;
				
				tester = true;
			}else{
				return false;
			}
			
			if(DbHopitalEs.stringOnly(txtpren.Text, "prenom"))
			{
				pers.Prenom = txtpren.Text;
				tester = true;
			}else{
				return false;
			}
			
			
			if(DbHopitalEs.stringOnly(txA.Text, "adresse"))
			{
				pers.Adresse = txA.Text;
				tester = true;
			}else{
				return false;
			}
			
			pers.Sexe = ""+combSp.SelectedItem;
			pers.Categorie = ""+combCat.SelectedItem;
			
			pers.NifCin = maskNif.Text;
					
			
			if(DbHopitalEs.numberOnly(txNban.Text, "nombreAnneeExp"))
			{
				pers.NombreAnneeExp = int.Parse(txNban.Text);
				tester = true;
			}else{
				return false;
			}
			
			if(DbHopitalEs.stringOnly(txtDom.Text, "domaineEtude"))
			{
				pers.DomaineEtude = txtDom.Text;
				tester = true;
			}else{
				return false;
			}

			if(DbHopitalEs.stringOnly(txNiE.Text, "niveauEtude"))
			{
				pers.NiveauEtude = txNiE.Text;
				tester = true;
			}else{
				return false;
			}	
			if(DbHopitalEs.stringOnly(txSpc.Text, "specialisation"))
			{
				pers.Specialisation = txSpc.Text;
				tester = true;
			}else{
				return false;
			}
			
			pers.DateNaissance = datNaissc.Text;
			if(DbHopitalEs.stringOnly(mskTel.Text, "telephone"))
			{
				pers.Telephone = mskTel.Text;
				tester = true;
			}else{
				return false;
			}	
			
			pers.ServicesAffectes = ""+comSers.SelectedItem;
			
			if(DbHopitalEs.stringOnly(tEm.Text, "email"))
			{
				pers.Email = tEm.Text;
				tester = true;
			}else{
				return false;
			}
			
			
			if(DbHopitalEs.boutonRadio(btActif.Checked, btQuit.Checked, "etat"))
			{
				if(btActif.Checked)
				{
					pers.Etat = "Actif";
				}else if(btQuit.Checked)
				{
					pers.Etat = "Quitter";
				}
				tester = true;
		 	}else
		 	{
		 		return false;
		 	}
			return tester;
		}
		
		public void calculDate(System.DateTime startDate, System.DateTime endDate){
			
				
		}
		void BtEnregistrerPClick(object sender, EventArgs e)
		{
			
			if(pers == null){
				MessageBox.Show("Vous devez remplir tous les champs");
				
			}
			
			bool tester = false;
			
			souspanelPers.Visible = true;
			
			bool modification = pers != null;
			
			if(!modification){
				pers = new PersonelsTraitement();
			}
			
			tester = affectation();
			
			if(tester)
			{
				if(!modification && ViewPersonels.EnregistrerPersonel(pers) == 1)
				{
					MessageBox.Show("Personel enregistrer avec succes!","EnregistrerPersonel");
					
				}
				
			}			
		
		
	}
		void SouspanelPersPaint(object sender, PaintEventArgs e)
		{
	
		}
		void TxAnnulClick(object sender, EventArgs e)
		{
			txNomPr.ResetText();
			txPren.ResetText();
			txA.ResetText();
			comSers.ResetText();
			txtDom.ResetText();
			txNban.ResetText();
			combSp.ResetText();
			mskTel.ResetText();
			txNiE.ResetText();
			maskNif.ResetText();
			combCat.ResetText();
			txSpc.ResetText();
			tEm.ResetText();
			
		}
		void BtRetourClick(object sender, EventArgs e)
		{
//			this.Hide();
//			personels per = new personels();
//			per.Visible = false;
		}
		void BtAfficherPClick(object sender, EventArgs e)
		{
			
			souspanelPers.Visible = false;
			souspanelPers2.Visible = false;
			this.Hide();
			//ViewPersonels perso = new ViewPersonels();
			//ViewPersonels.updateP(pers);
			NewPersonel nwp = new NewPersonel();
			nwp.Show();
			
		}
		void PersonelsLoad(object sender, EventArgs e)
		{
			
			souspanelPers.Visible = true;
			souspanelPers2.Visible = true;
		}
		void PanelPersonelsPaint(object sender, PaintEventArgs e)
		{

			souspanelPers.Visible = true;
			souspanelPers2.Visible = true;
		}
		public void BtModifierPClick(object sender, EventArgs e)
		{
			
			bool edit = pers != null;
			pers = !edit ? new PersonelsTraitement() : pers;
			
			if(MessageBox.Show("Voulez-vous vraiment modifier Ce personel?", "Confimer",
			                   
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
								
			{
				
					if (edit) {
						affectation();
						ViewPersonels.updateP(pers);
						MessageBox.Show("Modification!", "Succes");
						//this.Hide();
					}
					
			
				NewPersonel np = new NewPersonel();
				np.Show();	
			}
			
			
		}
		
//		void Button1Click(object sender, EventArgs e)
//		{
//				this.Hide();
//				menuPrincipal men = new menuPrincipal();
//	    	    men.Show();
//		}
		void PanelPersPaint(object sender, PaintEventArgs e)
		{
	
		}
		void CombCatSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		
		void DatNaisscValueChanged(object sender, EventArgs e)
		{
			bool test = true;
			DateTime from = datNaissc.Value;
			DateTime to = DateTime.Now;
			TimeSpan tSpan = to-from;
			double days = tSpan.TotalDays;
			
			int age = int.Parse((days/365).ToString("0"));
			if(age < 18){
				MessageBox.Show("ce personnel est mineur, non enregistre");
				test = false;
			}
			else{
				test = true;
			}
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
			personels per = new personels();
			per.Visible = false;
			
		}
		
	}
}

