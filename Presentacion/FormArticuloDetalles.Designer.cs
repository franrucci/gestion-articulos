namespace Presentacion
{
    partial class FormArticuloDetalles
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
            this.gBoxArticuloDetalles = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gBoxArticuloDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxArticuloDetalles
            // 
            this.gBoxArticuloDetalles.Controls.Add(this.lblDescripcion);
            this.gBoxArticuloDetalles.Controls.Add(this.rtbDescripcion);
            this.gBoxArticuloDetalles.Controls.Add(this.txtCodigo);
            this.gBoxArticuloDetalles.Controls.Add(this.lblCodigo);
            this.gBoxArticuloDetalles.Location = new System.Drawing.Point(12, 12);
            this.gBoxArticuloDetalles.Name = "gBoxArticuloDetalles";
            this.gBoxArticuloDetalles.Size = new System.Drawing.Size(388, 171);
            this.gBoxArticuloDetalles.TabIndex = 0;
            this.gBoxArticuloDetalles.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 41);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(15, 57);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(345, 96);
            this.rtbDescripcion.TabIndex = 2;
            this.rtbDescripcion.Text = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(97, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código de artículo:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(325, 189);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormArticuloDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 220);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gBoxArticuloDetalles);
            this.Name = "FormArticuloDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.FormArticuloDetalles_Load);
            this.gBoxArticuloDetalles.ResumeLayout(false);
            this.gBoxArticuloDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxArticuloDetalles;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnVolver;
    }
}