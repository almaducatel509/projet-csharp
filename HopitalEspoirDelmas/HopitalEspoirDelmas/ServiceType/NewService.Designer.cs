/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 10/10/2021
 * Time: 17:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.ServiceType
{
	partial class NewService
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btBar1;
		private System.Windows.Forms.Button btModSer;
		private System.Windows.Forms.Panel barOutils;
		private System.Windows.Forms.DataGridView dataServ;
		private System.Windows.Forms.DataGridViewTextBoxColumn txService;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNomSer;
		private System.Windows.Forms.DataGridViewTextBoxColumn txPrix;
		private System.Windows.Forms.DataGridViewTextBoxColumn combEt;
		private System.Windows.Forms.DataGridViewTextBoxColumn txDescrip;
		private System.Windows.Forms.DataGridViewTextBoxColumn txAss;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNomChef;
		private System.Windows.Forms.Button btSuppS;
		private System.Windows.Forms.Button btRetS;
		private System.Windows.Forms.Panel panelServs;
		private System.Windows.Forms.Button btImprimerSer;
		//private System.Windows.Forms.Button btImprimerSer;
		
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
			this.panelServs = new System.Windows.Forms.Panel();
			this.dataServ = new System.Windows.Forms.DataGridView();
			this.txService = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNomSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.combEt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txAss = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNomChef = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btModSer = new System.Windows.Forms.Button();
			this.btBar1 = new System.Windows.Forms.Button();
			this.barOutils = new System.Windows.Forms.Panel();
			this.btImprimerSer = new System.Windows.Forms.Button();
			this.btRetS = new System.Windows.Forms.Button();
			this.btSuppS = new System.Windows.Forms.Button();
			this.panelServs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataServ)).BeginInit();
			this.barOutils.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelServs
			// 
			this.panelServs.Controls.Add(this.dataServ);
			this.panelServs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelServs.Location = new System.Drawing.Point(0, 30);
			this.panelServs.Name = "panelServs";
			this.panelServs.Size = new System.Drawing.Size(622, 509);
			this.panelServs.TabIndex = 3;
			// 
			// dataServ
			// 
			this.dataServ.AllowUserToResizeColumns = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataServ.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataServ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataServ.BackgroundColor = System.Drawing.Color.White;
			this.dataServ.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataServ.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataServ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.txService,
			this.txNomSer,
			this.txPrix,
			this.combEt,
			this.txDescrip,
			this.txAss,
			this.txNomChef});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataServ.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataServ.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataServ.GridColor = System.Drawing.Color.White;
			this.dataServ.Location = new System.Drawing.Point(0, 0);
			this.dataServ.Name = "dataServ";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataServ.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.dataServ.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataServ.Size = new System.Drawing.Size(622, 509);
			this.dataServ.StandardTab = true;
			this.dataServ.TabIndex = 4;
			this.dataServ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataServCellContentClick);
			// 
			// txService
			// 
			this.txService.HeaderText = "Id service";
			this.txService.Name = "txService";
			// 
			// txNomSer
			// 
			this.txNomSer.HeaderText = "Nom service";
			this.txNomSer.Name = "txNomSer";
			// 
			// txPrix
			// 
			this.txPrix.HeaderText = "Prix consultation";
			this.txPrix.Name = "txPrix";
			// 
			// combEt
			// 
			this.combEt.HeaderText = "Etat";
			this.combEt.Name = "combEt";
			this.combEt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.combEt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// txDescrip
			// 
			this.txDescrip.HeaderText = "Description";
			this.txDescrip.Name = "txDescrip";
			// 
			// txAss
			// 
			this.txAss.HeaderText = "Couvrir par assurance";
			this.txAss.Name = "txAss";
			this.txAss.ReadOnly = true;
			this.txAss.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.txAss.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// txNomChef
			// 
			this.txNomChef.HeaderText = "Nom chef service";
			this.txNomChef.Name = "txNomChef";
			// 
			// btModSer
			// 
			this.btModSer.BackColor = System.Drawing.Color.White;
			this.btModSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btModSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btModSer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btModSer.Location = new System.Drawing.Point(122, 5);
			this.btModSer.Name = "btModSer";
			this.btModSer.Size = new System.Drawing.Size(122, 26);
			this.btModSer.TabIndex = 1;
			this.btModSer.Text = "ModifierService";
			this.btModSer.UseVisualStyleBackColor = false;
			this.btModSer.Click += new System.EventHandler(this.BtModSerClick);
			// 
			// btBar1
			// 
			this.btBar1.BackColor = System.Drawing.Color.White;
			this.btBar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btBar1.Location = new System.Drawing.Point(0, 5);
			this.btBar1.Name = "btBar1";
			this.btBar1.Size = new System.Drawing.Size(125, 27);
			this.btBar1.TabIndex = 0;
			this.btBar1.Text = "AjouterService";
			this.btBar1.UseVisualStyleBackColor = false;
			this.btBar1.Click += new System.EventHandler(this.Button1Click);
			// 
			// barOutils
			// 
			this.barOutils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutils.Controls.Add(this.btImprimerSer);
			this.barOutils.Controls.Add(this.btRetS);
			this.barOutils.Controls.Add(this.btSuppS);
			this.barOutils.Controls.Add(this.btBar1);
			this.barOutils.Controls.Add(this.btModSer);
			this.barOutils.Dock = System.Windows.Forms.DockStyle.Top;
			this.barOutils.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.barOutils.Location = new System.Drawing.Point(0, 0);
			this.barOutils.Name = "barOutils";
			this.barOutils.Size = new System.Drawing.Size(622, 30);
			this.barOutils.TabIndex = 2;
			// 
			// btImprimerSer
			// 
			this.btImprimerSer.BackColor = System.Drawing.Color.White;
			this.btImprimerSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btImprimerSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btImprimerSer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btImprimerSer.Location = new System.Drawing.Point(388, 6);
			this.btImprimerSer.Name = "btImprimerSer";
			this.btImprimerSer.Size = new System.Drawing.Size(147, 26);
			this.btImprimerSer.TabIndex = 6;
			this.btImprimerSer.Text = "Imprimer";
			this.btImprimerSer.UseVisualStyleBackColor = false;
			this.btImprimerSer.Click += new System.EventHandler(this.BtImprimerSerClick);
			// 
			// btRetS
			// 
			this.btRetS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btRetS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btRetS.FlatAppearance.BorderSize = 0;
			this.btRetS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRetS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRetS.ForeColor = System.Drawing.Color.White;
			this.btRetS.Location = new System.Drawing.Point(538, 3);
			this.btRetS.Name = "btRetS";
			this.btRetS.Size = new System.Drawing.Size(130, 26);
			this.btRetS.TabIndex = 5;
			this.btRetS.Text = "Retour";
			this.btRetS.UseVisualStyleBackColor = false;
			this.btRetS.Click += new System.EventHandler(this.BtRetSClick);
			// 
			// btSuppS
			// 
			this.btSuppS.BackColor = System.Drawing.Color.White;
			this.btSuppS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSuppS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSuppS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btSuppS.Location = new System.Drawing.Point(242, 5);
			this.btSuppS.Name = "btSuppS";
			this.btSuppS.Size = new System.Drawing.Size(147, 26);
			this.btSuppS.TabIndex = 4;
			this.btSuppS.Text = "SupprimerService";
			this.btSuppS.UseVisualStyleBackColor = false;
			this.btSuppS.Click += new System.EventHandler(this.BtSuppSClick);
			// 
			// NewService
			// 
			this.AutoScroll = true;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(622, 539);
			this.Controls.Add(this.panelServs);
			this.Controls.Add(this.barOutils);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "NewService";
			this.Text = "NewService";
			this.panelServs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataServ)).EndInit();
			this.barOutils.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}