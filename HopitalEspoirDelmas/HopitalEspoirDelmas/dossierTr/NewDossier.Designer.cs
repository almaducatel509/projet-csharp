/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 30/10/2021
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.dossierTr
{
	partial class NewDossier
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelDoss;
		private System.Windows.Forms.Panel barOutils;
		private System.Windows.Forms.Button btImprimerDos;
		private System.Windows.Forms.Button btRetDos;
		private System.Windows.Forms.Button btTraitSuivi;
		private System.Windows.Forms.Button btAjoutDos;
		private System.Windows.Forms.Button btModDos;
		private System.Windows.Forms.DataGridView dataDoss;
		private System.Windows.Forms.DataGridViewTextBoxColumn txService;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNomSer;
		private System.Windows.Forms.DataGridViewTextBoxColumn txPrix;
		private System.Windows.Forms.DataGridViewTextBoxColumn combEt;
		private System.Windows.Forms.DataGridViewTextBoxColumn txDescrip;
		private System.Windows.Forms.DataGridViewTextBoxColumn txAss;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNomChef;
		private System.Windows.Forms.DataGridViewTextBoxColumn txPers;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNumPers;
		private System.Windows.Forms.DataGridViewTextBoxColumn txAdr;
		private System.Windows.Forms.DataGridViewTextBoxColumn txTel;
		private System.Windows.Forms.DataGridViewTextBoxColumn txEm;
		private System.Windows.Forms.DataGridViewTextBoxColumn txTrait;
		private System.Windows.Forms.DataGridViewTextBoxColumn txMe;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelDoss = new System.Windows.Forms.Panel();
			this.dataDoss = new System.Windows.Forms.DataGridView();
			this.txService = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNomSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.combEt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txAss = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNomChef = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txPers = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNumPers = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txAdr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txTrait = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barOutils = new System.Windows.Forms.Panel();
			this.btImprimerDos = new System.Windows.Forms.Button();
			this.btRetDos = new System.Windows.Forms.Button();
			this.btTraitSuivi = new System.Windows.Forms.Button();
			this.btAjoutDos = new System.Windows.Forms.Button();
			this.btModDos = new System.Windows.Forms.Button();
			this.panelDoss.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataDoss)).BeginInit();
			this.barOutils.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelDoss
			// 
			this.panelDoss.Controls.Add(this.dataDoss);
			this.panelDoss.Controls.Add(this.barOutils);
			this.panelDoss.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDoss.Location = new System.Drawing.Point(0, 0);
			this.panelDoss.Name = "panelDoss";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDoss.Size = new System.Drawing.Size(827, 539);
			this.panelDoss.TabIndex = 0;
			// 
			// dataDoss
			// 
			this.dataDoss.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataDoss.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataDoss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataDoss.BackgroundColor = System.Drawing.Color.White;
			this.dataDoss.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataDoss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataDoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataDoss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.txService,
			this.txNomSer,
			this.txPrix,
			this.combEt,
			this.txDescrip,
			this.txAss,
			this.txNomChef,
			this.txPers,
			this.txNumPers,
			this.txAdr,
			this.txTel,
			this.txEm,
			this.txTrait,
			this.txMe});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataDoss.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataDoss.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataDoss.GridColor = System.Drawing.Color.White;
			this.dataDoss.Location = new System.Drawing.Point(0, 30);
			this.dataDoss.Name = "dataDoss";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataDoss.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.dataDoss.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataDoss.Size = new System.Drawing.Size(827, 509);
			this.dataDoss.StandardTab = true;
			this.dataDoss.TabIndex = 5;
			this.dataDoss.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDossCellContentClick);
			// 
			// txService
			// 
			this.txService.FillWeight = 115F;
			this.txService.HeaderText = "NoDossier";
			this.txService.Name = "txService";
			// 
			// txNomSer
			// 
			this.txNomSer.HeaderText = "Nom Patient";
			this.txNomSer.Name = "txNomSer";
			// 
			// txPrix
			// 
			this.txPrix.FillWeight = 90F;
			this.txPrix.HeaderText = "Prenom";
			this.txPrix.Name = "txPrix";
			// 
			// combEt
			// 
			this.combEt.FillWeight = 60F;
			this.combEt.HeaderText = "Sexe";
			this.combEt.Name = "combEt";
			this.combEt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.combEt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// txDescrip
			// 
			this.txDescrip.FillWeight = 115F;
			this.txDescrip.HeaderText = "Date naissance";
			this.txDescrip.Name = "txDescrip";
			// 
			// txAss
			// 
			this.txAss.FillWeight = 60F;
			this.txAss.HeaderText = "Age";
			this.txAss.Name = "txAss";
			this.txAss.ReadOnly = true;
			this.txAss.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.txAss.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// txNomChef
			// 
			this.txNomChef.FillWeight = 120F;
			this.txNomChef.HeaderText = "Compagnie assure";
			this.txNomChef.Name = "txNomChef";
			// 
			// txPers
			// 
			this.txPers.FillWeight = 150F;
			this.txPers.HeaderText = "Personne responsable";
			this.txPers.Name = "txPers";
			// 
			// txNumPers
			// 
			this.txNumPers.FillWeight = 170F;
			this.txNumPers.HeaderText = "Numero personne responsable";
			this.txNumPers.Name = "txNumPers";
			// 
			// txAdr
			// 
			this.txAdr.FillWeight = 90F;
			this.txAdr.HeaderText = "Adresse";
			this.txAdr.Name = "txAdr";
			// 
			// txTel
			// 
			this.txTel.FillWeight = 115F;
			this.txTel.HeaderText = "Telephone";
			this.txTel.Name = "txTel";
			// 
			// txEm
			// 
			this.txEm.FillWeight = 70F;
			this.txEm.HeaderText = "Email";
			this.txEm.Name = "txEm";
			// 
			// txTrait
			// 
			this.txTrait.FillWeight = 120F;
			this.txTrait.HeaderText = "Traitement suivi";
			this.txTrait.Name = "txTrait";
			// 
			// txMe
			// 
			this.txMe.FillWeight = 80F;
			this.txMe.HeaderText = "Memo";
			this.txMe.Name = "txMe";
			// 
			// barOutils
			// 
			this.barOutils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutils.Controls.Add(this.btImprimerDos);
			this.barOutils.Controls.Add(this.btRetDos);
			this.barOutils.Controls.Add(this.btTraitSuivi);
			this.barOutils.Controls.Add(this.btAjoutDos);
			this.barOutils.Controls.Add(this.btModDos);
			this.barOutils.Dock = System.Windows.Forms.DockStyle.Top;
			this.barOutils.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutils.Location = new System.Drawing.Point(0, 0);
			this.barOutils.Name = "barOutils";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.barOutils.Size = new System.Drawing.Size(827, 30);
			this.barOutils.TabIndex = 3;
			// 
			// btImprimerDos
			// 
			this.btImprimerDos.BackColor = System.Drawing.Color.White;
			this.btImprimerDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btImprimerDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btImprimerDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btImprimerDos.Location = new System.Drawing.Point(388, 5);
			this.btImprimerDos.Name = "btImprimerDos";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btImprimerDos.Size = new System.Drawing.Size(147, 26);
			this.btImprimerDos.TabIndex = 6;
			this.btImprimerDos.Text = "Imprimer";
			this.btImprimerDos.UseVisualStyleBackColor = false;
			this.btImprimerDos.Click += new System.EventHandler(this.BtImprimerDosClick);
			// 
			// btRetDos
			// 
			this.btRetDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btRetDos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btRetDos.FlatAppearance.BorderSize = 0;
			this.btRetDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRetDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRetDos.ForeColor = System.Drawing.Color.White;
			this.btRetDos.Location = new System.Drawing.Point(538, 3);
			this.btRetDos.Name = "btRetDos";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btRetDos.Size = new System.Drawing.Size(130, 26);
			this.btRetDos.TabIndex = 5;
			this.btRetDos.Text = "Retour";
			this.btRetDos.UseVisualStyleBackColor = false;
			this.btRetDos.Click += new System.EventHandler(this.BtRetDosClick);
			// 
			// btTraitSuivi
			// 
			this.btTraitSuivi.BackColor = System.Drawing.Color.White;
			this.btTraitSuivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTraitSuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btTraitSuivi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btTraitSuivi.Location = new System.Drawing.Point(242, 5);
			this.btTraitSuivi.Name = "btTraitSuivi";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btTraitSuivi.Size = new System.Drawing.Size(147, 26);
			this.btTraitSuivi.TabIndex = 4;
			this.btTraitSuivi.Text = "TraitementSuivi";
			this.btTraitSuivi.UseVisualStyleBackColor = false;
			// 
			// btAjoutDos
			// 
			this.btAjoutDos.BackColor = System.Drawing.Color.White;
			this.btAjoutDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAjoutDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAjoutDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btAjoutDos.Location = new System.Drawing.Point(0, 5);
			this.btAjoutDos.Name = "btAjoutDos";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btAjoutDos.Size = new System.Drawing.Size(125, 27);
			this.btAjoutDos.TabIndex = 0;
			this.btAjoutDos.Text = "AjouterDossier";
			this.btAjoutDos.UseVisualStyleBackColor = false;
			this.btAjoutDos.Click += new System.EventHandler(this.BtAjoutDosClick);
			// 
			// btModDos
			// 
			this.btModDos.BackColor = System.Drawing.Color.White;
			this.btModDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btModDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btModDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btModDos.Location = new System.Drawing.Point(122, 5);
			this.btModDos.Name = "btModDos";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btModDos.Size = new System.Drawing.Size(122, 26);
			this.btModDos.TabIndex = 1;
			this.btModDos.Text = "ModifierDossier";
			this.btModDos.UseVisualStyleBackColor = false;
			this.btModDos.Click += new System.EventHandler(this.BtModDosClick);
			// 
			// NewDossier
			// 
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(827, 539);
			this.Controls.Add(this.panelDoss);
			this.Name = "NewDossier";
			//this.ShowIcon = false;
			this.Text = "NewDossier";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDoss.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataDoss)).EndInit();
			this.barOutils.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
