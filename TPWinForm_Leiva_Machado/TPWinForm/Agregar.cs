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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listarMarca();
                cboMarca.ValueMember = "Id"; //nombres de las propiedades de la clase elemento
                cboMarca.DisplayMember = "NombreMarca";

                cboCategoria.DataSource = categoriaNegocio.listarCategoria();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "NombreCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            try
            {
                nuevo.CodArticulo = txtCodArticulo.Text;
                nuevo.NombreArticulo = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.MarcaArticulo = (Marca)cboMarca.SelectedItem;
                nuevo.CategoriaArticulo = (Categoria)cboCategoria.SelectedItem;
                nuevo.UrlImagen = txtImagen.Text;
                nuevo.Precio = float.Parse(txtPrecio.Text);

                negocio.agregar(nuevo);

                MessageBox.Show("Agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
