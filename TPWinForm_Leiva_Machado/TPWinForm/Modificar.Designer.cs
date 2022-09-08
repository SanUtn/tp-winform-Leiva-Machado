
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
            this.lbModificarTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbModificarTitulo
            // 
            this.lbModificarTitulo.AutoSize = true;
            this.lbModificarTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificarTitulo.Location = new System.Drawing.Point(157, 22);
            this.lbModificarTitulo.Name = "lbModificarTitulo";
            this.lbModificarTitulo.Size = new System.Drawing.Size(390, 55);
            this.lbModificarTitulo.TabIndex = 0;
            this.lbModificarTitulo.Text = "Modificar Articulo";
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbModificarTitulo);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbModificarTitulo;
    }
}