namespace PrjAsistencia
{
    partial class Ejer01
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txtcod = new System.Windows.Forms.TextBox();
            this.Txtpass = new System.Windows.Forms.TextBox();
            this.Btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtcod
            // 
            this.Txtcod.Location = new System.Drawing.Point(323, 44);
            this.Txtcod.MaxLength = 10;
            this.Txtcod.Name = "Txtcod";
            this.Txtcod.Size = new System.Drawing.Size(100, 20);
            this.Txtcod.TabIndex = 0;
            // 
            // Txtpass
            // 
            this.Txtpass.Location = new System.Drawing.Point(323, 99);
            this.Txtpass.MaxLength = 6;
            this.Txtpass.Name = "Txtpass";
            this.Txtpass.Size = new System.Drawing.Size(100, 20);
            this.Txtpass.TabIndex = 1;
            // 
            // Btnok
            // 
            this.Btnok.Location = new System.Drawing.Point(277, 182);
            this.Btnok.Name = "Btnok";
            this.Btnok.Size = new System.Drawing.Size(75, 23);
            this.Btnok.TabIndex = 2;
            this.Btnok.Text = "OK";
            this.Btnok.UseVisualStyleBackColor = true;
            this.Btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clave:";
            // 
            // Btnsalir
            // 
            this.Btnsalir.Location = new System.Drawing.Point(358, 182);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(75, 23);
            this.Btnsalir.TabIndex = 5;
            this.Btnsalir.Text = "Salir";
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Ejer01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 445);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnok);
            this.Controls.Add(this.Txtpass);
            this.Controls.Add(this.Txtcod);
            this.Name = "Ejer01";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ejer01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtcod;
        private System.Windows.Forms.TextBox Txtpass;
        private System.Windows.Forms.Button Btnok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btnsalir;
    }
}

