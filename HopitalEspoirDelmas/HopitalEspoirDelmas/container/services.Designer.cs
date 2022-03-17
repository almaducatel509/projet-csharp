/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 27/09/2021
 * Time: 23:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;



namespace HopitalEspoirDelmas.container
{
	partial class services
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelService;
		private System.Windows.Forms.Panel souspanelSer;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TextBox txPrix;
		private System.Windows.Forms.TextBox txNomSer;
		private System.Windows.Forms.Label txNom;
		private System.Windows.Forms.Label txNomChef;
		private System.Windows.Forms.Label txPrixCons;
		private System.Windows.Forms.Panel formCh;
		private System.Windows.Forms.Button btEnregistrer;
		private System.Windows.Forms.Button btAfficher;
		private System.Windows.Forms.Button btModifier;
		private System.Windows.Forms.Panel souspanelSer2;
		private System.Windows.Forms.ComboBox combEt;
		private System.Windows.Forms.TextBox txDescrip;
		private System.Windows.Forms.RadioButton btAss2;
		private System.Windows.Forms.RadioButton btAss1;
		private System.Windows.Forms.Label txAss;
		private System.Windows.Forms.Label txDesc;
		private System.Windows.Forms.Label txEtat;
		private System.Windows.Forms.TextBox txNomCh;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
			this.panelService = new System.Windows.Forms.Panel();
			this.souspanelSer = new System.Windows.Forms.Panel();
			this.txNomCh = new System.Windows.Forms.TextBox();
			this.btCancel = new System.Windows.Forms.Button();
			this.souspanelSer2 = new System.Windows.Forms.Panel();
			this.btAss2 = new System.Windows.Forms.RadioButton();
			this.btAss1 = new System.Windows.Forms.RadioButton();
			this.txDescrip = new System.Windows.Forms.TextBox();
			this.txEtat = new System.Windows.Forms.Label();
			this.combEt = new System.Windows.Forms.ComboBox();
			this.txDesc = new System.Windows.Forms.Label();
			this.txAss = new System.Windows.Forms.Label();
			this.txPrix = new System.Windows.Forms.TextBox();
			this.txNomSer = new System.Windows.Forms.TextBox();
			this.txNom = new System.Windows.Forms.Label();
			this.txNomChef = new System.Windows.Forms.Label();
			this.txPrixCons = new System.Windows.Forms.Label();
			this.formCh = new System.Windows.Forms.Panel();
			this.btEnregistrer = new System.Windows.Forms.Button();
			this.btAfficher = new System.Windows.Forms.Button();
			this.btModifier = new System.Windows.Forms.Button();
			this.panelService.SuspendLayout();
			this.souspanelSer.SuspendLayout();
			this.souspanelSer2.SuspendLayout();
			this.formCh.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelService
			// 
			this.panelService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelService.Controls.Add(this.souspanelSer);
			this.panelService.Controls.Add(this.formCh);
			this.panelService.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelService.Location = new System.Drawing.Point(0, 0);
			this.panelService.Name = "panelService";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelService.Size = new System.Drawing.Size(1004, 539);
			this.panelService.TabIndex = 0;
			// 
			// souspanelSer
			// 
			this.souspanelSer.BackColor = System.Drawing.Color.White;
			this.souspanelSer.Controls.Add(this.txNomCh);
			this.souspanelSer.Controls.Add(this.btCancel);
			this.souspanelSer.Controls.Add(this.souspanelSer2);
			this.souspanelSer.Controls.Add(this.txPrix);
			this.souspanelSer.Controls.Add(this.txNomSer);
			this.souspanelSer.Controls.Add(this.txNom);
			this.souspanelSer.Controls.Add(this.txNomChef);
			this.souspanelSer.Controls.Add(this.txPrixCons);
			this.souspanelSer.Cursor = System.Windows.Forms.Cursors.Default;
			this.souspanelSer.Dock = System.Windows.Forms.DockStyle.Left;
			this.souspanelSer.ForeColor = System.Drawing.Color.DimGray;
			this.souspanelSer.Location = new System.Drawing.Point(0, 86);
			this.souspanelSer.Name = "souspanelSer";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.souspanelSer.Size = new System.Drawing.Size(816, 453);
			this.souspanelSer.TabIndex = 33;
			// 
			// txNomCh
			// 
			this.txNomCh.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txNomCh.ForeColor = System.Drawing.Color.Turquoise;
			this.txNomCh.Location = new System.Drawing.Point(32, 151);
			this.txNomCh.Name = "txNomCh";
			this.txNomCh.Size = new System.Drawing.Size(317, 20);
			this.txNomCh.TabIndex = 28;
			// 
			// btCancel
			// 
			this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btCancel.FlatAppearance.BorderSize = 0;
			this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btCancel.Location = new System.Drawing.Point(41, 305);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(80, 23);
			this.btCancel.TabIndex = 27;
			this.btCancel.Text = "Annuler";
			this.btCancel.UseVisualStyleBackColor = false;
			this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
			// 
			// souspanelSer2
			// 
			this.souspanelSer2.BackColor = System.Drawing.Color.White;
			this.souspanelSer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.souspanelSer2.Controls.Add(this.btAss2);
			this.souspanelSer2.Controls.Add(this.btAss1);
			this.souspanelSer2.Controls.Add(this.txDescrip);
			this.souspanelSer2.Controls.Add(this.txEtat);
			this.souspanelSer2.Controls.Add(this.combEt);
			this.souspanelSer2.Controls.Add(this.txDesc);
			this.souspanelSer2.Controls.Add(this.txAss);
			this.souspanelSer2.Cursor = System.Windows.Forms.Cursors.Default;
			this.souspanelSer2.Dock = System.Windows.Forms.DockStyle.Right;
			this.souspanelSer2.Location = new System.Drawing.Point(424, 0);
			this.souspanelSer2.Name = "souspanelSer2";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.souspanelSer2.Size = new System.Drawing.Size(392, 453);
			this.souspanelSer2.TabIndex = 34;
			this.souspanelSer2.Paint += new System.Windows.Forms.PaintEventHandler(this.SouspanelSer2Paint);
			// 
			// btAss2
			// 
			this.btAss2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btAss2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btAss2.Location = new System.Drawing.Point(149, 209);
			this.btAss2.Name = "btAss2";
			this.btAss2.Size = new System.Drawing.Size(104, 24);
			this.btAss2.TabIndex = 36;
			this.btAss2.TabStop = true;
			this.btAss2.Text = "Non";
			this.btAss2.UseVisualStyleBackColor = false;
			// 
			// btAss1
			// 
			this.btAss1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btAss1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btAss1.Location = new System.Drawing.Point(33, 209);
			this.btAss1.Name = "btAss1";
			this.btAss1.Size = new System.Drawing.Size(78, 24);
			this.btAss1.TabIndex = 35;
			this.btAss1.TabStop = true;
			this.btAss1.Text = "Oui";
			this.btAss1.UseVisualStyleBackColor = false;
			// 
			// txDescrip
			// 
			this.txDescrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txDescrip.ForeColor = System.Drawing.Color.Turquoise;
			this.txDescrip.Location = new System.Drawing.Point(33, 151);
			this.txDescrip.Name = "txDescrip";
			this.txDescrip.Size = new System.Drawing.Size(299, 20);
			this.txDescrip.TabIndex = 17;
			this.txDescrip.TextChanged += new System.EventHandler(this.TxDescripTextChanged);
			// 
			// txEtat
			// 
			this.txEtat.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txEtat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txEtat.Location = new System.Drawing.Point(33, 28);
			this.txEtat.Name = "txEtat";
			this.txEtat.Size = new System.Drawing.Size(173, 23);
			this.txEtat.TabIndex = 5;
			this.txEtat.Text = "Etat";
			// 
			// combEt
			// 
			this.combEt.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.combEt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combEt.ForeColor = System.Drawing.Color.Turquoise;
			this.combEt.FormattingEnabled = true;
			this.combEt.Items.AddRange(new object[] {
			"Disponible",
			"Non disponible"});
			this.combEt.Location = new System.Drawing.Point(33, 65);
			this.combEt.Name = "combEt";
			this.combEt.Size = new System.Drawing.Size(299, 21);
			this.combEt.TabIndex = 22;
			this.combEt.SelectedIndexChanged += new System.EventHandler(this.CombEtSelectedIndexChanged);
			// 
			// txDesc
			// 
			this.txDesc.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txDesc.Location = new System.Drawing.Point(33, 110);
			this.txDesc.Name = "txDesc";
			this.txDesc.Size = new System.Drawing.Size(100, 23);
			this.txDesc.TabIndex = 7;
			this.txDesc.Text = "Description";
			// 
			// txAss
			// 
			this.txAss.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txAss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txAss.Location = new System.Drawing.Point(33, 183);
			this.txAss.Name = "txAss";
			this.txAss.Size = new System.Drawing.Size(164, 23);
			this.txAss.TabIndex = 3;
			this.txAss.Text = "Couvrir par assurance";
			this.txAss.Click += new System.EventHandler(this.TxAssClick);
			// 
			// txPrix
			// 
			this.txPrix.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txPrix.ForeColor = System.Drawing.Color.Turquoise;
			this.txPrix.Location = new System.Drawing.Point(32, 221);
			this.txPrix.Name = "txPrix";
			this.txPrix.Size = new System.Drawing.Size(317, 20);
			this.txPrix.TabIndex = 19;
			// 
			// txNomSer
			// 
			this.txNomSer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txNomSer.ForeColor = System.Drawing.Color.Turquoise;
			this.txNomSer.Location = new System.Drawing.Point(32, 65);
			this.txNomSer.Name = "txNomSer";
			this.txNomSer.Size = new System.Drawing.Size(317, 20);
			this.txNomSer.TabIndex = 18;
			// 
			// txNom
			// 
			this.txNom.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txNom.Location = new System.Drawing.Point(97, 39);
			this.txNom.Name = "txNom";
			this.txNom.Size = new System.Drawing.Size(100, 23);
			this.txNom.TabIndex = 1;
			this.txNom.Text = "NomService";
			// 
			// txNomChef
			// 
			this.txNomChef.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txNomChef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txNomChef.Location = new System.Drawing.Point(97, 110);
			this.txNomChef.Name = "txNomChef";
			this.txNomChef.Size = new System.Drawing.Size(135, 23);
			this.txNomChef.TabIndex = 2;
			this.txNomChef.Text = "Nom chef service";
			// 
			// txPrixCons
			// 
			this.txPrixCons.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txPrixCons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txPrixCons.Location = new System.Drawing.Point(97, 183);
			this.txPrixCons.Name = "txPrixCons";
			this.txPrixCons.Size = new System.Drawing.Size(130, 23);
			this.txPrixCons.TabIndex = 4;
			this.txPrixCons.Text = "Prix Consultation";
			// 
			// formCh
			// 
			this.formCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.formCh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.formCh.Controls.Add(this.btEnregistrer);
			this.formCh.Controls.Add(this.btAfficher);
			this.formCh.Controls.Add(this.btModifier);
			this.formCh.Cursor = System.Windows.Forms.Cursors.Default;
			this.formCh.Dock = System.Windows.Forms.DockStyle.Top;
			this.formCh.Location = new System.Drawing.Point(0, 0);
			this.formCh.Name = "formCh";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formCh.Size = new System.Drawing.Size(1004, 86);
			this.formCh.TabIndex = 32;
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
			this.btEnregistrer.Location = new System.Drawing.Point(402, 0);
			this.btEnregistrer.Name = "btEnregistrer";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btEnregistrer.Size = new System.Drawing.Size(200, 84);
			this.btEnregistrer.TabIndex = 19;
			this.btEnregistrer.Text = "Enregistrer";
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
			this.btAfficher.Location = new System.Drawing.Point(602, 0);
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
			this.btModifier.Location = new System.Drawing.Point(802, 0);
			this.btModifier.Name = "btModifier";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btModifier.Size = new System.Drawing.Size(200, 84);
			this.btModifier.TabIndex = 21;
			this.btModifier.Text = "Modifier";
			this.btModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btModifier.UseVisualStyleBackColor = false;
			this.btModifier.Click += new System.EventHandler(this.BtModifierClick);
			// 
			// services
			// 
			this.ClientSize = new System.Drawing.Size(1004, 539);
			this.Controls.Add(this.panelService);
			this.Name = "services";
			this.Text = "services";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelService.ResumeLayout(false);
			this.souspanelSer.ResumeLayout(false);
			this.souspanelSer.PerformLayout();
			this.souspanelSer2.ResumeLayout(false);
			this.souspanelSer2.PerformLayout();
			this.formCh.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}

