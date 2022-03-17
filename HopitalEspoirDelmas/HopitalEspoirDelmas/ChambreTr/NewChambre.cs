/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 14/10/2021
 * Time: 19:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using iTextSharp.text.pdf;
using System.Linq;


namespace HopitalEspoirDelmas.ChambreTr
{
	/// <summary>
	/// Description of NewChambre.
	/// </summary>
	public partial class NewChambre : Panel
	{
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
		ChambreTraitement chb = new ChambreTraitement();
		ViewChambre vch = new ViewChambre();
		public NewChambre()
		{
			
			InitializeComponent();
			
			

			foreach(ChambreTraitement chb in ViewChambre.getAll()){
				this.dataChamb.Rows.Add(chb.IdChambre, chb.TypeChambre,chb.PrixLocationParJour,chb.Etat,
				                       chb.ConstituantChambre, chb.Description,chb.CouvrirParAssurance, chb.NomChambre);
			}
			
			
            docPdf = new PrintDialog();
            printer = new PrintDocument();
            printer.PrintPage += drawPDF;
			
		}
		
		public  void DataChambCellContentClick(object sender, DataGridViewCellEventArgs e){
			
			int chMod = dataChamb.CurrentCell.RowIndex;
			String idChambre = ""+dataChamb.Rows[chMod].Cells[0].Value;
			if(e.ColumnIndex == 8)
			{
				DbHopitalEs.Connection();
			}
			
			
		}
		void BtAjoutClick(object sender, EventArgs e)
		{
			barOutilsCh.Visible = false;
			bool tester = false;
			ChambreTraitement chb = new ChambreTraitement();
			ViewChambre vch = new ViewChambre();
			
			chambre ch = new chambre();
			panelNewChb.Controls.Add(ch);
			ch.BringToFront();
			
			
			if(tester)
			{
				if(ViewChambre.EnregistrerChambre(chb) == 1)
				{
					MessageBox.Show("Chambre enregistrer avec succes!","EnregistrerChambre");
					
				}
			}
		}
		void BtModifchClick(object sender, EventArgs e)
		{
			barOutilsCh.Visible = false;
			
			MySqlConnection con = DbHopitalEs.Connection();
			int chMod =dataChamb.CurrentCell.RowIndex;
			String idChambre = ""+dataChamb.Rows[chMod].Cells[0].Value;
				
				ChambreTraitement chamb = new ChambreTraitement();
				
				ViewChambre chanb = new ViewChambre();
						
						chamb.IdChambre = int.Parse(dataChamb.Rows[chMod].Cells[0].Value.ToString());
						chamb.TypeChambre = ""+dataChamb.Rows[chMod].Cells[1].Value;
						chamb.PrixLocationParJour = double.Parse(""+dataChamb.Rows[chMod].Cells[2].Value);
						chamb.Etat = ""+dataChamb.Rows[chMod].Cells[3].Value;
						chamb.ConstituantChambre = ""+dataChamb.Rows[chMod].Cells[4].Value;
						chamb.Description = ""+dataChamb.Rows[chMod].Cells[5].Value;
						chamb.CouvrirParAssurance = ""+dataChamb.Rows[chMod].Cells[6].Value;
						chamb.NomChambre = ""+dataChamb.Rows[chMod].Cells[7].Value;
						
						chambre ch = new chambre(chamb);
						panelNewChb.Controls.Add(ch);
						ch.BringToFront();
						ViewChambre.updateCh(chamb);
						
						
					
					
		}
					
	void BtSuppClick(object sender, EventArgs e)
	{
			
			barOutilsCh.Visible = false;MySqlConnection con = DbHopitalEs.Connection();
			int chSup =dataChamb.CurrentCell.RowIndex;
			String idChambre = ""+dataChamb.Rows[chSup].Cells[0].Value;
			
				
			
			if(MessageBox.Show("Voulez-vous vraiment supprimer Cette chambre?", "Confimer",
			        			MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
				{
				
				ViewChambre vwch = new ViewChambre();
					if (vwch.DelChambre(idChambre) == 1) {
						MessageBox.Show("Suppression!", "Succes");
					}
				NewChambre nc = new NewChambre();
				nc.Show();
			}
					
	}
		
		public void BtRetChClick(object sender, EventArgs e)
		{
			this.Hide();
			NewChambre nwch = new NewChambre();
			nwch.Visible = false;
			
		}
		
		//----------------------------------------
		
        protected PrintDialog docPdf;
        protected PrintDocument printer;
        
        
        private void drawPDF(object sender, PrintPageEventArgs e)
        {
			e.Graphics.DrawImage(bitmap, 0,0);
        }
        
        //----------------------------------------
		
		Bitmap bitmap;
		private void BImprimerClick(object sender, EventArgs e){
		
			barOutilsCh.Visible = false;
			// MySqlConnection con = DbHopitalEs.Connection();
			
			BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
		 	iTextSharp.text.Font f1_15_bold = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.BOLD);
			iTextSharp.text.Font f1_12_normal = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.NORMAL);
			
			 int hauteur = dataChamb.Height;
		    bitmap = new Bitmap(dataChamb.Width, dataChamb.Height);
			dataChamb.Height = dataChamb.RowCount * dataChamb.RowTemplate.Height*2;
			dataChamb.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0,0, dataChamb.Width, dataChamb.Height));
			dataChamb.Height = hauteur;
			
			//--------------------------------------------------------------
			
            
			if (docPdf.ShowDialog() == DialogResult.OK)
            {
                docPdf.Document = printer;
                docPdf.PrintToFile = true;
                docPdf.UseEXDialog = false;
                printer.Print();
				MessageBox.Show("Impression effectue");
            }
			else{
				MessageBox.Show("Impression echouer");
			}
			//--------------------------------------------------------------
			
			
		}
		
	  private void ImprimerChambrePrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
//			e.Graphics.DrawImage(bitmap, 0,0);
	
		}
	}
	  
	  
	
}

