﻿namespace EjemploConexionBBDD
{
	partial class FormularioAltas
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dni = new System.Windows.Forms.TextBox();
			this.nombre = new System.Windows.Forms.TextBox();
			this.apellido = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.volver = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dni
			// 
			this.dni.Location = new System.Drawing.Point(246, 40);
			this.dni.Name = "dni";
			this.dni.Size = new System.Drawing.Size(178, 20);
			this.dni.TabIndex = 0;
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(246, 80);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(178, 20);
			this.nombre.TabIndex = 1;
			// 
			// apellido
			// 
			this.apellido.Location = new System.Drawing.Point(246, 121);
			this.apellido.Name = "apellido";
			this.apellido.Size = new System.Drawing.Size(178, 20);
			this.apellido.TabIndex = 2;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(246, 168);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(178, 20);
			this.email.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(187, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "DNI";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(187, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(187, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Apellido";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(187, 175);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "email";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(349, 216);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Dar de alta";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// volver
			// 
			this.volver.Location = new System.Drawing.Point(246, 216);
			this.volver.Name = "volver";
			this.volver.Size = new System.Drawing.Size(75, 23);
			this.volver.TabIndex = 9;
			this.volver.Text = "Volver";
			this.volver.UseVisualStyleBackColor = true;
			this.volver.Click += new System.EventHandler(this.volver_Click);
			// 
			// FormularioAltas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.volver);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.email);
			this.Controls.Add(this.apellido);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.dni);
			this.Name = "FormularioAltas";
			this.Text = "FormularioAltas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox dni;
		private System.Windows.Forms.TextBox nombre;
		private System.Windows.Forms.TextBox apellido;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button volver;
	}
}