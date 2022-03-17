/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 27/09/2021
 * Time: 23:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HopitalEspoirDelmas.ChambreTr;
namespace HopitalEspoirDelmas.container
{
	partial class chambre
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelChambre;
		private System.Windows.Forms.Panel souspanelCh2;
		private System.Windows.Forms.TextBox txConsCh;
		private System.Windows.Forms.TextBox txDescr;
		private System.Windows.Forms.RadioButton btAss2;
		private System.Windows.Forms.Label txCons;
		private System.Windows.Forms.RadioButton btAss1;
		private System.Windows.Forms.Label txAss;
		private System.Windows.Forms.Label txDesc;
		private System.Windows.Forms.Panel souspanelch1;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.ComboBox combEta;
		private System.Windows.Forms.TextBox txPrixL;
		private System.Windows.Forms.TextBox txChb;
		private System.Windows.Forms.ComboBox combCh;
		private System.Windows.Forms.Label txNom;
		private System.Windows.Forms.Label txType;
		private System.Windows.Forms.Label txPrix;
		private System.Windows.Forms.Label txEtat;
		private System.Windows.Forms.Panel formCh;
		private System.Windows.Forms.Button btEnregistrer;
		private System.Windows.Forms.Button btAfficher;
		private System.Windows.Forms.Button btModifier;
		
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
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chambre));
			this.panelChambre = new System.Windows.Forms.Panel();
			this.souspanelch1 = new System.Windows.Forms.Panel();
			this.btCancel = new System.Windows.Forms.Button();
			this.souspanelCh2 = new System.Windows.Forms.Panel();
			this.txConsCh = new System.Windows.Forms.TextBox();
			this.txDescr = new System.Windows.Forms.TextBox();
			this.btAss2 = new System.Windows.Forms.RadioButton();
			this.txCons = new System.Windows.Forms.Label();
			this.btAss1 = new System.Windows.Forms.RadioButton();
			this.txAss = new System.Windows.Forms.Label();
			this.txDesc = new System.Windows.Forms.Label();
			this.combEta = new System.Windows.Forms.ComboBox();
			this.txPrixL = new System.Windows.Forms.TextBox();
			this.txChb = new System.Windows.Forms.TextBox();
			this.combCh = new System.Windows.Forms.ComboBox();
			this.txNom = new System.Windows.Forms.Label();
			this.txType = new System.Windows.Forms.Label();
			this.txPrix = new System.Windows.Forms.Label();
			this.txEtat = new System.Windows.Forms.Label();
			this.formCh = new System.Windows.Forms.Panel();
			this.btEnregistrer = new System.Windows.Forms.Button();
			this.btAfficher = new System.Windows.Forms.Button();
			this.btModifier = new System.Windows.Forms.Button();
			this.panelChambre.SuspendLayout();
			this.souspanelch1.SuspendLayout();
			this.souspanelCh2.SuspendLayout();
			this.formCh.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelChambre
			// 
			this.panelChambre.BackColor = System.Drawing.Color.White;
			this.panelChambre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChambre.BackgroundImage")));
			this.panelChambre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelChambre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelChambre.Controls.Add(this.souspanelch1);
			this.panelChambre.Controls.Add(this.formCh);
			this.panelChambre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChambre.Location = new System.Drawing.Point(0, 0);
			this.panelChambre.Name = "panelChambre";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChambre.Size = new System.Drawing.Size(948, 520);
			this.panelChambre.TabIndex = 0;
			this.panelChambre.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChambrePaint);
			// 
			// souspanelch1
			// 
			this.souspanelch1.BackColor = System.Drawing.Color.White;
			this.souspanelch1.Controls.Add(this.btCancel);
			this.souspanelch1.Controls.Add(this.souspanelCh2);
			this.souspanelch1.Controls.Add(this.combEta);
			this.souspanelch1.Controls.Add(this.txPrixL);
			this.souspanelch1.Controls.Add(this.txChb);
			this.souspanelch1.Controls.Add(this.combCh);
			this.souspanelch1.Controls.Add(this.txNom);
			this.souspanelch1.Controls.Add(this.txType);
			this.souspanelch1.Controls.Add(this.txPrix);
			this.souspanelch1.Controls.Add(this.txEtat);
			this.souspanelch1.Cursor = System.Windows.Forms.Cursors.Default;
			this.souspanelch1.Dock = System.Windows.Forms.DockStyle.Left;
			this.souspanelch1.ForeColor = System.Drawing.Color.DimGray;
			this.souspanelch1.Location = new System.Drawing.Point(0, 86);
			this.souspanelch1.Name = "souspanelch1";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.souspanelch1.Size = new System.Drawing.Size(877, 430);
			this.souspanelch1.TabIndex = 30;
			this.souspanelch1.Paint += new System.Windows.Forms.PaintEventHandler(this.Souspanelch1Paint);
			// 
			// btCancel
			// 
			this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btCancel.FlatAppearance.BorderSize = 0;
			this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btCancel.Location = new System.Drawing.Point(77, 346);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(80, 23);
			this.btCancel.TabIndex = 27;
			this.btCancel.Text = "Annuler";
			this.btCancel.UseVisualStyleBackColor = false;
			this.btCancel.Click += new System.EventHandler(this.BtCancelClick);
			// 
			// souspanelCh2
			// 
			this.souspanelCh2.BackColor = System.Drawing.Color.White;
			this.souspanelCh2.Controls.Add(this.txConsCh);
			this.souspanelCh2.Controls.Add(this.txDescr);
			this.souspanelCh2.Controls.Add(this.btAss2);
			this.souspanelCh2.Controls.Add(this.txCons);
			this.souspanelCh2.Controls.Add(this.btAss1);
			this.souspanelCh2.Controls.Add(this.txAss);
			this.souspanelCh2.Controls.Add(this.txDesc);
			this.souspanelCh2.Cursor = System.Windows.Forms.Cursors.Default;
			this.souspanelCh2.Dock = System.Windows.Forms.DockStyle.Right;
			this.souspanelCh2.Location = new System.Drawing.Point(445, 0);
			this.souspanelCh2.Name = "souspanelCh2";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.souspanelCh2.Size = new System.Drawing.Size(432, 430);
			this.souspanelCh2.TabIndex = 31;
			this.souspanelCh2.Paint += new System.Windows.Forms.PaintEventHandler(this.SouspanelCh2Paint);
			// 
			// txConsCh
			// 
			this.txConsCh.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txConsCh.ForeColor = System.Drawing.Color.Turquoise;
			this.txConsCh.Location = new System.Drawing.Point(71, 124);
			this.txConsCh.Name = "txConsCh";
			this.txConsCh.Size = new System.Drawing.Size(278, 20);
			this.txConsCh.TabIndex = 20;
			// 
			// txDescr
			// 
			this.txDescr.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txDescr.ForeColor = System.Drawing.Color.Turquoise;
			this.txDescr.Location = new System.Drawing.Point(71, 198);
			this.txDescr.Name = "txDescr";
			this.txDescr.Size = new System.Drawing.Size(278, 20);
			this.txDescr.TabIndex = 17;
			// 
			// btAss2
			// 
			this.btAss2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btAss2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btAss2.Location = new System.Drawing.Point(247, 289);
			this.btAss2.Name = "btAss2";
			this.btAss2.Size = new System.Drawing.Size(102, 24);
			this.btAss2.TabIndex = 18;
			this.btAss2.TabStop = true;
			this.btAss2.Text = "Non";
			this.btAss2.UseVisualStyleBackColor = false;
			// 
			// txCons
			// 
			this.txCons.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txCons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txCons.Location = new System.Drawing.Point(114, 98);
			this.txCons.Name = "txCons";
			this.txCons.Size = new System.Drawing.Size(188, 23);
			this.txCons.TabIndex = 6;
			this.txCons.Text = "Constituant de la chambre";
			// 
			// btAss1
			// 
			this.btAss1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btAss1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btAss1.Location = new System.Drawing.Point(71, 289);
			this.btAss1.Name = "btAss1";
			this.btAss1.Size = new System.Drawing.Size(104, 24);
			this.btAss1.TabIndex = 17;
			this.btAss1.TabStop = true;
			this.btAss1.Text = "Oui";
			this.btAss1.UseVisualStyleBackColor = false;
			// 
			// txAss
			// 
			this.txAss.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txAss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txAss.Location = new System.Drawing.Point(138, 242);
			this.txAss.Name = "txAss";
			this.txAss.Size = new System.Drawing.Size(164, 23);
			this.txAss.TabIndex = 3;
			this.txAss.Text = "Couvrir par assurance";
			// 
			// txDesc
			// 
			this.txDesc.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txDesc.Location = new System.Drawing.Point(160, 168);
			this.txDesc.Name = "txDesc";
			this.txDesc.Size = new System.Drawing.Size(100, 23);
			this.txDesc.TabIndex = 7;
			this.txDesc.Text = "Description";
			// 
			// combEta
			// 
			this.combEta.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.combEta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combEta.ForeColor = System.Drawing.Color.Turquoise;
			this.combEta.FormattingEnabled = true;
			this.combEta.Items.AddRange(new object[] {
			"Disponible",
			"Non disponible"});
			this.combEta.Location = new System.Drawing.Point(77, 292);
			this.combEta.Name = "combEta";
			this.combEta.Size = new System.Drawing.Size(287, 21);
			this.combEta.TabIndex = 22;
			// 
			// txPrixL
			// 
			this.txPrixL.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txPrixL.ForeColor = System.Drawing.Color.Turquoise;
			this.txPrixL.Location = new System.Drawing.Point(77, 230);
			this.txPrixL.Name = "txPrixL";
			this.txPrixL.Size = new System.Drawing.Size(287, 20);
			this.txPrixL.TabIndex = 19;
			// 
			// txChb
			// 
			this.txChb.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txChb.ForeColor = System.Drawing.Color.Turquoise;
			this.txChb.Location = new System.Drawing.Point(77, 124);
			this.txChb.Name = "txChb";
			this.txChb.Size = new System.Drawing.Size(287, 20);
			this.txChb.TabIndex = 18;
			// 
			// combCh
			// 
			this.combCh.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.combCh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combCh.ForeColor = System.Drawing.Color.Turquoise;
			this.combCh.FormattingEnabled = true;
			this.combCh.Items.AddRange(new object[] {
			"Privee",
			"Commune",
			"Seule",
			"gite"});
			this.combCh.Location = new System.Drawing.Point(77, 169);
			this.combCh.Name = "combCh";
			this.combCh.Size = new System.Drawing.Size(287, 21);
			this.combCh.TabIndex = 21;
			// 
			// txNom
			// 
			this.txNom.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txNom.Location = new System.Drawing.Point(122, 98);
			this.txNom.Name = "txNom";
			this.txNom.Size = new System.Drawing.Size(132, 23);
			this.txNom.TabIndex = 1;
			this.txNom.Text = "Nom";
			// 
			// txType
			// 
			this.txType.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txType.Location = new System.Drawing.Point(122, 147);
			this.txType.Name = "txType";
			this.txType.Size = new System.Drawing.Size(100, 23);
			this.txType.TabIndex = 2;
			this.txType.Text = "type Chambre";
			// 
			// txPrix
			// 
			this.txPrix.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txPrix.Location = new System.Drawing.Point(122, 204);
			this.txPrix.Name = "txPrix";
			this.txPrix.Size = new System.Drawing.Size(154, 23);
			this.txPrix.TabIndex = 4;
			this.txPrix.Text = "Prix Location par jour";
			// 
			// txEtat
			// 
			this.txEtat.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txEtat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txEtat.Location = new System.Drawing.Point(122, 263);
			this.txEtat.Name = "txEtat";
			this.txEtat.Size = new System.Drawing.Size(100, 23);
			this.txEtat.TabIndex = 5;
			this.txEtat.Text = "Etat";
			// 
			// formCh
			// 
			this.formCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.formCh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.formCh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.formCh.Controls.Add(this.btEnregistrer);
			this.formCh.Controls.Add(this.btAfficher);
			this.formCh.Controls.Add(this.btModifier);
			this.formCh.Cursor = System.Windows.Forms.Cursors.Default;
			this.formCh.Dock = System.Windows.Forms.DockStyle.Top;
			this.formCh.Location = new System.Drawing.Point(0, 0);
			this.formCh.Name = "formCh";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formCh.Size = new System.Drawing.Size(944, 86);
			this.formCh.TabIndex = 29;
			// 
			// btEnregistrer
			// 
			this.btEnregistrer.AutoSize = true;
			this.btEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btEnregistrer.Dock = System.Windows.Forms.DockStyle.Right;
			this.btEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
			this.btEnregistrer.FlatAppearance.BorderSize = 0;
			this.btEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btEnregistrer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("btEnregistrer.Image")));
			this.btEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btEnregistrer.Location = new System.Drawing.Point(513, 0);
			this.btEnregistrer.Margin = new System.Windows.Forms.Padding(4);
			this.btEnregistrer.Name = "btEnregistrer";
			this.btEnregistrer.Size = new System.Drawing.Size(152, 84);
			this.btEnregistrer.TabIndex = 19;
			this.btEnregistrer.Text = "Enregistrer";
			this.btEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btEnregistrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btEnregistrer.UseMnemonic = false;
			this.btEnregistrer.UseVisualStyleBackColor = false;
			this.btEnregistrer.Click += new System.EventHandler(this.BtEnregistrerClick);
			// 
			// btAfficher
			// 
			this.btAfficher.AutoSize = true;
			this.btAfficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btAfficher.Cursor = System.Windows.Forms.Cursors.Default;
			this.btAfficher.Dock = System.Windows.Forms.DockStyle.Right;
			this.btAfficher.FlatAppearance.BorderSize = 0;
			this.btAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAfficher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btAfficher.Image = ((System.Drawing.Image)(resources.GetObject("btAfficher.Image")));
			this.btAfficher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btAfficher.Location = new System.Drawing.Point(665, 0);
			this.btAfficher.Name = "btAfficher";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btAfficher.Size = new System.Drawing.Size(150, 84);
			this.btAfficher.TabIndex = 20;
			this.btAfficher.Text = "Afficher";
			this.btAfficher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btAfficher.UseMnemonic = false;
			this.btAfficher.UseVisualStyleBackColor = false;
			this.btAfficher.Click += new System.EventHandler(this.BtAfficherClick);
			// 
			// btModifier
			// 
			this.btModifier.AutoSize = true;
			this.btModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btModifier.Dock = System.Windows.Forms.DockStyle.Right;
			this.btModifier.FlatAppearance.BorderSize = 0;
			this.btModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btModifier.Image = ((System.Drawing.Image)(resources.GetObject("btModifier.Image")));
			this.btModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btModifier.Location = new System.Drawing.Point(815, 0);
			this.btModifier.Name = "btModifier";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btModifier.Size = new System.Drawing.Size(127, 84);
			this.btModifier.TabIndex = 21;
			this.btModifier.Text = "Modifier";
			this.btModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btModifier.UseMnemonic = false;
			this.btModifier.UseVisualStyleBackColor = false;
			this.btModifier.Click += new System.EventHandler(this.BtModifierClick);
			// 
			// chambre
			// 
			this.ClientSize = new System.Drawing.Size(948, 520);
			this.Controls.Add(this.panelChambre);
			this.Name = "chambre";
			this.Text = "chambre";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChambre.ResumeLayout(false);
			this.souspanelch1.ResumeLayout(false);
			this.souspanelch1.PerformLayout();
			this.souspanelCh2.ResumeLayout(false);
			this.souspanelCh2.PerformLayout();
			this.formCh.ResumeLayout(false);
			this.formCh.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
