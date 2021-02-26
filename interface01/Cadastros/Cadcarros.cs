/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 18/01/2021
 * Hora: 00:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace interface01
{
	/// <summary>
	/// Description of CadServicos.
	/// </summary>
	public partial class Cadcarros : Form
	{
		public Cadcarros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{	
			ConexaoMySQL cnx = new ConexaoMySQL("locadora","root","admim");
			
			if(cnx.Open()){
				cnx.ExecutarQuery("INSERT INTO tbcarros (MODELO,MARCA,CATEGORIA,PLACA,CHASSI) VALUES ('"+txtMODELO.Text+"', '"+txtMARCA.Text+"', '"+txtCATEGORIA.Text+"', '"+txtPLACA.Text+"', '"+txtCHASSI.Text+"');");
				MessageBox.Show("Cliente Cadastrado!");
				this.Hide();
			}else{
				MessageBox.Show("Não foi possível conectar com Banco de Dados!");
			}

		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
