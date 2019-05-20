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
	public partial class Ficha : Form
	{
		String nombre = "";
		String apellido = "";
		String id_pelicula = PaginaPrincipal.seleccion;
		//////////Vamos a declarar una variable string que nos de el valor de la fecha en que ha sido alquilada
		String fecha_alquilado = "";
		String fecha_devuelto = "";

		private DataTable datos = new DataTable();

		public Ficha()
		{
			InitializeComponent();
			rellenaPelis();
			comprueba();
		}

		private void comprueba()
		{
			//Pimero hacemos una consulta a la base de datos para saber su disponibilidad
			MySqlConnection conexionInformacion = new ConexionBBDD().conecta();
			MySqlCommand comando =
				new MySqlCommand("SELECT registro.* from registro where registro.movies_id ='" + id_pelicula + "'"
				, conexionInformacion);

			MySqlDataReader resultado = comando.ExecuteReader();

			if (resultado.Read())
			{
				consultaCliente();
				// Al consultar el cliente debemos rellenar datos
				buttonDevolver.Enabled = true;
				//Pondremos el boton de alquilar desactivado
				buttonAlquilar.Enabled = false;
				textBoxRegistro.Text = "DNI: " + textBoxDNI.Text +
										Environment.NewLine + "Teléfono" + textBoxTelefono.Text +
										Environment.NewLine + "ID: " + id_pelicula +
										Environment.NewLine + "Fecha alquiler: " + fecha_alquilado +
										Environment.NewLine + "Fecha devolución: " + fecha_devuelto;
			}
			else
			{

			}
			//En segundo lugar cogemos los datos del alquiler
			//Mostramos los datos del alquiler por pantalla
		}

		private void consultaCliente()
		{
			

			//Este código rellenará los datos del cliente que realice la reserva
			MySqlConnection conexionInformacion = new ConexionBBDD().conecta();
			MySqlCommand comando =
				new MySqlCommand("SELECT registro.DNI, registro.telefono, registro.fecha_alquiler, registro.fecha_devolucion from registro where registro.movies_id ='" + id_pelicula + "'"
				, conexionInformacion);
			MySqlDataReader resultado = comando.ExecuteReader();

			if (resultado.Read())
			{
				textBoxDNI.Text = resultado.GetString("DNI");
				textBoxTelefono.Text = resultado.GetString("telefono");
				// Vamos a dar el valor de la consulta fecha  al string
				fecha_alquilado = resultado.GetString("fecha_alquiler");
				fecha_devuelto = resultado.GetString("fecha_devolucion");

			}
			

		}

		private void buscafoto() //Método para buscar las fotos en el ordenador
		{
			try
			{
				fotoUsuario.Image = Image.FromFile(@"C:\\Users\\gonza\\Desktop\\C_Sharp_AccesoBBDD-master\fotos usuarios videoclub\\"+ textBoxDNI.Text + ".jpg");
			}
			catch (Exception ex)
			{
				
			}
		}

		private void rellenaPelis()
		{
			datos.Clear();
			dgtFicha.DataSource = null;
			dgtFicha.Rows.Clear();

			

			MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

			MySqlCommand comando =
				new MySqlCommand("SELECT movies.* from movies where movies.id ='" + id_pelicula + "'"
				, conexionInformacion);

			MySqlDataReader resultado = comando.ExecuteReader();

			datos.Load(resultado);
			dgtFicha.DataSource = datos;

			conexionInformacion.Close();
		}
		private void datosClientes()
		{
			


			MySqlConnection conexion = new ConexionBBDD().conecta();

			MySqlCommand comando =
				new MySqlCommand("SELECT * from usuario where DNI =  " + textBoxDNI.Text, conexion);

			MySqlDataReader resultado = comando.ExecuteReader();

			if (resultado.Read())
			{
				String nombre = resultado.GetString("Nombre");
				String apellido = resultado.GetString("Apellido");
				textBoxNombre.Text = nombre;
				textBoxApellidos.Text = apellido;
				
			}
			else
			{
				// Aqui llamaremos a un ventana de dar de alta clientes
				MessageBox.Show("Usuario sin registrar", "Aviso", MessageBoxButtons.OK);
			}


		}



		private void buttonDevolver_Click(object sender, EventArgs e)
		{
			buttonDevolver.Enabled = false;
			buttonAlquilar.Enabled = true;
			textBoxRegistro.Text = "";

			

			////////////////////Este Código vuelve a poner disponible la película//////////////////////////

			MySqlConnection conexion = new ConexionBBDD().conecta();
			MySqlCommand comando = new MySqlCommand("UPDATE `movies` SET " +
				"`disponible` = b'0' WHERE `movies`.`id` =" + id_pelicula + ";", conexion);

			MySqlDataReader resultado = comando.ExecuteReader();
			conexion.Close();

			///////////////////////Ahora debemos borrar el registro del alquiler////////////////////////////

			borraRegistro();

			///////////////////////////////////////////////////////////////////////////////////////////////


		}

		private void borraRegistro()
		{
			MySqlConnection conexionBorrado = new ConexionBBDD().conecta();
			MySqlCommand comandoBorrado = new MySqlCommand("DELETE FROM `registro` " +
				"WHERE `registro`.`movies_id` =" + id_pelicula + " and " +
	"			`registro`.`DNI` =" + textBoxDNI.Text + ";", conexionBorrado);

			MySqlDataReader resultadoBorrado = comandoBorrado.ExecuteReader();
		}

		private void buttonAlquilar_Click(object sender, EventArgs e)
		{
			if (textBoxNombre.Text != "Nombre" && textBoxNombre.Text.Length <= 15 &&
				textBoxApellidos.Text != "Apellidos" && textBoxApellidos.Text.Length <= 30 &&
				textBoxTelefono.Text != "Teléfono" && textBoxTelefono.Text.Length == 9)
			{
				buttonDevolver.Enabled = true;
				buttonAlquilar.Enabled = false;
				textBoxRegistro.Text = dtpFecha.Value.ToString("dd/MM/yyyy") + " - " +
					dtpFecha.Value.AddDays(2).ToString("dd/MM/yyyy") +
					Environment.NewLine + textBoxNombre.Text + " " + textBoxApellidos.Text +
					Environment.NewLine + textBoxDNI.Text +
					Environment.NewLine + textBoxTelefono.Text +
					Environment.NewLine + "ID" + id_pelicula;

				generaRegistro();
				cambiaDisponibilidad();

				textBoxNombre.Text = "";
				textBoxApellidos.Text = "";
				textBoxTelefono.Text = "";
				textBoxDNI.Text = "";



			}


		}

		private void cambiaDisponibilidad()
		{
			//Al pulsar el boton de alquiler 
			MySqlConnection conexion = new ConexionBBDD().conecta();
			MySqlCommand comando = new MySqlCommand("UPDATE `movies` SET " +
				"`disponible` = b'1' WHERE `movies`.`id` ="+ id_pelicula+";", conexion);

			MySqlDataReader resultado = comando.ExecuteReader();
		}

		private void generaRegistro()
		{
			///////////////////// Declaramos dos String con los valores de alquiler y devolucion ////////////////////////////
			String fecha = dtpFecha.Value.ToString("yyyy/MM/dd");
			String fecha_devolucion = dtpFecha.Value.AddDays(2).ToString("yyyy/MM/dd");
			//'2019-05-19'
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			MySqlConnection conexion = new ConexionBBDD().conecta();

			MySqlCommand comando = new MySqlCommand("INSERT INTO `registro` (`id_registro`, `DNI`, `movies_id`, `telefono`, `fecha_alquiler`, `fecha_devolucion`)" +
				" VALUES (NULL, '" + textBoxDNI.Text + "', '" + id_pelicula + "', '" + textBoxTelefono.Text + "', '"+ fecha +"', '" + fecha_devolucion + "');", conexion);

			MySqlDataReader resultado = comando.ExecuteReader();
		}

		private void Enter(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Enter))
			{
				datosClientes();
				buscafoto(); // Cuando introducimos el usuario, llamamos al método para encontrar la foto
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormularioAltas pagina = new FormularioAltas();
			pagina.Visible = true;
		}
	}
}