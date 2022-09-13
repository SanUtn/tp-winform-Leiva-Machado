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
        private List<Articulo> listaArticulos;
        public VerDetalle()
        {
            InitializeComponent();
        }

        private void VerDetalle_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                listaArticulos = negocio.listarArticulo();
                var x = 50;
                var y = 100;
                foreach (Articulo aux in listaArticulos)
                {
                    
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(x, y);
                    pic.Name = "pic" + aux.NombreArticulo;
                    pic.Size = new Size(100, 100);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.AccessibleName = aux.NombreArticulo;
                    cargarImagen(pic, aux.UrlImagen);
                    x += 100;
                    pic.Click += new EventHandler(visualizarDetalle);
                    this.Controls.Add(pic);
                }
                Control[] pictures = this.Controls.Find("picBicicleta", false);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void visualizarDetalle(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string name = pb.AccessibleName;

            Articulo aux = listaArticulos.Where(x => x.NombreArticulo == name).FirstOrDefault();
            Detalle detalle = new Detalle(aux);
            detalle.ShowDialog();
        }

        private void picNombreArticulo(object sender, EventArgs e)
        {
            //Control[] pictures = this.Controls.Find("picBicicleta", false);
           
        }


        private void cargarImagen(PictureBox pb, string imagen)
        {
            try
            {
                pb.Load(imagen);
            }
            catch (Exception ex)
            {
                pb.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png");
            }
        }
    }
}
