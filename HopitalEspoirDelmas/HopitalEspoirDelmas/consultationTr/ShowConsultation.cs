/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 10/11/2021
 * Time: 03:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using System.Drawing.Printing;
using HopitalEspoirDelmas.container;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace HopitalEspoirDelmas.consultationTr
{
	/// <summary>
	/// Description of ShowConsultation.
	/// </summary>
	public partial class ShowConsultation : Panel
	{
		ConsultationTraitement cons = new ConsultationTraitement();
		
		Bitmap bitmap;
		public ShowConsultation(ConsultationTraitement cons)
		{
			
			InitializeComponent();
			panelShowCons.ForeColor = Color.Black;
			txtidCons.Text = ""+cons.Idcons;
			txAss.Text = cons.PaiementConsAss;
			txConsSer.Text = cons.ConsultationServices;
			txDateCons.Text = ""+cons.DateConsul;
			txDuH.Text = ""+cons.DureeHosp;
			txHospAss.Text = cons.HospAss;
			txIdChamb.Text = cons.IdChambre;
			txMed.Text = cons.Medecin;
			txMotifCons.Text = cons.MotifCons;
			txNecess.Text = cons.NecHospitalisation;
			txNoDos.Text = ""+cons.NoDosspat;
			txDateHospita.Text = ""+cons.DateHospitalisation;
			
			 docPdf = new PrintDialog();
           	 printer = new PrintDocument();
             printer.PrintPage += drawPDF;
             
			
		}
		void BtRetourClick(object sender, EventArgs e)
		{
	
		}
		
		 protected PrintDialog docPdf;
         protected PrintDocument printer;
        
        
        private void drawPDF(object sender, PrintPageEventArgs e)
        {
			e.Graphics.DrawImage(bitmap, 0,0);
        }
		void BtImpriConsClick(object sender, EventArgs e)
		{
			
			 int hauteur = panelShowCons.Height;
		    bitmap = new Bitmap(panelShowCons.Width, panelShowCons.Height);
			panelShowCons.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0,0, panelShowCons.Width, panelShowCons.Height));
			panelShowCons.Height = hauteur;
			
			//--------------------------------------------------------------
			
            
			if (docPdf.ShowDialog() == DialogResult.OK)
            {
                docPdf.Document = printer;
                docPdf.PrintToFile = true;
                docPdf.UseEXDialog = false;
                printer.Print();
                panelShowCons.ForeColor = Color.Black;
				MessageBox.Show("Impression effectue");
            }
			else{
				MessageBox.Show("Impression echouer");
			}
		}
		void LabconsClick(object sender, EventArgs e)
		{
	
		}
	}
}
