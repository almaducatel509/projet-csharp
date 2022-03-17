/*
 * Created by SharpDevelop.
 * User: Fl3m
 * Date: 14-Oct-21
 * Time: 9:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using iTextSharp.text.pdf;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;


namespace HopitalEspoirDelmas.consultationTr
{
	/// Description of NewConsultation
	
	public partial class NewConsultation : 	Panel
	{
		MySqlConnection con = null;
		MySqlCommand comd = null;
		
		MySqlDataAdapter adap = null;
	
		ViewConsultation vwcsl = new ViewConsultation();
		ConsultationTraitement cons = new ConsultationTraitement();
		
		public NewConsultation()
		{
			InitializeComponent();
			
			foreach(ConsultationTraitement cons in ViewConsultation.getAll()){
				
				this.dataConsult.Rows.Add(cons.Idcons,cons.NoDosspat,cons.ConsultationServices,cons.PaiementConsAss,
				                         cons.MotifCons, cons.NecHospitalisation,cons.HospAss,cons.IdChambre,cons.DureeHosp,cons.Medecin,
				                         cons.DateConsul,cons.DateHospitalisation);
			}
			
			 docPdf = new PrintDialog();
           	 printer = new PrintDocument();
             printer.PrintPage += drawPDF;
			
			
			
		}
		private void DataServCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int consulA = dataConsult.CurrentCell.RowIndex;
			String Idcons = ""+dataConsult.Rows[consulA].Cells[0].Value;
			if(e.ColumnIndex == 11){
				DbHopitalEs.Connection();
			}
		}
		
					
		
		void BtBarcons1Click(object sender, EventArgs e)
		{
			bool tester = false;
			barOutilons.Visible=false;
			consultation consul = new consultation();
			panelconsul.Controls.Add(consul);
			consul.BringToFront();
		
			if(tester)
			{
				if(ViewConsultation.EnregistrerConsultation(cons) == 1)
				{
					MessageBox.Show("Consultation enregistre avec succes!","EnregistrerConsultation");
				}
				
			}
			
		}

		void BtRetClick(object sender, EventArgs e)
		{
		    this.Hide();
			NewConsultation nwc =new NewConsultation();
			nwc.Visible = false;
			
		}
		
		void PanelconsulPaint(object sender, PaintEventArgs e)
		{
	
		}
		
		  protected PrintDialog docPdf;
          protected PrintDocument printer;
        
        
        private void drawPDF(object sender, PrintPageEventArgs e)
        {
			e.Graphics.DrawImage(bitmap, 0,0);
        }
        Bitmap bitmap;
		void BtImprimerConsClick(object sender, EventArgs e)
		{
			barOutilons.Visible=false;
			int consl = dataConsult.CurrentCell.RowIndex;
			String IdCons = ""+dataConsult.Rows[consl].Cells[0].Value;
			ConsultationTraitement consul = new ConsultationTraitement();
					
			ViewConsultation consult = new ViewConsultation();
				
					consul.Idcons = int.Parse(dataConsult.Rows[consl].Cells[0].Value.ToString());
					consul.NoDosspat = int.Parse(dataConsult.Rows[consl].Cells[1].Value.ToString());
					consul.ConsultationServices = dataConsult.Rows[consl].Cells[2].Value.ToString();
					consul.PaiementConsAss = dataConsult.Rows[consl].Cells[3].Value.ToString();
					consul.MotifCons = dataConsult.Rows[consl].Cells[4].Value.ToString();
					consul.NecHospitalisation = dataConsult.Rows[consl].Cells[5].Value.ToString();
					consul.HospAss = dataConsult.Rows[consl].Cells[6].Value.ToString();
					consul.IdChambre = dataConsult.Rows[consl].Cells[7].Value.ToString();
					consul.DureeHosp = int.Parse(dataConsult.Rows[consl].Cells[8].Value.ToString());
					consul.Medecin = dataConsult.Rows[consl].Cells[9].Value.ToString();
					consul.DateConsul = dataConsult.Rows[consl].Cells[10].Value.ToString();
					consul.DateHospitalisation = dataConsult.Rows[consl].Cells[11].Value.ToString();
					
					
					dataConsult.Visible = false;
					ShowConsultation cons = new ShowConsultation(consul);
//					ViewConsultation.updateCons(consul);
					panelconsul.Controls.Add(cons);
					cons.BringToFront();
					cons.Show();
			
			BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
		 	iTextSharp.text.Font f1_15_bold = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.BOLD);
			iTextSharp.text.Font f1_12_normal = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.NORMAL);
			
			
			//----------------------
		}
		void BtModClick(object sender, EventArgs e)
		{
			barOutilons.Visible=false;
			bool tester = false;
			MySqlConnection con = DbHopitalEs.Connection();
			int consl = dataConsult.CurrentCell.RowIndex;
			String IdCons = ""+dataConsult.Rows[consl].Cells[0].Value;
				ConsultationTraitement consul = new ConsultationTraitement();
					
				ViewConsultation consult = new ViewConsultation();
				
					consul.Idcons = int.Parse(dataConsult.Rows[consl].Cells[0].Value.ToString());
					consul.NoDosspat = int.Parse(dataConsult.Rows[consl].Cells[1].Value.ToString());
					consul.ConsultationServices = dataConsult.Rows[consl].Cells[2].Value.ToString();
					consul.PaiementConsAss = dataConsult.Rows[consl].Cells[3].Value.ToString();
					consul.MotifCons = dataConsult.Rows[consl].Cells[4].Value.ToString();
					consul.NecHospitalisation = dataConsult.Rows[consl].Cells[5].Value.ToString();
					consul.HospAss = dataConsult.Rows[consl].Cells[6].Value.ToString();
					consul.IdChambre = dataConsult.Rows[consl].Cells[7].Value.ToString();
					consul.DureeHosp = int.Parse(dataConsult.Rows[consl].Cells[8].Value.ToString());
					consul.Medecin = dataConsult.Rows[consl].Cells[9].Value.ToString();
					consul.DateConsul = dataConsult.Rows[consl].Cells[10].Value.ToString();
					consul.DateHospitalisation = dataConsult.Rows[consl].Cells[11].Value.ToString();
					
					
					
					consultation cons = new consultation(consul);
					//ViewConsultation.updateCons(consul);
					panelconsul.Controls.Add(cons);
					cons.BringToFront();
					cons.Show();
					
					
		}
		
		void TxRecherTextChanged(object sender, EventArgs e)
		{
			
			string txt = ((TextBox) sender).Text;
			for(int i = 0; i < dataConsult.Rows.Count; i++){
				
				dataConsult.Rows[i].Visible = txt.Length == 0 || dataConsult.Rows[i].Cells[2].Value.ToString().ToLower().Contains(txt.ToLower());
				dataConsult.Rows[i].Visible = txt.Length == 0 || dataConsult.Rows[i].Cells[4].Value.ToString().ToLower().Contains(txt.ToLower());
				dataConsult.Rows[i].Visible = txt.Length == 0 || dataConsult.Rows[i].Cells[9].Value.ToString().ToLower().Contains(txt.ToLower());
				
			}
				
				
		}
		
		
		}
}
