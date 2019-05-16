namespace EjemploConexionBBDD
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.desplegableActores = new System.Windows.Forms.ComboBox();
            this.desplegableDirectores = new System.Windows.Forms.ComboBox();
            this.desplegablePeliculas = new System.Windows.Forms.ComboBox();
            this.desplegableGeneros = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // desplegableActores
            // 
            this.desplegableActores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desplegableActores.FormattingEnabled = true;
            this.desplegableActores.Location = new System.Drawing.Point(6, 95);
            this.desplegableActores.Name = "desplegableActores";
            this.desplegableActores.Size = new System.Drawing.Size(129, 21);
            this.desplegableActores.TabIndex = 0;
            this.desplegableActores.Text = "Actores";
            // 
            // desplegableDirectores
            // 
            this.desplegableDirectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desplegableDirectores.FormattingEnabled = true;
            this.desplegableDirectores.Location = new System.Drawing.Point(141, 95);
            this.desplegableDirectores.Name = "desplegableDirectores";
            this.desplegableDirectores.Size = new System.Drawing.Size(132, 21);
            this.desplegableDirectores.TabIndex = 1;
            this.desplegableDirectores.Text = "Directores";
            // 
            // desplegablePeliculas
            // 
            this.desplegablePeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desplegablePeliculas.FormattingEnabled = true;
            this.desplegablePeliculas.Location = new System.Drawing.Point(279, 95);
            this.desplegablePeliculas.Name = "desplegablePeliculas";
            this.desplegablePeliculas.Size = new System.Drawing.Size(132, 21);
            this.desplegablePeliculas.TabIndex = 2;
            this.desplegablePeliculas.Text = "Películas";
            // 
            // desplegableGeneros
            // 
            this.desplegableGeneros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desplegableGeneros.ForeColor = System.Drawing.SystemColors.WindowText;
            this.desplegableGeneros.FormattingEnabled = true;
            this.desplegableGeneros.Location = new System.Drawing.Point(417, 95);
            this.desplegableGeneros.Name = "desplegableGeneros";
            this.desplegableGeneros.Size = new System.Drawing.Size(132, 21);
            this.desplegableGeneros.TabIndex = 3;
            this.desplegableGeneros.Text = "Géneros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 123);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.desplegableGeneros);
            this.Controls.Add(this.desplegablePeliculas);
            this.Controls.Add(this.desplegableDirectores);
            this.Controls.Add(this.desplegableActores);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegableActores;
        private System.Windows.Forms.ComboBox desplegableDirectores;
        private System.Windows.Forms.ComboBox desplegablePeliculas;
        private System.Windows.Forms.ComboBox desplegableGeneros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

