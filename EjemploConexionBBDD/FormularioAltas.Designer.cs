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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dni = new System.Windows.Forms.TextBox();
			this.nombre = new System.Windows.Forms.TextBox();
			this.apellido = new System.Windows.Forms.TextBox();
			this.email = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.volver = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.iniciar = new System.Windows.Forms.Button();
			this.capturar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(491, 69);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(157, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// dni
			// 
			this.dni.Location = new System.Drawing.Point(142, 79);
			this.dni.Name = "dni";
			this.dni.Size = new System.Drawing.Size(128, 20);
			this.dni.TabIndex = 4;
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(142, 116);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(127, 20);
			this.nombre.TabIndex = 5;
			// 
			// apellido
			// 
			this.apellido.Location = new System.Drawing.Point(142, 155);
			this.apellido.Name = "apellido";
			this.apellido.Size = new System.Drawing.Size(127, 20);
			this.apellido.TabIndex = 6;
			// 
			// email
			// 
			this.email.Location = new System.Drawing.Point(142, 197);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(127, 20);
			this.email.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(99, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "DNI";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(86, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Apellido";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(99, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "email";
			// 
			// volver
			// 
			this.volver.Location = new System.Drawing.Point(89, 254);
			this.volver.Name = "volver";
			this.volver.Size = new System.Drawing.Size(75, 23);
			this.volver.TabIndex = 12;
			this.volver.Text = "Volver";
			this.volver.UseVisualStyleBackColor = true;
			this.volver.Click += new System.EventHandler(this.volver_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(217, 254);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 13;
			this.button4.Text = "Enviar";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// iniciar
			// 
			this.iniciar.Location = new System.Drawing.Point(491, 284);
			this.iniciar.Name = "iniciar";
			this.iniciar.Size = new System.Drawing.Size(75, 23);
			this.iniciar.TabIndex = 14;
			this.iniciar.Text = "iniciar";
			this.iniciar.UseVisualStyleBackColor = true;
			this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
			// 
			// capturar
			// 
			this.capturar.Location = new System.Drawing.Point(573, 284);
			this.capturar.Name = "capturar";
			this.capturar.Size = new System.Drawing.Size(75, 23);
			this.capturar.TabIndex = 15;
			this.capturar.Text = "capturar";
			this.capturar.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::EjemploConexionBBDD.Properties.Resources.user1;
			this.pictureBox1.Image = global::EjemploConexionBBDD.Properties.Resources.user1;
			this.pictureBox1.Location = new System.Drawing.Point(492, 107);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(155, 156);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// FormularioAltas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.capturar);
			this.Controls.Add(this.iniciar);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.volver);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.email);
			this.Controls.Add(this.apellido);
			this.Controls.Add(this.nombre);
			this.Controls.Add(this.dni);
			this.Controls.Add(this.comboBox1);
			this.Name = "FormularioAltas";
			this.Text = "FormularioAltas";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox dni;
		private System.Windows.Forms.TextBox nombre;
		private System.Windows.Forms.TextBox apellido;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button volver;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button iniciar;
		private System.Windows.Forms.Button capturar;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}