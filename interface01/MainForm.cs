/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 17/01/2021
 * Hora: 23:37
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace interface01
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
		
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void CadastroToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Consultar c2 = new Consultar();
			c2.Show();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Cadastrar c1 = new Cadastrar();
			c1.Show();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button4Click(object sender, EventArgs e)
		{
			Deletar d1 = new Deletar();
			d1.Show();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Editar edi1 = new Editar();
			edi1.Show();
		}
	}
}
