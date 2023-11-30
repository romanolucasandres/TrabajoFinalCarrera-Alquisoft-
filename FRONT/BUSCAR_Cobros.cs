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
    public partial class BUSCAR_Cobros : Form
    {
        BLL_ComprobanteCobroAlquiler ComprobanteAlquiler_;
        BLL_ComprobanteFactura ComprobanteFactura_;
        public BUSCAR_Cobros()
        {
            InitializeComponent();
            ComprobanteAlquiler_ = new BLL_ComprobanteCobroAlquiler();
            ComprobanteFactura_ = new BLL_ComprobanteFactura();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonABRIR_Click(object sender, EventArgs e)
        {
            try
            {
                if (uC_DGV1.RowsMayor0())
                {
                    BE_ComprobanteCobroAlquiler comprobante = uC_DGV1.Seleccionado() as BE_ComprobanteCobroAlquiler;
                    
                    if (comprobante != null)
                    {
                        Generar_Factura frm = new Generar_Factura(comprobante, false);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonIR_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                uC_DGV1.Mostrar(ComprobanteAlquiler_.Traer(dateTimePicker1.Value));
            else
                uC_DGV1.Mostrar(ComprobanteAlquiler_.Traer());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = !checkBox1.Checked;
         
        }

        private void buttonEDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (uC_DGV1.RowsMayor0())
                {
                    BE_ComprobanteCobroAlquiler cobro = uC_DGV1.Seleccionado() as BE_ComprobanteCobroAlquiler;
                    if (cobro != null)
                    {
                        Generar_Factura frm = new Generar_Factura(cobro, true);
                        if (frm.ShowDialog() == DialogResult.OK)
                            buttonIR_Click(null, new EventArgs());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonBORRAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (uC_DGV1.RowsMayor0())
                {
                    BE_ComprobanteCobroAlquiler cobro = uC_DGV1.Seleccionado() as BE_ComprobanteCobroAlquiler;
                    if (cobro != null)
                    {
                        if (MessageBox.Show($"Está seguro que desea eliminar el Cobro {cobro.NroComprobante} seleccionado?", "Importante!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            ComprobanteAlquiler_.Baja(cobro);
                            if (cobro.N_Factura.EstadoPagado)
                            {
                                BE_ComprobanteFactura factura = cobro.N_Factura;
                                factura.EstadoPagado = false;
                                ComprobanteFactura_.Modificacion(factura);
                            }
                            buttonIR_Click(null, new EventArgs());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
