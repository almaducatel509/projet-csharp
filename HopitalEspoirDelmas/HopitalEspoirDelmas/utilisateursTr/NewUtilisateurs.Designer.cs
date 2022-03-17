/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 31/10/2021
 * Time: 05:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.utilisateursTr
{
	partial class NewUtilisateurs
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelUtil;
		private System.Windows.Forms.Panel barOutils;
		private System.Windows.Forms.Button btDesac;
		private System.Windows.Forms.Button btRetUt;
		private System.Windows.Forms.Button btSupUt;
		private System.Windows.Forms.Button btAjoutUt;
		private System.Windows.Forms.Button btModUt;
		private System.Windows.Forms.DataGridView dataUtil;
		private System.Windows.Forms.DataGridViewTextBoxColumn txUti;
		private System.Windows.Forms.DataGridViewTextBoxColumn txPseudo;
		private System.Windows.Forms.DataGridViewTextBoxColumn txEtat;
		private System.Windows.Forms.DataGridViewTextBoxColumn txListe;
		
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
			this.panelUtil = new System.Windows.Forms.Panel();
			this.dataUtil = new System.Windows.Forms.DataGridView();
			this.barOutils = new System.Windows.Forms.Panel();
			this.btDesac = new System.Windows.Forms.Button();
			this.btRetUt = new System.Windows.Forms.Button();
			this.btSupUt = new System.Windows.Forms.Button();
			this.btAjoutUt = new System.Windows.Forms.Button();
			this.btModUt = new System.Windows.Forms.Button();
			this.txUti = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txPseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txListe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelUtil.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataUtil)).BeginInit();
			this.barOutils.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelUtil
			// 
			this.panelUtil.BackColor = System.Drawing.Color.White;
			this.panelUtil.Controls.Add(this.dataUtil);
			this.panelUtil.Controls.Add(this.barOutils);
			this.panelUtil.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelUtil.Location = new System.Drawing.Point(0, 0);
			this.panelUtil.Name = "panelUtil";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelUtil.Size = new System.Drawing.Size(1049, 485);
			this.panelUtil.TabIndex = 0;
			// 
			// dataUtil
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataUtil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataUtil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataUtil.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataUtil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataUtil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataUtil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.txUti,
			this.txPseudo,
			this.txEtat,
			this.txListe});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataUtil.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataUtil.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataUtil.Location = new System.Drawing.Point(0, 30);
			this.dataUtil.Name = "dataUtil";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataUtil.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.dataUtil.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataUtil.Size = new System.Drawing.Size(1049, 455);
			this.dataUtil.TabIndex = 5;
			this.dataUtil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUtilCellContentClick);
			// 
			// barOutils
			// 
			this.barOutils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutils.Controls.Add(this.btDesac);
			this.barOutils.Controls.Add(this.btRetUt);
			this.barOutils.Controls.Add(this.btSupUt);
			this.barOutils.Controls.Add(this.btAjoutUt);
			this.barOutils.Controls.Add(this.btModUt);
			this.barOutils.Dock = System.Windows.Forms.DockStyle.Top;
			this.barOutils.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutils.Location = new System.Drawing.Point(0, 0);
			this.barOutils.Name = "barOutils";
			this.barOutils.Size = new System.Drawing.Size(1049, 30);
			this.barOutils.TabIndex = 4;
			// 
			// btDesac
			// 
			this.btDesac.BackColor = System.Drawing.Color.White;
			this.btDesac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDesac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btDesac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btDesac.Location = new System.Drawing.Point(330, 5);
			this.btDesac.Name = "btDesac";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btDesac.Size = new System.Drawing.Size(99, 26);
			this.btDesac.TabIndex = 6;
			this.btDesac.Text = "Desactiver";
			this.btDesac.UseVisualStyleBackColor = false;
			this.btDesac.Click += new System.EventHandler(this.BtDesacClick);
			// 
			// btRetUt
			// 
			this.btRetUt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btRetUt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btRetUt.FlatAppearance.BorderSize = 0;
			this.btRetUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRetUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRetUt.ForeColor = System.Drawing.Color.White;
			this.btRetUt.Location = new System.Drawing.Point(447, 5);
			this.btRetUt.Name = "btRetUt";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btRetUt.Size = new System.Drawing.Size(114, 24);
			this.btRetUt.TabIndex = 5;
			this.btRetUt.Text = "Retour";
			this.btRetUt.UseVisualStyleBackColor = false;
			this.btRetUt.Click += new System.EventHandler(this.BtRetUtClick);
			// 
			// btSupUt
			// 
			this.btSupUt.BackColor = System.Drawing.Color.White;
			this.btSupUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSupUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSupUt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btSupUt.Location = new System.Drawing.Point(224, 5);
			this.btSupUt.Name = "btSupUt";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btSupUt.Size = new System.Drawing.Size(106, 26);
			this.btSupUt.TabIndex = 4;
			this.btSupUt.Text = "SupprimerUti";
			this.btSupUt.UseVisualStyleBackColor = false;
			this.btSupUt.Click += new System.EventHandler(this.BtSupUtClick);
			// 
			// btAjoutUt
			// 
			this.btAjoutUt.BackColor = System.Drawing.Color.White;
			this.btAjoutUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAjoutUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAjoutUt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btAjoutUt.Location = new System.Drawing.Point(0, 5);
			this.btAjoutUt.Name = "btAjoutUt";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btAjoutUt.Size = new System.Drawing.Size(130, 27);
			this.btAjoutUt.TabIndex = 0;
			this.btAjoutUt.Text = "AjouterUtilisateur";
			this.btAjoutUt.UseVisualStyleBackColor = false;
			this.btAjoutUt.Click += new System.EventHandler(this.BtAjoutUtClick);
			// 
			// btModUt
			// 
			this.btModUt.BackColor = System.Drawing.Color.White;
			this.btModUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btModUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btModUt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btModUt.Location = new System.Drawing.Point(130, 5);
			this.btModUt.Name = "btModUt";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btModUt.Size = new System.Drawing.Size(94, 26);
			this.btModUt.TabIndex = 1;
			this.btModUt.Text = "ModifierUti";
			this.btModUt.UseVisualStyleBackColor = false;
			this.btModUt.Click += new System.EventHandler(this.BtModUtClick);
			// 
			// txUti
			// 
			this.txUti.HeaderText = "idEmp";
			this.txUti.Name = "txUti";
			// 
			// txPseudo
			// 
			this.txPseudo.HeaderText = "Pseudo";
			this.txPseudo.Name = "txPseudo";
			// 
			// txEtat
			// 
			this.txEtat.HeaderText = "Etat";
			this.txEtat.Name = "txEtat";
			// 
			// txListe
			// 
			this.txListe.HeaderText = "Listes d\'acces";
			this.txListe.Name = "txListe";
			// 
			// NewUtilisateurs
			// 
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1049, 485);
			this.Controls.Add(this.panelUtil);
			this.Name = "NewUtilisateurs";
			this.Text = "NewUtilisateurs";
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelUtil.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataUtil)).EndInit();
			this.barOutils.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
