
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
            this.SuspendLayout();
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(188, 52);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txbBusqueda.TabIndex = 0;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(295, 52);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 1;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txbBusqueda);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
    }
}