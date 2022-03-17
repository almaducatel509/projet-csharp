/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 27/09/2021
 * Time: 23:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Text;
using System.Data;
using HopitalEspoirDelmas.Properties.MainForm;
using System.Windows.Forms;
using HopitalEspoirDelmas.contratTr;
using HopitalEspoirDelmas.dossierTr;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.persoTr;
using HopitalEspoirDelmas.consultationTr;
using HopitalEspoirDelmas.utilisateursTr;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;


namespace HopitalEspoirDelmas.container
{
	
	
	/// <summary>
	/// Description of menuPrincipal.
	/// </summary>
	public partial class menuPrincipal : Form
	{
		MySqlConnection con = DbHopitalEs.Connection();
		
		private Button currentButton;
		private Random random;
		private int tempIndex;
		public menuPrincipal()
		{
			
			InitializeComponent();
			
			this.btnConsultations.Visible = MainForm.user.ModuleAcces.Contains(this.btnConsultations.Text);
			this.btnDossier.Visible = MainForm.user.ModuleAcces.Contains(this.btnDossier.Text);
			this.btnContrats.Visible = MainForm.user.ModuleAcces.Contains(this.btnContrats.Text);
			this.btnPersonnel.Visible = MainForm.user.ModuleAcces.Contains(this.btnPersonnel.Text);
			this.btnservices.Visible = MainForm.user.ModuleAcces.Contains(this.btnservices.Text);
			this.btnChambres.Visible = MainForm.user.ModuleAcces.Contains(this.btnChambres.Text);
			this.btnUtilisateurs.Visible = MainForm.user.ModuleAcces.Contains(this.btnUtilisateurs.Text);
			random = new Random();
//			con.Open();
			String req = "select count(*) as Chambre_disponible from chambre where Etat = 'Disponible'";
			
			MySqlCommand comd = new MySqlCommand(req,con);
			
			MySqlDataReader readr = comd.ExecuteReader();
			readr.Read();
			this.labChamD.Text = readr["Chambre_disponible"].ToString()+" Chambres disponible";
			readr.Close();
			
			
			String re = "select count(*) as 'Service_disponible' from services where Etat = 'Disponible'";
			MySqlCommand com = new MySqlCommand(re,con);
			MySqlDataReader reader = com.ExecuteReader();
			reader.Read();
			this.labSerDis.Text = (reader.HasRows ? reader["Service_disponible"].ToString() : "0")+" Services disponible";
			reader.Close();
			
			String reqt = "select count(noDossier) as 'Patient_Enregistre' from dossiers";
			MySqlCommand commd = new MySqlCommand(reqt,con);
			MySqlDataReader rder = commd.ExecuteReader();
			rder.Read();
			this.labPatEnreg.Text = (rder.HasRows ? rder["Patient_Enregistre"].ToString() : "1")+" Patients enregistré";
			rder.Close();
			
			String reqAs = "select count(noDossPat) as 'Patient_Assure' from consultation where HospAss = 'Oui'";
			MySqlCommand cmd = new MySqlCommand(reqAs,con);
			MySqlDataReader rdr = cmd.ExecuteReader();
			rdr.Read();
			this.labHosAss.Text = (rdr.HasRows ? rdr["Patient_Assure"].ToString() : "2")+" sur assurance";
			rdr.Close();
			String reqhos = "select count(noDossPat) as 'Patient_hospitalise' from consultation where necHospitalisation = 'Oui'";
			MySqlCommand cmmd = new MySqlCommand(reqhos,con);
			MySqlDataReader redr = cmmd.ExecuteReader();
			redr.Read();
			this.labHosp.Text = (redr.HasRows ? redr["Patient_hospitalise"].ToString() : "3")+" hospitalisé";
			redr.Close();
			
			String reqUt = "select count(idEmp) as 'Employe' from utilisateurs";
			MySqlCommand comm = new MySqlCommand(reqUt,con);
			MySqlDataReader reder = comm.ExecuteReader();
			reder.Read();
			this.labUtilEn.Text = (reder.HasRows ? reder["Employe"].ToString() : "4")+" utilisateurs enregistré";
			reder.Close();
			
			String reqAd = "select count(idEmp) as 'Employe' from utilisateurs where pseudo = 'Admin'";
			MySqlCommand comde = new MySqlCommand(reqAd,con);
			MySqlDataReader reade = comde.ExecuteReader();
			reade.Read();
			this.labUtAdm.Text = (reade.HasRows ? reade["Employe"].ToString() : "5")+" Administrateur";
			reade.Close();
			
			String reqU = "select count(idEmp) as 'Employe' from utilisateurs where Etat = 'Inactif'";
			MySqlCommand commde = new MySqlCommand(reqU,con);
			MySqlDataReader rade = commde.ExecuteReader();
			rade.Read();
			this.labUtInac.Text = (rade.HasRows ? rade["Employe"].ToString() : "4")+" Utilisateur Inactif";
			con.Close();
			
		}
		
		     

		 
		//methods
		
		private Color SelectThemeColor(){
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index){
				random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}
		
		
		
		
		private void ActivateButton(object btnSender){
			if (btnSender != null)
			{
				Color color = SelectThemeColor();
				currentButton = (Button)btnSender;
				currentButton.BackColor = color;
				currentButton.ForeColor = Color.White;
				currentButton.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			}
			
			
		}
		
		private void disableButton(){
			foreach(Control dBtn in mainPanel.Controls){
				if (dBtn.GetType() == typeof(Button)){
					dBtn.BackColor = Color.FromArgb(160,70,120);
					dBtn.ForeColor = Color.Gainsboro;
					dBtn.Font = new System.Drawing.Font("Lucida Fax", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					
				}
			}
		}
		
		
		
		
		
		void SousPgPaint(object sender, PaintEventArgs e)
		{
	
		}
		private void BtnservicesClick(object sender, EventArgs e)
		{
			btnservices.BackColor = System.Drawing.Color.Cyan;
			ServiceType.NewService ser = new ServiceType.NewService();
			mainPanel.Controls.Add(ser);
            ser.BringToFront();
			
			
		}
		private void BtnChambresClick(object sender, EventArgs e)
		{
			btnChambres.BackColor = System.Drawing.Color.MediumSpringGreen;
			ChambreTr.NewChambre chb = new ChambreTr.NewChambre();
			mainPanel.Controls.Add(chb);
			chb.BringToFront();
			
		}
		private void BtnPersonnelClick(object sender, EventArgs e)
		{
			btnPersonnel.BackColor = System.Drawing.Color.Aquamarine;
			NewPersonel pers = new NewPersonel();
			mainPanel.Controls.Add(pers);
			pers.BringToFront();
		
		}
		private void BtnContratsClick(object sender, EventArgs e)
		{
			btnContrats.BackColor = System.Drawing.Color.SkyBlue;
			NewContrat contr = new NewContrat();
			mainPanel.Controls.Add(contr);
			contr.BringToFront();
		
			
		}
		private void BtnDossierClick(object sender, EventArgs e)
		{
			btnDossier.BackColor = System.Drawing.Color.LightSeaGreen;
			NewDossier dosr = new NewDossier();
			mainPanel.Controls.Add(dosr);
			dosr.BringToFront();
			
	
		}
		private void BtnConsultationsClick(object sender, EventArgs e)
		{
			btnConsultations.BackColor = System.Drawing.Color.MediumAquamarine;
			NewConsultation cons = new NewConsultation();
			mainPanel.Controls.Add(cons);
			cons.BringToFront();
	
		}
		private void BtnUtilisateursClick(object sender, EventArgs e)
		{
			btnUtilisateurs.BackColor = System.Drawing.Color.PowderBlue;
			UtilisateursTraitement util = new UtilisateursTraitement();
			NewUtilisateurs uti = new NewUtilisateurs();
			mainPanel.Controls.Add(uti);
			uti.BringToFront();
			
	
		}
		
		public menuPrincipal(ChambreTraitement chb) : this()
		{		
		}
		
		public menuPrincipal(Traitement.TraitementSer ser) : this()
		{		
		}

		void BtLogoutClick(object sender, EventArgs e)
		{
			
			Accueil ac = new Accueil();
			ac.Show();
			this.Close();
		}
		void LabdelmasClick(object sender, EventArgs e)
		{
	
		}
		
		
	}
}


