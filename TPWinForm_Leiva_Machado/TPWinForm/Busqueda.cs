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
        private List<Articulo> listaArticulos;
        public Busqueda()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                listaArticulos = negocio.listarArticulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ocultarColumnas()
        {
            dgvBusqueda.Columns["UrlImagen"].Visible = false;
            dgvBusqueda.Columns["Id"].Visible = false;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            string campo = cboCampo.SelectedItem.ToString();
            string criterio = cboCriterio.SelectedItem.ToString();
            string filtro = txbBusqueda.Text;
            List<Articulo> listaArticulosEncontrados;

            try
            {
                listaArticulosEncontrados = negocio.filtrar(campo,criterio,filtro);
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
            if(dgvBusqueda.CurrentRow != null) 
            {
                Articulo articuloSeleccionado = (Articulo)dgvBusqueda.CurrentRow.DataBoundItem;
                cargarImagen(articuloSeleccionado.UrlImagen);
            }
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            ocultarComponentes();
            cargar();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Categoria");
        }

        private void ocultarComponentes()
        {
            dgvBusqueda.Hide();
            pbBusqueda.Hide();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            List<Articulo> listaFiltrada;
            string filtro = txtFiltroRapido.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.NombreArticulo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvBusqueda.DataSource = null;
            dgvBusqueda.DataSource = listaFiltrada;
            dgvBusqueda.Show();
            ocultarColumnas();
        }
    }
}
