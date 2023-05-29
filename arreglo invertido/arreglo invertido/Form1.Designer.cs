namespace arreglo_invertido
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
            this.Lista2 = new System.Windows.Forms.ListBox();
            this.Lista1 = new System.Windows.Forms.ListBox();
            this.Generar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista2
            // 
            this.Lista2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lista2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista2.FormattingEnabled = true;
            this.Lista2.ItemHeight = 15;
            this.Lista2.Location = new System.Drawing.Point(345, 21);
            this.Lista2.Name = "Lista2";
            this.Lista2.Size = new System.Drawing.Size(120, 349);
            this.Lista2.TabIndex = 0;
            // 
            // Lista1
            // 
            this.Lista1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lista1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista1.FormattingEnabled = true;
            this.Lista1.ItemHeight = 15;
            this.Lista1.Location = new System.Drawing.Point(21, 21);
            this.Lista1.Name = "Lista1";
            this.Lista1.Size = new System.Drawing.Size(120, 349);
            this.Lista1.TabIndex = 1;
            // 
            // Generar
            // 
            this.Generar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Generar.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar.Location = new System.Drawing.Point(189, 335);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(94, 35);
            this.Generar.TabIndex = 2;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = false;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(485, 393);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.Lista1);
            this.Controls.Add(this.Lista2);
            this.Name = "Form1";
            this.Text = "Arreglo Invertido";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista2;
        private System.Windows.Forms.ListBox Lista1;
        private System.Windows.Forms.Button Generar;
    }
}

