﻿namespace Colas_FIFO
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSimular = new System.Windows.Forms.Button();
			this.txtConsola = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSimular
			// 
			this.btnSimular.Location = new System.Drawing.Point(118, 28);
			this.btnSimular.Name = "btnSimular";
			this.btnSimular.Size = new System.Drawing.Size(181, 40);
			this.btnSimular.TabIndex = 0;
			this.btnSimular.Text = "Simular";
			this.btnSimular.UseVisualStyleBackColor = true;
			this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
			// 
			// txtConsola
			// 
			this.txtConsola.Location = new System.Drawing.Point(12, 84);
			this.txtConsola.Multiline = true;
			this.txtConsola.Name = "txtConsola";
			this.txtConsola.Size = new System.Drawing.Size(354, 130);
			this.txtConsola.TabIndex = 1;
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 226);
			this.Controls.Add(this.txtConsola);
			this.Controls.Add(this.btnSimular);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "frmPrincipal";
			this.Text = "Simulador FIFO";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSimular;
		private System.Windows.Forms.TextBox txtConsola;
	}
}

