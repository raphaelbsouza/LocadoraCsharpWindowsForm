/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 18/01/2021
 * Hora: 00:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interface01
{
	/// <summary>
	/// Description of ConFuncionarios.
	/// </summary>
	public partial class ConFuncionarios : Form
	{
		public ConFuncionarios()
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
				dgvFuncionarios.DataSource = cnx.ExecutarQuery("Select * From tbfuncionarios");
			}else{
				MessageBox.Show("Não foi possível conectar com Banco de Dados!");
			}
			MessageBox.Show("Lista de Funcionarios!");
		}			
		}
}
