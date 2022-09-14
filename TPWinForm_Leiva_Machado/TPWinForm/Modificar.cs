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
        private Articulo articulo = null;
        public Modificar()
        {
            InitializeComponent();
        }

        public Modificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            cargar();
            //if (articulo != null)
            //{
            //    txtCodArticuloM.Text = articulo.CodArticulo;
            //    txtNombreM.Text = articulo.NombreArticulo;
            //    txtDescripcionM.Text = articulo.Descripcion;
            //}
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

        //private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    Articulo seleccionado;
        //    seleccionado = (Articulo)dataListado.CurrentRow.DataBoundItem;
        //    cerrarForms();
        //    Modificar modificar = new Modificar(seleccionado);
        //    //modificar.MdiParent = this;
        //    modificar.Size = new Size(865, 474);
        //    modificar.Show();
        //}

        void cerrarForms()
        {
            List<Form> formularios = Application.OpenForms.Cast<Form>().Where(x => !(x is Contenedor))
            .ToList(); //busca formularios abiertos y solo trae los que sean diferentes a Contenedor.

            foreach (var item in formularios)
            {
                //los cierra
                item.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.CodArticulo = txtCodArticuloM.Text;
                articulo.NombreArticulo = txtNombreM.Text;
                articulo.Descripcion = txtDescripcionM.Text;
                articulo.MarcaArticulo = (Marca)cboMarcaM.SelectedItem;
                articulo.CategoriaArticulo = (Categoria)cboCategoriaM.SelectedItem;
                articulo.UrlImagen = txtImagenM.Text;
                articulo.Precio = float.Parse(txtPrecioM.Text);

                negocio.modificar(articulo);

                MessageBox.Show("Modificado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                cargar();
            }
        }
    }
}
