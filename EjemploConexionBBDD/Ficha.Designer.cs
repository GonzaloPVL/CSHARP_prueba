namespace EjemploConexionBBDD
{
	partial class Ficha
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ficha));
			this.textBoxDNI = new System.Windows.Forms.TextBox();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxApellidos = new System.Windows.Forms.TextBox();
			this.textBoxTelefono = new System.Windows.Forms.TextBox();
			this.textBoxRegistro = new System.Windows.Forms.TextBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.buttonDevolver = new System.Windows.Forms.Button();
			this.buttonAlquilar = new System.Windows.Forms.Button();
			this.dgtFicha = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.fotoUsuario = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgtFicha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxDNI
			// 
			this.textBoxDNI.Location = new System.Drawing.Point(548, 138);
			this.textBoxDNI.Name = "textBoxDNI";
			this.textBoxDNI.Size = new System.Drawing.Size(235, 20);
			this.textBoxDNI.TabIndex = 0;
			this.textBoxDNI.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter);
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(547, 179);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(236, 20);
			this.textBoxNombre.TabIndex = 1;
			// 
			// textBoxApellidos
			// 
			this.textBoxApellidos.Location = new System.Drawing.Point(546, 216);
			this.textBoxApellidos.Name = "textBoxApellidos";
			this.textBoxApellidos.Size = new System.Drawing.Size(237, 20);
			this.textBoxApellidos.TabIndex = 2;
			// 
			// textBoxTelefono
			// 
			this.textBoxTelefono.Location = new System.Drawing.Point(546, 251);
			this.textBoxTelefono.Name = "textBoxTelefono";
			this.textBoxTelefono.Size = new System.Drawing.Size(237, 20);
			this.textBoxTelefono.TabIndex = 3;
			// 
			// textBoxRegistro
			// 
			this.textBoxRegistro.Location = new System.Drawing.Point(512, 399);
			this.textBoxRegistro.Multiline = true;
			this.textBoxRegistro.Name = "textBoxRegistro";
			this.textBoxRegistro.Size = new System.Drawing.Size(271, 104);
			this.textBoxRegistro.TabIndex = 4;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(583, 295);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 5;
			// 
			// buttonDevolver
			// 
			this.buttonDevolver.Location = new System.Drawing.Point(685, 342);
			this.buttonDevolver.Name = "buttonDevolver";
			this.buttonDevolver.Size = new System.Drawing.Size(83, 36);
			this.buttonDevolver.TabIndex = 6;
			this.buttonDevolver.Text = "Devolver";
			this.buttonDevolver.UseVisualStyleBackColor = true;
			this.buttonDevolver.Click += new System.EventHandler(this.buttonDevolver_Click);
			// 
			// buttonAlquilar
			// 
			this.buttonAlquilar.Location = new System.Drawing.Point(512, 341);
			this.buttonAlquilar.Name = "buttonAlquilar";
			this.buttonAlquilar.Size = new System.Drawing.Size(118, 37);
			this.buttonAlquilar.TabIndex = 7;
			this.buttonAlquilar.Text = "Alquilar";
			this.buttonAlquilar.UseVisualStyleBackColor = true;
			this.buttonAlquilar.Click += new System.EventHandler(this.buttonAlquilar_Click);
			// 
			// dgtFicha
			// 
			this.dgtFicha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgtFicha.Location = new System.Drawing.Point(12, 138);
			this.dgtFicha.Name = "dgtFicha";
			this.dgtFicha.Size = new System.Drawing.Size(424, 261);
			this.dgtFicha.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(491, 254);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Telefono";
			// 
			// fotoUsuario
			// 
			this.fotoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fotoUsuario.BackgroundImage")));
			this.fotoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.fotoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fotoUsuario.Cursor = System.Windows.Forms.Cursors.Default;
			this.fotoUsuario.Location = new System.Drawing.Point(626, 49);
			this.fotoUsuario.Name = "fotoUsuario";
			this.fotoUsuario.Size = new System.Drawing.Size(85, 83);
			this.fotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.fotoUsuario.TabIndex = 10;
			this.fotoUsuario.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(287, 466);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 37);
			this.button1.TabIndex = 11;
			this.button1.Text = "Alta nueva";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Ficha
			// 
			this.ClientSize = new System.Drawing.Size(846, 537);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.fotoUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgtFicha);
			this.Controls.Add(this.buttonAlquilar);
			this.Controls.Add(this.buttonDevolver);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.textBoxRegistro);
			this.Controls.Add(this.textBoxTelefono);
			this.Controls.Add(this.textBoxApellidos);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.textBoxDNI);
			this.Name = "Ficha";
			((System.ComponentModel.ISupportInitialize)(this.dgtFicha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBoxDNI;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxApellidos;
		private System.Windows.Forms.TextBox textBoxTelefono;
		private System.Windows.Forms.TextBox textBoxRegistro;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button buttonDevolver;
		private System.Windows.Forms.Button buttonAlquilar;
		private System.Windows.Forms.DataGridView dgtFicha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox fotoUsuario;
		private System.Windows.Forms.Button button1;
	}
}