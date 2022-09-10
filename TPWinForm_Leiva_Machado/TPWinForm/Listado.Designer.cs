
namespace TPWinForm
{
    partial class Listado
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
            this.tituloListado = new System.Windows.Forms.Label();
            this.pbListado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataListado.Location = new System.Drawing.Point(29, 89);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(569, 259);
            this.dataListado.TabIndex = 0;
            this.dataListado.SelectionChanged += new System.EventHandler(this.dataListado_SelectionChanged);
            // 
            // tituloListado
            // 
            this.tituloListado.AutoSize = true;
            this.tituloListado.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloListado.Location = new System.Drawing.Point(285, 27);
            this.tituloListado.Name = "tituloListado";
            this.tituloListado.Size = new System.Drawing.Size(288, 37);
            this.tituloListado.TabIndex = 1;
            this.tituloListado.Text = "Listado de Artículos";
            // 
            // pbListado
            // 
            this.pbListado.Location = new System.Drawing.Point(634, 152);
            this.pbListado.Name = "pbListado";
            this.pbListado.Size = new System.Drawing.Size(151, 136);
            this.pbListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbListado.TabIndex = 2;
            this.pbListado.TabStop = false;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.pbListado);
            this.Controls.Add(this.tituloListado);
            this.Controls.Add(this.dataListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label tituloListado;
        private System.Windows.Forms.PictureBox pbListado;
    }
}