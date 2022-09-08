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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
            //Home ventanaHome = new Home();
            //ventanaHome.MdiParent = this;
            //ventanaHome.Show();
        }

        private void ventanaHome_Click(object sender, EventArgs e)
        {
            Home ventanaHome = new Home();
            ventanaHome.MdiParent = this;
            ventanaHome.Show();
        }

        private void ventanaListado_Click(object sender, EventArgs e)
        {
            Listado ventanaListado = new Listado();
            ventanaListado.MdiParent = this;
            ventanaListado.Show();
        }

        private void ventanaBusqueda_Click(object sender, EventArgs e)
        {
            Busqueda ventanaBusqueda = new Busqueda();
            ventanaBusqueda.MdiParent = this;
            ventanaBusqueda.Show();
        }

        private void ventanaAgregar_Click(object sender, EventArgs e)
        {
            Agregar ventanaAgregar = new Agregar();
            ventanaAgregar.MdiParent = this;
            ventanaAgregar.Show();
        }

        private void ventanaModificar_Click(object sender, EventArgs e)
        {
            Modificar ventanaModificar = new Modificar();
            ventanaModificar.MdiParent = this;
            ventanaModificar.Show();
        }

        private void ventanaEliminar_Click(object sender, EventArgs e)
        {
            Eliminar ventanaEliminar = new Eliminar();
            ventanaEliminar.MdiParent = this;
            ventanaEliminar.Show();
        }

        private void ventanaVerDetalle_Click(object sender, EventArgs e)
        {
            VerDetalle ventanaVerDetalle = new VerDetalle();
            ventanaVerDetalle.MdiParent = this;
            ventanaVerDetalle.Show();
        }
    }
}
