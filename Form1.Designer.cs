
namespace DynamicIPCONFIG
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btncambiarip = new System.Windows.Forms.Button();
            this.lblip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.label1.Name = "label1";
            // 
            // btncambiarip
            // 
            resources.ApplyResources(this.btncambiarip, "btncambiarip");
            this.btncambiarip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.btncambiarip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.btncambiarip.Name = "btncambiarip";
            this.btncambiarip.UseVisualStyleBackColor = false;
            this.btncambiarip.Click += new System.EventHandler(this.btncambiarip_Click);
            // 
            // lblip
            // 
            resources.ApplyResources(this.lblip, "lblip");
            this.lblip.BackColor = System.Drawing.Color.Transparent;
            this.lblip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(108)))), ((int)(((byte)(188)))));
            this.lblip.Name = "lblip";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(215)))), ((int)(((byte)(232)))));
            this.BackgroundImage = global::DynamicIPCONFIG.Properties.Resources.background;
            this.Controls.Add(this.lblip);
            this.Controls.Add(this.btncambiarip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncambiarip;
        private System.Windows.Forms.Label lblip;
    }
}

