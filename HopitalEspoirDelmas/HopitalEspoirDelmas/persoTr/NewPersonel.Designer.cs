/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 15/10/2021
 * Time: 01:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.persoTr
{
	partial class NewPersonel
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btAjoutP;
		private System.Windows.Forms.Panel barOutilsP;
		private System.Windows.Forms.DataGridView dataPers;
		private System.Windows.Forms.DataGridViewTextBoxColumn txN;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNm;
		private System.Windows.Forms.DataGridViewTextBoxColumn txP;
		private System.Windows.Forms.DataGridViewTextBoxColumn txA;
		private System.Windows.Forms.DataGridViewTextBoxColumn txS;
		private System.Windows.Forms.DataGridViewTextBoxColumn txC;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNC;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNb;
		private System.Windows.Forms.DataGridViewTextBoxColumn txDo;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNi;
		private System.Windows.Forms.DataGridViewTextBoxColumn txSp;
		private System.Windows.Forms.DataGridViewTextBoxColumn txDat;
		private System.Windows.Forms.DataGridViewTextBoxColumn txSer;
		private System.Windows.Forms.DataGridViewTextBoxColumn txEm;
		private System.Windows.Forms.DataGridViewTextBoxColumn txTl;
		private System.Windows.Forms.DataGridViewTextBoxColumn txE;
		private System.Windows.Forms.Button btSupp;
		private System.Windows.Forms.Button btRet;
		private System.Windows.Forms.Button btMod;
		private System.Windows.Forms.Button btImprimerP;
		private System.Drawing.Printing.PrintDocument ImprimerListe;
		private System.Windows.Forms.Panel panelPers;
		
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
			this.btAjoutP = new System.Windows.Forms.Button();
			this.barOutilsP = new System.Windows.Forms.Panel();
			this.btImprimerP = new System.Windows.Forms.Button();
			this.btRet = new System.Windows.Forms.Button();
			this.btMod = new System.Windows.Forms.Button();
			this.btSupp = new System.Windows.Forms.Button();
			this.ImprimerListe = new System.Drawing.Printing.PrintDocument();
			this.panelPers = new System.Windows.Forms.Panel();
			this.dataPers = new System.Windows.Forms.DataGridView();
			this.txN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNb = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txTl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barOutilsP.SuspendLayout();
			this.panelPers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataPers)).BeginInit();
			this.SuspendLayout();
			// 
			// btAjoutP
			// 
			this.btAjoutP.BackColor = System.Drawing.Color.White;
			this.btAjoutP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAjoutP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAjoutP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btAjoutP.Location = new System.Drawing.Point(0, 6);
			this.btAjoutP.Name = "btAjoutP";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btAjoutP.Size = new System.Drawing.Size(125, 27);
			this.btAjoutP.TabIndex = 0;
			this.btAjoutP.Text = "AjouterPersonel";
			this.btAjoutP.UseVisualStyleBackColor = false;
			this.btAjoutP.Click += new System.EventHandler(this.BtAjoutPClick);
			// 
			// barOutilsP
			// 
			this.barOutilsP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutilsP.Controls.Add(this.btImprimerP);
			this.barOutilsP.Controls.Add(this.btRet);
			this.barOutilsP.Controls.Add(this.btMod);
			this.barOutilsP.Controls.Add(this.btSupp);
			this.barOutilsP.Controls.Add(this.btAjoutP);
			this.barOutilsP.Dock = System.Windows.Forms.DockStyle.Top;
			this.barOutilsP.Location = new System.Drawing.Point(0, 0);
			this.barOutilsP.Name = "barOutilsP";
			this.barOutilsP.Size = new System.Drawing.Size(993, 30);
			this.barOutilsP.TabIndex = 5;
			// 
			// btImprimerP
			// 
			this.btImprimerP.BackColor = System.Drawing.Color.White;
			this.btImprimerP.Cursor = System.Windows.Forms.Cursors.Default;
			this.btImprimerP.FlatAppearance.BorderSize = 0;
			this.btImprimerP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btImprimerP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btImprimerP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btImprimerP.Location = new System.Drawing.Point(394, 7);
			this.btImprimerP.Name = "btImprimerP";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btImprimerP.Size = new System.Drawing.Size(134, 24);
			this.btImprimerP.TabIndex = 24;
			this.btImprimerP.Text = "Imprimer";
			this.btImprimerP.UseVisualStyleBackColor = false;
			// 
			// btRet
			// 
			this.btRet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btRet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btRet.FlatAppearance.BorderSize = 0;
			this.btRet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRet.ForeColor = System.Drawing.Color.White;
			this.btRet.Location = new System.Drawing.Point(529, 5);
			this.btRet.Name = "btRet";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btRet.Size = new System.Drawing.Size(130, 26);
			this.btRet.TabIndex = 4;
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
			this.btMod.Location = new System.Drawing.Point(264, 6);
			this.btMod.Name = "btMod";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btMod.Size = new System.Drawing.Size(130, 26);
			this.btMod.TabIndex = 3;
			this.btMod.Text = "ModifierPersonel";
			this.btMod.UseVisualStyleBackColor = false;
			this.btMod.Click += new System.EventHandler(this.BtModClick);
			// 
			// btSupp
			// 
			this.btSupp.BackColor = System.Drawing.Color.White;
			this.btSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSupp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btSupp.Location = new System.Drawing.Point(121, 6);
			this.btSupp.Name = "btSupp";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btSupp.Size = new System.Drawing.Size(147, 25);
			this.btSupp.TabIndex = 2;
			this.btSupp.Text = "SupprimerPersonel";
			this.btSupp.UseVisualStyleBackColor = false;
			this.btSupp.Click += new System.EventHandler(this.BtSuppClick);
			// 
			// ImprimerListe
			// 
			this.ImprimerListe.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
			// 
			// panelPers
			// 
			this.panelPers.Controls.Add(this.dataPers);
			this.panelPers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPers.Location = new System.Drawing.Point(0, 30);
			this.panelPers.Name = "panelPers";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPers.Size = new System.Drawing.Size(993, 283);
			this.panelPers.TabIndex = 6;
			// 
			// dataPers
			// 
			this.dataPers.AllowDrop = true;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataPers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataPers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataPers.BackgroundColor = System.Drawing.Color.White;
			this.dataPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataPers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.txN,
			this.txNm,
			this.txP,
			this.txA,
			this.txS,
			this.txC,
			this.txNC,
			this.txNb,
			this.txDo,
			this.txNi,
			this.txSp,
			this.txDat,
			this.txSer,
			this.txEm,
			this.txTl,
			this.txE});
			this.dataPers.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataPers.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataPers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataPers.Location = new System.Drawing.Point(0, 0);
			this.dataPers.Name = "dataPers";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataPers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataPers.RowHeadersWidth = 15;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dataPers.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataPers.Size = new System.Drawing.Size(993, 283);
			this.dataPers.TabIndex = 7;
			this.dataPers.TabStop = false;
			this.dataPers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPersCellContentClick);
			// 
			// txN
			// 
			this.txN.HeaderText = "Id personel";
			this.txN.Name = "txN";
			// 
			// txNm
			// 
			this.txNm.HeaderText = "Nom personel";
			this.txNm.Name = "txNm";
			// 
			// txP
			// 
			this.txP.HeaderText = "Prenom";
			this.txP.Name = "txP";
			// 
			// txA
			// 
			this.txA.HeaderText = "Adresse";
			this.txA.Name = "txA";
			// 
			// txS
			// 
			this.txS.HeaderText = "Sexe";
			this.txS.Name = "txS";
			// 
			// txC
			// 
			this.txC.HeaderText = "Categorie";
			this.txC.Name = "txC";
			// 
			// txNC
			// 
			this.txNC.HeaderText = "Nif/Cin";
			this.txNC.Name = "txNC";
			// 
			// txNb
			// 
			this.txNb.HeaderText = "Nombre d\'annee d\'experience";
			this.txNb.Name = "txNb";
			// 
			// txDo
			// 
			this.txDo.HeaderText = "Domaine d\'etude";
			this.txDo.Name = "txDo";
			// 
			// txNi
			// 
			this.txNi.HeaderText = "Niveau d\'etude";
			this.txNi.Name = "txNi";
			// 
			// txSp
			// 
			this.txSp.HeaderText = "Specialisation";
			this.txSp.Name = "txSp";
			// 
			// txDat
			// 
			this.txDat.HeaderText = "Date de Naissance";
			this.txDat.Name = "txDat";
			// 
			// txSer
			// 
			this.txSer.HeaderText = "Sevices Affectes";
			this.txSer.Name = "txSer";
			// 
			// txEm
			// 
			this.txEm.HeaderText = "Email";
			this.txEm.Name = "txEm";
			// 
			// txTl
			// 
			this.txTl.HeaderText = "Telephone";
			this.txTl.Name = "txTl";
			// 
			// txE
			// 
			this.txE.HeaderText = "Etat";
			this.txE.Name = "txE";
			// 
			// NewPersonel
			// 
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(993, 313);
			this.Controls.Add(this.panelPers);
			this.Controls.Add(this.barOutilsP);
			this.Name = "NewPersonel";
			//this.ShowIcon = false;
			this.Text = "NewPersonel";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.barOutilsP.ResumeLayout(false);
			this.panelPers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataPers)).EndInit();
			this.ResumeLayout(false);

		}
		}
	}

