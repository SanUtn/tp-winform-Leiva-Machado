using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using Helper;


namespace TPWinForm
{
    public partial class Listado : Form
    {
        
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulos;
            try
            {
                listaArticulos = negocio.listarArticulo();
                dataListado.DataSource = listaArticulos;
                dataListado.Columns["Id"].Visible = false;
                dataListado.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaArticulos.First().UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbListado.Load(imagen);
            }
            catch (Exception ex)
            {

                pbListado.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png");
            }
        }

        private void dataListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListado.CurrentRow != null)//para que no rompa si no seleccione nada
            {
                Articulo articuloSeleccionado = (Articulo)dataListado.CurrentRow.DataBoundItem;
                cargarImagen(articuloSeleccionado.UrlImagen);
            }
        }
    }
}
