/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 10/10/2021
 * Time: 17:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using HopitalEspoirDelmas.Traitement;
using System.Threading.Tasks;
using System.Linq;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using iTextSharp.text.pdf;

namespace HopitalEspoirDelmas.ServiceType
{
	/// <summary>
	/// Description of NewService.
	/// </summary>
	public partial class NewService : Panel
	{
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
	
		ViewService vws = new ViewService();
		
		public NewService()
		{
			InitializeComponent();
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			foreach(TraitementSer trs in ViewService.getAll()){
				this.dataServ.Rows.Add(trs.IdService, trs.NomService,trs.PrixConsultation,
				                       trs.etat, trs.description,trs.couvrirParAssurance,trs.NomChefService);
			}
			
			docPdf = new PrintDialog();
            printer = new PrintDocument();
            printer.PrintPage += drawPDF;
		}
		
		
		private void DataServCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int serAf = dataServ.CurrentCell.RowIndex;
			String idService = ""+dataServ.Rows[serAf].Cells[0].Value;
			if(e.ColumnIndex == 7){
				DbHopitalEs.Connection();
			}
		}
		void NewServiceLoad(object sender, EventArgs e)
		{
	
		}
		bool tester;
		void Button1Click(object sender, EventArgs e)
		{
			barOutils.Visible=false;
			TraitementSer trs = new TraitementSer();
			services se = new services();
			panelServs.Controls.Add(se);
			se.BringToFront();
			
			if(tester)
			{
				if(ViewService.EnregistrerService(trs) == 1)
				{
					
					MessageBox.Show("Service enregistrer avec succes!","EnregistrerService");
					
				}
			}
		}
		
	
		void BtModSerClick(object sender, EventArgs e)
		{
			
			barOutils.Visible=false;
			int serv =dataServ.CurrentCell.RowIndex;
			String idService = ""+dataServ.Rows[serv].Cells[0].Value;
				TraitementSer trSer = new TraitementSer();
					
				trSer.IdService = int.Parse(dataServ.Rows[serv].Cells[0].Value.ToString());
				trSer.NomService = ""+dataServ.Rows[serv].Cells[1].Value;
				trSer.PrixConsultation = double.Parse(""+dataServ.Rows[serv].Cells[2].Value);
				trSer.etat = ""+dataServ.Rows[serv].Cells[3].Value;
				trSer.description = ""+dataServ.Rows[serv].Cells[4].Value;
				trSer.couvrirParAssurance = ""+dataServ.Rows[serv].Cells[5].Value;
				trSer.NomChefService = ""+dataServ.Rows[serv].Cells[6].Value;
				//this.Hide();
				services ser = new services(trSer);
				panelServs.Controls.Add(ser);
				ser.BringToFront();
				btBar1.Enabled = false;
				btImprimerSer.Enabled = false;
				btSuppS.Enabled = false;
				btModSer.Enabled = false;
				btRetS.Enabled = false;
				
				ViewService.updateSer(trSer);
				//ser.Show();
					
				
			
				
		
	}
		void BtRetSClick(object sender, EventArgs e)
		{
			this.Hide();
			NewService nws = new NewService();
			nws.Visible = false;
			
		}
		void BtSuppSClick(object sender, EventArgs e)
		{
			barOutils.Visible=false;
			int serSup =dataServ.CurrentCell.RowIndex;
			String idService = ""+dataServ.Rows[serSup].Cells[0].Value;
			
				
			
				if(MessageBox.Show("Voulez-vous vraiment supprimer Ce service?", "Confimer",
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
				{
				
					
				if (vws.DelService(idService) == 1) {
					MessageBox.Show("Suppression!", "Succes");
				}
				
	
				//this.Hide();
				NewService ns = new NewService();
				ns.Show();			
				}
		}
		
		protected PrintDialog docPdf;
        protected PrintDocument printer;
        
        
        private void drawPDF(object sender, PrintPageEventArgs e)
        {
			e.Graphics.DrawImage(bitmap, 0,0);
        }
		Bitmap bitmap;
		void BtImprimerSerClick(object sender, EventArgs e)
		{
				
			barOutils.Visible=false;
			BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
		 	iTextSharp.text.Font f1_15_bold = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.BOLD);
			iTextSharp.text.Font f1_12_normal = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.NORMAL);
			
			 int hauteur = dataServ.Height;
		    bitmap = new Bitmap(dataServ.Width, dataServ.Height);
			dataServ.Height = dataServ.RowCount * dataServ.RowTemplate.Height*2;
			dataServ.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0,0, dataServ.Width, dataServ.Height));
			dataServ.Height = hauteur;
			
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
