using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class Eliminar : Form
    {
        private Articulo articulo;

        public Eliminar()
        {
            InitializeComponent();
        }

      
        private void Eliminar_Load(object sender, EventArgs e)
        {
            cargar();
            if (dataListado.CurrentRow != null)//para que no rompa si no seleccione nada
            {
                articulo = (Articulo)dataListado.CurrentRow.DataBoundItem;
                cargarFormulario(articulo);
            }
        }

        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulos;
            try
            {
                listaArticulos = negocio.listarArticulo();
                dataListado.DataSource = listaArticulos;
                dataListado.Columns["UrlImagen"].Visible = false;
                dataListado.Columns["Activo"].Visible = false;
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
                pbEliminar.Load(imagen);
            }
            catch (Exception ex)
            {

                pbEliminar.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png");
            }
        }

        private void dataListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListado.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dataListado.CurrentRow.DataBoundItem;
                cargarFormulario(articuloSeleccionado);
                cargarImagen(articuloSeleccionado.UrlImagen);
            }
        }

        private void eliminar(bool logico = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro que queres eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //retorna un valor
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataListado.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);

                    MessageBox.Show("Eliminado correctamente");
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        public void cargarFormulario(Articulo art)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                txtCodArticuloE.Text = art.CodArticulo;
                txtNombreE.Text = art.NombreArticulo;
                txtDescripcionE.Text = art.Descripcion;
                txtMarcaE.Text = art.MarcaArticulo.NombreMarca;
                txtCategoriaE.Text = art.CategoriaArticulo.NombreCategoria;
                txtImagenE.Text = art.UrlImagen;
                txtPrecioE.Text = art.Precio.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
