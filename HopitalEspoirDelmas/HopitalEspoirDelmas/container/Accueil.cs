/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 20/11/2021
 * Time: 07:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using HopitalEspoirDelmas.Properties.MainForm;
using HopitalEspoirDelmas.baseHopital;
namespace HopitalEspoirDelmas.container
{
	/// <summary>
	/// Description of Accueil.
	/// </summary>
	public partial class Accueil : Form
	{
		public Accueil()
		{
			
			InitializeComponent();
			
			
		}
		void BtAccClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm m = new MainForm();
			m.Show();
		}
		void BtLogoutClick(object sender, EventArgs e)
		{
			Accueil a = new Accueil();
			this.Close();
		}
	}
}
