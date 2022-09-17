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
    public partial class Agregar : Form
    {
        private MetodosCompartidos helper = new MetodosCompartidos();
        public Agregar()
        {
            InitializeComponent();
            ocultarLabels();
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
            ocultarLabels();
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            try
            {
                if (validarCampos()) { return; }
                nuevo.CodArticulo = txtCodArticulo.Text;
                nuevo.NombreArticulo = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.MarcaArticulo = (Marca)cboMarca.SelectedItem;
                nuevo.CategoriaArticulo = (Categoria)cboCategoria.SelectedItem;
                nuevo.UrlImagen = txtImagen.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                nuevo.Activo = true;

                negocio.agregar(nuevo);

                MessageBox.Show("Agregado exitosamente");
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarCampos()
        {
            bool bandera = false;
            
                if (string.IsNullOrEmpty(txtCodArticulo.Text))
                {
                    lbErrorCodArt.Visible = true;
                    bandera = true;
                }

                if (!(helper.soloLetrasYNumeros(txtCodArticulo.Text)) && !(string.IsNullOrEmpty(txtNombre.Text)))
                {
                    lbError2CodArt.Visible = true;
                    bandera = true;
                }
               
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    lbErrorNombre.Visible = true;
                    bandera = true;
                }

                if (!(helper.soloLetrasYNumeros(txtNombre.Text)) && !(string.IsNullOrEmpty(txtNombre.Text)))
                {
                    lbError2Nombre.Visible = true;
                    bandera = true;
                }
         
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    lbErrorPrecio.Visible = true;
                    bandera = true;
                }

                if (!(helper.soloNumerosDecimales(txtPrecio.Text)) && !(string.IsNullOrEmpty(txtPrecio.Text)))
            
                {
                    lbError2Precio.Visible = true;
                    bandera = true;
                }

            return bandera;
        }

        public void ocultarLabels()
        {
            lbErrorCodArt.Visible = false;
            lbError2CodArt.Visible = false;
            lbErrorNombre.Visible = false;
            lbError2Nombre.Visible = false;
            lbErrorPrecio.Visible = false;
            lbError2Precio.Visible = false;
        }

        public void limpiarForm()
        {
            txtCodArticulo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtImagen.Clear();
            txtPrecio.Clear();
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            helper.formatoMoneda(txtPrecio);
        }
    }
}
