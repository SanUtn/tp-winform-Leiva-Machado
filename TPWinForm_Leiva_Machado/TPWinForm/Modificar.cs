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
            if (articulo != null)
            {
                txtCodArticuloM.Text = articulo.CodArticulo;
                txtNombreM.Text = articulo.NombreArticulo;
                txtDescripcionM.Text = articulo.Descripcion;
                
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
            Articulo articuloSeleccionado = (Articulo)dataListado.CurrentRow.DataBoundItem;
            cargarImagen(articuloSeleccionado.UrlImagen);
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dataListado.CurrentRow.DataBoundItem;
            cerrarForms();
            Modificar modificar = new Modificar(seleccionado);
            //modificar.MdiParent = this;
            modificar.Size = new Size(865, 474);
            modificar.Show();
         

        }

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


    }
}
