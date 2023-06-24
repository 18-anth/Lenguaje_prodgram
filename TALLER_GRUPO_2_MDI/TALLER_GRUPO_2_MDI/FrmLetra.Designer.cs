namespace TALLER_GRUPO_2_MDI
{
    partial class FrmLetra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLetra));
            this.LETRA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LETRA
            // 
            this.LETRA.AutoSize = true;
            this.LETRA.BackColor = System.Drawing.Color.White;
            this.LETRA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LETRA.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LETRA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LETRA.Location = new System.Drawing.Point(328, 23);
            this.LETRA.Name = "LETRA";
            this.LETRA.Padding = new System.Windows.Forms.Padding(10);
            this.LETRA.Size = new System.Drawing.Size(179, 87);
            this.LETRA.TabIndex = 0;
            this.LETRA.Text = "LETRA ";
            // 
            // FrmLetra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::TALLER_GRUPO_2_MDI.Properties.Resources.letra;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LETRA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLetra";
            this.Text = "FrmLetra";
            this.Load += new System.EventHandler(this.FrmLetra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LETRA;
    }
}