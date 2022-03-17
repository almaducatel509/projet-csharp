/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 30/10/2021
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using itextsharp.pdfa;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace HopitalEspoirDelmas.dossierTr
{
	/// <summary>
	/// Description of NewDossier.
	/// </summary>
	public partial class NewDossier : Panel
	{
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
	
		ViewDossiers vwd = new ViewDossiers();
		DossiersTraitement dosr = new DossiersTraitement();
		public NewDossier()
		{
			
			InitializeComponent();
			foreach(DossiersTraitement dosr in ViewDossiers.getAll()){
				this.dataDoss.Rows.Add(dosr.NoDossier, dosr.NomPatient,dosr.Prenom,
				                       dosr.Sexe, dosr.DateNaiss,dosr.Age,dosr.CompAssure,
				                       dosr.PersResp,dosr.NumeroPers,dosr.Adres,dosr.Telephone,dosr.Mail,
				                       dosr.TrtSuivi, dosr.Memo);
			}
			
			docPdf = new PrintDialog();
            printer = new PrintDocument();
            printer.PrintPage += drawPDF;
			
		}
		
		bool tester;
		void BtAjoutDosClick(object sender, EventArgs e)
		{
			barOutils.Visible = false;
			
			MySqlConnection con = DbHopitalEs.Connection();
			dossiers de = new dossiers();
			panelDoss.Controls.Add(de);
			de.BringToFront();
			
			
			
	
			if(tester)
			{
				if(ViewDossiers.EnregistrerPatient(dosr) == 1)
				{
				MessageBox.Show("Patient enregistrer avec succes!","EnregistrerPatient");
				}
				
			}
			
		}
		void BtModDosClick(object sender, EventArgs e)
		{
			barOutils.Visible = false;
			
			bool tester = false;
			MySqlConnection con = DbHopitalEs.Connection();
			int dosAf = dataDoss.CurrentCell.RowIndex;
			String NoDossier = ""+dataDoss.Rows[dosAf].Cells[0].Value;
			DossiersTraitement dos = new DossiersTraitement();
			ViewDossiers dosir = new ViewDossiers();
		
			dos.NoDossier = int.Parse(dataDoss.Rows[dosAf].Cells[0].Value.ToString());
			dos.NomPatient= ""+dataDoss.Rows[dosAf].Cells[1].Value;
			dos.Prenom= ""+dataDoss.Rows[dosAf].Cells[2].Value;
			dos.Sexe= ""+dataDoss.Rows[dosAf].Cells[3].Value;
			dos.DateNaiss= ""+dataDoss.Rows[dosAf].Cells[4].Value;
			dos.Age= int.Parse(""+dataDoss.Rows[dosAf].Cells[5].Value);
			dos.CompAssure= ""+dataDoss.Rows[dosAf].Cells[6].Value;
			dos.PersResp= ""+dataDoss.Rows[dosAf].Cells[7].Value;
			dos.NumeroPers= ""+dataDoss.Rows[dosAf].Cells[8].Value;
			dos.Adres= ""+dataDoss.Rows[dosAf].Cells[9].Value;
			dos.Telephone= ""+dataDoss.Rows[dosAf].Cells[10].Value;
			dos.Mail= ""+dataDoss.Rows[dosAf].Cells[11].Value;
			dos.TrtSuivi= ""+dataDoss.Rows[dosAf].Cells[12].Value;
			dos.Memo= ""+dataDoss.Rows[dosAf].Cells[13].Value;
			
			
			dossiers dosie = new dossiers(dos);
			ViewDossiers.updateD(dos);
			panelDoss.Controls.Add(dosie);
			dosie.BringToFront();
			dosie.Show();
		}
//		void BtTraitSuiviClick(object sender, EventArgs e)
//		{
//			MySqlConnection con = new MySqlConnection();
//			MySqlCommand comd = new MySqlCommand("select txTrait from dossiers where");
//		}
		
		protected PrintDialog docPdf;
        protected PrintDocument printer;
        
        
        private void drawPDF(object sender, PrintPageEventArgs e)
        {
			e.Graphics.DrawImage(bitmap, 0,0);
        }
		Bitmap bitmap;
		void BtImprimerDosClick(object sender, EventArgs e)
		{
			barOutils.Visible = false;
			int dosAf = dataDoss.CurrentCell.RowIndex;
			
			if(dosAf < 0) return;
			
			String NoDossier = ""+dataDoss.Rows[dosAf].Cells[0].Value;
			DossiersTraitement dos = new DossiersTraitement();
				
			dos.NoDossier = int.Parse(dataDoss.Rows[dosAf].Cells[0].Value.ToString());
			dos.NomPatient= ""+dataDoss.Rows[dosAf].Cells[1].Value;
			dos.Prenom= ""+dataDoss.Rows[dosAf].Cells[2].Value;
			dos.Sexe= ""+dataDoss.Rows[dosAf].Cells[3].Value;
			dos.DateNaiss= ""+dataDoss.Rows[dosAf].Cells[4].Value;
			dos.Age= int.Parse(""+dataDoss.Rows[dosAf].Cells[5].Value);
			dos.CompAssure= ""+dataDoss.Rows[dosAf].Cells[6].Value;
			dos.PersResp= ""+dataDoss.Rows[dosAf].Cells[7].Value;
			dos.NumeroPers= ""+dataDoss.Rows[dosAf].Cells[8].Value;
			dos.Adres= ""+dataDoss.Rows[dosAf].Cells[9].Value;
			dos.Telephone= ""+dataDoss.Rows[dosAf].Cells[10].Value;
			dos.Mail= ""+dataDoss.Rows[dosAf].Cells[11].Value;
			dos.TrtSuivi= ""+dataDoss.Rows[dosAf].Cells[12].Value;
			dos.Memo= ""+dataDoss.Rows[dosAf].Cells[13].Value;
			
			
			ShowDossiers dossier = new ShowDossiers(dos);
			panelDoss.Controls.Add(dossier);
			dossier.BringToFront();
			dossier.Show();
			
		}
		void BtRetDosClick(object sender, EventArgs e)
		{
			this.Hide();
			NewDossier nwd = new NewDossier();
			nwd.Visible = false;
		}
		void DataDossCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int dosAf = dataDoss.CurrentCell.RowIndex;
			String NoDossier = ""+dataDoss.Rows[dosAf].Cells[0].Value;
			if(e.ColumnIndex == 14){
				DbHopitalEs.Connection();
			}
		}
	}
}
