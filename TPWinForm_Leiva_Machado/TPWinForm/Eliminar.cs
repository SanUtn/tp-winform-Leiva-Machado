﻿using Dominio;
using Negocio;
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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
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
                cargarImagen(listaArticulos.First().UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbEliminar.Load(imagen);
            }
            catch (Exception ex)
            {

                pbEliminar.Load("https://socialistmodernism.com/wp-content/uploads/2017/07/placeholder-image.png");
            }
        }

        private void dataListado_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dataListado.CurrentRow.DataBoundItem;
            cargarImagen(articuloSeleccionado.UrlImagen);
        }

        private void eliminar(bool logico = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro que queres eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //retorna un valor
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataListado.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);

                    MessageBox.Show("Eliminado correctamente");
                    cargar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
