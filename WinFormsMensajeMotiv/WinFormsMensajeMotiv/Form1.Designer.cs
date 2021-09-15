namespace WinFormsMensajeMotiv
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
            this.btn_procesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_procesar
            // 
            this.btn_procesar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_procesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_procesar.FlatAppearance.BorderSize = 4;
            this.btn_procesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_procesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_procesar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_procesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_procesar.Location = new System.Drawing.Point(147, 170);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(185, 51);
            this.btn_procesar.TabIndex = 1;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.UseVisualStyleBackColor = false;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 390);
            this.Controls.Add(this.btn_procesar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Mensaje Motivacional";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_procesar;
    }
}

