
namespace TPWinForm
{
    partial class Eliminar
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbEliminarTitulo = new System.Windows.Forms.Label();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.gbFormEliminar = new System.Windows.Forms.GroupBox();
            this.txtCategoriaE = new System.Windows.Forms.TextBox();
            this.txtMarcaE = new System.Windows.Forms.TextBox();
            this.lbPrecioE = new System.Windows.Forms.Label();
            this.lbImagenE = new System.Windows.Forms.Label();
            this.txtImagenE = new System.Windows.Forms.TextBox();
            this.lbCategoriaE = new System.Windows.Forms.Label();
            this.txtPrecioE = new System.Windows.Forms.TextBox();
            this.lbMarcaE = new System.Windows.Forms.Label();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.lbNombreE = new System.Windows.Forms.Label();
            this.lbDescripcionE = new System.Windows.Forms.Label();
            this.txtCodArticuloE = new System.Windows.Forms.TextBox();
            this.lbCodArticuloE = new System.Windows.Forms.Label();
            this.txtDescripcionE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            this.gbFormEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataListado.Location = new System.Drawing.Point(29, 99);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(406, 204);
            this.dataListado.TabIndex = 84;
            this.dataListado.SelectionChanged += new System.EventHandler(this.dataListado_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEliminar.Location = new System.Drawing.Point(580, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Fisico";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lbEliminarTitulo
            // 
            this.lbEliminarTitulo.AutoSize = true;
            this.lbEliminarTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEliminarTitulo.Location = new System.Drawing.Point(337, 32);
            this.lbEliminarTitulo.Name = "lbEliminarTitulo";
            this.lbEliminarTitulo.Size = new System.Drawing.Size(246, 37);
            this.lbEliminarTitulo.TabIndex = 68;
            this.lbEliminarTitulo.Text = "Eliminar Artículo";
            // 
            // pbEliminar
            // 
            this.pbEliminar.Location = new System.Drawing.Point(169, 309);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(148, 115);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 85;
            this.pbEliminar.TabStop = false;
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarLogico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarLogico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarLogico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLogico.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEliminarLogico.Location = new System.Drawing.Point(715, 339);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(104, 23);
            this.btnEliminarLogico.TabIndex = 86;
            this.btnEliminarLogico.Text = "Eliminar Logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // gbFormEliminar
            // 
            this.gbFormEliminar.Controls.Add(this.txtCategoriaE);
            this.gbFormEliminar.Controls.Add(this.txtMarcaE);
            this.gbFormEliminar.Controls.Add(this.lbPrecioE);
            this.gbFormEliminar.Controls.Add(this.lbImagenE);
            this.gbFormEliminar.Controls.Add(this.txtImagenE);
            this.gbFormEliminar.Controls.Add(this.lbCategoriaE);
            this.gbFormEliminar.Controls.Add(this.txtPrecioE);
            this.gbFormEliminar.Controls.Add(this.lbMarcaE);
            this.gbFormEliminar.Controls.Add(this.txtNombreE);
            this.gbFormEliminar.Controls.Add(this.lbNombreE);
            this.gbFormEliminar.Controls.Add(this.lbDescripcionE);
            this.gbFormEliminar.Controls.Add(this.txtCodArticuloE);
            this.gbFormEliminar.Controls.Add(this.lbCodArticuloE);
            this.gbFormEliminar.Controls.Add(this.txtDescripcionE);
            this.gbFormEliminar.Location = new System.Drawing.Point(464, 94);
            this.gbFormEliminar.Name = "gbFormEliminar";
            this.gbFormEliminar.Size = new System.Drawing.Size(376, 209);
            this.gbFormEliminar.TabIndex = 87;
            this.gbFormEliminar.TabStop = false;
            // 
            // txtCategoriaE
            // 
            this.txtCategoriaE.Location = new System.Drawing.Point(115, 120);
            this.txtCategoriaE.Name = "txtCategoriaE";
            this.txtCategoriaE.ReadOnly = true;
            this.txtCategoriaE.Size = new System.Drawing.Size(240, 20);
            this.txtCategoriaE.TabIndex = 67;
            // 
            // txtMarcaE
            // 
            this.txtMarcaE.Location = new System.Drawing.Point(115, 94);
            this.txtMarcaE.Name = "txtMarcaE";
            this.txtMarcaE.ReadOnly = true;
            this.txtMarcaE.Size = new System.Drawing.Size(240, 20);
            this.txtMarcaE.TabIndex = 66;
            // 
            // lbPrecioE
            // 
            this.lbPrecioE.AutoSize = true;
            this.lbPrecioE.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecioE.Location = new System.Drawing.Point(7, 175);
            this.lbPrecioE.Name = "lbPrecioE";
            this.lbPrecioE.Size = new System.Drawing.Size(50, 17);
            this.lbPrecioE.TabIndex = 65;
            this.lbPrecioE.Text = "Precio:";
            // 
            // lbImagenE
            // 
            this.lbImagenE.AutoSize = true;
            this.lbImagenE.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagenE.Location = new System.Drawing.Point(7, 149);
            this.lbImagenE.Name = "lbImagenE";
            this.lbImagenE.Size = new System.Drawing.Size(56, 17);
            this.lbImagenE.TabIndex = 64;
            this.lbImagenE.Text = "Imagen:";
            // 
            // txtImagenE
            // 
            this.txtImagenE.Location = new System.Drawing.Point(116, 146);
            this.txtImagenE.Name = "txtImagenE";
            this.txtImagenE.ReadOnly = true;
            this.txtImagenE.Size = new System.Drawing.Size(240, 20);
            this.txtImagenE.TabIndex = 5;
            // 
            // lbCategoriaE
            // 
            this.lbCategoriaE.AutoSize = true;
            this.lbCategoriaE.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoriaE.Location = new System.Drawing.Point(7, 123);
            this.lbCategoriaE.Name = "lbCategoriaE";
            this.lbCategoriaE.Size = new System.Drawing.Size(69, 17);
            this.lbCategoriaE.TabIndex = 60;
            this.lbCategoriaE.Text = "Categoría:";
            // 
            // txtPrecioE
            // 
            this.txtPrecioE.Location = new System.Drawing.Point(116, 172);
            this.txtPrecioE.Name = "txtPrecioE";
            this.txtPrecioE.ReadOnly = true;
            this.txtPrecioE.Size = new System.Drawing.Size(240, 20);
            this.txtPrecioE.TabIndex = 6;
            // 
            // lbMarcaE
            // 
            this.lbMarcaE.AutoSize = true;
            this.lbMarcaE.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcaE.Location = new System.Drawing.Point(7, 97);
            this.lbMarcaE.Name = "lbMarcaE";
            this.lbMarcaE.Size = new System.Drawing.Size(50, 17);
            this.lbMarcaE.TabIndex = 58;
            this.lbMarcaE.Text = "Marca:";
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(115, 42);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.ReadOnly = true;
            this.txtNombreE.Size = new System.Drawing.Size(240, 20);
            this.txtNombreE.TabIndex = 1;
            // 
            // lbNombreE
            // 
            this.lbNombreE.AutoSize = true;
            this.lbNombreE.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreE.Location = new System.Drawing.Point(7, 45);
            this.lbNombreE.Name = "lbNombreE";
            this.lbNombreE.Size = new System.Drawing.Size(60, 17);
            this.lbNombreE.TabIndex = 56;
            this.lbNombreE.Text = "Nombre:";
            // 
            // lbDescripcionE
            // 
            this.lbDescripcionE.AutoSize = true;
            this.lbDescripcionE.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionE.Location = new System.Drawing.Point(7, 71);
            this.lbDescripcionE.Name = "lbDescripcionE";
            this.lbDescripcionE.Size = new System.Drawing.Size(84, 17);
            this.lbDescripcionE.TabIndex = 54;
            this.lbDescripcionE.Text = "Descripción:";
            // 
            // txtCodArticuloE
            // 
            this.txtCodArticuloE.Location = new System.Drawing.Point(115, 16);
            this.txtCodArticuloE.Name = "txtCodArticuloE";
            this.txtCodArticuloE.ReadOnly = true;
            this.txtCodArticuloE.Size = new System.Drawing.Size(240, 20);
            this.txtCodArticuloE.TabIndex = 0;
            // 
            // lbCodArticuloE
            // 
            this.lbCodArticuloE.AutoSize = true;
            this.lbCodArticuloE.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodArticuloE.Location = new System.Drawing.Point(7, 19);
            this.lbCodArticuloE.Name = "lbCodArticuloE";
            this.lbCodArticuloE.Size = new System.Drawing.Size(103, 17);
            this.lbCodArticuloE.TabIndex = 52;
            this.lbCodArticuloE.Text = "Código Artículo:";
            // 
            // txtDescripcionE
            // 
            this.txtDescripcionE.Location = new System.Drawing.Point(115, 68);
            this.txtDescripcionE.Name = "txtDescripcionE";
            this.txtDescripcionE.ReadOnly = true;
            this.txtDescripcionE.Size = new System.Drawing.Size(240, 20);
            this.txtDescripcionE.TabIndex = 2;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.gbFormEliminar);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbEliminarTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            this.gbFormEliminar.ResumeLayout(false);
            this.gbFormEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbEliminarTitulo;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.GroupBox gbFormEliminar;
        private System.Windows.Forms.Label lbPrecioE;
        private System.Windows.Forms.Label lbImagenE;
        private System.Windows.Forms.TextBox txtImagenE;
        private System.Windows.Forms.Label lbCategoriaE;
        private System.Windows.Forms.TextBox txtPrecioE;
        private System.Windows.Forms.Label lbMarcaE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label lbNombreE;
        private System.Windows.Forms.Label lbDescripcionE;
        private System.Windows.Forms.TextBox txtCodArticuloE;
        private System.Windows.Forms.Label lbCodArticuloE;
        private System.Windows.Forms.TextBox txtDescripcionE;
        private System.Windows.Forms.TextBox txtCategoriaE;
        private System.Windows.Forms.TextBox txtMarcaE;
    }
}