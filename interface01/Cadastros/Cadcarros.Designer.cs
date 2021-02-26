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
	partial class Cadcarros
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadcarros));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMODELO = new System.Windows.Forms.TextBox();
			this.txtMARCA = new System.Windows.Forms.TextBox();
			this.txtPLACA = new System.Windows.Forms.TextBox();
			this.txtCHASSI = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCATEGORIA = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(84, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastro de Carros";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "MODELO:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "MARCA:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "PLACA:";
			// 
			// txtMODELO
			// 
			this.txtMODELO.Location = new System.Drawing.Point(113, 69);
			this.txtMODELO.Name = "txtMODELO";
			this.txtMODELO.Size = new System.Drawing.Size(156, 20);
			this.txtMODELO.TabIndex = 0;
			this.txtMODELO.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// txtMARCA
			// 
			this.txtMARCA.Location = new System.Drawing.Point(113, 100);
			this.txtMARCA.Name = "txtMARCA";
			this.txtMARCA.Size = new System.Drawing.Size(156, 20);
			this.txtMARCA.TabIndex = 1;
			// 
			// txtPLACA
			// 
			this.txtPLACA.Location = new System.Drawing.Point(113, 155);
			this.txtPLACA.Name = "txtPLACA";
			this.txtPLACA.Size = new System.Drawing.Size(156, 20);
			this.txtPLACA.TabIndex = 3;
			// 
			// txtCHASSI
			// 
			this.txtCHASSI.Location = new System.Drawing.Point(113, 184);
			this.txtCHASSI.Name = "txtCHASSI";
			this.txtCHASSI.Size = new System.Drawing.Size(156, 20);
			this.txtCHASSI.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "CHASSI:";
			// 
			// txtCATEGORIA
			// 
			this.txtCATEGORIA.Location = new System.Drawing.Point(113, 125);
			this.txtCATEGORIA.Name = "txtCATEGORIA";
			this.txtCATEGORIA.Size = new System.Drawing.Size(156, 20);
			this.txtCATEGORIA.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 18);
			this.label6.TabIndex = 10;
			this.label6.Text = "CATEGORIA:";
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(113, 222);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(168, 24);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Veículo Disponível";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(194, 271);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 47);
			this.button1.TabIndex = 7;
			this.button1.Text = "VOLTAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.Location = new System.Drawing.Point(32, 271);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(156, 47);
			this.btnCadastrar.TabIndex = 6;
			this.btnCadastrar.Text = "CADASTRAR";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.Button2Click);
			// 
			// Cadcarros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 339);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtCATEGORIA);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCHASSI);
			this.Controls.Add(this.txtPLACA);
			this.Controls.Add(this.txtMARCA);
			this.Controls.Add(this.txtMODELO);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Cadcarros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Carros (LOCADORA PRO v1.0)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCATEGORIA;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCHASSI;
		private System.Windows.Forms.TextBox txtPLACA;
		private System.Windows.Forms.TextBox txtMARCA;
		private System.Windows.Forms.TextBox txtMODELO;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
