
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
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataListado.Location = new System.Drawing.Point(60, 99);
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
            this.btnEliminar.Location = new System.Drawing.Point(515, 280);
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
            this.pbEliminar.Location = new System.Drawing.Point(546, 125);
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
            this.btnEliminarLogico.Location = new System.Drawing.Point(625, 280);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(104, 23);
            this.btnEliminarLogico.TabIndex = 86;
            this.btnEliminarLogico.Text = "Eliminar Logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = false;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lbEliminarTitulo;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.Button btnEliminarLogico;
    }
}