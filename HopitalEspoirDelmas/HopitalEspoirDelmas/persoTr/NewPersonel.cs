/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 15/10/2021
 * Time: 01:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HopitalEspoirDelmas.baseHopital;
using HopitalEspoirDelmas.container;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using itextsharp.pdfa;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Data;
namespace HopitalEspoirDelmas.persoTr
{
	/// <summary>
	/// Description of NewPersonel.
	/// </summary>
	public partial class NewPersonel : Panel
	{
		
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader readr = null;
		MySqlDataAdapter adap = null;
		
		
	
		public  NewPersonel()
		{
			
			InitializeComponent();
			
			foreach(PersonelsTraitement pers in ViewPersonels.getAll()){
				this.dataPers.Rows.Add(pers.IdPersonel, pers.Nom,pers.Prenom, pers.Adresse,pers.Sexe,
				                       pers.Categorie, pers.NifCin,pers.NombreAnneeExp, pers.DomaineEtude, 
					                   pers.NiveauEtude, pers.Specialisation, pers.DateNaissance, pers.ServicesAffectes,pers.Email,
					                    pers.Telephone, pers.Etat);
				
				}
				docPdf = new PrintDialog();
			    printer = new PrintDocument();
			    printer.PrintPage += drawPDF;
			
		}
		
		public  void DataPersCellContentClick(object sender, DataGridViewCellEventArgs e){
			
			int perAf = dataPers.CurrentCell.RowIndex;
			String idPersonel = ""+dataPers.Rows[perAf].Cells[0].Value;
			if(e.ColumnIndex == 16)
			{
				DbHopitalEs.Connection();
			}
			
			
		}
		
		
		
		
		void BtAjoutPClick(object sender, EventArgs e)
		{
			barOutilsP.Visible = false;
			PersonelsTraitement pers = new PersonelsTraitement();
			bool tester = false;
//			
			personels perso = new personels();
			panelPers.Controls.Add(perso);
			perso.BringToFront();
			
			
			//per.Show();
			
			
//			
			if(tester)
			{
				if(ViewPersonels.EnregistrerPersonel(pers) == 1)
				{
					MessageBox.Show("Personel enregistrer avec succes!","EnregistrerPersonel");
					
				}
			}
	
		}
		void BtAfchPClick(object sender, EventArgs e)
		{
			
			MySqlConnection con = DbHopitalEs.Connection();
			PersonelsTraitement pers = new PersonelsTraitement();
			
				int perA = dataPers.CurrentCell.RowIndex;
			if(ViewPersonels.EnregistrerPersonel(pers) == 1){
				
					
					
					pers.IdPersonel = int.Parse(readr["idPersonel"].ToString());
					pers.Nom = readr["nom"].ToString();
					pers.Prenom = readr["prenom"].ToString();
					pers.Adresse = readr["adresse"].ToString();
					pers.Sexe = readr["sexe"].ToString();
					pers.Categorie = readr["categorie"].ToString();
					pers.NifCin = readr["nifCin"].ToString();
					pers.NombreAnneeExp = int.Parse(readr["nombreAnneeExp"].ToString());
					pers.DomaineEtude = readr["domaineEtude"].ToString();
					pers.NiveauEtude = readr["niveauEtude"].ToString();
					pers.Specialisation = readr["specialisation"].ToString();
					pers.DateNaissance = readr["dateNaissance"].ToString();
					pers.ServicesAffectes = readr["servicesAffectes"].ToString();
					pers.Email = readr["email"].ToString();
					pers.Telephone = readr["telephone"].ToString();
					pers.Etat = readr["etat"].ToString();
					
				}
			
			
		}
		
		private void BtSuppClick(object sender, EventArgs e)
		{
			barOutilsP.Visible = false;
			MySqlConnection con = DbHopitalEs.Connection();
			int perSup =dataPers.CurrentCell.RowIndex;
			String idPersonel = ""+dataPers.Rows[perSup].Cells[0].Value;
			
				
			
				if(MessageBox.Show("Voulez-vous vraiment supprimer Ce personel?", "Confimer",
			                   MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
				{
				
				ViewPersonels per = new ViewPersonels();
					if (per.DelPersonel(idPersonel) == 1) {
						MessageBox.Show("Suppression!", "Succes");
					}
					
				//this.Hide();
				NewPersonel np = new NewPersonel();
				np.Show();
				}
				
			
		}
		void BtRetClick(object sender, EventArgs e)
		{
			this.Hide();
			NewPersonel nwp = new NewPersonel();
			nwp.Visible = false;
		}
		
		
		public void BtModClick(object sender, EventArgs e)
		{
			
			barOutilsP.Visible = false;
			bool tester = false;
			MySqlConnection con = DbHopitalEs.Connection();
			int perSup =dataPers.CurrentCell.RowIndex;
			String idPersonel = ""+dataPers.Rows[perSup].Cells[0].Value;
				PersonelsTraitement persont = new PersonelsTraitement();
					
				ViewPersonels perso = new ViewPersonels();
				
				
					
					persont.IdPersonel = int.Parse(dataPers.Rows[perSup].Cells[0].Value.ToString());
					persont.Nom = ""+dataPers.Rows[perSup].Cells[1].Value;
					persont.Prenom =""+dataPers.Rows[perSup].Cells[2].Value;
					persont.Adresse = ""+dataPers.Rows[perSup].Cells[3].Value;
					persont.Sexe = ""+dataPers.Rows[perSup].Cells[4].Value;
					persont.Categorie = ""+dataPers.Rows[perSup].Cells[5].Value;
					persont.NifCin = ""+dataPers.Rows[perSup].Cells[6].Value;
					persont.NombreAnneeExp = int.Parse(""+dataPers.Rows[perSup].Cells[7].Value);
					persont.DomaineEtude = ""+dataPers.Rows[perSup].Cells[8].Value;
					persont.NiveauEtude = ""+dataPers.Rows[perSup].Cells[9].Value;
					persont.Specialisation = ""+dataPers.Rows[perSup].Cells[10].Value;
					persont.DateNaissance = ""+dataPers.Rows[perSup].Cells[11].Value;
					persont.ServicesAffectes = ""+dataPers.Rows[perSup].Cells[12].Value;
					persont.Email = ""+dataPers.Rows[perSup].Cells[13].Value;
					persont.Telephone = ""+dataPers.Rows[perSup].Cells[14].Value;
					persont.Etat = ""+dataPers.Rows[perSup].Cells[15].Value;
					
					personels pers = new personels(persont);
					panelPers.Controls.Add(pers);
					pers.BringToFront();
					ViewPersonels.updateP(persont);
					pers.Show();
					
					
				
				}
		
				

		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			
		}
		 protected PrintDialog docPdf;
         protected PrintDocument printer;
        
        
        private void drawPDF(object sender, PrintPageEventArgs e)
        {
			e.Graphics.DrawImage(bitmap, 0,0);
        }
        	Bitmap bitmap;
		void BtImprimerPClick(object sender, EventArgs e)
		{
			barOutilsP.Visible = false;
			BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
		 	iTextSharp.text.Font f1_15_bold = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.BOLD);
			iTextSharp.text.Font f1_12_normal = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.NORMAL);
			
			int hauteur = dataPers.Height;
		    bitmap = new Bitmap(dataPers.Width, dataPers.Height);
			dataPers.Height = dataPers.RowCount * dataPers.RowTemplate.Height*2;
			dataPers.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0,0, dataPers.Width, dataPers.Height));
			dataPers.Height = hauteur;
			
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
