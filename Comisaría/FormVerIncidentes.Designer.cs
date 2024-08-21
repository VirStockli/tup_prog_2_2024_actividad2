namespace Comisaría
{
    partial class FormVerIncidentes
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
            this.lboxVerIncidente = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxVerIncidente
            // 
            this.lboxVerIncidente.FormattingEnabled = true;
            this.lboxVerIncidente.Location = new System.Drawing.Point(12, 12);
            this.lboxVerIncidente.Name = "lboxVerIncidente";
            this.lboxVerIncidente.Size = new System.Drawing.Size(426, 355);
            this.lboxVerIncidente.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(169, 373);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(128, 36);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FormVerIncidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 414);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lboxVerIncidente);
            this.Name = "FormVerIncidentes";
            this.Text = "FormVerIncidentes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxVerIncidente;
        private System.Windows.Forms.Button btnCerrar;
    }
}