/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 27/09/2021
 * Time: 23:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using HopitalEspoirDelmas.Properties.MainForm;

namespace HopitalEspoirDelmas.container
{
	partial class menuPrincipal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Panel sousPb;
		private System.Windows.Forms.Panel sousPg;
		private System.Windows.Forms.Panel hopit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel sousPd;
		private System.Windows.Forms.Panel MenuHopital;
		private System.Windows.Forms.Panel pBar;
		private System.Windows.Forms.Panel pGcons;
		private System.Windows.Forms.Panel pGdos;
		private System.Windows.Forms.Panel pGcon;
		private System.Windows.Forms.Panel pGpers;
		private System.Windows.Forms.Panel pGch;
		private System.Windows.Forms.Panel pGser;
		private System.Windows.Forms.Button btnUtilisateurs;
		private System.Windows.Forms.Button btnConsultations;
		private System.Windows.Forms.Button btnDossier;
		private System.Windows.Forms.Button btnContrats;
		private System.Windows.Forms.Button btnPersonnel;
		private System.Windows.Forms.Button btnChambres;
		private System.Windows.Forms.Button btnservices;
		private System.Windows.Forms.Panel Logo;
		private System.Windows.Forms.Label labG4;
		private System.Windows.Forms.Label labG3;
		private System.Windows.Forms.Label labG2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btLogout;
		private System.Windows.Forms.Label labdelmas;
		private System.Windows.Forms.Label labTexHopit;
		private System.Windows.Forms.Label labUtAdm;
		private System.Windows.Forms.Label labUtilEn;
		private System.Windows.Forms.Label labHosAss;
		private System.Windows.Forms.Label labHosp;
		private System.Windows.Forms.Label labPatEnreg;
		private System.Windows.Forms.Label labChamD;
		private System.Windows.Forms.Label labSerDis;
		private System.Windows.Forms.PictureBox pictPanel;
		private System.Windows.Forms.Label labUtInac;
		
		
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
				
		private void InitializeComponent(){
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuPrincipal));
			this.mainPanel = new System.Windows.Forms.Panel();
			this.labUtInac = new System.Windows.Forms.Label();
			this.labdelmas = new System.Windows.Forms.Label();
			this.labTexHopit = new System.Windows.Forms.Label();
			this.labUtAdm = new System.Windows.Forms.Label();
			this.labUtilEn = new System.Windows.Forms.Label();
			this.labHosAss = new System.Windows.Forms.Label();
			this.labHosp = new System.Windows.Forms.Label();
			this.labPatEnreg = new System.Windows.Forms.Label();
			this.labChamD = new System.Windows.Forms.Label();
			this.labSerDis = new System.Windows.Forms.Label();
			this.pictPanel = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.labG4 = new System.Windows.Forms.Label();
			this.labG3 = new System.Windows.Forms.Label();
			this.labG2 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.sousPb = new System.Windows.Forms.Panel();
			this.sousPg = new System.Windows.Forms.Panel();
			this.hopit = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.sousPd = new System.Windows.Forms.Panel();
			this.MenuHopital = new System.Windows.Forms.Panel();
			this.btLogout = new System.Windows.Forms.Button();
			this.pBar = new System.Windows.Forms.Panel();
			this.pGcons = new System.Windows.Forms.Panel();
			this.pGdos = new System.Windows.Forms.Panel();
			this.pGcon = new System.Windows.Forms.Panel();
			this.pGpers = new System.Windows.Forms.Panel();
			this.pGch = new System.Windows.Forms.Panel();
			this.pGser = new System.Windows.Forms.Panel();
			this.btnUtilisateurs = new System.Windows.Forms.Button();
			this.btnConsultations = new System.Windows.Forms.Button();
			this.btnDossier = new System.Windows.Forms.Button();
			this.btnContrats = new System.Windows.Forms.Button();
			this.btnPersonnel = new System.Windows.Forms.Button();
			this.btnChambres = new System.Windows.Forms.Button();
			this.btnservices = new System.Windows.Forms.Button();
			this.Logo = new System.Windows.Forms.Panel();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictPanel)).BeginInit();
			this.hopit.SuspendLayout();
			this.MenuHopital.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.White;
			this.mainPanel.Controls.Add(this.labUtInac);
			this.mainPanel.Controls.Add(this.labdelmas);
			this.mainPanel.Controls.Add(this.labTexHopit);
			this.mainPanel.Controls.Add(this.labUtAdm);
			this.mainPanel.Controls.Add(this.labUtilEn);
			this.mainPanel.Controls.Add(this.labHosAss);
			this.mainPanel.Controls.Add(this.labHosp);
			this.mainPanel.Controls.Add(this.labPatEnreg);
			this.mainPanel.Controls.Add(this.labChamD);
			this.mainPanel.Controls.Add(this.labSerDis);
			this.mainPanel.Controls.Add(this.pictPanel);
			this.mainPanel.Controls.Add(this.label3);
			this.mainPanel.Controls.Add(this.labG4);
			this.mainPanel.Controls.Add(this.labG3);
			this.mainPanel.Controls.Add(this.labG2);
			this.mainPanel.Controls.Add(this.label2);
			this.mainPanel.Controls.Add(this.sousPb);
			this.mainPanel.Controls.Add(this.sousPg);
			this.mainPanel.Controls.Add(this.hopit);
			this.mainPanel.Controls.Add(this.sousPd);
			this.mainPanel.Controls.Add(this.MenuHopital);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1277, 749);
			this.mainPanel.TabIndex = 1;
			// 
			// labUtInac
			// 
			this.labUtInac.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labUtInac.ForeColor = System.Drawing.Color.DimGray;
			this.labUtInac.Location = new System.Drawing.Point(1071, 275);
			this.labUtInac.Name = "labUtInac";
			this.labUtInac.Size = new System.Drawing.Size(155, 30);
			this.labUtInac.TabIndex = 28;
			this.labUtInac.Text = "1 utilisateur inactif";
			// 
			// labdelmas
			// 
			this.labdelmas.AutoSize = true;
			this.labdelmas.BackColor = System.Drawing.Color.Transparent;
			this.labdelmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labdelmas.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labdelmas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
			this.labdelmas.Location = new System.Drawing.Point(264, 382);
			this.labdelmas.Name = "labdelmas";
			this.labdelmas.Size = new System.Drawing.Size(295, 24);
			this.labdelmas.TabIndex = 27;
			this.labdelmas.Text = "Rue Fragneau Ville, Port-au-Prince";
			this.labdelmas.Click += new System.EventHandler(this.LabdelmasClick);
			// 
			// labTexHopit
			// 
			this.labTexHopit.AutoSize = true;
			this.labTexHopit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labTexHopit.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTexHopit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.labTexHopit.Location = new System.Drawing.Point(264, 348);
			this.labTexHopit.Name = "labTexHopit";
			this.labTexHopit.Size = new System.Drawing.Size(365, 34);
			this.labTexHopit.TabIndex = 26;
			this.labTexHopit.Text = "Hospital Espoir de Delmas 75";
			// 
			// labUtAdm
			// 
			this.labUtAdm.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labUtAdm.ForeColor = System.Drawing.Color.DimGray;
			this.labUtAdm.Location = new System.Drawing.Point(1069, 247);
			this.labUtAdm.Name = "labUtAdm";
			this.labUtAdm.Size = new System.Drawing.Size(187, 30);
			this.labUtAdm.TabIndex = 25;
			this.labUtAdm.Text = "1 utilisateur inactif";
			// 
			// labUtilEn
			// 
			this.labUtilEn.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labUtilEn.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.labUtilEn.Location = new System.Drawing.Point(1071, 222);
			this.labUtilEn.Name = "labUtilEn";
			this.labUtilEn.Size = new System.Drawing.Size(185, 25);
			this.labUtilEn.TabIndex = 24;
			this.labUtilEn.Text = "1 superUtilisateur";
			// 
			// labHosAss
			// 
			this.labHosAss.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labHosAss.ForeColor = System.Drawing.Color.DimGray;
			this.labHosAss.Location = new System.Drawing.Point(874, 243);
			this.labHosAss.Name = "labHosAss";
			this.labHosAss.Size = new System.Drawing.Size(163, 30);
			this.labHosAss.TabIndex = 23;
			this.labHosAss.Text = "5 sur assurance";
			// 
			// labHosp
			// 
			this.labHosp.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labHosp.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.labHosp.Location = new System.Drawing.Point(876, 220);
			this.labHosp.Name = "labHosp";
			this.labHosp.Size = new System.Drawing.Size(145, 25);
			this.labHosp.TabIndex = 22;
			this.labHosp.Text = "6 Hospitalisé";
			// 
			// labPatEnreg
			// 
			this.labPatEnreg.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPatEnreg.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.labPatEnreg.Location = new System.Drawing.Point(675, 222);
			this.labPatEnreg.Name = "labPatEnreg";
			this.labPatEnreg.Size = new System.Drawing.Size(195, 25);
			this.labPatEnreg.TabIndex = 20;
			this.labPatEnreg.Text = "10 patients enregistré";
			// 
			// labChamD
			// 
			this.labChamD.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labChamD.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.labChamD.Location = new System.Drawing.Point(465, 222);
			this.labChamD.Name = "labChamD";
			this.labChamD.Size = new System.Drawing.Size(216, 25);
			this.labChamD.TabIndex = 18;
			this.labChamD.Text = "10 chambres disponible ";
			// 
			// labSerDis
			// 
			this.labSerDis.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labSerDis.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.labSerDis.Location = new System.Drawing.Point(264, 218);
			this.labSerDis.Name = "labSerDis";
			this.labSerDis.Size = new System.Drawing.Size(186, 25);
			this.labSerDis.TabIndex = 16;
			this.labSerDis.Text = "5 services disponible ";
			// 
			// pictPanel
			// 
			this.pictPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictPanel.ErrorImage = null;
			this.pictPanel.Image = ((System.Drawing.Image)(resources.GetObject("pictPanel.Image")));
			this.pictPanel.Location = new System.Drawing.Point(594, 406);
			this.pictPanel.Name = "pictPanel";
			this.pictPanel.Size = new System.Drawing.Size(451, 212);
			this.pictPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictPanel.TabIndex = 15;
			this.pictPanel.TabStop = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
			this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(1080, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 120);
			this.label3.TabIndex = 14;
			this.label3.Text = "Compte Utilisateur";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labG4
			// 
			this.labG4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(237)))), ((int)(((byte)(191)))));
			this.labG4.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labG4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.labG4.Image = ((System.Drawing.Image)(resources.GetObject("labG4.Image")));
			this.labG4.Location = new System.Drawing.Point(877, 99);
			this.labG4.Name = "labG4";
			this.labG4.Size = new System.Drawing.Size(180, 120);
			this.labG4.TabIndex = 13;
			this.labG4.Text = "Hospitalisation";
			this.labG4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labG3
			// 
			this.labG3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.labG3.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labG3.ForeColor = System.Drawing.Color.White;
			this.labG3.Image = ((System.Drawing.Image)(resources.GetObject("labG3.Image")));
			this.labG3.Location = new System.Drawing.Point(675, 99);
			this.labG3.Name = "labG3";
			this.labG3.Size = new System.Drawing.Size(180, 120);
			this.labG3.TabIndex = 12;
			this.labG3.Text = "Patient Enregistré";
			this.labG3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labG2
			// 
			this.labG2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(212)))), ((int)(((byte)(255)))));
			this.labG2.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labG2.ForeColor = System.Drawing.Color.White;
			this.labG2.Image = ((System.Drawing.Image)(resources.GetObject("labG2.Image")));
			this.labG2.Location = new System.Drawing.Point(471, 99);
			this.labG2.Name = "labG2";
			this.labG2.Size = new System.Drawing.Size(180, 120);
			this.labG2.TabIndex = 11;
			this.labG2.Text = "Chambre disponible";
			this.labG2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
			this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(264, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 120);
			this.label2.TabIndex = 10;
			this.label2.Text = "Service disponible";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// sousPb
			// 
			this.sousPb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.sousPb.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sousPb.Location = new System.Drawing.Point(213, 727);
			this.sousPb.Name = "sousPb";
			this.sousPb.Size = new System.Drawing.Size(1049, 22);
			this.sousPb.TabIndex = 9;
			// 
			// sousPg
			// 
			this.sousPg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.sousPg.Dock = System.Windows.Forms.DockStyle.Right;
			this.sousPg.Location = new System.Drawing.Point(1262, 80);
			this.sousPg.Name = "sousPg";
			this.sousPg.Size = new System.Drawing.Size(15, 669);
			this.sousPg.TabIndex = 7;
			this.sousPg.Paint += new System.Windows.Forms.PaintEventHandler(this.SousPgPaint);
			// 
			// hopit
			// 
			this.hopit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.hopit.Controls.Add(this.label1);
			this.hopit.Dock = System.Windows.Forms.DockStyle.Top;
			this.hopit.ForeColor = System.Drawing.SystemColors.Desktop;
			this.hopit.Location = new System.Drawing.Point(213, 0);
			this.hopit.Name = "hopit";
			this.hopit.Size = new System.Drawing.Size(1064, 80);
			this.hopit.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(207, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hopital Espoir de Delmas";
			// 
			// sousPd
			// 
			this.sousPd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.sousPd.Dock = System.Windows.Forms.DockStyle.Left;
			this.sousPd.Location = new System.Drawing.Point(200, 0);
			this.sousPd.Name = "sousPd";
			this.sousPd.Size = new System.Drawing.Size(13, 749);
			this.sousPd.TabIndex = 8;
			// 
			// MenuHopital
			// 
			this.MenuHopital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.MenuHopital.Controls.Add(this.btLogout);
			this.MenuHopital.Controls.Add(this.pBar);
			this.MenuHopital.Controls.Add(this.pGcons);
			this.MenuHopital.Controls.Add(this.pGdos);
			this.MenuHopital.Controls.Add(this.pGcon);
			this.MenuHopital.Controls.Add(this.pGpers);
			this.MenuHopital.Controls.Add(this.pGch);
			this.MenuHopital.Controls.Add(this.pGser);
			this.MenuHopital.Controls.Add(this.btnUtilisateurs);
			this.MenuHopital.Controls.Add(this.btnConsultations);
			this.MenuHopital.Controls.Add(this.btnDossier);
			this.MenuHopital.Controls.Add(this.btnContrats);
			this.MenuHopital.Controls.Add(this.btnPersonnel);
			this.MenuHopital.Controls.Add(this.btnChambres);
			this.MenuHopital.Controls.Add(this.btnservices);
			this.MenuHopital.Controls.Add(this.Logo);
			this.MenuHopital.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuHopital.Location = new System.Drawing.Point(0, 0);
			this.MenuHopital.Name = "MenuHopital";
			this.MenuHopital.Size = new System.Drawing.Size(200, 749);
			this.MenuHopital.TabIndex = 5;
			// 
			// btLogout
			// 
			this.btLogout.BackColor = System.Drawing.Color.White;
			this.btLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLogout.Location = new System.Drawing.Point(0, 695);
			this.btLogout.Name = "btLogout";
			this.btLogout.Size = new System.Drawing.Size(200, 32);
			this.btLogout.TabIndex = 15;
			this.btLogout.Text = "Deconnecter";
			this.btLogout.UseVisualStyleBackColor = false;
			this.btLogout.Click += new System.EventHandler(this.BtLogoutClick);
			// 
			// pBar
			// 
			this.pBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.pBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pBar.Location = new System.Drawing.Point(0, 727);
			this.pBar.Name = "pBar";
			this.pBar.Size = new System.Drawing.Size(200, 22);
			this.pBar.TabIndex = 15;
			// 
			// pGcons
			// 
			this.pGcons.BackColor = System.Drawing.Color.White;
			this.pGcons.Location = new System.Drawing.Point(0, 369);
			this.pGcons.Name = "pGcons";
			this.pGcons.Size = new System.Drawing.Size(200, 5);
			this.pGcons.TabIndex = 14;
			// 
			// pGdos
			// 
			this.pGdos.BackColor = System.Drawing.Color.White;
			this.pGdos.Location = new System.Drawing.Point(0, 325);
			this.pGdos.Name = "pGdos";
			this.pGdos.Size = new System.Drawing.Size(200, 5);
			this.pGdos.TabIndex = 13;
			// 
			// pGcon
			// 
			this.pGcon.BackColor = System.Drawing.Color.White;
			this.pGcon.Location = new System.Drawing.Point(0, 275);
			this.pGcon.Name = "pGcon";
			this.pGcon.Size = new System.Drawing.Size(200, 5);
			this.pGcon.TabIndex = 12;
			// 
			// pGpers
			// 
			this.pGpers.BackColor = System.Drawing.Color.White;
			this.pGpers.Location = new System.Drawing.Point(0, 220);
			this.pGpers.Name = "pGpers";
			this.pGpers.Size = new System.Drawing.Size(200, 5);
			this.pGpers.TabIndex = 11;
			// 
			// pGch
			// 
			this.pGch.BackColor = System.Drawing.Color.White;
			this.pGch.Location = new System.Drawing.Point(0, 175);
			this.pGch.Name = "pGch";
			this.pGch.Size = new System.Drawing.Size(200, 5);
			this.pGch.TabIndex = 10;
			// 
			// pGser
			// 
			this.pGser.BackColor = System.Drawing.Color.White;
			this.pGser.Location = new System.Drawing.Point(0, 130);
			this.pGser.Name = "pGser";
			this.pGser.Size = new System.Drawing.Size(200, 5);
			this.pGser.TabIndex = 9;
			// 
			// btnUtilisateurs
			// 
			this.btnUtilisateurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btnUtilisateurs.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnUtilisateurs.FlatAppearance.BorderSize = 0;
			this.btnUtilisateurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUtilisateurs.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUtilisateurs.ForeColor = System.Drawing.Color.White;
			this.btnUtilisateurs.Image = ((System.Drawing.Image)(resources.GetObject("btnUtilisateurs.Image")));
			this.btnUtilisateurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUtilisateurs.Location = new System.Drawing.Point(0, 380);
			this.btnUtilisateurs.Name = "btnUtilisateurs";
			this.btnUtilisateurs.Size = new System.Drawing.Size(200, 50);
			this.btnUtilisateurs.TabIndex = 8;
			this.btnUtilisateurs.Text = "GestionUtilisateurs";
			this.btnUtilisateurs.UseVisualStyleBackColor = false;
			this.btnUtilisateurs.Click += new System.EventHandler(this.BtnUtilisateursClick);
			// 
			// btnConsultations
			// 
			this.btnConsultations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btnConsultations.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnConsultations.FlatAppearance.BorderSize = 0;
			this.btnConsultations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultations.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultations.ForeColor = System.Drawing.Color.White;
			this.btnConsultations.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultations.Image")));
			this.btnConsultations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultations.Location = new System.Drawing.Point(0, 330);
			this.btnConsultations.Name = "btnConsultations";
			this.btnConsultations.Size = new System.Drawing.Size(200, 50);
			this.btnConsultations.TabIndex = 6;
			this.btnConsultations.Text = "GestionConsultations";
			this.btnConsultations.UseVisualStyleBackColor = false;
			this.btnConsultations.Click += new System.EventHandler(this.BtnConsultationsClick);
			// 
			// btnDossier
			// 
			this.btnDossier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btnDossier.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDossier.FlatAppearance.BorderSize = 0;
			this.btnDossier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDossier.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDossier.ForeColor = System.Drawing.Color.White;
			this.btnDossier.Image = ((System.Drawing.Image)(resources.GetObject("btnDossier.Image")));
			this.btnDossier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDossier.Location = new System.Drawing.Point(0, 280);
			this.btnDossier.Name = "btnDossier";
			this.btnDossier.Size = new System.Drawing.Size(200, 50);
			this.btnDossier.TabIndex = 5;
			this.btnDossier.Text = "GestionDossiers";
			this.btnDossier.UseVisualStyleBackColor = false;
			this.btnDossier.Click += new System.EventHandler(this.BtnDossierClick);
			// 
			// btnContrats
			// 
			this.btnContrats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btnContrats.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnContrats.FlatAppearance.BorderSize = 0;
			this.btnContrats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnContrats.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContrats.ForeColor = System.Drawing.Color.White;
			this.btnContrats.Image = ((System.Drawing.Image)(resources.GetObject("btnContrats.Image")));
			this.btnContrats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnContrats.Location = new System.Drawing.Point(0, 230);
			this.btnContrats.Name = "btnContrats";
			this.btnContrats.Size = new System.Drawing.Size(200, 50);
			this.btnContrats.TabIndex = 4;
			this.btnContrats.Text = "GestionContrats";
			this.btnContrats.UseVisualStyleBackColor = false;
			this.btnContrats.Click += new System.EventHandler(this.BtnContratsClick);
			// 
			// btnPersonnel
			// 
			this.btnPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btnPersonnel.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPersonnel.FlatAppearance.BorderSize = 0;
			this.btnPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPersonnel.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPersonnel.ForeColor = System.Drawing.Color.White;
			this.btnPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonnel.Image")));
			this.btnPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPersonnel.Location = new System.Drawing.Point(0, 180);
			this.btnPersonnel.Name = "btnPersonnel";
			this.btnPersonnel.Size = new System.Drawing.Size(200, 50);
			this.btnPersonnel.TabIndex = 3;
			this.btnPersonnel.Text = "GestionPersonnels";
			this.btnPersonnel.UseVisualStyleBackColor = false;
			this.btnPersonnel.Click += new System.EventHandler(this.BtnPersonnelClick);
			// 
			// btnChambres
			// 
			this.btnChambres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btnChambres.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnChambres.FlatAppearance.BorderSize = 0;
			this.btnChambres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChambres.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChambres.ForeColor = System.Drawing.Color.White;
			this.btnChambres.Image = ((System.Drawing.Image)(resources.GetObject("btnChambres.Image")));
			this.btnChambres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChambres.Location = new System.Drawing.Point(0, 130);
			this.btnChambres.Name = "btnChambres";
			this.btnChambres.Size = new System.Drawing.Size(200, 50);
			this.btnChambres.TabIndex = 2;
			this.btnChambres.Text = "GestionChambres";
			this.btnChambres.UseVisualStyleBackColor = false;
			this.btnChambres.Click += new System.EventHandler(this.BtnChambresClick);
			// 
			// btnservices
			// 
			this.btnservices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
			this.btnservices.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnservices.FlatAppearance.BorderSize = 0;
			this.btnservices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnservices.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnservices.ForeColor = System.Drawing.Color.White;
			this.btnservices.Image = ((System.Drawing.Image)(resources.GetObject("btnservices.Image")));
			this.btnservices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnservices.Location = new System.Drawing.Point(0, 80);
			this.btnservices.Name = "btnservices";
			this.btnservices.Size = new System.Drawing.Size(200, 50);
			this.btnservices.TabIndex = 1;
			this.btnservices.Text = "GestionServices";
			this.btnservices.UseVisualStyleBackColor = false;
			this.btnservices.Click += new System.EventHandler(this.BtnservicesClick);
			// 
			// Logo
			// 
			this.Logo.BackColor = System.Drawing.Color.White;
			this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
			this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
			this.Logo.Location = new System.Drawing.Point(0, 0);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(200, 80);
			this.Logo.TabIndex = 0;
			// 
			// menuPrincipal
			// 
			this.ClientSize = new System.Drawing.Size(1277, 749);
			this.Controls.Add(this.mainPanel);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "menuPrincipal";
			this.ShowIcon = false;
			this.Text = "menuPrincipal";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictPanel)).EndInit();
			this.hopit.ResumeLayout(false);
			this.MenuHopital.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
	}

