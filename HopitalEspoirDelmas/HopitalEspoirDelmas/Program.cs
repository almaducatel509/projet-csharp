/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 27/09/2021
 * Time: 23:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using HopitalEspoirDelmas.baseHopital;
using MySql.Data.MySqlClient;
using HopitalEspoirDelmas.container;
using HopitalEspoirDelmas.ServiceType;
using HopitalEspoirDelmas.Traitement;
using HopitalEspoirDelmas.consultationTr;

namespace HopitalEspoirDelmas.Properties.MainForm
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThreadAttribute]
		private static void Main(string[] args)
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
//			Application.Run(new MainForm());
			Application.Run(new Accueil());
			
		}
		
	}
}
