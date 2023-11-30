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
    public partial class CONTROL_CuentaCorriente : Form
    {
        BLL_ComprobanteCobroAlquiler Cobro_;
        BLL_ComprobanteFactura Factura_;
        BLL_CuentaCorriente CtaCte_;
        public CONTROL_CuentaCorriente(BE_Cliente cliente)
        {
            InitializeComponent();
            Cobro_ = new BLL_ComprobanteCobroAlquiler();
            Factura_ = new BLL_ComprobanteFactura();
            CtaCte_ = new BLL_CuentaCorriente();
            List<BE_CuentaCorriente> ctacte = CtaCte_.ObtenerCuentaCorriente(Cobro_.Traer(cliente), Factura_.Traer(cliente, true));
            decimal saldodeudor = CtaCte_.ObtenerSaldo(ctacte);
            labelSaldo.Text = "SALDO $" + saldodeudor.ToString();
            if (saldodeudor > 0)
                labelSaldo.BackColor = Color.Red;
            else if (saldodeudor < 0)
                labelSaldo.BackColor = Color.Green;
            else if (saldodeudor == 0)
                labelSaldo.Text = "No registra deuda";
                labelSaldo.ForeColor = Color.White;
                labelSaldo.BackColor= Color.OrangeRed;

            labelClient.Text = cliente?.ToString();
            uC_DGV1.Mostrar(ctacte);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
