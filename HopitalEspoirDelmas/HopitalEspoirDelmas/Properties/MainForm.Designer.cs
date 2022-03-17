/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 07/10/2021
 * Time: 22:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HopitalEspoirDelmas.Properties.MainForm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelLogin;
		private System.Windows.Forms.Panel sousPanelLogin;
		private System.Windows.Forms.Label motP;
		private System.Windows.Forms.Label nomUser;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.TextBox txPassword;
		private System.Windows.Forms.TextBox txAdmin;
		private System.Windows.Forms.Panel sousPLgin;
		private System.Windows.Forms.Label labCon;
		private System.Windows.Forms.Panel panCenL;
		private System.Windows.Forms.Panel panSousDr;
		private System.Windows.Forms.Panel pLog;
		private System.Windows.Forms.Panel plo2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panlg;
		private System.Windows.Forms.Panel paLogh;
		private System.Windows.Forms.Label labconct;
//		private System.Windows.Forms.Label label1;
//		private System.Windows.Forms.Label label1;
		
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
		private void InitializeComponent(){
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelLogin = new System.Windows.Forms.Panel();
			this.sousPLgin = new System.Windows.Forms.Panel();
			this.paLogh = new System.Windows.Forms.Panel();
			this.labconct = new System.Windows.Forms.Label();
			this.panlg = new System.Windows.Forms.Panel();
			this.pLog = new System.Windows.Forms.Panel();
			this.sousPanelLogin = new System.Windows.Forms.Panel();
			this.plo2 = new System.Windows.Forms.Panel();
			this.panCenL = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panSousDr = new System.Windows.Forms.Panel();
			this.labCon = new System.Windows.Forms.Label();
			this.motP = new System.Windows.Forms.Label();
			this.nomUser = new System.Windows.Forms.Label();
			this.btLogin = new System.Windows.Forms.Button();
			this.txPassword = new System.Windows.Forms.TextBox();
			this.txAdmin = new System.Windows.Forms.TextBox();
			this.panelLogin.SuspendLayout();
			this.sousPLgin.SuspendLayout();
			this.sousPanelLogin.SuspendLayout();
			this.panCenL.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLogin
			// 
			this.panelLogin.BackColor = System.Drawing.Color.White;
			this.panelLogin.Controls.Add(this.sousPLgin);
			this.panelLogin.Controls.Add(this.sousPanelLogin);
			this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLogin.Location = new System.Drawing.Point(0, 0);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(632, 475);
			this.panelLogin.TabIndex = 0;
			// 
			// sousPLgin
			// 
			this.sousPLgin.BackColor = System.Drawing.Color.White;
			this.sousPLgin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sousPLgin.BackgroundImage")));
			this.sousPLgin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.sousPLgin.Controls.Add(this.paLogh);
			this.sousPLgin.Controls.Add(this.panlg);
			this.sousPLgin.Controls.Add(this.pLog);
			this.sousPLgin.Location = new System.Drawing.Point(0, 0);
			this.sousPLgin.Name = "sousPLgin";
			this.sousPLgin.Size = new System.Drawing.Size(325, 474);
			this.sousPLgin.TabIndex = 1;
			// 
			// paLogh
			// 
			this.paLogh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.paLogh.Dock = System.Windows.Forms.DockStyle.Top;
			this.paLogh.Location = new System.Drawing.Point(10, 0);
			this.paLogh.Name = "paLogh";
			this.paLogh.Size = new System.Drawing.Size(315, 35);
			this.paLogh.TabIndex = 10;
			// 
			// labconct
			// 
			this.labconct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.labconct.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labconct.ForeColor = System.Drawing.Color.White;
			this.labconct.Location = new System.Drawing.Point(85, 75);
			this.labconct.Name = "labconct";
			this.labconct.Size = new System.Drawing.Size(141, 28);
			this.labconct.TabIndex = 0;
			this.labconct.Text = "CONNECTION";
			this.labconct.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.labconct.Click += new System.EventHandler(this.Label1Click);
			// 
			// panlg
			// 
			this.panlg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.panlg.Dock = System.Windows.Forms.DockStyle.Left;
			this.panlg.Location = new System.Drawing.Point(0, 0);
			this.panlg.Name = "panlg";
			this.panlg.Size = new System.Drawing.Size(10, 446);
			this.panlg.TabIndex = 9;
			this.panlg.UseWaitCursor = true;
			// 
			// pLog
			// 
			this.pLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.pLog.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pLog.Location = new System.Drawing.Point(0, 446);
			this.pLog.Name = "pLog";
			this.pLog.Size = new System.Drawing.Size(325, 28);
			this.pLog.TabIndex = 0;
			// 
			// sousPanelLogin
			// 
			this.sousPanelLogin.AutoSize = true;
			this.sousPanelLogin.BackColor = System.Drawing.Color.White;
			this.sousPanelLogin.Controls.Add(this.labconct);
			this.sousPanelLogin.Controls.Add(this.plo2);
			this.sousPanelLogin.Controls.Add(this.panCenL);
			this.sousPanelLogin.Controls.Add(this.panSousDr);
			this.sousPanelLogin.Controls.Add(this.labCon);
			this.sousPanelLogin.Controls.Add(this.motP);
			this.sousPanelLogin.Controls.Add(this.nomUser);
			this.sousPanelLogin.Controls.Add(this.btLogin);
			this.sousPanelLogin.Controls.Add(this.txPassword);
			this.sousPanelLogin.Controls.Add(this.txAdmin);
			this.sousPanelLogin.Location = new System.Drawing.Point(321, 0);
			this.sousPanelLogin.Name = "sousPanelLogin";
			this.sousPanelLogin.Size = new System.Drawing.Size(310, 474);
			this.sousPanelLogin.TabIndex = 0;
			this.sousPanelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.SousPanelLoginPaint);
			// 
			// plo2
			// 
			this.plo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.plo2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.plo2.Location = new System.Drawing.Point(10, 446);
			this.plo2.Name = "plo2";
			this.plo2.Size = new System.Drawing.Size(290, 28);
			this.plo2.TabIndex = 8;
			// 
			// panCenL
			// 
			this.panCenL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.panCenL.Controls.Add(this.panel1);
			this.panCenL.Dock = System.Windows.Forms.DockStyle.Left;
			this.panCenL.Location = new System.Drawing.Point(0, 35);
			this.panCenL.Name = "panCenL";
			this.panCenL.Size = new System.Drawing.Size(10, 439);
			this.panCenL.TabIndex = 7;
			this.panCenL.UseWaitCursor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 439);
			this.panel1.TabIndex = 8;
			// 
			// panSousDr
			// 
			this.panSousDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.panSousDr.Dock = System.Windows.Forms.DockStyle.Right;
			this.panSousDr.Location = new System.Drawing.Point(300, 35);
			this.panSousDr.Name = "panSousDr";
			this.panSousDr.Size = new System.Drawing.Size(10, 439);
			this.panSousDr.TabIndex = 6;
			// 
			// labCon
			// 
			this.labCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.labCon.Dock = System.Windows.Forms.DockStyle.Top;
			this.labCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labCon.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCon.ForeColor = System.Drawing.Color.White;
			this.labCon.Location = new System.Drawing.Point(0, 0);
			this.labCon.Name = "labCon";
			this.labCon.Size = new System.Drawing.Size(310, 35);
			this.labCon.TabIndex = 5;
			this.labCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// motP
			// 
			this.motP.BackColor = System.Drawing.Color.White;
			this.motP.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.motP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.motP.Location = new System.Drawing.Point(27, 204);
			this.motP.Name = "motP";
			this.motP.Size = new System.Drawing.Size(142, 23);
			this.motP.TabIndex = 4;
			this.motP.Text = "Mot de passe";
			// 
			// nomUser
			// 
			this.nomUser.BackColor = System.Drawing.Color.White;
			this.nomUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nomUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.nomUser.Location = new System.Drawing.Point(27, 127);
			this.nomUser.Name = "nomUser";
			this.nomUser.Size = new System.Drawing.Size(81, 25);
			this.nomUser.TabIndex = 3;
			this.nomUser.Text = "Pseudo";
			// 
			// btLogin
			// 
			this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btLogin.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLogin.ForeColor = System.Drawing.Color.White;
			this.btLogin.Location = new System.Drawing.Point(85, 301);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(121, 35);
			this.btLogin.TabIndex = 2;
			this.btLogin.Text = "Connecter";
			this.btLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btLogin.UseVisualStyleBackColor = false;
			this.btLogin.Click += new System.EventHandler(this.BtLoginClick);
			// 
			// txPassword
			// 
			this.txPassword.BackColor = System.Drawing.Color.White;
			this.txPassword.Cursor = System.Windows.Forms.Cursors.Default;
			this.txPassword.Location = new System.Drawing.Point(26, 241);
			this.txPassword.Name = "txPassword";
			this.txPassword.PasswordChar = '*';
			this.txPassword.Size = new System.Drawing.Size(253, 20);
			this.txPassword.TabIndex = 1;
			// 
			// txAdmin
			// 
			this.txAdmin.BackColor = System.Drawing.Color.White;
			this.txAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txAdmin.Cursor = System.Windows.Forms.Cursors.Default;
			this.txAdmin.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txAdmin.ForeColor = System.Drawing.Color.Black;
			this.txAdmin.Location = new System.Drawing.Point(25, 160);
			this.txAdmin.Name = "txAdmin";
			this.txAdmin.Size = new System.Drawing.Size(254, 20);
			this.txAdmin.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(632, 475);
			this.Controls.Add(this.panelLogin);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Login";
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			this.sousPLgin.ResumeLayout(false);
			this.sousPanelLogin.ResumeLayout(false);
			this.sousPanelLogin.PerformLayout();
			this.panCenL.ResumeLayout(false);
			this.ResumeLayout(false);

		}
//		this.sousPanelLogin.PerformLayout();
//			this.ResumeLayout(false);

		}
	}

