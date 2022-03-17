/*
 * Created by SharpDevelop.
 * User: Fl3m
 * Date: 14-Oct-21
 * Time: 9:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
namespace HopitalEspoirDelmas.consultationTr
{
	partial class NewConsultation
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelconsul;
		private System.Windows.Forms.DataGridView dataConsult;
		private System.Windows.Forms.DataGridViewTextBoxColumn txService;
		private System.Windows.Forms.Panel barOutilons;
		private System.Windows.Forms.Button btBarcons1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nodossier;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeservice;
		private System.Windows.Forms.DataGridViewTextBoxColumn consultationassurance;
		private System.Windows.Forms.DataGridViewTextBoxColumn motif;
		private System.Windows.Forms.DataGridViewTextBoxColumn hospitalisation;
		private System.Windows.Forms.DataGridViewTextBoxColumn hospitalisationassure;
		private System.Windows.Forms.DataGridViewTextBoxColumn chambre;
		private System.Windows.Forms.DataGridViewTextBoxColumn duree;
		private System.Windows.Forms.DataGridViewTextBoxColumn medecin;
		private System.Windows.Forms.DataGridViewTextBoxColumn date;
		private System.Windows.Forms.Button btMod;
		private System.Windows.Forms.Button btRet;
		private System.Windows.Forms.Button btImprimerCons;
		private System.Windows.Forms.TextBox txRecher;
		private System.Windows.Forms.DataGridViewTextBoxColumn txDatHos;
		private System.Windows.Forms.PictureBox pictRech;
		//private System.Windows.Forms.Button btImprimerCons;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConsultation));
			this.panelconsul = new System.Windows.Forms.Panel();
			this.dataConsult = new System.Windows.Forms.DataGridView();
			this.barOutilons = new System.Windows.Forms.Panel();
			this.pictRech = new System.Windows.Forms.PictureBox();
			this.txRecher = new System.Windows.Forms.TextBox();
			this.btImprimerCons = new System.Windows.Forms.Button();
			this.btRet = new System.Windows.Forms.Button();
			this.btMod = new System.Windows.Forms.Button();
			this.btBarcons1 = new System.Windows.Forms.Button();
			this.txService = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nodossier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeservice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.consultationassurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hospitalisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hospitalisationassure = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txDatHos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelconsul.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataConsult)).BeginInit();
			this.barOutilons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictRech)).BeginInit();
			this.SuspendLayout();
			// 
			// panelconsul
			// 
			this.panelconsul.Controls.Add(this.dataConsult);
			this.panelconsul.Controls.Add(this.barOutilons);
			this.panelconsul.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelconsul.Location = new System.Drawing.Point(0, 0);
			this.panelconsul.Name = "panelconsul";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelconsul.Size = new System.Drawing.Size(1044, 539);
			this.panelconsul.TabIndex = 0;
			this.panelconsul.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelconsulPaint);
			// 
			// dataConsult
			// 
			this.dataConsult.AllowUserToAddRows = false;
			this.dataConsult.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataConsult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataConsult.BackgroundColor = System.Drawing.Color.White;
			this.dataConsult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataConsult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataConsult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.txService,
			this.nodossier,
			this.typeservice,
			this.consultationassurance,
			this.motif,
			this.hospitalisation,
			this.hospitalisationassure,
			this.chambre,
			this.duree,
			this.medecin,
			this.date,
			this.txDatHos});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataConsult.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataConsult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataConsult.GridColor = System.Drawing.Color.White;
			this.dataConsult.Location = new System.Drawing.Point(0, 30);
			this.dataConsult.Name = "dataConsult";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataConsult.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.dataConsult.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataConsult.Size = new System.Drawing.Size(1044, 509);
			this.dataConsult.StandardTab = true;
			this.dataConsult.TabIndex = 5;
			this.dataConsult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataServCellContentClick);
			// 
			// barOutilons
			// 
			this.barOutilons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutilons.Controls.Add(this.pictRech);
			this.barOutilons.Controls.Add(this.txRecher);
			this.barOutilons.Controls.Add(this.btImprimerCons);
			this.barOutilons.Controls.Add(this.btRet);
			this.barOutilons.Controls.Add(this.btMod);
			this.barOutilons.Controls.Add(this.btBarcons1);
			this.barOutilons.Dock = System.Windows.Forms.DockStyle.Top;
			this.barOutilons.Location = new System.Drawing.Point(0, 0);
			this.barOutilons.Name = "barOutilons";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.barOutilons.Size = new System.Drawing.Size(1044, 30);
			this.barOutilons.TabIndex = 4;
			// 
			// pictRech
			// 
			this.pictRech.BackColor = System.Drawing.Color.White;
			this.pictRech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictRech.ErrorImage = null;
			this.pictRech.Image = ((System.Drawing.Image)(resources.GetObject("pictRech.Image")));
			this.pictRech.Location = new System.Drawing.Point(534, 10);
			this.pictRech.Name = "pictRech";
			this.pictRech.Size = new System.Drawing.Size(34, 20);
			this.pictRech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictRech.TabIndex = 11;
			this.pictRech.TabStop = false;
			// 
			// txRecher
			// 
			this.txRecher.ForeColor = System.Drawing.Color.DarkGray;
			this.txRecher.Location = new System.Drawing.Point(568, 10);
			this.txRecher.Name = "txRecher";
			this.txRecher.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txRecher.Size = new System.Drawing.Size(189, 20);
			this.txRecher.TabIndex = 10;
			this.txRecher.TextChanged += new System.EventHandler(this.TxRecherTextChanged);
			// 
			// btImprimerCons
			// 
			this.btImprimerCons.BackColor = System.Drawing.Color.White;
			this.btImprimerCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btImprimerCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btImprimerCons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btImprimerCons.Location = new System.Drawing.Point(262, 7);
			this.btImprimerCons.Name = "btImprimerCons";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btImprimerCons.Size = new System.Drawing.Size(118, 24);
			this.btImprimerCons.TabIndex = 9;
			this.btImprimerCons.Text = "Imprimer";
			this.btImprimerCons.UseVisualStyleBackColor = false;
			this.btImprimerCons.Click += new System.EventHandler(this.BtImprimerConsClick);
			// 
			// btRet
			// 
			this.btRet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btRet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btRet.FlatAppearance.BorderSize = 0;
			this.btRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRet.ForeColor = System.Drawing.Color.White;
			this.btRet.Location = new System.Drawing.Point(826, 3);
			this.btRet.Name = "btRet";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btRet.Size = new System.Drawing.Size(130, 25);
			this.btRet.TabIndex = 7;
			this.btRet.Text = "Retour";
			this.btRet.UseVisualStyleBackColor = false;
			this.btRet.Click += new System.EventHandler(this.BtRetClick);
			// 
			// btMod
			// 
			this.btMod.BackColor = System.Drawing.Color.White;
			this.btMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btMod.Location = new System.Drawing.Point(145, 7);
			this.btMod.Name = "btMod";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btMod.Size = new System.Drawing.Size(118, 24);
			this.btMod.TabIndex = 5;
			this.btMod.Text = "Modifier";
			this.btMod.UseVisualStyleBackColor = false;
			this.btMod.Click += new System.EventHandler(this.BtModClick);
			// 
			// btBarcons1
			// 
			this.btBarcons1.BackColor = System.Drawing.Color.White;
			this.btBarcons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btBarcons1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBarcons1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btBarcons1.Location = new System.Drawing.Point(1, 7);
			this.btBarcons1.Name = "btBarcons1";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btBarcons1.Size = new System.Drawing.Size(144, 23);
			this.btBarcons1.TabIndex = 0;
			this.btBarcons1.Text = "Ajouter";
			this.btBarcons1.UseVisualStyleBackColor = false;
			this.btBarcons1.Click += new System.EventHandler(this.BtBarcons1Click);
			// 
			// txService
			// 
			this.txService.HeaderText = "Id Consultation";
			this.txService.Name = "txService";
			// 
			// nodossier
			// 
			this.nodossier.HeaderText = "Numero Dossier";
			this.nodossier.Name = "nodossier";
			// 
			// typeservice
			// 
			this.typeservice.HeaderText = "Consultation pour service de";
			this.typeservice.Name = "typeservice";
			this.typeservice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// consultationassurance
			// 
			this.consultationassurance.HeaderText = "Consultation Assurance";
			this.consultationassurance.Name = "consultationassurance";
			this.consultationassurance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// motif
			// 
			this.motif.HeaderText = "Motif Consultation";
			this.motif.Name = "motif";
			// 
			// hospitalisation
			// 
			this.hospitalisation.HeaderText = "Necessite Hospitalisation";
			this.hospitalisation.Name = "hospitalisation";
			this.hospitalisation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// hospitalisationassure
			// 
			this.hospitalisationassure.HeaderText = "Hospitalisation sur Assurance";
			this.hospitalisationassure.Name = "hospitalisationassure";
			this.hospitalisationassure.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// chambre
			// 
			this.chambre.HeaderText = "Id Chambre";
			this.chambre.Name = "chambre";
			// 
			// duree
			// 
			this.duree.HeaderText = "Duree Hospitalisation";
			this.duree.Name = "duree";
			// 
			// medecin
			// 
			this.medecin.HeaderText = "Medecins en Charge";
			this.medecin.Name = "medecin";
			// 
			// date
			// 
			this.date.HeaderText = "Date Consultation";
			this.date.Name = "date";
			// 
			// txDatHos
			// 
			this.txDatHos.HeaderText = "Date Hospitalisation";
			this.txDatHos.Name = "txDatHos";
			// 
			// NewConsultation
			// 
			this.ClientSize = new System.Drawing.Size(1044, 539);
			this.Controls.Add(this.panelconsul);
			this.Name = "NewConsultation";
			this.Text = "NewConsultation";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelconsul.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataConsult)).EndInit();
			this.barOutilons.ResumeLayout(false);
			this.barOutilons.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictRech)).EndInit();
			this.ResumeLayout(false);

		}
	}
}