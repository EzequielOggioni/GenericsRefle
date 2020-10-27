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
using ClaseGenerica.Entidades;
using Entitades;

namespace ClaseGenerica.Formularios
{
    public partial class FrmNumero : Form
    {
        public FrmNumero()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validaciones<int>.ValidaValor(int.Parse(this.txtMinimo.Text), int.Parse(this.txtMaximo.Text), int.Parse(this.txtValor.Text)))
                    txtValor.Text = "";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error al convertir en numero");
            }

            switch(this.cmbLista.SelectedItem.ToString())
            {


                case "Productos":
                    llenarDataGridView<Producto>(Inventario.Productos);
                    break;
                case "Empleados":
                    llenarDataGridView<Empleado>(Inventario.Empleados);
                    break;
                case "Clientes":
                    llenarDataGridView<Cliente>(Inventario.Clientes);
                    break;
            }

           
        }

        private void llenarDataGridView<T>(List<T> listaACargar )
        {
            this.dataGridView1.DataSource = null; 
            this.dataGridView1.DataSource = listaACargar;
            this.dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmABM<Producto> frnAMBProd = new FrmABM<Producto>(Inventario.Productos[0]);
            if (frnAMBProd.ShowDialog() == DialogResult.OK)
                Inventario.Productos.Add(frnAMBProd.objCreado);


            FrmABM<Cliente> frnAMBCliente = new FrmABM<Cliente>(Inventario.Clientes[0]);
          
            if (frnAMBCliente.ShowDialog() == DialogResult.OK)
                Inventario.Clientes.Add(frnAMBCliente.objCreado);


            FrmABM<Empleado> frmEmpleado = new FrmABM<Empleado>(Inventario.Empleados [0]);

            if (frmEmpleado.ShowDialog() == DialogResult.OK)
                Inventario.Empleados.Add(frmEmpleado.objCreado);



        }
    }
}
