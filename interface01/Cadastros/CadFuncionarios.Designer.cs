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
	partial class CadFuncionarios
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFuncionarios));
			this.txtTELEFONE = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.txtENDERECO = new System.Windows.Forms.TextBox();
			this.txtNOME = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTELEFONE
			// 
			this.txtTELEFONE.Location = new System.Drawing.Point(132, 165);
			this.txtTELEFONE.Name = "txtTELEFONE";
			this.txtTELEFONE.Size = new System.Drawing.Size(153, 20);
			this.txtTELEFONE.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(31, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 20);
			this.label7.TabIndex = 26;
			this.label7.Text = "TELEFONE:";
			// 
			// txtRG
			// 
			this.txtRG.Location = new System.Drawing.Point(132, 139);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(153, 20);
			this.txtRG.TabIndex = 3;
			// 
			// txtCPF
			// 
			this.txtCPF.Location = new System.Drawing.Point(132, 115);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(153, 20);
			this.txtCPF.TabIndex = 2;
			// 
			// txtENDERECO
			// 
			this.txtENDERECO.Location = new System.Drawing.Point(132, 91);
			this.txtENDERECO.Name = "txtENDERECO";
			this.txtENDERECO.Size = new System.Drawing.Size(365, 20);
			this.txtENDERECO.TabIndex = 1;
			// 
			// txtNOME
			// 
			this.txtNOME.Location = new System.Drawing.Point(132, 68);
			this.txtNOME.Name = "txtNOME";
			this.txtNOME.Size = new System.Drawing.Size(365, 20);
			this.txtNOME.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(87, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 20);
			this.label4.TabIndex = 17;
			this.label4.Text = "RG:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 20);
			this.label3.TabIndex = 16;
			this.label3.Text = "ENDEREÇO:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(77, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "CPF:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(65, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "NOME:";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(269, 214);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 25);
			this.button2.TabIndex = 6;
			this.button2.Text = "FECHAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(132, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 25);
			this.button1.TabIndex = 5;
			this.button1.Text = "CADASTRAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(132, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(299, 24);
			this.label8.TabIndex = 30;
			this.label8.Text = "CADASTRO DE FUNCIONÁRIOS";
			// 
			// CadFuncionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 257);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtTELEFONE);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtENDERECO);
			this.Controls.Add(this.txtNOME);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadFuncionarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Funcionários  (LOCADORA PRO v1.0)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNOME;
		private System.Windows.Forms.TextBox txtENDERECO;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTELEFONE;
	}
}
