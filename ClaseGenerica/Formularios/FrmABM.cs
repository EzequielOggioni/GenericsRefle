using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseGenerica.Formularios
{
    public partial class FrmABM<T> : Form where T : class, new()
    {

        public T objCreado;
        public FrmABM(T objetoACrear)
        {
            InitializeComponent();

            int posicionY= 20;
            this.Text = typeof(T).Name;
            foreach (PropertyInfo item in typeof(T).GetProperties())
            {
                if (item.CanRead)
                {

                Label labelDinamico = new Label();
                TextBox textBox = new TextBox();

                labelDinamico.Text = item.Name;
                textBox.Text = item.GetValue(objetoACrear).ToString();
                labelDinamico.Name = "lbl" + item.Name;
                textBox.Name = "txt" + item.Name;
                labelDinamico.Location = new Point(20, posicionY);
                textBox.Location = new Point(220, posicionY);
                    
                posicionY += 60;

                this.Controls.Add(labelDinamico);
                this.Controls.Add(textBox);

                }
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objCreado = new T();

            foreach (PropertyInfo item in typeof(T).GetProperties())
            {
                if (item.CanWrite && item.CanRead)
                {
                    if (item.GetType().Name == "String")
                        item.SetValue(objCreado, this.Controls["txt" + item.Name].Text);
                    else
                item.SetValue(objCreado,  TypeDescriptor.GetConverter(item.PropertyType).ConvertFromString(this.Controls["txt" + item.Name].Text));
                }

            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
