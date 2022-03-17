/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 09/11/2021
 * Time: 14:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using HopitalEspoirDelmas.dossierTr;
using HopitalEspoirDelmas.baseHopital;
namespace HopitalEspoirDelmas.container
{
	/// <summary>
	/// Description of ShowDossiers.
	/// </summary>
	public partial class ShowDossiers : Panel
	{
		DossiersTraitement dosr = new DossiersTraitement();
		ViewDossiers vwd = new ViewDossiers();

		Bitmap bitmap;
		public  ShowDossiers(DossiersTraitement dosr)
		{
			
			InitializeComponent();
			
			
			panelShowDos.ForeColor = Color.Black;
			txtNodoss.Text = ""+dosr.NoDossier;
			txNom.Text =  dosr.NomPatient;
			txPrenom.Text =  dosr.Prenom;
			txSexe.Text =  dosr.Sexe;
			txAdresse.Text =  dosr.Adres;
			txDate.Text =  dosr.DateNaiss;
			txCompAssure.Text =  dosr.CompAssure;
			txNumPers.Text =  dosr.NumeroPers;
			txPersResp.Text =  dosr.PersResp;
			txEmail.Text =  dosr.Mail;
			txTel.Text = dosr.Telephone;
			txMemo.Text = dosr.Memo;
			txTraitem.Text = dosr.TrtSuivi;
			txAge.Text = ""+dosr.Age;
		
			
			docPdf = new PrintDialog();
            printer = new PrintDocument();
            printer.PrintPage += drawPDF;
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtAffDosClick(object sender, EventArgs e)
		{
			bool t = false;
			if(ViewDossiers.EnregistrerPatient(dosr)== 1){
				
			}
			
			this.Hide();
			ViewDossiers vwd = new ViewDossiers();
			
		}

		  protected PrintDialog docPdf;
          protected PrintDocument printer;

		void BtImpDosClick(object sender, EventArgs e)
		{
			
			int hauteur = panelShowDos.Height;
		    bitmap = new Bitmap(panelShowDos.Width, panelShowDos.Height);
			panelShowDos.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0,0, panelShowDos.Width, panelShowDos.Height));
			panelShowDos.Height = hauteur;
			
			//--------------------------------------------------------------
			
            
			if (docPdf.ShowDialog() == DialogResult.OK)
            {
				 
				docPdf.Document = printer;
                docPdf.PrintToFile = true;
                docPdf.UseEXDialog = false;
                printer.Print();
                panelShowDos.ForeColor = Color.Black;
				MessageBox.Show("Impression effectue");
            }
			else{
				MessageBox.Show("Impression echouer");
			}
		}
		
        private void drawPDF(object sender, PrintPageEventArgs e)
        {
			e.Graphics.DrawImage(bitmap, 0,0);
        }
        
		void BtRetourClick(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TxSexeClick(object sender, EventArgs e)
		{
	
		}
		void TxDateClick(object sender, EventArgs e)
		{
	
		}
		void TxAgeClick(object sender, EventArgs e)
		{
	
		}
		void TxCompAssureClick(object sender, EventArgs e)
		{
	
		}
		void TxPersRespClick(object sender, EventArgs e)
		{
	
		}
		void TxNumPersClick(object sender, EventArgs e)
		{
	
		}
		void TxAdresseClick(object sender, EventArgs e)
		{
	
		}
		void TxEmailClick(object sender, EventArgs e)
		{
	
		}
		void TxTelClick(object sender, EventArgs e)
		{
	
		}
		void TxTraitemClick(object sender, EventArgs e)
		{
	
		}
		void TxMemoClick(object sender, EventArgs e)
		{
	
		}
		void TxtNodosClick(object sender, EventArgs e)
		{
	
		}
	}
}
