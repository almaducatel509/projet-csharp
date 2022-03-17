/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 28/09/2021
 * Time: 10:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
 using System.Drawing;
 using System.Windows.Forms;
namespace HopitalEspoirDelmas.Properties.MainForm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelLogin;
		private System.Windows.Forms.TextBox txEntete;
		private System.Windows.Forms.Panel panelConnect;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.TextBox txtUtilisateur;
		private System.Windows.Forms.Label txMotP;
		private System.Windows.Forms.Label txNomUser;
//		private System.Windows.Forms.TextBox password1;
//		private System.Windows.Forms.TextBox txtUtilisateur1;
//		private System.Windows.Forms.Label txMotP1;
//		private System.Windows.Forms.Label txNomUser1;
		
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
		
		private void InitializeComponent()
		{
			{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelLogin = new System.Windows.Forms.Panel();
			this.txEntete = new System.Windows.Forms.TextBox();
			this.panelConnect = new System.Windows.Forms.Panel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txNomUser = new System.Windows.Forms.Label();
			this.txMotP = new System.Windows.Forms.Label();
			this.txtUtilisateur = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.panelLogin.SuspendLayout();
			this.panelConnect.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLogin
			// 
			this.panelLogin.BackColor = System.Drawing.Color.White;
			this.panelLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogin.BackgroundImage")));
			this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelLogin.Controls.Add(this.txEntete);
			this.panelLogin.Controls.Add(this.panelConnect);
			this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLogin.Location = new System.Drawing.Point(0, 0);
			this.panelLogin.Margin = new System.Windows.Forms.Padding(6);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(816, 473);
			this.panelLogin.TabIndex = 0;
			this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLoginPaint);
			// 
			// txEntete
			// 
			this.txEntete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.txEntete.Dock = System.Windows.Forms.DockStyle.Top;
			this.txEntete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txEntete.ForeColor = System.Drawing.Color.White;
			this.txEntete.Location = new System.Drawing.Point(0, 0);
			this.txEntete.Margin = new System.Windows.Forms.Padding(6);
			this.txEntete.Name = "txEntete";
			this.txEntete.Size = new System.Drawing.Size(816, 31);
			this.txEntete.TabIndex = 1;
			this.txEntete.Text = "Hopital Espoir de Delmas";
			this.txEntete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txEntete.TextChanged += new System.EventHandler(this.TxEnteteTextChanged);
			// 
			// panelConnect
			// 
			this.panelConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.panelConnect.Controls.Add(this.password);
			this.panelConnect.Controls.Add(this.txtUtilisateur);
			this.panelConnect.Controls.Add(this.txMotP);
			this.panelConnect.Controls.Add(this.txNomUser);
			this.panelConnect.Controls.Add(this.btnLogin);
			this.panelConnect.Location = new System.Drawing.Point(244, 43);
			this.panelConnect.Margin = new System.Windows.Forms.Padding(6);
			this.panelConnect.Name = "panelConnect";
			this.panelConnect.Size = new System.Drawing.Size(320, 356);
			this.panelConnect.TabIndex = 0;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.White;
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.btnLogin.Location = new System.Drawing.Point(114, 211);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(88, 35);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// txNomUser
			// 
			this.txNomUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.txNomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txNomUser.ForeColor = System.Drawing.Color.White;
			this.txNomUser.Location = new System.Drawing.Point(33, 102);
			this.txNomUser.Name = "txNomUser";
			this.txNomUser.Size = new System.Drawing.Size(117, 23);
			this.txNomUser.TabIndex = 1;
			this.txNomUser.Text = "Utilisateur";
			// 
			// txMotP
			// 
			this.txMotP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.txMotP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txMotP.ForeColor = System.Drawing.Color.White;
			this.txMotP.Location = new System.Drawing.Point(33, 162);
			this.txMotP.Name = "txMotP";
			this.txMotP.Size = new System.Drawing.Size(117, 30);
			this.txMotP.TabIndex = 2;
			this.txMotP.Text = "Mot de passe";
			// 
			// txtUtilisateur
			// 
			this.txtUtilisateur.Location = new System.Drawing.Point(149, 102);
			this.txtUtilisateur.Name = "txtUtilisateur";
			this.txtUtilisateur.Size = new System.Drawing.Size(147, 29);
			this.txtUtilisateur.TabIndex = 3;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(149, 156);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(147, 29);
			this.password.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 473);
			this.Controls.Add(this.panelLogin);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "MainForm";
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			this.panelConnect.ResumeLayout(false);
			this.panelConnect.PerformLayout();
			this.ResumeLayout(false);

		}// 
			// txNomUser
			// 
			this.txNomUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.txNomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txNomUser.ForeColor = System.Drawing.Color.White;
			this.txNomUser.Location = new System.Drawing.Point(33, 102);
			this.txNomUser.Name = "txNomUser";
			this.txNomUser.Size = new System.Drawing.Size(117, 23);
			this.txNomUser.TabIndex = 1;
			this.txNomUser.Text = "Utilisateur";
			// 
			// txMotP
			// 
			this.txMotP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(206)))), ((int)(((byte)(136)))));
			this.txMotP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txMotP.ForeColor = System.Drawing.Color.White;
			this.txMotP.Location = new System.Drawing.Point(33, 162);
			this.txMotP.Name = "txMotP";
			this.txMotP.Size = new System.Drawing.Size(117, 30);
			this.txMotP.TabIndex = 2;
			this.txMotP.Text = "Mot de passe";
			// 
			// txtUtilisateur
			// 
			this.txtUtilisateur.Location = new System.Drawing.Point(149, 102);
			this.txtUtilisateur.Name = "txtUtilisateur";
			this.txtUtilisateur.Size = new System.Drawing.Size(147, 29);
			this.txtUtilisateur.TabIndex = 3;
			
			// password
			// 
			this.password.Location = new System.Drawing.Point(149, 156);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(147, 29);
			this.password.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 473);
			this.Controls.Add(this.panelLogin);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "MainForm";
			this.panelLogin.ResumeLayout(false);
			this.panelLogin.PerformLayout();
			this.panelConnect.ResumeLayout(false);
			this.panelConnect.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

