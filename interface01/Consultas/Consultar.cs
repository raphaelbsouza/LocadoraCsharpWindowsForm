/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 25/01/2021
 * Hora: 00:37
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interface01
{
	/// <summary>
	/// Description of Consultar.
	/// </summary>
	public partial class Consultar : Form
	{
		public Consultar()
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
			ConCarros Con1 = new ConCarros();
			Con1.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			ConClientes concli1 = new ConClientes();
			concli1.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			ConFuncionarios confun1 = new ConFuncionarios();
			confun1.Show();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			ConLocacao conLoca = new ConLocacao();
			conLoca.Show();
		}
	}
}
