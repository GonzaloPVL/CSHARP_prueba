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
	public partial class PortalTrabajador : Form
	{
		public PortalTrabajador()
		{
			InitializeComponent();
		}

		private void crear_Click(object sender, EventArgs e)
		{
			if (conf_contraseña == passwordtxt) { 
				String usuario = usuariotxt.Text;
				String contraseña = passwordtxt.Text;



				MySqlConnection conexion = new ConexionBBDD().conecta();

				MySqlCommand comando = new MySqlCommand("INSERT INTO `usuarios` (`id`, `usuario`, `pass`, `ultimoLogin`) VALUES (NULL, '" + usuario + "', '" + contraseña + "', '');", conexion);

				MySqlDataReader resultado = comando.ExecuteReader();

				MessageBox.Show("Usuario registrado", "Aviso");
			}
			else
			{
				MessageBox.Show("Usuario NO registrado, la contraseña debe coincidir", "Aviso");
			}
		}
	}
}
