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
using Helper;
using Negocio;

namespace TPWinForm
{
    public partial class Modificar : Form
    {
        private Articulo articulo;
        private MetodosCompartidos helper = new MetodosCompartidos();
        public Modificar()
        {
            InitializeComponent();
            ocultarLabels();
        }

        public Modificar(Articulo articulo)
        {
            InitializeComponent();
            ocultarLabels();
            this.articulo = articulo;
            
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            cargar();
            ocultarLabels();
            if (dataListado.CurrentRow != null)//para que no rompa si no seleccione nada
            {
                articulo = (Articulo)dataListado.CurrentRow.DataBoundItem;
                cargarFormulario(articulo);
            }
        }

        public void cargarFormulario(Articulo art)
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                txtCodArticuloM.Text = art.CodArticulo;
                txtNombreM.Text = art.NombreArticulo;
                txtDescripcionM.Text = art.Descripcion;

                cboMarcaM.DataSource = marcaNegocio.listarMarca();
                cboMarcaM.ValueMember = "Id"; //nombres de las propiedades de la clase elemento
                cboMarcaM.DisplayMember = "NombreMarca";
                cboMarcaM.SelectedValue = art.MarcaArticulo.Id;

                cboCategoriaM.DataSource = categoriaNegocio.listarCategoria();
                cboCategoriaM.ValueMember = "Id";
                cboCategoriaM.DisplayMember = "NombreCategoria";
                cboCategoriaM.SelectedValue = art.CategoriaArticulo.Id;

                txtImagenM.Text = art.UrlImagen;
                txtPrecioM.Text = art.Precio.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
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
                dataListado.Columns["Id"].Visible = false;
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
                pbModificar.Load(imagen);
            }
            catch (Exception ex)
            {

                pbModificar.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png");
            }
        }

        private void dataListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataListado.CurrentRow != null)//para que no rompa si no seleccione nada
            { 
                articulo = (Articulo)dataListado.CurrentRow.DataBoundItem;
                cargarFormulario(articulo);
                cargarImagen(articulo.UrlImagen);
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            ocultarLabels();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarCampos()) { return; }
                articulo.CodArticulo = txtCodArticuloM.Text;
                articulo.NombreArticulo = txtNombreM.Text;
                articulo.Descripcion = txtDescripcionM.Text;
                articulo.MarcaArticulo = (Marca)cboMarcaM.SelectedItem;
                articulo.CategoriaArticulo = (Categoria)cboCategoriaM.SelectedItem;
                articulo.UrlImagen = txtImagenM.Text;
                articulo.Precio = decimal.Parse(txtPrecioM.Text);

                negocio.modificar(articulo);

                MessageBox.Show("Modificado exitosamente");
                limpiarForm();
                ocultarLabels();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private bool validarCampos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            bool bandera = false;

            if (string.IsNullOrEmpty(txtCodArticuloM.Text))
            {
                lbErrorVacioM.Visible = true;
                bandera = true;
            }

            if (!(helper.soloLetrasYNumeros(txtCodArticuloM.Text)) && !(string.IsNullOrEmpty(txtNombreM.Text)))
            {
                lbError2CodArtM.Visible = true;
                bandera = true;
            }

            if (!(negocio.buscarArticulo(txtCodArticuloM.Text)))
            {
                lbError2CodArtM.Text = "El código de artículo es inexistente";
                lbError2CodArtM.Visible = true;
                bandera = true;
            }

            if (string.IsNullOrEmpty(txtNombreM.Text))
            {
                lbErrorVacioM.Visible = true;
                bandera = true;
            }

            if (!(helper.soloLetrasYNumeros(txtNombreM.Text)) && !(string.IsNullOrEmpty(txtNombreM.Text)))
            {
                lbError2NombreM.Visible = true;
                bandera = true;
            }

            if (string.IsNullOrEmpty(txtPrecioM.Text))
            {
                lbErrorVacioM.Visible = true;
                bandera = true;
            }

            if (!(helper.soloNumerosDecimales(txtPrecioM.Text)) && !(string.IsNullOrEmpty(txtPrecioM.Text)))

            {
                lbError2M.Visible = true;
                bandera = true;
            }

            return bandera;
        }

        public void ocultarLabels()
        {
            lbErrorVacioM.Visible = false;
            lbError2M.Visible = false;
            lbError2CodArtM.Visible = false;
            lbError2NombreM.Visible = false;
        }

        public void limpiarForm()
        {
            txtCodArticuloM.Clear();
            txtNombreM.Clear();
            txtDescripcionM.Clear();
            txtImagenM.Clear();
            txtPrecioM.Clear();

        }

        //private void txtPrecioM_Leave(object sender, EventArgs e)
        //{
        //    helper.formatoMoneda(txtPrecioM);
        //}
    }
}
