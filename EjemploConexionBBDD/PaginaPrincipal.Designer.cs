namespace EjemploConexionBBDD
{
    partial class PaginaPrincipal
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
			this.desplegable1 = new System.Windows.Forms.ComboBox();
			this.desplegable2 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listaDatos = new System.Windows.Forms.DataGridView();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.buscador = new System.Windows.Forms.TextBox();
			this.button_buscar = new System.Windows.Forms.Button();
			this.alta = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.listaDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// desplegable1
			// 
			this.desplegable1.FormattingEnabled = true;
			this.desplegable1.Location = new System.Drawing.Point(51, 42);
			this.desplegable1.Name = "desplegable1";
			this.desplegable1.Size = new System.Drawing.Size(283, 21);
			this.desplegable1.TabIndex = 8;
			this.desplegable1.SelectedIndexChanged += new System.EventHandler(this.desplegable1_SelectedIndexChanged);
			// 
			// desplegable2
			// 
			this.desplegable2.FormattingEnabled = true;
			this.desplegable2.Location = new System.Drawing.Point(51, 80);
			this.desplegable2.Name = "desplegable2";
			this.desplegable2.Size = new System.Drawing.Size(283, 21);
			this.desplegable2.TabIndex = 9;
			this.desplegable2.SelectedIndexChanged += new System.EventHandler(this.desplegable2_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Filtrar por:";
			// 
			// listaDatos
			// 
			this.listaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.listaDatos.Location = new System.Drawing.Point(51, 119);
			this.listaDatos.Name = "listaDatos";
			this.listaDatos.Size = new System.Drawing.Size(604, 311);
			this.listaDatos.TabIndex = 11;
			this.listaDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listaDatos_CellMouseClick);
			// 
			// buscador
			// 
			this.buscador.Location = new System.Drawing.Point(387, 42);
			this.buscador.Name = "buscador";
			this.buscador.Size = new System.Drawing.Size(268, 20);
			this.buscador.TabIndex = 12;
			this.buscador.Text = "Buscador  id";
			this.buscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.buscador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buscador_MouseClick);
			this.buscador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Enter);
			// 
			// button_buscar
			// 
			this.button_buscar.Location = new System.Drawing.Point(569, 76);
			this.button_buscar.Name = "button_buscar";
			this.button_buscar.Size = new System.Drawing.Size(85, 24);
			this.button_buscar.TabIndex = 15;
			this.button_buscar.Text = "Buscar";
			this.button_buscar.UseVisualStyleBackColor = true;
			this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
			// 
			// alta
			// 
			this.alta.Location = new System.Drawing.Point(51, 503);
			this.alta.Name = "alta";
			this.alta.Size = new System.Drawing.Size(123, 35);
			this.alta.TabIndex = 16;
			this.alta.Text = "Alta Trabajadores";
			this.alta.UseVisualStyleBackColor = true;
			this.alta.Click += new System.EventHandler(this.alta_Click);
			// 
			// PaginaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 588);
			this.Controls.Add(this.alta);
			this.Controls.Add(this.button_buscar);
			this.Controls.Add(this.buscador);
			this.Controls.Add(this.listaDatos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.desplegable2);
			this.Controls.Add(this.desplegable1);
			this.Name = "PaginaPrincipal";
			this.Text = "PaginaPrincipal";
			((System.ComponentModel.ISupportInitialize)(this.listaDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox desplegable1;
        private System.Windows.Forms.ComboBox desplegable2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView listaDatos;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox buscador;
		private System.Windows.Forms.Button button_buscar;
		private System.Windows.Forms.Button alta;
	}
}