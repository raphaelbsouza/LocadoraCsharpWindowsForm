/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 18/01/2021
 * Hora: 00:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interface01
{
	/// <summary>
	/// Description of ConLocacao.
	/// </summary>
	public partial class ConLocacao : Form
	{
		public ConLocacao()
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
			ConexaoMySQL cnx = new ConexaoMySQL("locadora","root","admim");
			
			if(cnx.Open()){
				dgvLocacao.DataSource = cnx.ExecutarQuery("Select * From tblocacao");
			}else{
				MessageBox.Show("Não foi possível conectar com Banco de Dados!");
			}
			MessageBox.Show("Informações do Consultado.");			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
