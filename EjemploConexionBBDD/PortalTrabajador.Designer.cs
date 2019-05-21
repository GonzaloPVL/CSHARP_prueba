namespace EjemploConexionBBDD
{
	partial class PortalTrabajador
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.passwordtxt = new System.Windows.Forms.TextBox();
			this.usuariotxt = new System.Windows.Forms.TextBox();
			this.crear = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.conf_contraseña = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(116, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario nuevo:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(116, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña:";
			// 
			// passwordtxt
			// 
			this.passwordtxt.Location = new System.Drawing.Point(200, 139);
			this.passwordtxt.Name = "passwordtxt";
			this.passwordtxt.PasswordChar = '*';
			this.passwordtxt.Size = new System.Drawing.Size(150, 20);
			this.passwordtxt.TabIndex = 2;
			// 
			// usuariotxt
			// 
			this.usuariotxt.Location = new System.Drawing.Point(200, 89);
			this.usuariotxt.Name = "usuariotxt";
			this.usuariotxt.Size = new System.Drawing.Size(150, 20);
			this.usuariotxt.TabIndex = 3;
			// 
			// crear
			// 
			this.crear.Location = new System.Drawing.Point(200, 232);
			this.crear.Name = "crear";
			this.crear.Size = new System.Drawing.Size(75, 23);
			this.crear.TabIndex = 4;
			this.crear.Text = "Crear";
			this.crear.UseVisualStyleBackColor = true;
			this.crear.Click += new System.EventHandler(this.crear_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Confirmar contraseña:";
			// 
			// conf_contraseña
			// 
			this.conf_contraseña.Location = new System.Drawing.Point(200, 180);
			this.conf_contraseña.Name = "conf_contraseña";
			this.conf_contraseña.PasswordChar = '*';
			this.conf_contraseña.Size = new System.Drawing.Size(149, 20);
			this.conf_contraseña.TabIndex = 6;
			// 
			// PortalTrabajador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 341);
			this.Controls.Add(this.conf_contraseña);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.crear);
			this.Controls.Add(this.usuariotxt);
			this.Controls.Add(this.passwordtxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PortalTrabajador";
			this.Text = "PortalTrabajador";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwordtxt;
		private System.Windows.Forms.TextBox usuariotxt;
		private System.Windows.Forms.Button crear;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox conf_contraseña;
	}
}