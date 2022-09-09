
namespace TPWinForm
{
    partial class VerDetalle
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
            this.lbVerDetalleTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVerDetalleTitulo
            // 
            this.lbVerDetalleTitulo.AutoSize = true;
            this.lbVerDetalleTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerDetalleTitulo.Location = new System.Drawing.Point(129, 28);
            this.lbVerDetalleTitulo.Name = "lbVerDetalleTitulo";
            this.lbVerDetalleTitulo.Size = new System.Drawing.Size(420, 55);
            this.lbVerDetalleTitulo.TabIndex = 0;
            this.lbVerDetalleTitulo.Text = "Ver detalle articulo";
            // 
            // VerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbVerDetalleTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerDetalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbVerDetalleTitulo;
    }
}