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
	/// Description of CadFuncionarios.
	/// </summary>
	public partial class CadFuncionarios : Form
	{
		public CadFuncionarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ConexaoMySQL cnx = new ConexaoMySQL("locadora","root","admim");
			
			if(cnx.Open()){
				cnx.ExecutarQuery("INSERT INTO tbfuncionarios (NOME,ENDERECO,CPF,RG,TELEFONE) VALUES ('"+txtNOME.Text+"', '"+txtENDERECO.Text+"', '"+txtCPF.Text+"', '"+txtRG.Text+"', '"+txtTELEFONE.Text+"');");
				MessageBox.Show("Funcionário Cadastrado Com Sucesso!");
				this.Hide();
			}else{
				MessageBox.Show("Não foi possível conectar com Banco de Dados!");
			}
		}
	}
}
