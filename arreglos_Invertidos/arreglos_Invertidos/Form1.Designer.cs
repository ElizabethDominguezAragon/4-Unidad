namespace arreglos_Invertidos
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NumerosRamdom = new System.Windows.Forms.ListBox();
            this.NumerosInvertidos = new System.Windows.Forms.ListBox();
            this.Generar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // NumerosRamdom
            // 
            this.NumerosRamdom.FormattingEnabled = true;
            this.NumerosRamdom.ItemHeight = 22;
            this.NumerosRamdom.Location = new System.Drawing.Point(34, 39);
            this.NumerosRamdom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumerosRamdom.Name = "NumerosRamdom";
            this.NumerosRamdom.Size = new System.Drawing.Size(132, 444);
            this.NumerosRamdom.TabIndex = 0;
            this.NumerosRamdom.SelectedIndexChanged += new System.EventHandler(this.NumerosRamdom_SelectedIndexChanged);
            // 
            // NumerosInvertidos
            // 
            this.NumerosInvertidos.FormattingEnabled = true;
            this.NumerosInvertidos.ItemHeight = 22;
            this.NumerosInvertidos.Location = new System.Drawing.Point(174, 39);
            this.NumerosInvertidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumerosInvertidos.Name = "NumerosInvertidos";
            this.NumerosInvertidos.Size = new System.Drawing.Size(145, 444);
            this.NumerosInvertidos.TabIndex = 1;
            this.NumerosInvertidos.SelectedIndexChanged += new System.EventHandler(this.NumerosInvertidos_SelectedIndexChanged);
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(395, 39);
            this.Generar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(112, 39);
            this.Generar.TabIndex = 2;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de numeros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista invertida:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.NumerosInvertidos);
            this.Controls.Add(this.NumerosRamdom);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "lista de numeros y numeros invertidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox NumerosRamdom;
        private System.Windows.Forms.ListBox NumerosInvertidos;
        private System.Windows.Forms.Button Generar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

