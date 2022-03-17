/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 28/09/2021
 * Time: 10:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Windows.Forms;

namespace HopitalEspoirDelmas.Properties.MainForm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TxEnteteTextChanged(object sender, EventArgs e)
		{
	
		}
	    void BtnLoginClick(object sender, EventArgs e)
		{
	    	String utilisateur = txNomUser.Name;
	    	String mdp = password.Name;
	    	if (txNomUser.Name != "invite" && password.Name != "WAR")
	    	{
	    		
	    		 MessageBox.Show("connexion reussi");
				 this.Hide();
	    		 container.menuPrincipal me = new container.menuPrincipal();
	    	     me.Show();	   		
	    	}
	    	
	    	 
	    	else
	    	{
	    		MessageBox.Show("connexion echoue");
	    		
	    	}
	    	
	    	
			
			
		}
		void PanelLoginPaint(object sender, PaintEventArgs e)
		{
	
		}
	}
}
