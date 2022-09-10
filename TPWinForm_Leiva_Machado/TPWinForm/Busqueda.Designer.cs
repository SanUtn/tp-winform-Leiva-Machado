
namespace TPWinForm
{
    partial class Busqueda
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
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.pbBusqueda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(257, 204);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(236, 20);
            this.txbBusqueda.TabIndex = 0;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBusqueda.Location = new System.Drawing.Point(519, 202);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(259, 32);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(325, 37);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Busqueda de Artículos";
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(32, 281);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(240, 150);
            this.dgvBusqueda.TabIndex = 3;
            this.dgvBusqueda.SelectionChanged += new System.EventHandler(this.dgvBusqueda_SelectionChanged);
            // 
            // pbBusqueda
            // 
            this.pbBusqueda.Location = new System.Drawing.Point(460, 318);
            this.pbBusqueda.Name = "pbBusqueda";
            this.pbBusqueda.Size = new System.Drawing.Size(100, 92);
            this.pbBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusqueda.TabIndex = 4;
            this.pbBusqueda.TabStop = false;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbBusqueda);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txbBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.PictureBox pbBusqueda;
    }
}