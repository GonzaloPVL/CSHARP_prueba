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

        //private void rellenaComboAutores()
        //{
        //    MySqlConnection conexion = new ConexionBBDD().conecta();

        //    MySqlCommand comando = 
        //        new MySqlCommand("SELECT * from actors ORDER BY first_name", conexion);

        //    MySqlDataReader resultado = comando.ExecuteReader();
        //    while (resultado.Read())
        //    {
        //        String id = resultado.GetString(0); // el numero hace referencia al numero de columna de la BBDD
        //        String first_name = resultado.GetString("first_name");// hace referencia al nombre de la columna de la BBDD
        //        String last_name = resultado.GetString("last_name");
        //        String gender = resultado.GetString("gender");
        //        desplegable.Items.Add(first_name + " " + last_name);
        //    }
        //    conexion.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
        //}

        private void desplegable1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (desplegable1.Text == "actors") {

                desplegable2.Items.Clear(); //Este código nos vale para limpiar el comboBox antes de volver a escribir

                MySqlConnection conexionActores = new ConexionBBDD().conecta();

                MySqlCommand comando =
                    new MySqlCommand("SELECT * from actors ORDER BY first_name", conexionActores);

                MySqlDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    String id = resultado.GetString(0); // el numero hace referencia al numero de columna de la BBDD
                    String first_name = resultado.GetString("first_name");// hace referencia al nombre de la columna de la BBDD
                    String last_name = resultado.GetString("last_name");
                    String gender = resultado.GetString("gender");
                    desplegable2.Items.Add(first_name + " " + last_name);
                }
                conexionActores.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
                
            }
            if(desplegable1.Text == "movies")
            {
                desplegable2.Items.Clear();
                MySqlConnection conexionPeliculas = new ConexionBBDD().conecta();

                MySqlCommand comando =
                    new MySqlCommand("SELECT * from movies", conexionPeliculas);

                MySqlDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    String name = resultado.GetString("name");// hace referencia al nombre de la película
                    String year = resultado.GetString("year");// hace referencia al año
                    desplegable2.Items.Add(name + "   año: " + year);
                }
                conexionPeliculas.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
            }

            if(desplegable1.Text == "directors")
            {
                desplegable2.Items.Clear();
                MySqlConnection conexionDirectores = new ConexionBBDD().conecta();

                MySqlCommand comando =
                    new MySqlCommand("SELECT * from directors", conexionDirectores);

                MySqlDataReader resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    String first_name = resultado.GetString("first_name");// hace referencia al nombre de la columna de la BBDD
                    String last_name = resultado.GetString("last_name");
                    desplegable2.Items.Add(first_name + " " + last_name);
                }
                conexionDirectores.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
            }
        }

        private void desplegable2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String pedido = desplegable1.Text;
            listaInformacion.Clear();
            MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

            MySqlCommand comando =
                new MySqlCommand("SELECT * from "  + pedido , conexionInformacion);

            MySqlDataReader resultado = comando.ExecuteReader();
            while (resultado.Read())
            {
                String first_name = resultado.GetString("first_name");// hace referencia al nombre de la columna de la BBDD
                listaInformacion.Text = first_name;
            }
            conexionInformacion.Close(); //Cerrar siempre la conexion porque no lo hace automáticamente
            // Aqui tenemos que rellenar un textBox o un listBox con el contenido de
            // las peliculas.
        }
    }
}
