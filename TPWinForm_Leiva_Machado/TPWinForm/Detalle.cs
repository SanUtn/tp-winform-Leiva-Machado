using Dominio;
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
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        public Detalle(Articulo aux)
        {
            InitializeComponent();
            cargarDetalle(aux);
        }
        private void cargarDetalle(Articulo aux)
        {
            lbNombre.Text = aux.NombreArticulo;
            lbDescripcion.Text = string.IsNullOrWhiteSpace(aux.Descripcion) ? " Sin descripción " : aux.Descripcion;
            lblPrecio.Text += decimal.Round(aux.Precio,2);
            lbCategoria.Text += string.IsNullOrWhiteSpace(aux.CategoriaArticulo.NombreCategoria) ? " Sin categoría " : aux.CategoriaArticulo.NombreCategoria;
            lbMarca.Text += string.IsNullOrWhiteSpace(aux.MarcaArticulo.NombreMarca) ? " Sin marca " : aux.MarcaArticulo.NombreMarca;
            lbCodigo.Text += aux.CodArticulo;
            cargarImagen(aux.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                pbDetalle.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png");
               
            }
        }
    }
}
