
namespace TPWinForm
{
    partial class Modificar
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
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lbPrecioM = new System.Windows.Forms.Label();
            this.lbImagenM = new System.Windows.Forms.Label();
            this.cboCategoriaM = new System.Windows.Forms.ComboBox();
            this.cboMarcaM = new System.Windows.Forms.ComboBox();
            this.txtImagenM = new System.Windows.Forms.TextBox();
            this.lbCategoriaM = new System.Windows.Forms.Label();
            this.txtPrecioM = new System.Windows.Forms.TextBox();
            this.lbMarcaM = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lbNombreM = new System.Windows.Forms.Label();
            this.txtDescripcionM = new System.Windows.Forms.TextBox();
            this.lbDescripcionM = new System.Windows.Forms.Label();
            this.txtCodArticuloM = new System.Windows.Forms.TextBox();
            this.lbCodArticuloM = new System.Windows.Forms.Label();
            this.lbModificarTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataListado.Location = new System.Drawing.Point(29, 88);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(406, 259);
            this.dataListado.TabIndex = 67;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModificar.Location = new System.Drawing.Point(652, 324);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // lbPrecioM
            // 
            this.lbPrecioM.AutoSize = true;
            this.lbPrecioM.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioM.Location = new System.Drawing.Point(460, 264);
            this.lbPrecioM.Name = "lbPrecioM";
            this.lbPrecioM.Size = new System.Drawing.Size(50, 17);
            this.lbPrecioM.TabIndex = 65;
            this.lbPrecioM.Text = "Precio:";
            // 
            // lbImagenM
            // 
            this.lbImagenM.AutoSize = true;
            this.lbImagenM.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagenM.Location = new System.Drawing.Point(460, 238);
            this.lbImagenM.Name = "lbImagenM";
            this.lbImagenM.Size = new System.Drawing.Size(56, 17);
            this.lbImagenM.TabIndex = 64;
            this.lbImagenM.Text = "Imagen:";
            // 
            // cboCategoriaM
            // 
            this.cboCategoriaM.FormattingEnabled = true;
            this.cboCategoriaM.Location = new System.Drawing.Point(568, 208);
            this.cboCategoriaM.Name = "cboCategoriaM";
            this.cboCategoriaM.Size = new System.Drawing.Size(241, 21);
            this.cboCategoriaM.TabIndex = 4;
            // 
            // cboMarcaM
            // 
            this.cboMarcaM.FormattingEnabled = true;
            this.cboMarcaM.Location = new System.Drawing.Point(568, 182);
            this.cboMarcaM.Name = "cboMarcaM";
            this.cboMarcaM.Size = new System.Drawing.Size(241, 21);
            this.cboMarcaM.TabIndex = 3;
            // 
            // txtImagenM
            // 
            this.txtImagenM.Location = new System.Drawing.Point(569, 235);
            this.txtImagenM.Name = "txtImagenM";
            this.txtImagenM.Size = new System.Drawing.Size(240, 20);
            this.txtImagenM.TabIndex = 5;
            // 
            // lbCategoriaM
            // 
            this.lbCategoriaM.AutoSize = true;
            this.lbCategoriaM.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaM.Location = new System.Drawing.Point(460, 212);
            this.lbCategoriaM.Name = "lbCategoriaM";
            this.lbCategoriaM.Size = new System.Drawing.Size(69, 17);
            this.lbCategoriaM.TabIndex = 60;
            this.lbCategoriaM.Text = "Categoría:";
            // 
            // txtPrecioM
            // 
            this.txtPrecioM.Location = new System.Drawing.Point(569, 261);
            this.txtPrecioM.Name = "txtPrecioM";
            this.txtPrecioM.Size = new System.Drawing.Size(240, 20);
            this.txtPrecioM.TabIndex = 6;
            // 
            // lbMarcaM
            // 
            this.lbMarcaM.AutoSize = true;
            this.lbMarcaM.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcaM.Location = new System.Drawing.Point(460, 186);
            this.lbMarcaM.Name = "lbMarcaM";
            this.lbMarcaM.Size = new System.Drawing.Size(50, 17);
            this.lbMarcaM.TabIndex = 58;
            this.lbMarcaM.Text = "Marca:";
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(568, 131);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(240, 20);
            this.txtNombreM.TabIndex = 1;
            // 
            // lbNombreM
            // 
            this.lbNombreM.AutoSize = true;
            this.lbNombreM.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreM.Location = new System.Drawing.Point(460, 134);
            this.lbNombreM.Name = "lbNombreM";
            this.lbNombreM.Size = new System.Drawing.Size(60, 17);
            this.lbNombreM.TabIndex = 56;
            this.lbNombreM.Text = "Nombre:";
            // 
            // txtDescripcionM
            // 
            this.txtDescripcionM.Location = new System.Drawing.Point(568, 157);
            this.txtDescripcionM.Name = "txtDescripcionM";
            this.txtDescripcionM.Size = new System.Drawing.Size(240, 20);
            this.txtDescripcionM.TabIndex = 2;
            // 
            // lbDescripcionM
            // 
            this.lbDescripcionM.AutoSize = true;
            this.lbDescripcionM.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionM.Location = new System.Drawing.Point(460, 160);
            this.lbDescripcionM.Name = "lbDescripcionM";
            this.lbDescripcionM.Size = new System.Drawing.Size(84, 17);
            this.lbDescripcionM.TabIndex = 54;
            this.lbDescripcionM.Text = "Descripción:";
            // 
            // txtCodArticuloM
            // 
            this.txtCodArticuloM.Location = new System.Drawing.Point(568, 105);
            this.txtCodArticuloM.Name = "txtCodArticuloM";
            this.txtCodArticuloM.Size = new System.Drawing.Size(240, 20);
            this.txtCodArticuloM.TabIndex = 0;
            // 
            // lbCodArticuloM
            // 
            this.lbCodArticuloM.AutoSize = true;
            this.lbCodArticuloM.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodArticuloM.Location = new System.Drawing.Point(460, 108);
            this.lbCodArticuloM.Name = "lbCodArticuloM";
            this.lbCodArticuloM.Size = new System.Drawing.Size(103, 17);
            this.lbCodArticuloM.TabIndex = 52;
            this.lbCodArticuloM.Text = "Código Artículo:";
            // 
            // lbModificarTitulo
            // 
            this.lbModificarTitulo.AutoSize = true;
            this.lbModificarTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificarTitulo.Location = new System.Drawing.Point(335, 32);
            this.lbModificarTitulo.Name = "lbModificarTitulo";
            this.lbModificarTitulo.Size = new System.Drawing.Size(267, 37);
            this.lbModificarTitulo.TabIndex = 51;
            this.lbModificarTitulo.Text = "Modificar Artículo";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lbPrecioM);
            this.Controls.Add(this.lbImagenM);
            this.Controls.Add(this.cboCategoriaM);
            this.Controls.Add(this.cboMarcaM);
            this.Controls.Add(this.txtImagenM);
            this.Controls.Add(this.lbCategoriaM);
            this.Controls.Add(this.txtPrecioM);
            this.Controls.Add(this.lbMarcaM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.lbNombreM);
            this.Controls.Add(this.txtDescripcionM);
            this.Controls.Add(this.lbDescripcionM);
            this.Controls.Add(this.txtCodArticuloM);
            this.Controls.Add(this.lbCodArticuloM);
            this.Controls.Add(this.lbModificarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lbPrecioM;
        private System.Windows.Forms.Label lbImagenM;
        private System.Windows.Forms.ComboBox cboCategoriaM;
        private System.Windows.Forms.ComboBox cboMarcaM;
        private System.Windows.Forms.TextBox txtImagenM;
        private System.Windows.Forms.Label lbCategoriaM;
        private System.Windows.Forms.TextBox txtPrecioM;
        private System.Windows.Forms.Label lbMarcaM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label lbNombreM;
        private System.Windows.Forms.TextBox txtDescripcionM;
        private System.Windows.Forms.Label lbDescripcionM;
        private System.Windows.Forms.TextBox txtCodArticuloM;
        private System.Windows.Forms.Label lbCodArticuloM;
        private System.Windows.Forms.Label lbModificarTitulo;
    }
}