/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 20/11/2021
 * Time: 07:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HopitalEspoirDelmas.container
{
	partial class Accueil
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel paAccueil;
		private System.Windows.Forms.Panel paAcc1;
		private System.Windows.Forms.Label labNom;
		private System.Windows.Forms.Label labWar;
		private System.Windows.Forms.PictureBox pictDoc;
		private System.Windows.Forms.Button btAcc;
		private System.Windows.Forms.PictureBox pictAcc;
		private System.Windows.Forms.Label laBAC;
		private System.Windows.Forms.Panel SouspanelAcc;
		private System.Windows.Forms.PictureBox pictLogo;
		private System.Windows.Forms.Panel paLoIm;
		private System.Windows.Forms.Label labcom;
		private System.Windows.Forms.Button btLogout;
		private System.Windows.Forms.Label labSante;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
			this.paAccueil = new System.Windows.Forms.Panel();
			this.labcom = new System.Windows.Forms.Label();
			this.paLoIm = new System.Windows.Forms.Panel();
			this.btLogout = new System.Windows.Forms.Button();
			this.btAcc = new System.Windows.Forms.Button();
			this.paAcc1 = new System.Windows.Forms.Panel();
			this.pictDoc = new System.Windows.Forms.PictureBox();
			this.labNom = new System.Windows.Forms.Label();
			this.pictAcc = new System.Windows.Forms.PictureBox();
			this.laBAC = new System.Windows.Forms.Label();
			this.SouspanelAcc = new System.Windows.Forms.Panel();
			this.labWar = new System.Windows.Forms.Label();
			this.pictLogo = new System.Windows.Forms.PictureBox();
			this.labSante = new System.Windows.Forms.Label();
			this.paAccueil.SuspendLayout();
			this.paLoIm.SuspendLayout();
			this.paAcc1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictDoc)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictAcc)).BeginInit();
			this.SouspanelAcc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// paAccueil
			// 
			this.paAccueil.BackColor = System.Drawing.Color.White;
			this.paAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.paAccueil.Controls.Add(this.labSante);
			this.paAccueil.Controls.Add(this.labcom);
			this.paAccueil.Controls.Add(this.paLoIm);
			this.paAccueil.Controls.Add(this.paAcc1);
			this.paAccueil.Controls.Add(this.pictAcc);
			this.paAccueil.Controls.Add(this.laBAC);
			this.paAccueil.Controls.Add(this.SouspanelAcc);
			this.paAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paAccueil.Location = new System.Drawing.Point(0, 0);
			this.paAccueil.Name = "paAccueil";
			this.paAccueil.Size = new System.Drawing.Size(1105, 633);
			this.paAccueil.TabIndex = 0;
			// 
			// labcom
			// 
			this.labcom.BackColor = System.Drawing.Color.White;
			this.labcom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labcom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labcom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.labcom.Location = new System.Drawing.Point(200, 521);
			this.labcom.Name = "labcom";
			this.labcom.Size = new System.Drawing.Size(905, 40);
			this.labcom.TabIndex = 4;
			this.labcom.Text = "Pour commencer";
			this.labcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// paLoIm
			// 
			this.paLoIm.BackColor = System.Drawing.Color.White;
			this.paLoIm.Controls.Add(this.btAcc);
			this.paLoIm.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.paLoIm.Location = new System.Drawing.Point(200, 561);
			this.paLoIm.Name = "paLoIm";
			this.paLoIm.Size = new System.Drawing.Size(905, 36);
			this.paLoIm.TabIndex = 5;
			// 
			// btLogout
			// 
			this.btLogout.BackColor = System.Drawing.Color.White;
			this.btLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btLogout.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btLogout.Location = new System.Drawing.Point(0, 561);
			this.btLogout.Name = "btLogout";
			this.btLogout.Size = new System.Drawing.Size(200, 36);
			this.btLogout.TabIndex = 4;
			this.btLogout.Text = "Logout";
			this.btLogout.UseVisualStyleBackColor = false;
			this.btLogout.Click += new System.EventHandler(this.BtLogoutClick);
			// 
			// btAcc
			// 
			this.btAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAcc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAcc.ForeColor = System.Drawing.Color.White;
			this.btAcc.Location = new System.Drawing.Point(526, 3);
			this.btAcc.Name = "btAcc";
			this.btAcc.Size = new System.Drawing.Size(119, 33);
			this.btAcc.TabIndex = 3;
			this.btAcc.Text = "Login";
			this.btAcc.UseVisualStyleBackColor = false;
			this.btAcc.Click += new System.EventHandler(this.BtAccClick);
			// 
			// paAcc1
			// 
			this.paAcc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.paAcc1.Controls.Add(this.pictDoc);
			this.paAcc1.Controls.Add(this.labNom);
			this.paAcc1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.paAcc1.Location = new System.Drawing.Point(200, 597);
			this.paAcc1.Name = "paAcc1";
			this.paAcc1.Size = new System.Drawing.Size(905, 36);
			this.paAcc1.TabIndex = 4;
			// 
			// pictDoc
			// 
			this.pictDoc.BackColor = System.Drawing.Color.White;
			this.pictDoc.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictDoc.ErrorImage = null;
			this.pictDoc.Image = ((System.Drawing.Image)(resources.GetObject("pictDoc.Image")));
			this.pictDoc.Location = new System.Drawing.Point(808, 0);
			this.pictDoc.Name = "pictDoc";
			this.pictDoc.Size = new System.Drawing.Size(97, 36);
			this.pictDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictDoc.TabIndex = 0;
			this.pictDoc.TabStop = false;
			// 
			// labNom
			// 
			this.labNom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNom.ForeColor = System.Drawing.Color.White;
			this.labNom.Location = new System.Drawing.Point(408, 9);
			this.labNom.Name = "labNom";
			this.labNom.Size = new System.Drawing.Size(397, 24);
			this.labNom.TabIndex = 4;
			this.labNom.Text = "Crée par le groupe WAR Composé de : Wildarline, Alma, Rose-Kenflore";
			// 
			// pictAcc
			// 
			this.pictAcc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictAcc.ErrorImage = null;
			this.pictAcc.Image = ((System.Drawing.Image)(resources.GetObject("pictAcc.Image")));
			this.pictAcc.Location = new System.Drawing.Point(200, 37);
			this.pictAcc.Name = "pictAcc";
			this.pictAcc.Size = new System.Drawing.Size(905, 596);
			this.pictAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictAcc.TabIndex = 2;
			this.pictAcc.TabStop = false;
			// 
			// laBAC
			// 
			this.laBAC.Dock = System.Windows.Forms.DockStyle.Top;
			this.laBAC.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.laBAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.laBAC.Location = new System.Drawing.Point(200, 0);
			this.laBAC.Name = "laBAC";
			this.laBAC.Size = new System.Drawing.Size(905, 37);
			this.laBAC.TabIndex = 1;
			this.laBAC.Text = "WELCOME TO HOPITAL ESPOIR !!!";
			this.laBAC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// SouspanelAcc
			// 
			this.SouspanelAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.SouspanelAcc.Controls.Add(this.btLogout);
			this.SouspanelAcc.Controls.Add(this.labWar);
			this.SouspanelAcc.Controls.Add(this.pictLogo);
			this.SouspanelAcc.Dock = System.Windows.Forms.DockStyle.Left;
			this.SouspanelAcc.Location = new System.Drawing.Point(0, 0);
			this.SouspanelAcc.Name = "SouspanelAcc";
			this.SouspanelAcc.Size = new System.Drawing.Size(200, 633);
			this.SouspanelAcc.TabIndex = 0;
			// 
			// labWar
			// 
			this.labWar.BackColor = System.Drawing.Color.White;
			this.labWar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labWar.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labWar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.labWar.Location = new System.Drawing.Point(0, 597);
			this.labWar.Name = "labWar";
			this.labWar.Size = new System.Drawing.Size(200, 36);
			this.labWar.TabIndex = 1;
			this.labWar.Text = "WAR";
			this.labWar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictLogo
			// 
			this.pictLogo.BackColor = System.Drawing.Color.White;
			this.pictLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictLogo.ErrorImage = null;
			this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
			this.pictLogo.Location = new System.Drawing.Point(0, 0);
			this.pictLogo.Name = "pictLogo";
			this.pictLogo.Size = new System.Drawing.Size(200, 113);
			this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictLogo.TabIndex = 0;
			this.pictLogo.TabStop = false;
			// 
			// labSante
			// 
			this.labSante.Dock = System.Windows.Forms.DockStyle.Top;
			this.labSante.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.labSante.Location = new System.Drawing.Point(200, 37);
			this.labSante.Name = "labSante";
			this.labSante.Size = new System.Drawing.Size(905, 37);
			this.labSante.TabIndex = 6;
			this.labSante.Text = "Votre santé c\'est notre priorité";
			this.labSante.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Accueil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1105, 633);
			this.Controls.Add(this.paAccueil);
			this.Name = "Accueil";
			this.ShowIcon = false;
			this.Text = "Accueil";
			this.paAccueil.ResumeLayout(false);
			this.paLoIm.ResumeLayout(false);
			this.paAcc1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictDoc)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictAcc)).EndInit();
			this.SouspanelAcc.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
