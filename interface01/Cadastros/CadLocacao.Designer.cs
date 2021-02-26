/*
 * Criado por SharpDevelop.
 * Usuário: RAPH-DESKTOP
 * Data: 18/01/2021
 * Hora: 00:07
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace interface01
{
	partial class CadLocacao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadLocacao));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNOME = new System.Windows.Forms.TextBox();
			this.txtCARRO = new System.Windows.Forms.TextBox();
			this.txtDIARIA = new System.Windows.Forms.TextBox();
			this.txtDIARIAS = new System.Windows.Forms.TextBox();
			this.txtSEGURO = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(101, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(370, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "CADASTRO DE LOCAÇÃO";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(70, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOME:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "QTD DIÁRIAS:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(4, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 22);
			this.label4.TabIndex = 3;
			this.label4.Text = "VALOR DIÁRIA:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(4, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(130, 22);
			this.label5.TabIndex = 4;
			this.label5.Text = "VALOR SEGURO:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(61, 106);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 22);
			this.label6.TabIndex = 5;
			this.label6.Text = "CARRO:";
			// 
			// txtNOME
			// 
			this.txtNOME.Location = new System.Drawing.Point(130, 75);
			this.txtNOME.Name = "txtNOME";
			this.txtNOME.Size = new System.Drawing.Size(393, 20);
			this.txtNOME.TabIndex = 0;
			// 
			// txtCARRO
			// 
			this.txtCARRO.Location = new System.Drawing.Point(130, 106);
			this.txtCARRO.Name = "txtCARRO";
			this.txtCARRO.Size = new System.Drawing.Size(209, 20);
			this.txtCARRO.TabIndex = 1;
			// 
			// txtDIARIA
			// 
			this.txtDIARIA.Location = new System.Drawing.Point(130, 132);
			this.txtDIARIA.Name = "txtDIARIA";
			this.txtDIARIA.Size = new System.Drawing.Size(68, 20);
			this.txtDIARIA.TabIndex = 2;
			// 
			// txtDIARIAS
			// 
			this.txtDIARIAS.Location = new System.Drawing.Point(130, 154);
			this.txtDIARIAS.Name = "txtDIARIAS";
			this.txtDIARIAS.Size = new System.Drawing.Size(68, 20);
			this.txtDIARIAS.TabIndex = 3;
			this.txtDIARIAS.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
			// 
			// txtSEGURO
			// 
			this.txtSEGURO.Location = new System.Drawing.Point(130, 180);
			this.txtSEGURO.Name = "txtSEGURO";
			this.txtSEGURO.Size = new System.Drawing.Size(68, 20);
			this.txtSEGURO.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(101, 229);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 46);
			this.button1.TabIndex = 5;
			this.button1.Text = "CADASTRAR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(276, 229);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(169, 46);
			this.button2.TabIndex = 6;
			this.button2.Text = "FECHAR";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// CadLocacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 303);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtSEGURO);
			this.Controls.Add(this.txtDIARIAS);
			this.Controls.Add(this.txtDIARIA);
			this.Controls.Add(this.txtCARRO);
			this.Controls.Add(this.txtNOME);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadLocacao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Locação  (LOCADORA PRO v1.0)";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSEGURO;
		private System.Windows.Forms.TextBox txtDIARIAS;
		private System.Windows.Forms.TextBox txtDIARIA;
		private System.Windows.Forms.TextBox txtCARRO;
		private System.Windows.Forms.TextBox txtNOME;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
