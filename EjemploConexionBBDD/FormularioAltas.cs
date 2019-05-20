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
using AForge.Video;
using AForge.Video.DirectShow;

namespace EjemploConexionBBDD
{
	public partial class FormularioAltas : Form
	{
		public FormularioAltas()
		{
			InitializeComponent();
		}
		
		////////////////////////////////// Acceso a formulario///////////////////////////////////

		private void volver_Click(object sender, EventArgs e)
		{
			this.Visible = false; //oculta la ventana
		}


		private void button4_Click(object sender, EventArgs e)
		{

			MySqlConnection conexion = new ConexionBBDD().conecta();

			MySqlCommand comando = new MySqlCommand("INSERT INTO `usuario` (`DNI`, `Nombre`, `Apellido`, `password`, `email`) VALUES ('"+ dni.Text + "'," +
				" '" + nombre.Text + "', '" + apellido.Text + "', '', '" + email.Text + " ');", conexion);

			MySqlDataReader resultado = comando.ExecuteReader();

			MessageBox.Show("Usuario registrado correctamente", "aviso");

			dni.Clear();
			nombre.Clear();
			apellido.Clear();
			email.Clear();

		}

		private void volver_Click_1(object sender, EventArgs e)
		{
			this.Visible = false; //oculta la ventana
		}




























		private void iniciar_Click(object sender, EventArgs e)
		{
			//VideoCaptureDevice video = new VideoCaptureDevice();
			//FilterInfoCollection DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

			//video(DispositivoDeVideo)
			//VideoCapabilities(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
			//FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
		}
	}
}