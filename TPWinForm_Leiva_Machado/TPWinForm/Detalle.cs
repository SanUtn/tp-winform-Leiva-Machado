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
            lbNombre.Text = aux.NombreArticulo;
            lbDescripcion.Text = aux.Descripcion;
            lblPrecio.Text += aux.Precio;
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
