/*
 * Created by SharpDevelop.
 * User: Wildar
 * Date: 06/10/2021
 * Time: 15:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace HopitalEspoirDelmas.baseHopital{	
namespace HopitalEspoirDelmas.container
{
	
	/// <summary>
	/// Description of ServicesView.
	/// </summary>
	public class ServicesView
	{
		MySqlConnection con = null;
		MySqlCommand comd = null;
		MySqlDataReader read = null;
		MySqlDataAdapter adap = null;
		public ServicesView()
		{
		}
		
		void EnregistrerService(ServiceTraitement ser){
			//preparation de la requete
			String prepareRequest = "insert into services values (@,@,@,@,@,@,@)";
			//Recuperation de la connection
			con = DbHopitalEs.Connection();
			
			//con = new MySqlConnection();
			comd = new MySqlCommand(prepareRequest, con);
			
			
			comd.Parameters.AddWithValue("IdService", null);
			comd.Parameters.AddWithValue("nomService", ser.NomService);
			comd.Parameters.AddWithValue("nomChefService", ser.NomChefService);
			comd.Parameters.AddWithValue("PrixConsultation", ser.PrixConsultation);
			comd.Parameters.AddWithValue("Etat", ser.etat);
			comd.Parameters.AddWithValue("Description", ser.description);
			comd.Parameters.AddWithValue("CouvrirParAssurance", ser.couvrirParAssurance);
			
			int serv = comd.ExecuteNonQuery();
			if(serv ==1){
				MessageBox.Show("Service Enregistrer avec succes!","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
			else{
				MessageBox.Show("Enregistrement Echouer!","Notfound", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			}
		}
	}
	}
