/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 08/10/2021
 * Time: 15:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.ServiceType
{
	partial class ShowService
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataServ;
		private System.Windows.Forms.DataGridViewTextBoxColumn txService;
		private System.Windows.Forms.DataGridViewTextBoxColumn txNomSer;
		private System.Windows.Forms.DataGridViewTextBoxColumn txPrix;
		private System.Windows.Forms.DataGridViewComboBoxColumn combEt;
		private System.Windows.Forms.DataGridViewTextBoxColumn txDescrip;
		private System.Windows.Forms.DataGridViewCheckBoxColumn txAss;
		private System.Windows.Forms.Button button1;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataServ = new System.Windows.Forms.DataGridView();
			this.txService = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txNomSer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.combEt = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.txDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txAss = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataServ)).BeginInit();
			this.SuspendLayout();
			// 
			// dataServ
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.dataServ.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataServ.BackgroundColor = System.Drawing.Color.White;
			this.dataServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.txService,
			this.txNomSer,
			this.txPrix,
			this.combEt,
			this.txDescrip,
			this.txAss});
			this.dataServ.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataServ.GridColor = System.Drawing.Color.White;
			this.dataServ.Location = new System.Drawing.Point(0, 0);
			this.dataServ.Name = "dataServ";
			this.dataServ.Size = new System.Drawing.Size(816, 417);
			this.dataServ.StandardTab = true;
			this.dataServ.TabIndex = 0;
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
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// ShowService
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 417);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataServ);
			this.Name = "ShowService";
			this.Text = "ShowService";
			((System.ComponentModel.ISupportInitialize)(this.dataServ)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
