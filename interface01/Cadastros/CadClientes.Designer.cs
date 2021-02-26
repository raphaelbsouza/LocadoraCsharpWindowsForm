/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 18/01/2021
 * Hora: 00:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace interface01
{
	partial class CadClientes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadClientes));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNOMEC = new System.Windows.Forms.TextBox();
			this.txtEnd = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtCNH = new System.Windows.Forms.TextBox();
			this.txtTipoCNH = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTELEFONE = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOME:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(65, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "CPF:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "ENDEREÇO:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(75, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "RG:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(65, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "CNH:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(4, 212);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "TIPO DA CNH:";
			// 
			// txtNOMEC
			// 
			this.txtNOMEC.Location = new System.Drawing.Point(120, 88);
			this.txtNOMEC.Name = "txtNOMEC";
			this.txtNOMEC.Size = new System.Drawing.Size(365, 20);
			this.txtNOMEC.TabIndex = 0;
			// 
			// txtEnd
			// 
			this.txtEnd.Location = new System.Drawing.Point(120, 111);
			this.txtEnd.Name = "txtEnd";
			this.txtEnd.Size = new System.Drawing.Size(365, 20);
			this.txtEnd.TabIndex = 1;
			this.txtEnd.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// txtCPF
			// 
			this.txtCPF.Location = new System.Drawing.Point(120, 135);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(153, 20);
			this.txtCPF.TabIndex = 2;
			// 
			// txtRG
			// 
			this.txtRG.Location = new System.Drawing.Point(120, 159);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(153, 20);
			this.txtRG.TabIndex = 3;
			// 
			// txtCNH
			// 
			this.txtCNH.Location = new System.Drawing.Point(120, 184);
			this.txtCNH.Name = "txtCNH";
			this.txtCNH.Size = new System.Drawing.Size(153, 20);
			this.txtCNH.TabIndex = 4;
			// 
			// txtTipoCNH
			// 
			this.txtTipoCNH.Location = new System.Drawing.Point(120, 211);
			this.txtTipoCNH.Name = "txtTipoCNH";
			this.txtTipoCNH.Size = new System.Drawing.Size(153, 20);
			this.txtTipoCNH.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 241);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "TELEFONE:";
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// txtTELEFONE
			// 
			this.txtTELEFONE.Location = new System.Drawing.Point(120, 237);
			this.txtTELEFONE.Name = "txtTELEFONE";
			this.txtTELEFONE.Size = new System.Drawing.Size(153, 20);
			this.txtTELEFONE.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(100, 339);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 25);
			this.button1.TabIndex = 7;
			this.button1.Text = "CADASTRAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(237, 339);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 25);
			this.button2.TabIndex = 8;
			this.button2.Text = "FECHAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(120, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(241, 24);
			this.label8.TabIndex = 16;
			this.label8.Text = "CADASTRO DE CLIENTES";
			// 
			// CadClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 431);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtTELEFONE);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtTipoCNH);
			this.Controls.Add(this.txtCNH);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtEnd);
			this.Controls.Add(this.txtNOMEC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Clientes  (LOCADORA PRO v1.0)";
			this.Load += new System.EventHandler(this.CadClientesLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtTELEFONE;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTipoCNH;
		private System.Windows.Forms.TextBox txtCNH;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.TextBox txtEnd;
		private System.Windows.Forms.TextBox txtNOMEC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
