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
    public partial class PaginaPrincipal : Form
		
    {
		
		private DataTable datos = new DataTable();
		public static String seleccion = "";

		public PaginaPrincipal()
        {
            InitializeComponent();
            textoDesplegable();
			//rellenaComboAutores();
			

		}


        private void textoDesplegable()
        {
            desplegable1.Items.Add("actors");
            desplegable1.Items.Add("directors");
            desplegable1.Items.Add("movies");
            desplegable1.Items.Add("Géneros");
        }

        //código para que al cerrar este form se cierre la app completa
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }


		// Código para rellenar los ComboBox

        private void desplegable1_SelectedIndexChanged(object sender, EventArgs e)
        {
			/////////////////////////////////////////////////////////////////////////////////////////////////
			datos.Clear();
			listaDatos.DataSource = null;
			listaDatos.Rows.Clear();
			///////////////////////////////////////////////////////////////////////////////////////////////////

			if (desplegable1.Text == "actors") {

				String query = "SELECT actors.first_name, actors.last_name, actors.id" +
					" from actors ORDER BY first_name";
				
				desplegable2.Items.Clear(); //Este código nos vale para limpiar el comboBox antes de volver a escribir

                MySqlConnection conexionActores = new ConexionBBDD().conecta();

				MySqlCommand comando = new MySqlCommand( query, conexionActores);
				MySqlDataReader resultado = comando.ExecuteReader();


				while (resultado.Read())
                {
                    
                    String first_name = resultado.GetString("first_name");// hace referencia al nombre de la columna de la BBDD
                    String last_name = resultado.GetString("last_name");
					String id = resultado.GetString("id"); // Este id debería llamar al id del actor seleccionado en el comboBox
					desplegable2.Items.Add(id + "-   " + first_name + " " + last_name);
					
				}
				
				conexionActores.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
                
            }
            if(desplegable1.Text == "movies")
            {
                desplegable2.Items.Clear();
				
				MySqlConnection conexionPeliculas = new ConexionBBDD().conecta();

                MySqlCommand comando =
                    new MySqlCommand("SELECT movies.id, movies.name, movies.year from movies", conexionPeliculas);

                MySqlDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    String name = resultado.GetString("name");// hace referencia al nombre de la película
                    String year = resultado.GetString("year");// hace referencia al año
					String id = resultado.GetString("id");
					desplegable2.Items.Add(id + "-   " + name + "   año: " + year);
                }
                conexionPeliculas.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
            }

            if(desplegable1.Text == "directors")
            {
                desplegable2.Items.Clear();
				
				MySqlConnection conexionDirectores = new ConexionBBDD().conecta();

                MySqlCommand comando =
                    new MySqlCommand("SELECT directors.id, directors.first_name, directors.last_name" +
					" from directors", conexionDirectores);

                MySqlDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    String first_name = resultado.GetString("first_name");// hace referencia al nombre de la columna de la BBDD
                    String last_name = resultado.GetString("last_name");
					String id = resultado.GetString("id");
                    desplegable2.Items.Add(id+"-   "+first_name + " " + last_name);
                }
                conexionDirectores.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
            }
			if (desplegable1.Text == "Géneros")
			{
				desplegable2.Items.Clear();

				MySqlConnection conexionDirectores = new ConexionBBDD().conecta();

				MySqlCommand comando =
					new MySqlCommand("SELECT distinct movies_genres.genre" +
					" from movies_genres", conexionDirectores);

				MySqlDataReader resultado = comando.ExecuteReader();
				while (resultado.Read())
				{
					//String movie_id = resultado.GetString("movie_id");// hace referencia al nombre de la columna de la BBDD
					String genre = resultado.GetString("genre");
					desplegable2.Items.Add(genre);
				}
				conexionDirectores.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
			}


		}


		// A partir de aqui tenemos el DataGridView

		private void desplegable2_SelectedIndexChanged(object sender, EventArgs e)
        {
			///////////////////////////////////////////////////////////////////////////////////////
			datos.Clear();
			listaDatos.DataSource = null;
			listaDatos.Rows.Clear();
			//////////////////////////////////////////////////////////////////////////////////

			string index = desplegable2.Text.ToString();
			
			String indice = "";


			for(int i = 0; i<index.Length; i++)
			{
				if(index[i] != '-')
				{
					indice = index.Substring(0, i+1);
				}
				else
				{
					break;
				}
			}

			if (desplegable1.Text == "actors") {
				String barra1 = desplegable1.Text;
				String barra2 = desplegable2.Text;
				

				MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

				MySqlCommand comando =
					new MySqlCommand("SELECT distinct movies.* from movies, roles, actors " +
					"where movies.id = roles.movie_id and " +
					"roles.actor_id = " + indice
					, conexionInformacion);

				MySqlDataReader resultado = comando.ExecuteReader();
				
				datos.Load(resultado);
				listaDatos.DataSource = datos;

				conexionInformacion.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
											 // Aqui tenemos que rellenar un textBox o un listBox con el contenido de
											 // las peliculas.
			}

			if (desplegable1.Text == "directors")
			{
				String barra1 = desplegable1.Text;
				String barra2 = desplegable2.Text;
				

				MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

				MySqlCommand comando =
					new MySqlCommand("SELECT distinct movies.* from movies, movies_directors, directors " +
					"where movies.id = movies_directors.movie_id and " +
					"movies_directors.director_id = " + indice
					, conexionInformacion);

				MySqlDataReader resultado = comando.ExecuteReader();

				datos.Load(resultado);
				listaDatos.DataSource = datos;

				conexionInformacion.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
											 // Aqui tenemos que rellenar un textBox o un listBox con el contenido de
											 // las peliculas.
			}

			if (desplegable1.Text == "movies")
			{
				String barra1 = desplegable1.Text;
				String barra2 = desplegable2.Text;
				
				

				MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

				MySqlCommand comando =
					new MySqlCommand("SELECT movies.* from movies where movies.id = " + indice
					, conexionInformacion);

				MySqlDataReader resultado = comando.ExecuteReader();

				datos.Load(resultado);
				listaDatos.DataSource = datos;

				conexionInformacion.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
											 // Aqui tenemos que rellenar un textBox o un listBox con el contenido de
											 // las peliculas.
			}

			if (desplegable1.Text == "Géneros")
			{
				String barra1 = desplegable1.Text;
				String barra2 = desplegable2.Text;

				MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

				MySqlCommand comando =
					new MySqlCommand("SELECT movies.* from movies, movies_genres where movies.id = movies_genres.movie_id and genre ='" + barra2 + "'"
					, conexionInformacion);

				MySqlDataReader resultado = comando.ExecuteReader();

				datos.Load(resultado);
				listaDatos.DataSource = datos;

				conexionInformacion.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
											 // Aqui tenemos que rellenar un textBox o un listBox con el contenido de
											 // las peliculas.
			}






		}

		private void buscador_MouseClick(object sender, MouseEventArgs e)
		{
			buscador.Clear();
		}


		private void button_buscar_Click(object sender, EventArgs e)
		{

			datos.Clear();
			listaDatos.DataSource = null;
			listaDatos.Rows.Clear();

			String buscador_id = buscador.Text;
			

			MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

			
			MySqlCommand comando =
				new MySqlCommand("SELECT movies.* from movies where movies.id = '" + buscador_id + "'"
				, conexionInformacion);

			MySqlDataReader resultado = comando.ExecuteReader();

				datos.Load(resultado);
				listaDatos.DataSource = datos;
				conexionInformacion.Close();
			

			

			conexionInformacion.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
										 // Aqui tenemos que rellenar un textBox o un listBox con el contenido de
										 // las peliculas.



		}

		private void Enter(object sender, KeyEventArgs key)
		{
			if (key.KeyCode.Equals(Keys.Enter))
			{
				datos.Clear();
				listaDatos.DataSource = null;
				listaDatos.Rows.Clear();

				String buscador_id = buscador.Text;

				MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

				MySqlCommand comando =
					new MySqlCommand("SELECT movies.* from movies where movies.id = '" + buscador_id + "'"
					, conexionInformacion);

				MySqlDataReader resultado = comando.ExecuteReader();

					datos.Load(resultado);
					listaDatos.DataSource = datos;
					conexionInformacion.Close();


				conexionInformacion.Close();
			}
		}

		private void listaDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{

			foreach (DataGridViewCell cell in listaDatos.SelectedCells)
			{
				seleccion = (cell.Value.ToString());
				Ficha ficha = new Ficha();
				ficha.Visible = true;
			}


			//Aqui enlazaremos con la pagina de la ficha
			//
			//
			//Método para llamar a otras clases 
			//
		}
	}
}
