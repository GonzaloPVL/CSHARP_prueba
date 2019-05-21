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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            String contraseña = textBox2.Text;

            MySqlConnection conexion = new ConexionBBDD().conecta();

                MySqlCommand comando = new MySqlCommand("" +
                    "SELECT * FROM usuarios WHERE" +
                    " usuario = '" + textBox1.Text +
                    "' AND pass = '" + contraseña +
                    "' ;", conexion);

                MySqlDataReader resultado = comando.ExecuteReader();
            

                if (resultado.Read())
                {
                    MessageBox.Show("Acceso Correcto", "Usuario OK");
                    this.Visible = false; //oculta la ventana
                    PaginaPrincipal pagina = new PaginaPrincipal();
                    pagina.Visible = true;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto(s)", "ERROR");
                }
        }
	}
}
