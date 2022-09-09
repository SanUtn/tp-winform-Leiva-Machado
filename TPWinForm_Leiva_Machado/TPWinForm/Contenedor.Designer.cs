namespace TPWinForm
{
    partial class Contenedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msNavegacion = new System.Windows.Forms.MenuStrip();
            this.ventanaHome = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaListado = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaVerDetalle = new System.Windows.Forms.ToolStripMenuItem();
            this.msNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNavegacion
            // 
            this.msNavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaHome,
            this.ventanaListado,
            this.ventanaBusqueda,
            this.ventanaAgregar,
            this.ventanaModificar,
            this.ventanaEliminar,
            this.ventanaVerDetalle});
            this.msNavegacion.Location = new System.Drawing.Point(0, 0);
            this.msNavegacion.Name = "msNavegacion";
            this.msNavegacion.Size = new System.Drawing.Size(870, 24);
            this.msNavegacion.TabIndex = 0;
            this.msNavegacion.Text = "menuStrip1";
            // 
            // ventanaHome
            // 
            this.ventanaHome.Name = "ventanaHome";
            this.ventanaHome.Size = new System.Drawing.Size(52, 20);
            this.ventanaHome.Text = "Home";
            this.ventanaHome.Click += new System.EventHandler(this.ventanaHome_Click);
            // 
            // ventanaListado
            // 
            this.ventanaListado.Name = "ventanaListado";
            this.ventanaListado.Size = new System.Drawing.Size(57, 20);
            this.ventanaListado.Text = "Listado";
            this.ventanaListado.Click += new System.EventHandler(this.ventanaListado_Click);
            // 
            // ventanaBusqueda
            // 
            this.ventanaBusqueda.Name = "ventanaBusqueda";
            this.ventanaBusqueda.Size = new System.Drawing.Size(71, 20);
            this.ventanaBusqueda.Text = "Busqueda";
            this.ventanaBusqueda.Click += new System.EventHandler(this.ventanaBusqueda_Click);
            // 
            // ventanaAgregar
            // 
            this.ventanaAgregar.Name = "ventanaAgregar";
            this.ventanaAgregar.Size = new System.Drawing.Size(61, 20);
            this.ventanaAgregar.Text = "Agregar";
            this.ventanaAgregar.Click += new System.EventHandler(this.ventanaAgregar_Click);
            // 
            // ventanaModificar
            // 
            this.ventanaModificar.Name = "ventanaModificar";
            this.ventanaModificar.Size = new System.Drawing.Size(70, 20);
            this.ventanaModificar.Text = "Modificar";
            this.ventanaModificar.Click += new System.EventHandler(this.ventanaModificar_Click);
            // 
            // ventanaEliminar
            // 
            this.ventanaEliminar.Name = "ventanaEliminar";
            this.ventanaEliminar.Size = new System.Drawing.Size(62, 20);
            this.ventanaEliminar.Text = "Eliminar";
            this.ventanaEliminar.Click += new System.EventHandler(this.ventanaEliminar_Click);
            // 
            // ventanaVerDetalle
            // 
            this.ventanaVerDetalle.Name = "ventanaVerDetalle";
            this.ventanaVerDetalle.Size = new System.Drawing.Size(73, 20);
            this.ventanaVerDetalle.Text = "Ver detalle";
            this.ventanaVerDetalle.Click += new System.EventHandler(this.ventanaVerDetalle_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 502);
            this.Controls.Add(this.msNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msNavegacion;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(886, 541);
            this.MinimumSize = new System.Drawing.Size(886, 541);
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Articulos";
            this.msNavegacion.ResumeLayout(false);
            this.msNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNavegacion;
        private System.Windows.Forms.ToolStripMenuItem ventanaHome;
        private System.Windows.Forms.ToolStripMenuItem ventanaListado;
        private System.Windows.Forms.ToolStripMenuItem ventanaBusqueda;
        private System.Windows.Forms.ToolStripMenuItem ventanaAgregar;
        private System.Windows.Forms.ToolStripMenuItem ventanaModificar;
        private System.Windows.Forms.ToolStripMenuItem ventanaEliminar;
        private System.Windows.Forms.ToolStripMenuItem ventanaVerDetalle;
    }
}

