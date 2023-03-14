namespace WindowsFormsApp1
{
    partial class Telegrama
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
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbUrgente = new System.Windows.Forms.RadioButton();
            this.rbOrdinario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(21, 41);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(414, 115);
            this.txtTelegrama.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(21, 177);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(416, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbUrgente
            // 
            this.rbUrgente.AutoSize = true;
            this.rbUrgente.Location = new System.Drawing.Point(472, 148);
            this.rbUrgente.Name = "rbUrgente";
            this.rbUrgente.Size = new System.Drawing.Size(63, 17);
            this.rbUrgente.TabIndex = 4;
            this.rbUrgente.TabStop = true;
            this.rbUrgente.Text = "Urgente";
            this.rbUrgente.UseVisualStyleBackColor = true;
            // 
            // rbOrdinario
            // 
            this.rbOrdinario.AutoSize = true;
            this.rbOrdinario.Location = new System.Drawing.Point(472, 177);
            this.rbOrdinario.Name = "rbOrdinario";
            this.rbOrdinario.Size = new System.Drawing.Size(67, 17);
            this.rbOrdinario.TabIndex = 5;
            this.rbOrdinario.TabStop = true;
            this.rbOrdinario.Text = "Ordinario";
            this.rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // Telegrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 232);
            this.Controls.Add(this.rbOrdinario);
            this.Controls.Add(this.rbUrgente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Name = "Telegrama";
            this.Text = "Telegrama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbUrgente;
        private System.Windows.Forms.RadioButton rbOrdinario;
    }
}

