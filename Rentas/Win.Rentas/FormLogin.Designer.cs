namespace Win.Rentas
{
    partial class FormLogin
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
            this.label1user = new System.Windows.Forms.Label();
            this.label2pass = new System.Windows.Forms.Label();
            this.textBox1user = new System.Windows.Forms.TextBox();
            this.textBox2pass = new System.Windows.Forms.TextBox();
            this.button1aceptar = new System.Windows.Forms.Button();
            this.button2cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1user
            // 
            this.label1user.AutoSize = true;
            this.label1user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1user.Location = new System.Drawing.Point(185, 44);
            this.label1user.Name = "label1user";
            this.label1user.Size = new System.Drawing.Size(72, 18);
            this.label1user.TabIndex = 0;
            this.label1user.Text = "Usuario:";
            // 
            // label2pass
            // 
            this.label2pass.AutoSize = true;
            this.label2pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2pass.Location = new System.Drawing.Point(161, 84);
            this.label2pass.Name = "label2pass";
            this.label2pass.Size = new System.Drawing.Size(100, 18);
            this.label2pass.TabIndex = 0;
            this.label2pass.Text = "Contraseña:";
            // 
            // textBox1user
            // 
            this.textBox1user.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1user.Location = new System.Drawing.Point(287, 40);
            this.textBox1user.Name = "textBox1user";
            this.textBox1user.Size = new System.Drawing.Size(213, 22);
            this.textBox1user.TabIndex = 1;
            // 
            // textBox2pass
            // 
            this.textBox2pass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2pass.Location = new System.Drawing.Point(287, 80);
            this.textBox2pass.Name = "textBox2pass";
            this.textBox2pass.PasswordChar = '*';
            this.textBox2pass.Size = new System.Drawing.Size(213, 22);
            this.textBox2pass.TabIndex = 1;
            // 
            // button1aceptar
            // 
            this.button1aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1aceptar.Location = new System.Drawing.Point(227, 158);
            this.button1aceptar.Name = "button1aceptar";
            this.button1aceptar.Size = new System.Drawing.Size(115, 43);
            this.button1aceptar.TabIndex = 2;
            this.button1aceptar.Text = "Aceptar";
            this.button1aceptar.UseVisualStyleBackColor = true;
            this.button1aceptar.Click += new System.EventHandler(this.button1aceptar_Click);
            // 
            // button2cancelar
            // 
            this.button2cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2cancelar.Location = new System.Drawing.Point(357, 158);
            this.button2cancelar.Name = "button2cancelar";
            this.button2cancelar.Size = new System.Drawing.Size(123, 43);
            this.button2cancelar.TabIndex = 2;
            this.button2cancelar.Text = "Cancelar";
            this.button2cancelar.UseVisualStyleBackColor = true;
            this.button2cancelar.Click += new System.EventHandler(this.button2cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(203, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Win.Rentas.Properties.Resources.user_login_icon_29;
            this.pictureBox1.Location = new System.Drawing.Point(36, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 255);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2cancelar);
            this.Controls.Add(this.button1aceptar);
            this.Controls.Add(this.textBox2pass);
            this.Controls.Add(this.textBox1user);
            this.Controls.Add(this.label2pass);
            this.Controls.Add(this.label1user);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1user;
        private System.Windows.Forms.Label label2pass;
        private System.Windows.Forms.TextBox textBox1user;
        private System.Windows.Forms.TextBox textBox2pass;
        private System.Windows.Forms.Button button1aceptar;
        private System.Windows.Forms.Button button2cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

