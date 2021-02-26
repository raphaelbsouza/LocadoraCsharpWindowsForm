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

namespace interface01
{
	/// <summary>
	/// Description of CadClientes.
	/// </summary>
	public partial class CadClientes : Form
	{
		public CadClientes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CadClientesLoad(object sender, EventArgs e)
		{
			
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ConexaoMySQL cnx = new ConexaoMySQL("locadora","root","admim");
			
			if(cnx.Open()){
				cnx.ExecutarQuery("INSERT INTO tbclientes (NOME,ENDERECO,CPF,RG,CNH,TIPOCNH,TELEFONE) VALUES ('"+txtNOMEC.Text+"', '"+txtEnd.Text+"', '"+txtCPF.Text+"', '"+txtRG.Text+"', '"+txtCNH.Text+"', '"+txtTipoCNH.Text+"', '"+txtTELEFONE.Text+"');");
				MessageBox.Show("Cliente Cadastrado!");
				this.Hide();
			}else{
				MessageBox.Show("Não foi possível conectar com Banco de Dados!");
			}
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
