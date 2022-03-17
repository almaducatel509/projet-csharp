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
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HopitalEspoirDelmas.consultationTr;
using HopitalEspoirDelmas.dossierTr;
using HopitalEspoirDelmas.baseHopital;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using HopitalEspoirDelmas.Properties.MainForm;

namespace HopitalEspoirDelmas.container
{
	public partial class consultation : Panel
	{
		private bool modification = false;
		//ConsultationTraitement cons = new ConsultationTraitement();
		public consultation()
		{
			modification = false;
			InitializeComponent();
			if(btEnregistrer.Enabled= true){
				btModifier.Enabled= false;
			}
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.combNDos.Items.AddRange(DossiersTraitement.getId());
			this.combChb.Items.AddRange(ChambreTraitement.getId());
			this.combConsul.Items.AddRange(Traitement.TraitementSer.getNom());
			
		}
		
		ConsultationTraitement cons = null;
		public consultation(ConsultationTraitement consul){
			bool test = false;
			modification = true;
			this.cons = consul;
			InitializeComponent();
			this.combNDos.Items.AddRange(DossiersTraitement.getId());
			this.combChb.Items.AddRange(ChambreTraitement.getId());
			this.combConsul.Items.AddRange(Traitement.TraitementSer.getNom());
			txNomMe.Text = consul.Medecin;
			combConsul.SelectedItem = consul.ConsultationServices;
			comMotif.SelectedItem = consul.MotifCons;
			combHosAss.SelectedItem = consul.HospAss;
			combChb.SelectedItem = consul.IdChambre;
			combNDos.SelectedItem = consul.NoDosspat;
			
			
			if(consul.PaiementConsAss.Equals("Oui")){
				
				btPAss1.Checked = true;
				test = true;
			}
			else if(consul.PaiementConsAss.Equals("Non"))
			{
				btPAss2.Checked = true;
				
				test = true;
			}else
			{
				test = false;
			}
			if(consul.NecHospitalisation.Equals("Oui")){
				
				btNeces1.Checked = true;
				test = true;
			}
			else if(consul.NecHospitalisation.Equals("Non"))
			{
				btNecess2.Checked = true;
				
				test = true;
			}else
			{
				test = false;
			}
			txDuH.Text = consul.DureeHosp.ToString();
			
//			txDateHospit.Text = MainForm.toCSDate(consul.DateHospitalisation);
//			txDatconsu.Text = MainForm.toCSDate(consul.DateConsul);
			txDateHospit.Text = consul.DateHospitalisation;
			txDatconsu.Text = consul.DateConsul;
		}
		
		bool affectation(){
			bool tester = false;
			
			cons.ConsultationServices = combConsul.Text;
		 	cons.MotifCons = comMotif.Text;
		 	cons.PaiementConsAss = txPyAss.Text;
		 	if(DbHopitalEs.boutonRadio(btPAss1.Checked, btPAss2.Checked, "paiementConsAss"))
			{
				if(btPAss1.Checked)
				{
					cons.PaiementConsAss = "Oui";
				}else if(btPAss2.Checked)
				{
					cons.PaiementConsAss = "Non";
				}
				tester = true;
		 	}else
		 	{
		 		return false;
		 	}
		 	
		 	try{
		 		cons.NoDosspat = int.Parse(combNDos.Text);
		 	}catch{
		 		return false;
		 	}
		 	
		 	
		 	cons.IdChambre = ""+combChb.SelectedItem;
		 	
		 	if(DbHopitalEs.numberOnly(txDuH.Text, "dureeHosp"))
			{
				cons.DureeHosp = int.Parse(txDuH.Text);
				tester = true;
			}else{
				return false;
			}
		 	
		 	//cons.Medecin = txNomMe.Text;
		 	if(DbHopitalEs.stringOnly (	txNomMe.Text, "medecin"))
		 	{
		 		cons.Medecin = 	txNomMe.Text;
		 		tester = true;
		 	}else
		 	{
		 		return false;
		 	}
		 	cons.DateConsul = MainForm.toSqlDate(txDatconsu.Text);
		 	string now = MainForm.toSqlDate(DateTime.Now.ToShortDateString());
		 	if(ComparerDate(cons.DateConsul, now) > 0){
		 		MessageBox.Show("Error, La date de consultation ne doit pas superieure a la date actuelle");
		 		return false;
		 	}else{
		 		tester = true;
		 	}
		 	
		 	cons.DateHospitalisation = MainForm.toSqlDate(txDateHospit.Text);
		 	
		 	if(ComparerDate(cons.DateHospitalisation, cons.DateConsul) < 0){
		 		MessageBox.Show("Error, La date d'hospitalisation ne doit pas inferieure a la date consultation");
		 		return false;
		 	}else{
		 		tester = true;
		 	}
		 	cons.HospAss = ""+combHosAss.SelectedItem;
			cons.NecHospitalisation = txNecess.Text;
		 	if(DbHopitalEs.boutonRadio(btNeces1.Checked, btNecess2.Checked, "necHospitalisation"))
			{
				if(btNeces1.Checked)
				{
					cons.NecHospitalisation = "Oui";
				}else if(btNecess2.Checked)
				{
					cons.NecHospitalisation = "Non";
				}
				tester = true;
		 	}
		 	else{
		 		return false;
		 	}
		 	
		 
		 	return tester;
			
			
		}
		
		
		void BtCancelClick(object sender, EventArgs e)
		{
			combNDos.ResetText();
			combConsul.ResetText();
			comMotif.ResetText();
			btPAss1.ResetText();
			txPyAss.ResetText();
			combChb.ResetText();
			txDuH.ResetText();
			txNomMe.ResetText();
			txDate.ResetText();
			btNeces1.ResetText();
			btNecess2.ResetText();
			combHosAss.ResetText();
			
			
		}
		void BtretourClick(object sender, EventArgs e)
		{
			this.Hide();
			consultation cns = new consultation();
			cns.Visible = false;	
		}
		void BtEnregistrerClick(object sender, EventArgs e)
		{
			
			bool tester = false;
			if(!modification){
				cons = new ConsultationTraitement();
				
			}
			tester = affectation();
			
			if(tester)
			{
				
				if(!modification && ViewConsultation.EnregistrerConsultation(cons) == 1)
				{
					MessageBox.Show("Consultation enregistrer avec succes!","EnregistrerConsultation");
					
				}
		
			}
			else{
				MessageBox.Show("Formulaire mal rempli !");
			}
		}
		
		
		void CombConsulSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void BtAfficherClick(object sender, EventArgs e)
		{
			souspanelCons.Visible = false;
			souspanelCons1.Visible = false;
			this.Hide();
			//ViewConsultation.updateCons(cons);
			NewConsultation nwc = new NewConsultation();
			nwc.Show();
		}

//		void BtAfficherClick(object sender, EventArgs e)
//		{
//			this.Hide();
//			NewConsultation nwc = new NewConsultation();
//			nwc.Show();
//		}
		void BtModifierClick(object sender, EventArgs e)
		{
			
			//btModifier.BackColor = System.Drawing.Color.Turquoise;
			
			bool edit = cons != null;
			cons = !edit ? new ConsultationTraitement() : cons;
			
			if(MessageBox.Show("Voulez-vous vraiment modifier Cette consultation?", "Confimer",
			                   
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
			{
				if (edit) {
						affectation();
						ViewConsultation.updateCons(cons);
						MessageBox.Show("Modification!", "Succes");
						//this.Hide();
						
					}
					
				
				NewConsultation nc = new NewConsultation();
				nc.Show();	
		    }
			
			

		}
		void CombChbSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void CombNDosSelectedIndexChanged(object sender, EventArgs e)
		{
			//bool t = false;
			string text = ((ComboBox) sender).Text;
			bool isOk = DossiersTraitement.EstSurAssurance(int.Parse(text));
			this.combHosAss.Enabled = isOk;
			
			if(!isOk){
				this.btPAss2.Checked = !isOk;
				this.btPAss2.Enabled = false;
				this.btPAss1.Checked = false;
				this.btPAss1.Enabled = false;
			}
			else{
				this.btPAss1.Enabled = true;
				this.btPAss2.Enabled = true;
			}
			
			
		}
		
		public bool chambreVide(int idChambre , string dateHospitalisation){
			bool t = false;
			ConsultationTraitement cons = new ConsultationTraitement();
			MySqlConnection con = DbHopitalEs.Connection();
			
			String prq = "select count(idCons) as total from consultation where ('@dateHospitalisation' BETWEEN dateHospitalisation and (dateHospitalisation +" +
						"INTERVAL dureeHosp DAY) or ('@dateHospitalisation' + INTERVAL DAY) BETWEEN dateHospitalisation and (dateHospitalisation +" +
                        "INTERVAL dureeHosp DAY) )  and idChambre = '@idChambre'";
			
			MySqlCommand comd = new MySqlCommand(prq, con);
			MySqlDataReader readr = comd.ExecuteReader();
			if(readr.HasRows)
			{
				if(readr.Read())
				{
					cons.DateHospitalisation = readr["total"].ToString();
//					if(readr["total"]){
//						MessageBox.Show("Cette chambre n'est pas disponible");
//						return t;
//					}
					
				}
				else{
					t = true;
				}
			}
			
				readr.Close();
				con.Close();
				return t;
		}
		
		int ComparerDate(string date1, string date2){
			string[] td1 = date1.Split(' ')[0].Split('-'),
					 td2 = date2.Split(' ')[0].Split('-');
			 int result = 0;
			 for(int i = 0; i < td1.Length; i++){
				 if(int.Parse(td1[i])>int.Parse(td2[i])){
				 	result = 1;
				 	break;
				 }
			 	 else if(int.Parse(td1[i]) != int.Parse(td2[i])){
				 	result = -1;
				 	break;
				 }
			 }
   		    return result;
		}
		
		void TxDateHospitValueChanged(object sender, EventArgs e)
		{
			
		}
		void SouspanelConsPaint(object sender, PaintEventArgs e)
		{
	
		}
	}
}
