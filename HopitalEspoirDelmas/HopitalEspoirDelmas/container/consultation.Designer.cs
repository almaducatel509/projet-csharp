/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 27/09/2021
 * Time: 23:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.container
{
	partial class consultation
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelConsultation;
		private System.Windows.Forms.Panel souspanelCons1;
		private System.Windows.Forms.DateTimePicker txDatconsu;
		private System.Windows.Forms.Label txDate;
		private System.Windows.Forms.TextBox txNomMe;
		private System.Windows.Forms.Label txNomMed;
		private System.Windows.Forms.Label txIdChambre;
		private System.Windows.Forms.RadioButton btNecess2;
		private System.Windows.Forms.RadioButton btNeces1;
		private System.Windows.Forms.Label txNecess;
		private System.Windows.Forms.Label txDuree;
		private System.Windows.Forms.Panel panelCons;
		private System.Windows.Forms.Button btEnregistrer;
		private System.Windows.Forms.Button btAfficher;
		private System.Windows.Forms.Button btModifier;
		private System.Windows.Forms.Panel souspanelCons;
		private System.Windows.Forms.RadioButton btPAss2;
		private System.Windows.Forms.RadioButton btPAss1;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.ComboBox comMotif;
		private System.Windows.Forms.ComboBox combConsul;
		private System.Windows.Forms.Label txNumero;
		private System.Windows.Forms.Label txConsul;
		private System.Windows.Forms.Label txMotif;
		private System.Windows.Forms.Label txPyAss;
		private System.Windows.Forms.Label txHospAss;
		private System.Windows.Forms.ComboBox combHosAss;
		private System.Windows.Forms.Label HospAss;
		private System.Windows.Forms.ComboBox combChb;
		private System.Windows.Forms.TextBox txDuH;
		private System.Windows.Forms.ComboBox combNDos;
		private System.Windows.Forms.Label txDatHosp;
		private System.Windows.Forms.DateTimePicker txDateHospit;
		private System.Windows.Forms.Panel panel1;
		//private System.Windows.Forms.Label txDatHosp;
		//private System.Windows.Forms.DateTimePicker txDateHospit;
//		private System.Windows.Forms.ComboBox combContrts;
//		private System.Windows.Forms.Label txtContrats;
		//private System.Windows.Forms.ComboBox combChb;
		
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
		/// Do not change the method conte
			private void InitializeComponent(){
				System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultation));
				this.panelConsultation = new System.Windows.Forms.Panel();
				this.souspanelCons1 = new System.Windows.Forms.Panel();
				this.panelCons = new System.Windows.Forms.Panel();
				this.btEnregistrer = new System.Windows.Forms.Button();
				this.btAfficher = new System.Windows.Forms.Button();
				this.btModifier = new System.Windows.Forms.Button();
				this.souspanelCons = new System.Windows.Forms.Panel();
				this.panel1 = new System.Windows.Forms.Panel();
				this.btPAss2 = new System.Windows.Forms.RadioButton();
				this.btPAss1 = new System.Windows.Forms.RadioButton();
				this.btNecess2 = new System.Windows.Forms.RadioButton();
				this.txNecess = new System.Windows.Forms.Label();
				this.btNeces1 = new System.Windows.Forms.RadioButton();
				this.combHosAss = new System.Windows.Forms.ComboBox();
				this.HospAss = new System.Windows.Forms.Label();
				this.txDuH = new System.Windows.Forms.TextBox();
				this.txDatHosp = new System.Windows.Forms.Label();
				this.txDateHospit = new System.Windows.Forms.DateTimePicker();
				this.txDuree = new System.Windows.Forms.Label();
				this.combNDos = new System.Windows.Forms.ComboBox();
				this.txDatconsu = new System.Windows.Forms.DateTimePicker();
				this.combChb = new System.Windows.Forms.ComboBox();
				this.txDate = new System.Windows.Forms.Label();
				this.txNomMe = new System.Windows.Forms.TextBox();
				this.txNomMed = new System.Windows.Forms.Label();
				this.btCancel = new System.Windows.Forms.Button();
				this.comMotif = new System.Windows.Forms.ComboBox();
				this.combConsul = new System.Windows.Forms.ComboBox();
				this.txNumero = new System.Windows.Forms.Label();
				this.txConsul = new System.Windows.Forms.Label();
				this.txMotif = new System.Windows.Forms.Label();
				this.txIdChambre = new System.Windows.Forms.Label();
				this.txPyAss = new System.Windows.Forms.Label();
				this.txHospAss = new System.Windows.Forms.Label();
				this.panelConsultation.SuspendLayout();
				this.panelCons.SuspendLayout();
				this.souspanelCons.SuspendLayout();
				this.panel1.SuspendLayout();
				this.SuspendLayout();
				// 
				// panelConsultation
				// 
				this.panelConsultation.BackColor = System.Drawing.Color.White;
				this.panelConsultation.Controls.Add(this.souspanelCons1);
				this.panelConsultation.Controls.Add(this.panelCons);
				this.panelConsultation.Controls.Add(this.souspanelCons);
				this.panelConsultation.Dock = System.Windows.Forms.DockStyle.Fill;
				this.panelConsultation.Location = new System.Drawing.Point(0, 0);
				this.panelConsultation.Name = "panelConsultation";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.panelConsultation.Size = new System.Drawing.Size(1056, 539);
				this.panelConsultation.TabIndex = 1;
				// 
				// souspanelCons1
				// 
				this.souspanelCons1.BackColor = System.Drawing.Color.White;
				this.souspanelCons1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("souspanelCons1.BackgroundImage")));
				this.souspanelCons1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
				this.souspanelCons1.Cursor = System.Windows.Forms.Cursors.Default;
				this.souspanelCons1.Dock = System.Windows.Forms.DockStyle.Right;
				this.souspanelCons1.Location = new System.Drawing.Point(750, 86);
				this.souspanelCons1.Name = "souspanelCons1";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.souspanelCons1.Size = new System.Drawing.Size(306, 453);
				this.souspanelCons1.TabIndex = 34;
				// 
				// panelCons
				// 
				this.panelCons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.panelCons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
				this.panelCons.Controls.Add(this.btEnregistrer);
				this.panelCons.Controls.Add(this.btAfficher);
				this.panelCons.Controls.Add(this.btModifier);
				this.panelCons.Cursor = System.Windows.Forms.Cursors.Default;
				this.panelCons.Dock = System.Windows.Forms.DockStyle.Top;
				this.panelCons.Location = new System.Drawing.Point(0, 0);
				this.panelCons.Name = "panelCons";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.panelCons.Size = new System.Drawing.Size(1056, 86);
				this.panelCons.TabIndex = 32;
				// 
				// btEnregistrer
				// 
				this.btEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.btEnregistrer.Dock = System.Windows.Forms.DockStyle.Right;
				this.btEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
				this.btEnregistrer.FlatAppearance.BorderSize = 0;
				this.btEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btEnregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
				this.btEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("btEnregistrer.Image")));
				this.btEnregistrer.Location = new System.Drawing.Point(454, 0);
				this.btEnregistrer.Name = "btEnregistrer";
				this.btEnregistrer.Size = new System.Drawing.Size(200, 84);
				this.btEnregistrer.TabIndex = 19;
				this.btEnregistrer.Text = "Enregistrer";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.btEnregistrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
				this.btEnregistrer.UseVisualStyleBackColor = false;
				this.btEnregistrer.Click += new System.EventHandler(this.BtEnregistrerClick);
				// 
				// btAfficher
				// 
				this.btAfficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.btAfficher.Cursor = System.Windows.Forms.Cursors.Default;
				this.btAfficher.Dock = System.Windows.Forms.DockStyle.Right;
				this.btAfficher.FlatAppearance.BorderSize = 0;
				this.btAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.btAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btAfficher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
				this.btAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btAfficher.Image")));
				this.btAfficher.Location = new System.Drawing.Point(654, 0);
				this.btAfficher.Name = "btAfficher";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.btAfficher.Size = new System.Drawing.Size(200, 84);
				this.btAfficher.TabIndex = 20;
				this.btAfficher.Text = "Afficher";
				this.btAfficher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
				this.btAfficher.UseVisualStyleBackColor = false;
				this.btAfficher.Click += new System.EventHandler(this.BtAfficherClick);
				// 
				// btModifier
				// 
				this.btModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.btModifier.Dock = System.Windows.Forms.DockStyle.Right;
				this.btModifier.FlatAppearance.BorderSize = 0;
				this.btModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.btModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
				this.btModifier.Image = ((System.Drawing.Image)(resources.GetObject("btModifier.Image")));
				this.btModifier.Location = new System.Drawing.Point(854, 0);
				this.btModifier.Name = "btModifier";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.btModifier.Size = new System.Drawing.Size(200, 84);
				this.btModifier.TabIndex = 21;
				this.btModifier.Text = "Modifier";
				this.btModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
				this.btModifier.UseVisualStyleBackColor = false;
				this.btModifier.Click += new System.EventHandler(this.BtModifierClick);
				// 
				// souspanelCons
				// 
				this.souspanelCons.BackColor = System.Drawing.Color.White;
				this.souspanelCons.Controls.Add(this.panel1);
				this.souspanelCons.Controls.Add(this.btNecess2);
				this.souspanelCons.Controls.Add(this.txNecess);
				this.souspanelCons.Controls.Add(this.btNeces1);
				this.souspanelCons.Controls.Add(this.combHosAss);
				this.souspanelCons.Controls.Add(this.HospAss);
				this.souspanelCons.Controls.Add(this.txDuH);
				this.souspanelCons.Controls.Add(this.txDatHosp);
				this.souspanelCons.Controls.Add(this.txDateHospit);
				this.souspanelCons.Controls.Add(this.txDuree);
				this.souspanelCons.Controls.Add(this.combNDos);
				this.souspanelCons.Controls.Add(this.txDatconsu);
				this.souspanelCons.Controls.Add(this.combChb);
				this.souspanelCons.Controls.Add(this.txDate);
				this.souspanelCons.Controls.Add(this.txNomMe);
				this.souspanelCons.Controls.Add(this.txNomMed);
				this.souspanelCons.Controls.Add(this.btCancel);
				this.souspanelCons.Controls.Add(this.comMotif);
				this.souspanelCons.Controls.Add(this.combConsul);
				this.souspanelCons.Controls.Add(this.txNumero);
				this.souspanelCons.Controls.Add(this.txConsul);
				this.souspanelCons.Controls.Add(this.txMotif);
				this.souspanelCons.Controls.Add(this.txIdChambre);
				this.souspanelCons.Controls.Add(this.txPyAss);
				this.souspanelCons.Cursor = System.Windows.Forms.Cursors.Default;
				this.souspanelCons.Dock = System.Windows.Forms.DockStyle.Fill;
				this.souspanelCons.ForeColor = System.Drawing.Color.Black;
				this.souspanelCons.Location = new System.Drawing.Point(0, 0);
				this.souspanelCons.Name = "souspanelCons";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.souspanelCons.Size = new System.Drawing.Size(1056, 539);
				this.souspanelCons.TabIndex = 33;
				this.souspanelCons.Paint += new System.Windows.Forms.PaintEventHandler(this.SouspanelConsPaint);
				// 
				// panel1
				// 
				this.panel1.Controls.Add(this.btPAss2);
				this.panel1.Controls.Add(this.btPAss1);
				this.panel1.Location = new System.Drawing.Point(35, 377);
				this.panel1.Name = "panel1";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.panel1.Size = new System.Drawing.Size(244, 23);
				this.panel1.TabIndex = 47;
				// 
				// btPAss2
				// 
				this.btPAss2.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.btPAss2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.btPAss2.Location = new System.Drawing.Point(137, 0);
				this.btPAss2.Name = "btPAss2";
				this.btPAss2.Size = new System.Drawing.Size(104, 24);
				this.btPAss2.TabIndex = 29;
				this.btPAss2.TabStop = true;
				this.btPAss2.Text = "Non";
				this.btPAss2.UseVisualStyleBackColor = false;
				// 
				// btPAss1
				// 
				this.btPAss1.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.btPAss1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.btPAss1.Location = new System.Drawing.Point(6, 0);
				this.btPAss1.Name = "btPAss1";
				this.btPAss1.Size = new System.Drawing.Size(104, 24);
				this.btPAss1.TabIndex = 28;
				this.btPAss1.TabStop = true;
				this.btPAss1.Text = "Oui";
				this.btPAss1.UseVisualStyleBackColor = false;
				// 
				// btNecess2
				// 
				this.btNecess2.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.btNecess2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.btNecess2.Location = new System.Drawing.Point(614, 376);
				this.btNecess2.Name = "btNecess2";
				this.btNecess2.Size = new System.Drawing.Size(104, 24);
				this.btNecess2.TabIndex = 29;
				this.btNecess2.TabStop = true;
				this.btNecess2.Text = "Non";
				this.btNecess2.UseVisualStyleBackColor = false;
				// 
				// txNecess
				// 
				this.txNecess.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txNecess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txNecess.Location = new System.Drawing.Point(468, 349);
				this.txNecess.Name = "txNecess";
				this.txNecess.Size = new System.Drawing.Size(223, 23);
				this.txNecess.TabIndex = 37;
				this.txNecess.Text = "Necessite d\'hospitalisation";
				// 
				// btNeces1
				// 
				this.btNeces1.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.btNeces1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.btNeces1.Location = new System.Drawing.Point(429, 376);
				this.btNeces1.Name = "btNeces1";
				this.btNeces1.Size = new System.Drawing.Size(104, 24);
				this.btNeces1.TabIndex = 28;
				this.btNeces1.TabStop = true;
				this.btNeces1.Text = "Oui";
				this.btNeces1.UseVisualStyleBackColor = false;
				// 
				// combHosAss
				// 
				this.combHosAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.combHosAss.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.combHosAss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.combHosAss.FormattingEnabled = true;
				this.combHosAss.Items.AddRange(new object[] {
			"Oui",
			"Non"});
				this.combHosAss.Location = new System.Drawing.Point(429, 320);
				this.combHosAss.Name = "combHosAss";
				this.combHosAss.Size = new System.Drawing.Size(289, 23);
				this.combHosAss.TabIndex = 39;
				// 
				// HospAss
				// 
				this.HospAss.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.HospAss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.HospAss.Location = new System.Drawing.Point(468, 298);
				this.HospAss.Name = "HospAss";
				this.HospAss.Size = new System.Drawing.Size(220, 23);
				this.HospAss.TabIndex = 40;
				this.HospAss.Text = "Hospitalisation sur Assurance";
				// 
				// txDuH
				// 
				this.txDuH.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.txDuH.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txDuH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.txDuH.Location = new System.Drawing.Point(429, 271);
				this.txDuH.Name = "txDuH";
				this.txDuH.Size = new System.Drawing.Size(289, 23);
				this.txDuH.TabIndex = 41;
				// 
				// txDatHosp
				// 
				this.txDatHosp.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txDatHosp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txDatHosp.Location = new System.Drawing.Point(32, 402);
				this.txDatHosp.Name = "txDatHosp";
				this.txDatHosp.Size = new System.Drawing.Size(144, 23);
				this.txDatHosp.TabIndex = 46;
				this.txDatHosp.Text = "Date Hospitalisation";
				// 
				// txDateHospit
				// 
				this.txDateHospit.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
				this.txDateHospit.CustomFormat = "yyyy-MM-dd";
				this.txDateHospit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
				this.txDateHospit.Location = new System.Drawing.Point(32, 428);
				this.txDateHospit.Name = "txDateHospit";
				this.txDateHospit.Size = new System.Drawing.Size(272, 23);
				this.txDateHospit.TabIndex = 45;
				this.txDateHospit.ValueChanged += new System.EventHandler(this.TxDateHospitValueChanged);
				// 
				// txDuree
				// 
				this.txDuree.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txDuree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txDuree.Location = new System.Drawing.Point(468, 245);
				this.txDuree.Name = "txDuree";
				this.txDuree.Size = new System.Drawing.Size(189, 23);
				this.txDuree.TabIndex = 36;
				this.txDuree.Text = "Duree hospitalisation";
				// 
				// combNDos
				// 
				this.combNDos.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.combNDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.combNDos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.combNDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.combNDos.FormattingEnabled = true;
				this.combNDos.Location = new System.Drawing.Point(32, 155);
				this.combNDos.Name = "combNDos";
				this.combNDos.Size = new System.Drawing.Size(272, 23);
				this.combNDos.TabIndex = 32;
				this.combNDos.SelectedIndexChanged += new System.EventHandler(this.CombNDosSelectedIndexChanged);
				// 
				// txDatconsu
				// 
				this.txDatconsu.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
				this.txDatconsu.CustomFormat = "yyyy-MM-dd";
				this.txDatconsu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
				this.txDatconsu.Location = new System.Drawing.Point(429, 214);
				this.txDatconsu.Name = "txDatconsu";
				this.txDatconsu.Size = new System.Drawing.Size(289, 23);
				this.txDatconsu.TabIndex = 32;
				// 
				// combChb
				// 
				this.combChb.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.combChb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.combChb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.combChb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.combChb.FormattingEnabled = true;
				this.combChb.Location = new System.Drawing.Point(32, 209);
				this.combChb.Name = "combChb";
				this.combChb.Size = new System.Drawing.Size(272, 23);
				this.combChb.TabIndex = 31;
				this.combChb.SelectedIndexChanged += new System.EventHandler(this.CombChbSelectedIndexChanged);
				// 
				// txDate
				// 
				this.txDate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txDate.Location = new System.Drawing.Point(468, 192);
				this.txDate.Name = "txDate";
				this.txDate.Size = new System.Drawing.Size(217, 23);
				this.txDate.TabIndex = 30;
				this.txDate.Text = "Date Consultation";
				// 
				// txNomMe
				// 
				this.txNomMe.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.txNomMe.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txNomMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.txNomMe.Location = new System.Drawing.Point(429, 158);
				this.txNomMe.Name = "txNomMe";
				this.txNomMe.Size = new System.Drawing.Size(289, 23);
				this.txNomMe.TabIndex = 31;
				// 
				// txNomMed
				// 
				this.txNomMed.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txNomMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txNomMed.Location = new System.Drawing.Point(468, 132);
				this.txNomMed.Name = "txNomMed";
				this.txNomMed.Size = new System.Drawing.Size(192, 23);
				this.txNomMed.TabIndex = 28;
				this.txNomMed.Text = "Medecin en charge";
				// 
				// btCancel
				// 
				this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.btCancel.FlatAppearance.BorderSize = 0;
				this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
				this.btCancel.Location = new System.Drawing.Point(32, 465);
				this.btCancel.Name = "btCancel";
				this.btCancel.Size = new System.Drawing.Size(80, 23);
				this.btCancel.TabIndex = 27;
				this.btCancel.Text = "Annuler";
				this.btCancel.UseVisualStyleBackColor = false;
				this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
				// 
				// comMotif
				// 
				this.comMotif.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.comMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.comMotif.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.comMotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.comMotif.FormattingEnabled = true;
				this.comMotif.Items.AddRange(new object[] {
			"Ulcere d\'estomac",
			"Mal au ventre, tete",
			"Anemie",
			"Appendicite",
			"Typhoide",
			"Malaria",
			"Oreillons",
			"Rougeole",
			"Rubeole"});
				this.comMotif.Location = new System.Drawing.Point(32, 320);
				this.comMotif.Name = "comMotif";
				this.comMotif.Size = new System.Drawing.Size(272, 23);
				this.comMotif.TabIndex = 22;
				// 
				// combConsul
				// 
				this.combConsul.BackColor = System.Drawing.SystemColors.ControlLightLight;
				this.combConsul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				this.combConsul.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.combConsul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.combConsul.FormattingEnabled = true;
				this.combConsul.Location = new System.Drawing.Point(32, 267);
				this.combConsul.Name = "combConsul";
				this.combConsul.Size = new System.Drawing.Size(272, 23);
				this.combConsul.TabIndex = 21;
				this.combConsul.SelectedIndexChanged += new System.EventHandler(this.CombConsulSelectedIndexChanged);
				// 
				// txNumero
				// 
				this.txNumero.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txNumero.Location = new System.Drawing.Point(77, 129);
				this.txNumero.Name = "txNumero";
				this.txNumero.Size = new System.Drawing.Size(127, 23);
				this.txNumero.TabIndex = 1;
				this.txNumero.Text = "Numero dossier";
				// 
				// txConsul
				// 
				this.txConsul.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txConsul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txConsul.Location = new System.Drawing.Point(35, 237);
				this.txConsul.Name = "txConsul";
				this.txConsul.Size = new System.Drawing.Size(232, 23);
				this.txConsul.TabIndex = 2;
				this.txConsul.Text = "Consultations pour les services";
				// 
				// txMotif
				// 
				this.txMotif.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txMotif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txMotif.Location = new System.Drawing.Point(61, 298);
				this.txMotif.Name = "txMotif";
				this.txMotif.Size = new System.Drawing.Size(178, 23);
				this.txMotif.TabIndex = 5;
				this.txMotif.Text = "Motif consultation";
				// 
				// txIdChambre
				// 
				this.txIdChambre.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txIdChambre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txIdChambre.Location = new System.Drawing.Point(65, 185);
				this.txIdChambre.Name = "txIdChambre";
				this.txIdChambre.Size = new System.Drawing.Size(139, 23);
				this.txIdChambre.TabIndex = 30;
				this.txIdChambre.Text = "Id Chambre choisie";
				// 
				// txPyAss
				// 
				this.txPyAss.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txPyAss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txPyAss.Location = new System.Drawing.Point(32, 351);
				this.txPyAss.Name = "txPyAss";
				this.txPyAss.Size = new System.Drawing.Size(237, 23);
				this.txPyAss.TabIndex = 3;
				this.txPyAss.Text = "Consultation payer par assurance";
				// 
				// txHospAss
				// 
				this.txHospAss.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.txHospAss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
				this.txHospAss.Location = new System.Drawing.Point(39, 286);
				this.txHospAss.Name = "txHospAss";
				this.txHospAss.Size = new System.Drawing.Size(223, 23);
				this.txHospAss.TabIndex = 33;
				this.txHospAss.Text = "Hospitalisation sur assurance";
				// 
				// consultation
				// 
				this.ClientSize = new System.Drawing.Size(1056, 539);
				this.Controls.Add(this.panelConsultation);
				this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
				this.Name = "consultation";
				this.Text = "consultation";
				this.Dock = System.Windows.Forms.DockStyle.Fill;
				this.panelConsultation.ResumeLayout(false);
				this.panelCons.ResumeLayout(false);
				this.souspanelCons.ResumeLayout(false);
				this.souspanelCons.PerformLayout();
				this.panel1.ResumeLayout(false);
				this.ResumeLayout(false);

			}
		
	}
}
	

	
	