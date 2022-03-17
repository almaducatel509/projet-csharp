/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 14/10/2021
 * Time: 19:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using HopitalEspoirDelmas.baseHopital;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Linq;
using iTextSharp.text.pdf;
using HopitalEspoirDelmas.container;
namespace HopitalEspoirDelmas.contratTr
{
	
	

	/// <summary>
	/// Description of NewContrat.
	/// </summary>
	public partial class NewContrat : Panel
	{
		
				MySqlConnection con = null;
				MySqlCommand comd = null;
				MySqlDataReader readr = null;
				MySqlDataAdapter adap = null;
				
				ContratTraitement contr = new ContratTraitement();
				ViewContrat vwc = new ViewContrat();
		public NewContrat()
		{
			
				MySqlConnection con = DbHopitalEs.Connection();
				InitializeComponent();
				foreach (ContratTraitement contr in  ViewContrat.getAll()) {
					this.dataContr.Rows.Add( contr.NomCompAs, contr.SigleCompAs, contr.NomDir, contr.Adresse, contr.Tlf, contr.Email,
						contr.PourcentageCons, contr.PourcentageChambre,contr.IdContrats, contr.PourcentageHosp, contr.Etat);
				}
			
				docPdf = new PrintDialog();
			    printer = new PrintDocument();
			    printer.PrintPage += drawPDF;
			
		}
		
		
	private void DataContrCellContentClick(object sender, DataGridViewCellEventArgs e)
	{
				int cntAf = dataContr.CurrentCell.RowIndex;
				String idContrats = "" + dataContr.Rows[cntAf].Cells[0].Value;
				if (e.ColumnIndex == 11) {
					DbHopitalEs.Connection();
					
				}
	}
		
					bool tester = false;
	private void BtContClick(object sender, EventArgs e)
	{
				barOutilsC.Visible =false;
				ContratTraitement contr = new ContratTraitement();
				ViewContrat vwc = new ViewContrat();
				
				contrats cont = new contrats();
				panelContrat.Controls.Add(cont);
				cont.BringToFront();

				if (tester) {
					if (ViewContrat.EnregistrerContrat(contr) == 1) {
						MessageBox.Show("Contrat enregistrer avec succes!", "EnregistrerContrat");
						
					}
				}
			
	}
		
	private void BtModifconClick(object sender, EventArgs e)
	{
				barOutilsC.Visible =false;
				
				MySqlConnection con = DbHopitalEs.Connection();
				int contUp =dataContr.CurrentCell.RowIndex;
				String idContrats = ""+dataContr.Rows[contUp].Cells[8].Value;
				ContratTraitement contra = new ContratTraitement();
					
				ViewContrat cont = new ViewContrat();
			
				
				contra.NomCompAs = ""+dataContr.Rows[contUp].Cells[0].Value;
				contra.SigleCompAs = ""+dataContr.Rows[contUp].Cells[1].Value;
				contra.NomDir = ""+dataContr.Rows[contUp].Cells[2].Value;
				contra.Adresse = ""+dataContr.Rows[contUp].Cells[3].Value;
				contra.Tlf = ""+dataContr.Rows[contUp].Cells[4].Value;
				contra.Email = ""+dataContr.Rows[contUp].Cells[5].Value;
				contra.PourcentageCons = double.Parse(dataContr.Rows[contUp].Cells[6].Value+"");
				contra.PourcentageChambre = double.Parse(dataContr.Rows[contUp].Cells[7].Value+"");
				contra.IdContrats = int.Parse(""+dataContr.Rows[contUp].Cells[8].Value);
				contra.PourcentageHosp = double.Parse(dataContr.Rows[contUp].Cells[9].Value+"");
				contra.Etat = ""+dataContr.Rows[contUp].Cells[10].Value;
					
				contrats contr = new contrats(contra);
				panelContrat.Controls.Add(contr);
				contr.BringToFront();
				ViewContrat.updateContr(contra);
				
					
					
					
			
				}
					
		
	void BtSuppCClick(object sender, EventArgs e)
	{
				barOutilsC.Visible =false;
				MySqlConnection con = DbHopitalEs.Connection();
				int chSup = dataContr.CurrentCell.RowIndex;
				String idContrat = "" + dataContr.Rows[chSup].Cells[8].Value;
			
				
			
			if (MessageBox.Show("Voulez-vous vraiment supprimer Ce contrat?", "Confimer",
				    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				
				ViewContrat vc = new ViewContrat();
				if (vc.DelService(idContrat) == 1) {
					MessageBox.Show("Suppression!", "Succes");
				}
				
				NewContrat np = new NewContrat();
				np.Show();				
			}
	}
	void BtRetCClick(object sender, EventArgs e)
	{
			this.Hide();
			NewContrat nwc = new NewContrat();
			nwc.Visible = false;
	}
		
	void NewContratLoad(object sender, EventArgs e)
	{
	
	}
		
		 protected PrintDialog docPdf;
         protected PrintDocument printer;
        
        
        private void drawPDF(object sender, PrintPageEventArgs e)
        {
			e.Graphics.DrawImage(bitmap, 0,0);
        }
        Bitmap bitmap;
		void BtImpmrClick(object sender, EventArgs e)
		{
			barOutilsC.Visible =false;
			BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
		 	iTextSharp.text.Font f1_15_bold = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.BOLD);
			iTextSharp.text.Font f1_12_normal = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.NORMAL);
			
			int hauteur = dataContr.Height;
		    bitmap = new Bitmap(dataContr.Width, dataContr.Height);
			dataContr.Height = dataContr.RowCount * dataContr.RowTemplate.Height*2;
			dataContr.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0,0, dataContr.Width, dataContr.Height));
			dataContr.Height = hauteur;
			
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
		}
	}
}
