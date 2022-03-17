/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 14/10/2021
 * Time: 19:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.contratTr
{
	partial class NewContrat
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelContrat;
		private System.Windows.Forms.Panel barOutilsC;
		private System.Windows.Forms.Button btCont;
		private System.Windows.Forms.Button btModifcon;
		private System.Windows.Forms.DataGridView dataContr;
		private System.Windows.Forms.DataGridViewTextBoxColumn txEtt;
		private System.Windows.Forms.DataGridViewTextBoxColumn txIdContr;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNomC;
		private System.Windows.Forms.DataGridViewTextBoxColumn txSg;
		private System.Windows.Forms.DataGridViewTextBoxColumn txDr;
		private System.Windows.Forms.DataGridViewTextBoxColumn txA;
		private System.Windows.Forms.DataGridViewTextBoxColumn txTl;
		private System.Windows.Forms.DataGridViewTextBoxColumn txM;
		private System.Windows.Forms.DataGridViewTextBoxColumn txP;
		private System.Windows.Forms.DataGridViewTextBoxColumn txPr;
		private System.Windows.Forms.DataGridViewTextBoxColumn txPo;
		private System.Windows.Forms.Button btSuppC;
		private System.Windows.Forms.Button btRetC;
		private System.Windows.Forms.Button btImpmr;
		//private System.Windows.Forms.Button button1;
		
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
		private void InitializeComponent(){
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelContrat = new System.Windows.Forms.Panel();
			this.dataContr = new System.Windows.Forms.DataGridView();
			this.txNomC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txSg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txDr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txTl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txIdContr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txPo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txEtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barOutilsC = new System.Windows.Forms.Panel();
			this.btCont = new System.Windows.Forms.Button();
			this.btImpmr = new System.Windows.Forms.Button();
			this.btModifcon = new System.Windows.Forms.Button();
			this.btRetC = new System.Windows.Forms.Button();
			this.btSuppC = new System.Windows.Forms.Button();
			this.panelContrat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataContr)).BeginInit();
			this.barOutilsC.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelContrat
			// 
			this.panelContrat.BackColor = System.Drawing.Color.White;
			this.panelContrat.Controls.Add(this.dataContr);
			this.panelContrat.Controls.Add(this.barOutilsC);
			this.panelContrat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContrat.Location = new System.Drawing.Point(0, 0);
			this.panelContrat.Name = "panelContrat";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContrat.Size = new System.Drawing.Size(872, 522);
			this.panelContrat.TabIndex = 0;
			// 
			// dataContr
			// 
			this.dataContr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataContr.BackgroundColor = System.Drawing.Color.White;
			this.dataContr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataContr.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.dataContr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataContr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.txNomC,
			this.txSg,
			this.txDr,
			this.txA,
			this.txTl,
			this.txM,
			this.txP,
			this.txPr,
			this.txIdContr,
			this.txPo,
			this.txEtt});
			this.dataContr.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataContr.Location = new System.Drawing.Point(0, 38);
			this.dataContr.Name = "dataContr";
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataContr.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataContr.Size = new System.Drawing.Size(872, 484);
			this.dataContr.TabIndex = 12;
			this.dataContr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataContrCellContentClick);
			// 
			// txNomC
			// 
			this.txNomC.HeaderText = "Nom compagnie assurance";
			this.txNomC.Name = "txNomC";
			// 
			// txSg
			// 
			this.txSg.HeaderText = "Sigle compagnie";
			this.txSg.Name = "txSg";
			// 
			// txDr
			// 
			this.txDr.HeaderText = "Nom directeur";
			this.txDr.Name = "txDr";
			// 
			// txA
			// 
			this.txA.HeaderText = "Adresse";
			this.txA.Name = "txA";
			// 
			// txTl
			// 
			this.txTl.HeaderText = "Telephone";
			this.txTl.Name = "txTl";
			// 
			// txM
			// 
			this.txM.HeaderText = "Email";
			this.txM.Name = "txM";
			// 
			// txP
			// 
			this.txP.HeaderText = "%Paiement consultation assurance";
			this.txP.Name = "txP";
			// 
			// txPr
			// 
			this.txPr.HeaderText = "%Paiement chambre";
			this.txPr.Name = "txPr";
			// 
			// txIdContr
			// 
			this.txIdContr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.txIdContr.HeaderText = "Id Contrat";
			this.txIdContr.Name = "txIdContr";
			this.txIdContr.ReadOnly = true;
			this.txIdContr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// txPo
			// 
			this.txPo.HeaderText = "%Paiement Hospitalisation";
			this.txPo.Name = "txPo";
			// 
			// txEtt
			// 
			this.txEtt.HeaderText = "Etat";
			this.txEtt.Name = "txEtt";
			// 
			// barOutilsC
			// 
			this.barOutilsC.AutoScroll = true;
			this.barOutilsC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutilsC.Controls.Add(this.btCont);
			this.barOutilsC.Controls.Add(this.btImpmr);
			this.barOutilsC.Controls.Add(this.btModifcon);
			this.barOutilsC.Controls.Add(this.btRetC);
			this.barOutilsC.Controls.Add(this.btSuppC);
			this.barOutilsC.Dock = System.Windows.Forms.DockStyle.Top;
			this.barOutilsC.Location = new System.Drawing.Point(0, 0);
			this.barOutilsC.Name = "barOutilsC";
			this.barOutilsC.Size = new System.Drawing.Size(872, 38);
			this.barOutilsC.TabIndex = 7;
			// 
			// btCont
			// 
			this.btCont.BackColor = System.Drawing.Color.White;
			this.btCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btCont.Location = new System.Drawing.Point(0, 12);
			this.btCont.Name = "btCont";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btCont.Size = new System.Drawing.Size(125, 27);
			this.btCont.TabIndex = 0;
			this.btCont.Text = "AjouterContrat";
			this.btCont.UseVisualStyleBackColor = false;
			this.btCont.Click += new System.EventHandler(this.BtContClick);
			// 
			// btImpmr
			// 
			this.btImpmr.BackColor = System.Drawing.Color.White;
			this.btImpmr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btImpmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btImpmr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btImpmr.Location = new System.Drawing.Point(375, 12);
			this.btImpmr.Name = "btImpmr";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btImpmr.Size = new System.Drawing.Size(125, 26);
			this.btImpmr.TabIndex = 6;
			this.btImpmr.Text = "ImprimerContrat";
			this.btImpmr.UseVisualStyleBackColor = false;
			this.btImpmr.Click += new System.EventHandler(this.BtImpmrClick);
			// 
			// btModifcon
			// 
			this.btModifcon.BackColor = System.Drawing.Color.White;
			this.btModifcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btModifcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btModifcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btModifcon.Location = new System.Drawing.Point(124, 12);
			this.btModifcon.Name = "btModifcon";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btModifcon.Size = new System.Drawing.Size(121, 26);
			this.btModifcon.TabIndex = 1;
			this.btModifcon.Text = "ModifierContrat";
			this.btModifcon.UseVisualStyleBackColor = false;
			this.btModifcon.Click += new System.EventHandler(this.BtModifconClick);
			// 
			// btRetC
			// 
			this.btRetC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btRetC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btRetC.FlatAppearance.BorderSize = 0;
			this.btRetC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRetC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRetC.ForeColor = System.Drawing.Color.White;
			this.btRetC.Location = new System.Drawing.Point(506, 11);
			this.btRetC.Name = "btRetC";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btRetC.Size = new System.Drawing.Size(130, 26);
			this.btRetC.TabIndex = 5;
			this.btRetC.Text = "Retour";
			this.btRetC.UseVisualStyleBackColor = false;
			this.btRetC.Click += new System.EventHandler(this.BtRetCClick);
			// 
			// btSuppC
			// 
			this.btSuppC.BackColor = System.Drawing.Color.White;
			this.btSuppC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSuppC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSuppC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btSuppC.Location = new System.Drawing.Point(243, 12);
			this.btSuppC.Name = "btSuppC";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btSuppC.Size = new System.Drawing.Size(132, 26);
			this.btSuppC.TabIndex = 2;
			this.btSuppC.Text = "SupprimerContrat";
			this.btSuppC.UseVisualStyleBackColor = false;
			this.btSuppC.Click += new System.EventHandler(this.BtSuppCClick);
			// 
			// NewContrat
			// 
			this.ClientSize = new System.Drawing.Size(872, 522);
			this.Controls.Add(this.panelContrat);
			this.Name = "NewContrat";
			this.Text = "NewContrat";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContrat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataContr)).EndInit();
			this.barOutilsC.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}