using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT
{
    public partial class BUSCAR_Cliente : Form
    {
        BLL_Cliente Cliente_;
        public BUSCAR_Cliente(bool trueb)
        {
            InitializeComponent();
            Cliente_ = new BLL_Cliente();

            this.button1.Visible = !trueb;
            this.button2.Visible = trueb;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonir_Click(object sender, EventArgs e)
        {
            try
            {
                uC_DGV1.Mostrar(Cliente_.ObtenerClientesBusqueda(uC_txtSoloNumeros1.Obtener()));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //cobrar

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Cliente cliente = uC_DGV1.Seleccionado() as BE_Cliente;
                if (cliente?.Nro_Cliente != null && cliente?.Nro_Cliente > 0)
                {
                    Generar_Factura frm = new Generar_Factura(cliente);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Seleccione un cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Cliente cliente = uC_DGV1.Seleccionado() as BE_Cliente;
                if (cliente?.DNI != null && cliente?.DNI > 0)
                {
                    CONTROL_CuentaCorriente frm = new CONTROL_CuentaCorriente(cliente);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Seleccione un cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
