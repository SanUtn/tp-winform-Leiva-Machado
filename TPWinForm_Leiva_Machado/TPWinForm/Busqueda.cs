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

namespace TPWinForm
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo buscado = new Articulo();
            buscado.NombreArticulo = txbBusqueda.Text;

            List<Articulo> listaArticulosEncontrados;

            try
            {
                listaArticulosEncontrados = negocio.buscarArticulo(buscado);
                dgvBusqueda.DataSource = listaArticulosEncontrados;
                if(dgvBusqueda.Rows.Count != 0)
                {
                    dgvBusqueda.Show(); //muestro el grid
                    dgvBusqueda.Columns["Id"].Visible = false;
                    dgvBusqueda.Columns["CodArticulo"].Visible = false;
                    dgvBusqueda.Columns["Descripcion"].Visible = false;
                    dgvBusqueda.Columns["MarcaArticulo"].Visible = false;
                    dgvBusqueda.Columns["CategoriaArticulo"].Visible = false;
                    dgvBusqueda.Columns["UrlImagen"].Visible = false;
                    dgvBusqueda.Columns["Precio"].Visible = false;
                    cargarImagen(listaArticulosEncontrados.First().UrlImagen);
                }
                else
                {
                    //sino oculto y mensaje sin resultados
                    ocultarComponentes();
                    MessageBox.Show("Sin resultados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            pbBusqueda.Show();
            try
            {
                pbBusqueda.Load(imagen);
            }
            catch (Exception ex)
            {

                pbBusqueda.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png");
            }
        }

        private void dgvBusqueda_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvBusqueda.Rows.Count != 0) //solo si tiene rows el datagridview
            {
                Articulo articuloSeleccionado = (Articulo)dgvBusqueda.CurrentRow.DataBoundItem;
                cargarImagen(articuloSeleccionado.UrlImagen);
            }
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            ocultarComponentes();
        }

        private void ocultarComponentes()
        {
            dgvBusqueda.Hide();
            pbBusqueda.Hide();
        }
    }
}
