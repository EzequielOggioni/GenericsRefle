namespace ClaseGenerica.Formularios
{
    partial class FrmNumero
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
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(39, 20);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(43, 13);
            this.lblMaximo.TabIndex = 0;
            this.lblMaximo.Text = "Maximo";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(148, 20);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(40, 13);
            this.lblMinimo.TabIndex = 1;
            this.lblMinimo.Text = "Minimo";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(262, 20);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(32, 46);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMaximo.TabIndex = 3;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(151, 46);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtMinimo.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(265, 46);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(345, 204);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // cmbLista
            // 
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Items.AddRange(new object[] {
            "Productos",
            "Clientes",
            "Empleados"});
            this.cmbLista.Location = new System.Drawing.Point(341, 140);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(121, 21);
            this.cmbLista.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbLista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Name = "FrmNumero";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.Button button1;
    }
}

