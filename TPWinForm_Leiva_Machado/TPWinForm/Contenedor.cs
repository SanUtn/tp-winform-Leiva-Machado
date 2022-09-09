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
            Home ventanaHome = new Home();
            ventanaHome.MdiParent = this;
            ventanaHome.Show();
        }

        private void ventanaHome_Click(object sender, EventArgs e)
        {
            cerrarForms();
            Home ventanaHome = new Home();
            ventanaHome.MdiParent = this;
            ventanaHome.Show();
        }

        private void ventanaListado_Click(object sender, EventArgs e)
        {
            cerrarForms();
            Listado ventanaListado = new Listado();
            ventanaListado.MdiParent = this;
            ventanaListado.Show();
        }

        private void ventanaBusqueda_Click(object sender, EventArgs e)
        {
            cerrarForms();
            Busqueda ventanaBusqueda = new Busqueda();
            ventanaBusqueda.MdiParent = this;
            ventanaBusqueda.Show();
        }

        private void ventanaAgregar_Click(object sender, EventArgs e)
        {
            cerrarForms();
            Agregar ventanaAgregar = new Agregar();
            ventanaAgregar.MdiParent = this;
            ventanaAgregar.Show();
        }

        private void ventanaModificar_Click(object sender, EventArgs e)
        {
            cerrarForms();
            Modificar ventanaModificar = new Modificar();
            ventanaModificar.MdiParent = this;
            ventanaModificar.Show();
        }

        private void ventanaEliminar_Click(object sender, EventArgs e)
        {
            cerrarForms();
            Eliminar ventanaEliminar = new Eliminar();
            ventanaEliminar.MdiParent = this;
            ventanaEliminar.Show();
        }

        private void ventanaVerDetalle_Click(object sender, EventArgs e)
        {
            cerrarForms();
            VerDetalle ventanaVerDetalle = new VerDetalle();
            ventanaVerDetalle.MdiParent = this;
            ventanaVerDetalle.Show();
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
