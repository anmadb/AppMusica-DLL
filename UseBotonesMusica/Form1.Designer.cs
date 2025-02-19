namespace UseBotonesMusica
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
            this.barraProgreso1 = new BotonesMusica.Botones.BarraProgreso();
            this.botonAnterior1 = new BotonesMusica.Botones.BotonAnterior();
            this.botonArchivos1 = new BotonesMusica.Botones.BotonArchivos();
            this.botonCerrar1 = new BotonesMusica.Botones.BotonCerrar();
            this.botonSiguiente1 = new BotonesMusica.Botones.BotonSiguiente();
            this.notaMusical1 = new BotonesMusica.Botones.NotaMusical();
            this.botonPlayPause1 = new BotonesMusica.Botones.BotonPlayPause();
            this.SuspendLayout();
            // 
            // barraProgreso1
            // 
            this.barraProgreso1.DuracionTotalSegundos = 225;
            this.barraProgreso1.Location = new System.Drawing.Point(38, 332);
            this.barraProgreso1.Maximo = 100;
            this.barraProgreso1.Name = "barraProgreso1";
            this.barraProgreso1.Progreso = 0;
            this.barraProgreso1.Size = new System.Drawing.Size(240, 31);
            this.barraProgreso1.TabIndex = 0;
            this.barraProgreso1.Text = "barraProgreso1";
            // 
            // botonAnterior1
            // 
            this.botonAnterior1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.botonAnterior1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAnterior1.FlatAppearance.BorderSize = 0;
            this.botonAnterior1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAnterior1.ForeColor = System.Drawing.Color.White;
            this.botonAnterior1.Location = new System.Drawing.Point(67, 369);
            this.botonAnterior1.Name = "botonAnterior1";
            this.botonAnterior1.Size = new System.Drawing.Size(50, 50);
            this.botonAnterior1.TabIndex = 1;
            this.botonAnterior1.Text = "botonAnterior1";
            this.botonAnterior1.UseVisualStyleBackColor = false;
            // 
            // botonArchivos1
            // 
            this.botonArchivos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.botonArchivos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonArchivos1.FlatAppearance.BorderSize = 0;
            this.botonArchivos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonArchivos1.ForeColor = System.Drawing.Color.White;
            this.botonArchivos1.Location = new System.Drawing.Point(12, 12);
            this.botonArchivos1.Name = "botonArchivos1";
            this.botonArchivos1.Size = new System.Drawing.Size(50, 50);
            this.botonArchivos1.TabIndex = 2;
            this.botonArchivos1.Text = "botonArchivos1";
            this.botonArchivos1.UseVisualStyleBackColor = false;
            // 
            // botonCerrar1
            // 
            this.botonCerrar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.botonCerrar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar1.FlatAppearance.BorderSize = 0;
            this.botonCerrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCerrar1.ForeColor = System.Drawing.Color.White;
            this.botonCerrar1.Location = new System.Drawing.Point(247, 12);
            this.botonCerrar1.Name = "botonCerrar1";
            this.botonCerrar1.Size = new System.Drawing.Size(50, 50);
            this.botonCerrar1.TabIndex = 3;
            this.botonCerrar1.Text = "botonCerrar1";
            this.botonCerrar1.UseVisualStyleBackColor = false;
            this.botonCerrar1.Click += new System.EventHandler(this.botonCerrar1_Click);
            // 
            // botonSiguiente1
            // 
            this.botonSiguiente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.botonSiguiente1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSiguiente1.FlatAppearance.BorderSize = 0;
            this.botonSiguiente1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSiguiente1.ForeColor = System.Drawing.Color.White;
            this.botonSiguiente1.Location = new System.Drawing.Point(186, 369);
            this.botonSiguiente1.Name = "botonSiguiente1";
            this.botonSiguiente1.Size = new System.Drawing.Size(50, 50);
            this.botonSiguiente1.TabIndex = 5;
            this.botonSiguiente1.Text = "botonSiguiente1";
            this.botonSiguiente1.UseVisualStyleBackColor = false;
            // 
            // notaMusical1
            // 
            this.notaMusical1.Location = new System.Drawing.Point(61, 118);
            this.notaMusical1.Name = "notaMusical1";
            this.notaMusical1.Size = new System.Drawing.Size(186, 181);
            this.notaMusical1.TabIndex = 6;
            this.notaMusical1.Text = "notaMusical1";
            this.notaMusical1.Click += new System.EventHandler(this.notaMusical1_Click);
            // 
            // botonPlayPause1
            // 
            this.botonPlayPause1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.botonPlayPause1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonPlayPause1.FlatAppearance.BorderSize = 0;
            this.botonPlayPause1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPlayPause1.ForeColor = System.Drawing.Color.White;
            this.botonPlayPause1.Location = new System.Drawing.Point(128, 369);
            this.botonPlayPause1.Name = "botonPlayPause1";
            this.botonPlayPause1.Size = new System.Drawing.Size(50, 50);
            this.botonPlayPause1.TabIndex = 7;
            this.botonPlayPause1.Text = "botonPlayPause1";
            this.botonPlayPause1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.botonPlayPause1);
            this.Controls.Add(this.notaMusical1);
            this.Controls.Add(this.botonSiguiente1);
            this.Controls.Add(this.botonCerrar1);
            this.Controls.Add(this.botonArchivos1);
            this.Controls.Add(this.botonAnterior1);
            this.Controls.Add(this.barraProgreso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BotonesMusica.Botones.BarraProgreso barraProgreso1;
        private BotonesMusica.Botones.BotonAnterior botonAnterior1;
        private BotonesMusica.Botones.BotonArchivos botonArchivos1;
        private BotonesMusica.Botones.BotonCerrar botonCerrar1;
        private BotonesMusica.Botones.BotonSiguiente botonSiguiente1;
        private BotonesMusica.Botones.NotaMusical notaMusical1;
        private BotonesMusica.Botones.BotonPlayPause botonPlayPause1;
    }
}

