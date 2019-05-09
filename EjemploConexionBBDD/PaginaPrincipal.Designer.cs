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
            this.desplegable = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.desplegable1 = new System.Windows.Forms.ComboBox();
            this.desplegable2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaInformacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // desplegable
            // 
            this.desplegable.Cursor = System.Windows.Forms.Cursors.Default;
            this.desplegable.FormattingEnabled = true;
            this.desplegable.Location = new System.Drawing.Point(499, 41);
            this.desplegable.Name = "desplegable";
            this.desplegable.Size = new System.Drawing.Size(211, 21);
            this.desplegable.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actores";
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
            // listaInformacion
            // 
            this.listaInformacion.Location = new System.Drawing.Point(51, 124);
            this.listaInformacion.Multiline = true;
            this.listaInformacion.Name = "listaInformacion";
            this.listaInformacion.Size = new System.Drawing.Size(283, 280);
            this.listaInformacion.TabIndex = 12;
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaInformacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desplegable2);
            this.Controls.Add(this.desplegable1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desplegable);
            this.Name = "PaginaPrincipal";
            this.Text = "PaginaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox desplegable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox desplegable1;
        private System.Windows.Forms.ComboBox desplegable2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox listaInformacion;
    }
}