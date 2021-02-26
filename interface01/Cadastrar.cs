/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 25/01/2021
 * Hora: 00:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interface01
{
	/// <summary>
	/// Description of Cadastrar.
	/// </summary>
	public partial class Cadastrar : Form
	{
		public Cadastrar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Cadcarros c1 = new Cadcarros();
			c1.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			CadClientes cad1 = new CadClientes();
			cad1.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			CadFuncionarios cadFun1 = new CadFuncionarios();
			cadFun1.Show();
		}
	}
}
