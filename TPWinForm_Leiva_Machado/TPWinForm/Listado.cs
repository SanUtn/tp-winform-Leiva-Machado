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
using Helper;


namespace TPWinForm
{
    public partial class Listado : Form
    {
        
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            cargar();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
