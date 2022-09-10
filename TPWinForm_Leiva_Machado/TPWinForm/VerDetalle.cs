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
    public partial class VerDetalle : Form
    {
        public VerDetalle()
        {
            InitializeComponent();
        }

        private void VerDetalle_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulos;
            try
            {
                listaArticulos = negocio.listarArticulo();
                var x = 50;
                var y = 50;
                foreach (Articulo aux in listaArticulos)
                {
                    
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(x, y);
                    pic.Name = "pic" + aux.NombreArticulo;
                    pic.Size = new Size(100, 100);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.ImageLocation = aux.UrlImagen;
                    x += 50;
                    y += 50;
                    this.Controls.Add(pic);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
