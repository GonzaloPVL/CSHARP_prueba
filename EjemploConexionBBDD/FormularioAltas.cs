using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EjemploConexionBBDD
{
	public partial class FormularioAltas : Form
	{
		public FormularioAltas()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			//Accedemos a la BBDD para introducir nuevos usuarios a la tabla
			MySqlConnection conexion = new ConexionBBDD().conecta();

			MySqlCommand comando = new MySqlCommand("INSERT INTO `usuario` (`DNI`, `Nombre`, `Apellido`, `email`)" +
				" VALUES ('" + dni.Text + "', '" + nombre.Text + "', '" + apellido.Text + "', '"+ email.Text+"');", conexion);
			MySqlDataReader resultado = comando.ExecuteReader();

			MessageBox.Show("Usuario registrado correctamente", "Aviso", MessageBoxButtons.OK);
			
			dni.Clear();
			nombre.Clear();
			apellido.Clear();
			email.Clear();

		}

		private void volver_Click(object sender, EventArgs e)
		{
			this.Visible = false; //oculta la ventana
		}
	}
}
