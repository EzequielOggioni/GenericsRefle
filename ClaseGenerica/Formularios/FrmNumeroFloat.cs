using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hoy.Clase.Generica;

namespace ClaseGenerica.Formularios
{
    public partial class FrmNumeroFloat : Form
    {
        public FrmNumeroFloat()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validaciones<float>.ValidaValor(float.Parse(this.txtMaximo.Text), float.Parse(this.txtMinimo.Text), float.Parse(this.txtValor.Text)))
                    txtValor.Text = "";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error al convertir en numero");
            }

            
        }
    }
}
