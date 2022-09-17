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
                    if(x >= 820)
                    {
                        x = 50;
                        y += 110;
                    }
                    PictureBox pic = new PictureBox();
                    
                    pic.Location = new Point(x, y);
                    
                    pic.Name = "pic" + aux.NombreArticulo;
                    pic.Size = new Size(100, 100);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.AccessibleName = aux.NombreArticulo;
                    pic.Cursor = Cursors.Hand;
                    pic.Click += new EventHandler(visualizarDetalle);

                    Label label = new Label();
                    label.Location = new Point(x, y);
                    label.Name = "lb" + aux.NombreArticulo;
                    label.Size = new Size(100, 100);
                    label.Cursor = Cursors.Hand;
                    label.Text = aux.NombreArticulo;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Visible = false;
                    label.Click += new EventHandler(visualizarDetalle);

                    cargarImagen(pic, aux.UrlImagen, label);

                    x += 110;          
                    this.Controls.Add(label);
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
            string name;

            if (sender.GetType() == typeof(PictureBox))
            {
                PictureBox pb = (PictureBox)sender;
                name = pb.AccessibleName;
            }
            else
            {
                Label pb = (Label)sender;
                name = pb.Text;
            }       

            Articulo aux = listaArticulos.Where(x => x.NombreArticulo == name).FirstOrDefault();
            Detalle detalle = new Detalle(aux);
            detalle.ShowDialog();
        }

        private void picNombreArticulo(object sender, EventArgs e)
        {
            //Control[] pictures = this.Controls.Find("picBicicleta", false);
           
        }


        private void cargarImagen(PictureBox pb, string imagen, Label lb)
        {
            try
            {
                pb.Load(imagen);
            }
            catch (Exception ex)
            {
                lb.Visible = true;
            }
        }


    }
}
