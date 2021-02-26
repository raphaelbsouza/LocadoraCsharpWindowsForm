/*
 * Criado por SharpDevelop.
 * Usuário: Usuario
 * Data: 02/02/2021
 * Hora: 10:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interface01
{
	/// <summary>
	/// Description of Deletar.
	/// </summary>
	public partial class Deletar : Form
	{
		public Deletar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			DELcarro del1 = new DELcarro();
			del1.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			DELcliente del2 = new DELcliente();
			del2.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			DELfuncionario del3 = new DELfuncionario();
			del3.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			DELlocacao del4 = new DELlocacao();
			del4.Show();
		}
	}
}
