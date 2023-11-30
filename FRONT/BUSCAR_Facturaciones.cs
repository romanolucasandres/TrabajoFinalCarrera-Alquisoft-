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
    public partial class BUSCAR_Facturaciones : Form
    {
        BLL_Alquiler Alquiler_;
        BLL_ComprobanteFactura Factura_;
        bool nfactura = false;
        public BUSCAR_Facturaciones()
        {
            InitializeComponent();
            Factura_= new BLL_ComprobanteFactura();
            dateTimePicker1.Value = DateTime.Now;
        }
        public BUSCAR_Facturaciones(bool nfactura)
        {
            InitializeComponent();
            Alquiler_ = new BLL_Alquiler();
            Factura_= new BLL_ComprobanteFactura();
            dateTimePicker1.Value = DateTime.Now;
            Inicializar(nfactura);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = !checkBox1.Checked;
            buttonIR_Click(null, new EventArgs());
        }

        private void button6_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        

        private void buttonEDITAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (uC_DGV1.RowsMayor0())
                {
                    BE_ComprobanteFactura factura = uC_DGV1.Seleccionado() as BE_ComprobanteFactura;
                    if (factura != null)
                    {
                        Generar_Factura frm = new Generar_Factura(factura, true);
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

        private void buttonIR_Click(object sender, EventArgs e)
        {
            if (nfactura)
            {
                if (!checkBox1.Checked)
                    uC_DGV1.Mostrar(Factura_.Traer(dateTimePicker1.Value));
                else
                    uC_DGV1.Mostrar(Factura_.Traer());
            }
            else
            {
                if (checkBox1.Checked)
                    uC_DGV1.Mostrar(Alquiler_.Traer(null, null));
                else
                    uC_DGV1.Mostrar(Alquiler_.Traer(dateTimePicker1.Value, false));
            }
        }

        private void buttonGENERARFACTU_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.uC_DGV1.RowsMayor0())
                {
                    BE_Alquiler alquiler = new BE_Alquiler();
                    alquiler = uC_DGV1.Seleccionado() as BE_Alquiler;

                    if (alquiler?.Codigo != null && alquiler?.Codigo > 0 && alquiler?.Cliente != null)
                    {
                        Generar_Factura frm = new Generar_Factura(alquiler);
                        if (frm.ShowDialog() == DialogResult.OK)
                            buttonIR_Click(null, new EventArgs());
                    }
                    else
                        MessageBox.Show("Debe seleccionar un alquiler", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Debe seleccionar un alquiler", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonABRIR_Click(object sender, EventArgs e)
        {
            try
            {
                if (uC_DGV1.RowsMayor0())
                {
                    BE_ComprobanteFactura factura = uC_DGV1.Seleccionado() as BE_ComprobanteFactura;
                    if (factura != null)
                    {
                        Generar_Factura frm = new Generar_Factura(factura, false);
                        frm.ShowDialog();
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
                    BE_ComprobanteFactura factura = uC_DGV1.Seleccionado() as BE_ComprobanteFactura;
                    if (factura != null)
                    {
                        if (MessageBox.Show($"Está seguro que desea eliminar la Factura seleccionada {factura.NroComprobante}?", "Importante!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            Factura_.Baja(factura);
                            BE_Alquiler alquiler = factura.Alquiler;
                            alquiler.IsFacturado = false;
                            Alquiler_.Modificacion(alquiler, false);
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

        void Inicializar(bool inicia)
        {
            this.buttonBORRAR.Visible = this.buttonEDITAR.Visible = this.buttonIR.Visible = inicia;
            this.buttonGENERARFACTU.Visible = !inicia;
            nfactura = inicia;
            dateTimePicker1.Value = DateTime.Now;

        }

       
    }
}
