
namespace TPWinForm
{
    partial class Agregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAgregarTitulo = new System.Windows.Forms.Label();
            this.lbCodArticulo = new System.Windows.Forms.Label();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbErrorCodArt = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbError2CodArt = new System.Windows.Forms.Label();
            this.lbErrorNombre = new System.Windows.Forms.Label();
            this.lbError2Nombre = new System.Windows.Forms.Label();
            this.lbErrorPrecio = new System.Windows.Forms.Label();
            this.lbError2Precio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAgregarTitulo
            // 
            this.lbAgregarTitulo.AutoSize = true;
            this.lbAgregarTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarTitulo.Location = new System.Drawing.Point(311, 31);
            this.lbAgregarTitulo.Name = "lbAgregarTitulo";
            this.lbAgregarTitulo.Size = new System.Drawing.Size(246, 37);
            this.lbAgregarTitulo.TabIndex = 1;
            this.lbAgregarTitulo.Text = "Agregar Artículo";
            // 
            // lbCodArticulo
            // 
            this.lbCodArticulo.AutoSize = true;
            this.lbCodArticulo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodArticulo.Location = new System.Drawing.Point(209, 99);
            this.lbCodArticulo.Name = "lbCodArticulo";
            this.lbCodArticulo.Size = new System.Drawing.Size(109, 17);
            this.lbCodArticulo.TabIndex = 2;
            this.lbCodArticulo.Text = "*Código Artículo:";
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Location = new System.Drawing.Point(317, 96);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(240, 20);
            this.txtCodArticulo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(317, 148);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(240, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(209, 151);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(84, 17);
            this.lbDescripcion.TabIndex = 4;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(317, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(209, 125);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 17);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "*Nombre:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(318, 252);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(240, 20);
            this.txtPrecio.TabIndex = 6;
            //this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(209, 177);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(50, 17);
            this.lbMarca.TabIndex = 8;
            this.lbMarca.Text = "Marca:";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(318, 226);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(240, 20);
            this.txtImagen.TabIndex = 5;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(209, 203);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(69, 17);
            this.lbCategoria.TabIndex = 10;
            this.lbCategoria.Text = "Categoría:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(317, 173);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(241, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(317, 199);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(241, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagen.Location = new System.Drawing.Point(209, 229);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(56, 17);
            this.lbImagen.TabIndex = 14;
            this.lbImagen.Text = "Imagen:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(209, 255);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(56, 17);
            this.lbPrecio.TabIndex = 15;
            this.lbPrecio.Text = "*Precio:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAgregar.Location = new System.Drawing.Point(401, 315);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbErrorCodArt
            // 
            this.lbErrorCodArt.AutoSize = true;
            this.lbErrorCodArt.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCodArt.Location = new System.Drawing.Point(563, 96);
            this.lbErrorCodArt.Name = "lbErrorCodArt";
            this.lbErrorCodArt.Size = new System.Drawing.Size(101, 13);
            this.lbErrorCodArt.TabIndex = 16;
            this.lbErrorCodArt.Text = "* Campo incompleto";
            this.lbErrorCodArt.UseWaitCursor = true;
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(315, 275);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(130, 16);
            this.lbInfo.TabIndex = 17;
            this.lbInfo.Text = "* Campos obligatorios";
            // 
            // lbError2CodArt
            // 
            this.lbError2CodArt.AutoSize = true;
            this.lbError2CodArt.ForeColor = System.Drawing.Color.Red;
            this.lbError2CodArt.Location = new System.Drawing.Point(563, 109);
            this.lbError2CodArt.Name = "lbError2CodArt";
            this.lbError2CodArt.Size = new System.Drawing.Size(182, 13);
            this.lbError2CodArt.TabIndex = 18;
            this.lbError2CodArt.Text = "* El campo admite letras y/o números";
            this.lbError2CodArt.UseWaitCursor = true;
            // 
            // lbErrorNombre
            // 
            this.lbErrorNombre.AutoSize = true;
            this.lbErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lbErrorNombre.Location = new System.Drawing.Point(563, 122);
            this.lbErrorNombre.Name = "lbErrorNombre";
            this.lbErrorNombre.Size = new System.Drawing.Size(101, 13);
            this.lbErrorNombre.TabIndex = 19;
            this.lbErrorNombre.Text = "* Campo incompleto";
            this.lbErrorNombre.UseWaitCursor = true;
            // 
            // lbError2Nombre
            // 
            this.lbError2Nombre.AutoSize = true;
            this.lbError2Nombre.ForeColor = System.Drawing.Color.Red;
            this.lbError2Nombre.Location = new System.Drawing.Point(563, 135);
            this.lbError2Nombre.Name = "lbError2Nombre";
            this.lbError2Nombre.Size = new System.Drawing.Size(182, 13);
            this.lbError2Nombre.TabIndex = 20;
            this.lbError2Nombre.Text = "* El campo admite letras y/o números";
            this.lbError2Nombre.UseWaitCursor = true;
            // 
            // lbErrorPrecio
            // 
            this.lbErrorPrecio.AutoSize = true;
            this.lbErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPrecio.Location = new System.Drawing.Point(563, 252);
            this.lbErrorPrecio.Name = "lbErrorPrecio";
            this.lbErrorPrecio.Size = new System.Drawing.Size(101, 13);
            this.lbErrorPrecio.TabIndex = 21;
            this.lbErrorPrecio.Text = "* Campo incompleto";
            this.lbErrorPrecio.UseWaitCursor = true;
            // 
            // lbError2Precio
            // 
            this.lbError2Precio.AutoSize = true;
            this.lbError2Precio.ForeColor = System.Drawing.Color.Red;
            this.lbError2Precio.Location = new System.Drawing.Point(564, 265);
            this.lbError2Precio.Name = "lbError2Precio";
            this.lbError2Precio.Size = new System.Drawing.Size(193, 13);
            this.lbError2Precio.TabIndex = 22;
            this.lbError2Precio.Text = "* Solo numeros (punto como separador)";
            this.lbError2Precio.UseWaitCursor = true;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbError2Precio);
            this.Controls.Add(this.lbErrorPrecio);
            this.Controls.Add(this.lbError2Nombre);
            this.Controls.Add(this.lbErrorNombre);
            this.Controls.Add(this.lbError2CodArt);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbErrorCodArt);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.txtCodArticulo);
            this.Controls.Add(this.lbCodArticulo);
            this.Controls.Add(this.lbAgregarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbAgregarTitulo;
        private System.Windows.Forms.Label lbCodArticulo;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbErrorCodArt;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbError2CodArt;
        private System.Windows.Forms.Label lbErrorNombre;
        private System.Windows.Forms.Label lbError2Nombre;
        private System.Windows.Forms.Label lbErrorPrecio;
        private System.Windows.Forms.Label lbError2Precio;
    }
}