/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 14/10/2021
 * Time: 19:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.ChambreTr
{
	partial class NewChambre
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelNewChb;
		private System.Windows.Forms.Panel barOutilsCh;
		private System.Windows.Forms.Button btAjout;
		private System.Windows.Forms.Button btModifch;
		private System.Windows.Forms.DataGridView dataChamb;
		private System.Windows.Forms.DataGridViewTextBoxColumn txIch;
		private System.Windows.Forms.DataGridViewTextBoxColumn txTy;
		private System.Windows.Forms.DataGridViewTextBoxColumn txP;
		private System.Windows.Forms.DataGridViewTextBoxColumn tEtt;
		private System.Windows.Forms.DataGridViewTextBoxColumn txC;
		private System.Windows.Forms.DataGridViewTextBoxColumn txD;
		private System.Windows.Forms.DataGridViewTextBoxColumn txCou;
		private System.Windows.Forms.Button btSupp;
		private System.Windows.Forms.Button btRetCh;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNomCh;
		private System.Windows.Forms.Button bImprimer;
		private System.Drawing.Printing.PrintDocument ImprimerChambre;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDCh;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewChambre));
			this.panelNewChb = new System.Windows.Forms.Panel();
			this.dataChamb = new System.Windows.Forms.DataGridView();
			this.txIch = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txTy = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tEtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txCou = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNomCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barOutilsCh = new System.Windows.Forms.Panel();
			this.bImprimer = new System.Windows.Forms.Button();
			this.btRetCh = new System.Windows.Forms.Button();
			this.btSupp = new System.Windows.Forms.Button();
			this.btAjout = new System.Windows.Forms.Button();
			this.btModifch = new System.Windows.Forms.Button();
			this.ImprimerChambre = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDCh = new System.Windows.Forms.PrintPreviewDialog();
			this.panelNewChb.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataChamb)).BeginInit();
			this.barOutilsCh.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelNewChb
			// 
			this.panelNewChb.BackColor = System.Drawing.Color.White;
			this.panelNewChb.Controls.Add(this.dataChamb);
			this.panelNewChb.Controls.Add(this.barOutilsCh);
			this.panelNewChb.Location = new System.Drawing.Point(0, 0);
			this.panelNewChb.Name = "panelNewChb";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNewChb.Size = new System.Drawing.Size(903, 539);
			this.panelNewChb.TabIndex = 0;
			// 
			// dataChamb
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataChamb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataChamb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataChamb.BackgroundColor = System.Drawing.Color.White;
			this.dataChamb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataChamb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataChamb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.txIch,
			this.txTy,
			this.txP,
			this.tEtt,
			this.txC,
			this.txD,
			this.txCou,
			this.txNomCh});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataChamb.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataChamb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataChamb.GridColor = System.Drawing.SystemColors.Control;
			this.dataChamb.Location = new System.Drawing.Point(0, 30);
			this.dataChamb.Name = "dataChamb";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataChamb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dataChamb.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataChamb.Size = new System.Drawing.Size(903, 509);
			this.dataChamb.TabIndex = 6;
			this.dataChamb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChambCellContentClick);
			// 
			// txIch
			// 
			this.txIch.HeaderText = "IdChambre";
			this.txIch.Name = "txIch";
			// 
			// txTy
			// 
			this.txTy.HeaderText = "Type Chambre";
			this.txTy.Name = "txTy";
			// 
			// txP
			// 
			this.txP.HeaderText = "Prix location par jour";
			this.txP.Name = "txP";
			// 
			// tEtt
			// 
			this.tEtt.HeaderText = "Etat";
			this.tEtt.Name = "tEtt";
			// 
			// txC
			// 
			this.txC.HeaderText = "Constituants Chambre";
			this.txC.Name = "txC";
			// 
			// txD
			// 
			this.txD.HeaderText = "Description";
			this.txD.Name = "txD";
			// 
			// txCou
			// 
			this.txCou.HeaderText = "Couvrir par assurance";
			this.txCou.Name = "txCou";
			// 
			// txNomCh
			// 
			this.txNomCh.HeaderText = "Nom Chambre";
			this.txNomCh.Name = "txNomCh";
			// 
			// barOutilsCh
			// 
			this.barOutilsCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutilsCh.Controls.Add(this.bImprimer);
			this.barOutilsCh.Controls.Add(this.btRetCh);
			this.barOutilsCh.Controls.Add(this.btSupp);
			this.barOutilsCh.Controls.Add(this.btAjout);
			this.barOutilsCh.Controls.Add(this.btModifch);
			this.barOutilsCh.Dock = System.Windows.Forms.DockStyle.Top;
			this.barOutilsCh.Location = new System.Drawing.Point(0, 0);
			this.barOutilsCh.Name = "barOutilsCh";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.barOutilsCh.Size = new System.Drawing.Size(903, 30);
			this.barOutilsCh.TabIndex = 4;
			// 
			// bImprimer
			// 
			this.bImprimer.BackColor = System.Drawing.Color.White;
			this.bImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bImprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.bImprimer.Location = new System.Drawing.Point(393, 5);
			this.bImprimer.Name = "bImprimer";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bImprimer.Size = new System.Drawing.Size(147, 26);
			this.bImprimer.TabIndex = 7;
			this.bImprimer.Text = "ImprimerChambre";
			this.bImprimer.UseVisualStyleBackColor = false;
			this.bImprimer.Click += new System.EventHandler(this.BImprimerClick);
			// 
			// btRetCh
			// 
			this.btRetCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btRetCh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btRetCh.FlatAppearance.BorderSize = 0;
			this.btRetCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRetCh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRetCh.ForeColor = System.Drawing.Color.White;
			this.btRetCh.Location = new System.Drawing.Point(540, 6);
			this.btRetCh.Name = "btRetCh";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btRetCh.Size = new System.Drawing.Size(130, 26);
			this.btRetCh.TabIndex = 6;
			this.btRetCh.Text = "Retour";
			this.btRetCh.UseVisualStyleBackColor = false;
			this.btRetCh.Click += new System.EventHandler(this.BtRetChClick);
			// 
			// btSupp
			// 
			this.btSupp.BackColor = System.Drawing.Color.White;
			this.btSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btSupp.Location = new System.Drawing.Point(247, 5);
			this.btSupp.Name = "btSupp";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btSupp.Size = new System.Drawing.Size(147, 26);
			this.btSupp.TabIndex = 2;
			this.btSupp.Text = "SupprimerChambre";
			this.btSupp.UseVisualStyleBackColor = false;
			this.btSupp.Click += new System.EventHandler(this.BtSuppClick);
			// 
			// btAjout
			// 
			this.btAjout.BackColor = System.Drawing.Color.White;
			this.btAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btAjout.Location = new System.Drawing.Point(0, 5);
			this.btAjout.Name = "btAjout";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btAjout.Size = new System.Drawing.Size(125, 27);
			this.btAjout.TabIndex = 0;
			this.btAjout.Text = "AjouterChambre";
			this.btAjout.UseVisualStyleBackColor = false;
			this.btAjout.Click += new System.EventHandler(this.BtAjoutClick);
			// 
			// btModifch
			// 
			this.btModifch.BackColor = System.Drawing.Color.White;
			this.btModifch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btModifch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btModifch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btModifch.Location = new System.Drawing.Point(121, 5);
			this.btModifch.Name = "btModifch";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btModifch.Size = new System.Drawing.Size(130, 27);
			this.btModifch.TabIndex = 1;
			this.btModifch.Text = "ModifierChambre";
			this.btModifch.UseVisualStyleBackColor = false;
			this.btModifch.Click += new System.EventHandler(this.BtModifchClick);
			// 
			// ImprimerChambre
			// 
			this.ImprimerChambre.DocumentName = "documentCh";
			this.ImprimerChambre.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimerChambrePrintPage);
			// 
			// printPreviewDCh
			// 
			this.printPreviewDCh.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDCh.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDCh.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDCh.Document = this.ImprimerChambre;
			this.printPreviewDCh.Enabled = true;
			this.printPreviewDCh.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDCh.Icon")));
			this.printPreviewDCh.Name = "printPreviewDialog1";
			this.printPreviewDCh.Visible = false;
			// 
			// NewChambre
			// 
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(780, 456);
			this.Controls.Add(this.panelNewChb);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "NewChambre";
			this.Text = "NewChambre";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelNewChb.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataChamb)).EndInit();
			this.barOutilsCh.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
