/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 18/01/2021
 * Hora: 00:07
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interface01
{
	/// <summary>
	/// Description of CadLocacao.
	/// </summary>
	public partial class CadLocacao : Form
	{
		public CadLocacao()
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
				cnx.ExecutarQuery("INSERT INTO tblocacao (NOME,CARRO,VALORDIARIA,QTDDIARIA,SEGURO) VALUES ('"+txtNOME.Text+"', '"+txtCARRO.Text+"', '"+txtDIARIA.Text+"', '"+txtDIARIAS.Text+"', '"+txtSEGURO.Text+"');");
				MessageBox.Show("Locação Cadastradada Com Sucesso!");
				this.Hide();
			}else{
				MessageBox.Show("Não foi possível conectar com Banco de Dados!");
			}
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
