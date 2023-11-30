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
    
    public partial class Generar_Factura : Form
    {
        BLL_Alquiler Alquiler_;
        BLL_ComprobanteFactura ComprobanteFactura_;
        BLL_ComprobanteCobroAlquiler ComprobanteCobroAlquiler_;
        BE_Cliente Cliente_BE;
        BE_ComprobanteFactura FacturaEdicion_BE;
        BE_ComprobanteCobroAlquiler CobroEdicion_BE;
        bool edicion = false;
        bool cobro = false;
        bool edicioncobro = false;
       
        public Generar_Factura(BE_Alquiler alquiler)
        {
            InitializeComponent();
            Alquiler_ = new BLL_Alquiler();
            ComprobanteFactura_ = new BLL_ComprobanteFactura();
            ComprobanteCobroAlquiler_ = new BLL_ComprobanteCobroAlquiler();
            InicializarDatos(alquiler);

        }

        public Generar_Factura(BE_ComprobanteFactura factura, bool edita)
        {
            InitializeComponent();
            Alquiler_ = new BLL_Alquiler();
            ComprobanteFactura_ = new BLL_ComprobanteFactura();
            ComprobanteCobroAlquiler_ = new BLL_ComprobanteCobroAlquiler();
            InicializarDatos(factura);
            Edicion(edita);

        }

        public Generar_Factura(BE_Cliente cliente)
        {
            InitializeComponent();
            ComprobanteFactura_ = new BLL_ComprobanteFactura();
            ComprobanteCobroAlquiler_ = new BLL_ComprobanteCobroAlquiler();
            InicializarDatos(cliente);
            this.cobro = true;

        }
        public Generar_Factura(BE_ComprobanteCobroAlquiler comprobante, bool edicion)
        {
            InitializeComponent();
            ComprobanteFactura_ = new BLL_ComprobanteFactura();
            ComprobanteCobroAlquiler_ = new BLL_ComprobanteCobroAlquiler();
            InicializarDatos(comprobante);
            this.cobro = true;
            EdicionCobro(edicion);


        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void EdicionCobro(bool edita)
        {

            dateTimePicker1.Enabled = false;
            comboBoxMP.Enabled = false;
            uC_txtSoloDecimalIMPORTE.Enabled = edita;
            buttonFCImpo.Enabled = edita;
            //dgV_General1.Enabled = edita;
            label7.Enabled = edita;
            edicioncobro = edita;
            label10.Visible = uC_txtSoloDecimalSaldo.Visible = edita;
            labelCons.Visible = uC_txtSoloDecimalCONSOLIDADO.Visible = !edita;

            if (edita)
                buttonFCImpo.Text = "MODIFICAR";
        }
        void Edicion(bool edita)
        {
            edicion = edita;
            this.dateTimePicker1.Enabled = this.comboBoxMP.Enabled = false;
            this.uC_txtSoloDecimaldesc.Enabled = this.uC_txtSoloDecimalsub.Enabled = this.radioButtonES.Enabled = this.radioButtonNO.Enabled = this.buttonFCSUB.Enabled = edita;
            if (edita)
                buttonFCSUB.Text = "MODIFICAR";

        }
        void InicializarDatos(BE_ComprobanteFactura factura)
        {
            try
            {
                if (factura != null)
                {
                    List<BE_Alquiler> alquileres = new List<BE_Alquiler>();
                    alquileres.Add(factura.Alquiler);
                    uC_txtSoloDecimaldesc.Texto = factura.Porcentaje.ToString();
                    radioButtonES.Checked = factura.EsDescuento;
                    radioButtonNO.Checked = !factura.EsDescuento;
                    uC_txtSoloDecimalsub.Texto = factura.Subtotal.ToString();
                    uC_txtSoloDecimaliva.Texto = factura.Iva.ToString();
                    uC_txtSoloDecimalIMPORTE.Texto = factura.ImporteTotal.ToString();
                    uC_txtSoloNumerosDNI.Texto = factura.ClienteComprobante.Nro_Cliente.ToString();
                    uC_txtSoloNumerosNUMERO.Texto = factura.NroComprobante.ToString();
                    dateTimePicker1.Value = factura.Fecha.Date;
                    uC_txtSoloTextoNOMBRE.Texto = factura.ClienteComprobante.Nombre;
                    uC_txtSoloTextoAPELLIDO.Texto = factura.ClienteComprobante.Apellido;
                    comboBoxMP.SelectedItem = factura.Medio;
                    uC_DGV1.Mostrar(alquileres);
                    FacturaEdicion_BE = factura;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        void InicializarDatos(BE_Alquiler alquiler)
        {
            try
            {

                if (alquiler != null)
                {
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker1.MinDate = DateTime.Now.AddDays(-15);
                    uC_txtSoloNumerosNUMERO.Texto = ComprobanteFactura_.ObtenerUltimoNumero();
                    this.Text = "Cobro";
                    List<string> mediosPago = new List<string>
                {
                    "Efectivo",
                    "Transferencia",
                    "Débito",
                    "Tarjeta de Crédito"
                };
                    comboBoxMP.DataSource = mediosPago;
                    comboBoxMP.SelectedIndex = 0;
                    uC_txtSoloDecimalsub.Texto = alquiler.Total.ToString() ?? "";
                    uC_txtSoloNumerosDNI.Texto = alquiler.Cliente.DNI.ToString();                    
                    uC_txtSoloTextoNOMBRE.Texto = alquiler.Cliente.Nombre;
                    uC_txtSoloTextoAPELLIDO.Texto = alquiler.Cliente.Apellido;
                    List<BE_Alquiler> alquileres = new List<BE_Alquiler>();
                    alquileres.Add(alquiler);
                    this.uC_DGV1.Mostrar(alquileres);
                    Cliente_BE = alquiler.Cliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void InicializarDatos(BE_Cliente cliente)
        {
            if (cliente != null)
            {
                Cliente_BE = cliente;
                groupBoxCOBRO.Visible = true;
                groupBoxCOBRO.BringToFront();
                this.Text = "Cobro";
                List<string> mediosPago = new List<string>
                {
                    "Efectivo",
                    "Transferencia",
                    "Débito",
                    "Tarjeta de Crédito"
                };
                comboBoxMP.DataSource = mediosPago;
                comboBoxMP.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker1.MinDate = DateTime.Now.AddDays(-5);
                uC_txtSoloNumerosNUMERO.Texto = ComprobanteCobroAlquiler_.ObtenerUltimoNumero();
                uC_txtSoloNumerosDNI.Texto = cliente.DNI.ToString();           
                uC_txtSoloTextoNOMBRE.Texto = cliente.Nombre;
                uC_txtSoloTextoAPELLIDO.Texto = cliente.Apellido;
                uC_DGV1.Mostrar(ComprobanteFactura_.Traer(cliente, false));

            }

        }

        void InicializarDatos(BE_ComprobanteCobroAlquiler comprobante)
        {
            if (comprobante != null)
            {
                comprobante.N_Factura = ComprobanteFactura_.Traer(comprobante.N_Factura.NroComprobante);
                CobroEdicion_BE = comprobante;
                List<BE_ComprobanteFactura> lista = new List<BE_ComprobanteFactura>();
                lista.Add(comprobante.N_Factura);
                Cliente_BE = comprobante.ClienteComprobante;
                groupBoxCOBRO.Visible = true;
                groupBoxCOBRO.BringToFront();
                this.Text = "Cobro";
                List<string> mediosPago = new List<string>
                {
                    "Efectivo",
                    "Transferencia",
                    "Débito",
                    "Tarjeta de Crédito"
                };
                comboBoxMP.DataSource = mediosPago;
                comboBoxMP.SelectedItem = comprobante.Medio;
                dateTimePicker1.Value = comprobante.Fecha;
                uC_txtSoloNumerosNUMERO.Texto = comprobante.NroComprobante.ToString();
                uC_txtSoloNumerosDNI.Texto = Cliente_BE.DNI.ToString();              
                uC_txtSoloTextoNOMBRE.Texto = Cliente_BE.Nombre;
                uC_txtSoloTextoAPELLIDO.Texto = Cliente_BE.Apellido;
                uC_DGV1.Mostrar(lista);
                uC_txtSoloDecimalIMPORTE.Texto = comprobante.ImporteTotal.ToString();
                uC_DGV1_eventoSeleccionado(null, new EventArgs());

            }

        }

      

        private void uC_DGV1_eventoSeleccionado(object sender, EventArgs e)
        {
            if (cobro)
            {
                BE_ComprobanteFactura Factura = uC_DGV1.Seleccionado() as BE_ComprobanteFactura;
                if (Factura?.NroComprobante != null)
                {
                    uC_txtSoloDecimalAPLICADO.Texto = ComprobanteCobroAlquiler_.ObtenerCobradoFactura(Factura).ToString();
                    decimal saldo = Factura.ImporteTotal - uC_txtSoloDecimalAPLICADO.ObtenerValorDecimal() - uC_txtSoloDecimalIMPORTE.ObtenerValorDecimal();
                    uC_txtSoloDecimalSaldo.Texto = saldo.ToString("0.00");
                    uC_txtSoloDecimalCONSOLIDADO.Texto = (Factura.ImporteTotal - uC_txtSoloDecimalAPLICADO.ObtenerValorDecimal()).ToString("0.00");
                }

            }
        }

      

        private void buttonFCSUB_Click(object sender, EventArgs e)
        {
            try
            {


                if (uC_txtSoloDecimalTOTAL.ObtenerValorDecimal() > 0)
                {
                    if (edicion)
                    {
                        FacturaEdicion_BE.Subtotal = uC_txtSoloDecimalsub.ObtenerValorDecimal();
                        FacturaEdicion_BE.Iva = uC_txtSoloDecimaliva.ObtenerValorDecimal();
                        FacturaEdicion_BE.Porcentaje = uC_txtSoloDecimaldesc.ObtenerValorDecimal();
                        FacturaEdicion_BE.EsDescuento = radioButtonES.Checked;
                        FacturaEdicion_BE.ImporteTotal = uC_txtSoloDecimalTOTAL.ObtenerValorDecimal();
                        if (FacturaEdicion_BE.EstadoPagado)
                            FacturaEdicion_BE.EstadoPagado = false;
                        ComprobanteFactura_.Modificacion(FacturaEdicion_BE);
                        MessageBox.Show("¡Hecho!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {

                        if (MessageBox.Show("Desea generar la factura?", "Facturación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            BE_ComprobanteFactura comprobante = new BE_ComprobanteFactura();
                            comprobante.NroComprobante = uC_txtSoloNumerosNUMERO.Obtener();
                            comprobante.ClienteComprobante = new BE_Cliente
                            {
                                DNI = Cliente_BE.DNI,
                                Nombre = Cliente_BE.Nombre,
                                Apellido = Cliente_BE.Apellido
                            };
                            comprobante.EsDescuento = radioButtonES.Checked;
                            comprobante.Fecha = dateTimePicker1.Value;
                            BE_Alquiler alquiler = uC_DGV1.Seleccionado() as BE_Alquiler;
                            if (alquiler != null)
                                alquiler.IsFacturado = true;
                            comprobante.Alquiler = alquiler;
                            comprobante.Porcentaje = uC_txtSoloDecimaldesc.ObtenerValorDecimal();
                            comprobante.Subtotal = uC_txtSoloDecimalsub.ObtenerValorDecimal();
                            comprobante.Iva = uC_txtSoloDecimaliva.ObtenerValorDecimal();
                            comprobante.ImporteTotal = uC_txtSoloDecimalTOTAL.ObtenerValorDecimal();
                            comprobante.Medio = comboBoxMP.SelectedItem.ToString();
                            ComprobanteFactura_.Alta(comprobante);
                            Alquiler_.Modificacion(alquiler, false);

                            if (comboBoxMP.SelectedIndex == 0)
                            {
                                BE_ComprobanteCobroAlquiler efectivo = new BE_ComprobanteCobroAlquiler();
                                efectivo.ClienteComprobante = Cliente_BE;
                                efectivo.ImporteTotal = uC_txtSoloDecimalTOTAL.ObtenerValorDecimal();
                                efectivo.NroComprobante = int.Parse(ComprobanteCobroAlquiler_.ObtenerUltimoNumero());
                                efectivo.Fecha = comprobante.Fecha;
                                efectivo.Medio = comprobante.Medio;
                                efectivo.N_Factura = comprobante;

                                ComprobanteCobroAlquiler_.Alta(efectivo);
                                comprobante.EstadoPagado = true;
                                ComprobanteFactura_.Modificacion(comprobante);

                                MessageBox.Show($"Cobro Nro {efectivo.NroComprobante} en Efectivo realizado!", "Cobro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }

                            MessageBox.Show($"Factura N°: {comprobante.NroComprobante} realizada");

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }

                }
                else
                    MessageBox.Show("El comprobante debe tener un saldo mayor a CERO", "Generar Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonFCImpo_Click(object sender, EventArgs e)
        {
            try
            {
                BE_ComprobanteFactura Factura = uC_DGV1.Seleccionado() as BE_ComprobanteFactura;
                if (Factura != null)
                {
                    if (uC_txtSoloDecimalSaldo.ObtenerValorDecimal() >= 0 && uC_txtSoloDecimalIMPORTE.ObtenerValorDecimal() > 0)
                    {
                        if (edicioncobro)
                        {
                            BE_ComprobanteFactura factura = CobroEdicion_BE.N_Factura;
                            if (factura.EstadoPagado && uC_txtSoloDecimalSaldo.ObtenerValorDecimal() > 0)
                            {
                                factura.EstadoPagado = false;
                                ComprobanteFactura_.Modificacion(factura);
                            }
                            else if (!factura.EstadoPagado && uC_txtSoloDecimalSaldo.ObtenerValorDecimal() == 0)
                            {
                                factura.EstadoPagado = true;
                                ComprobanteFactura_.Modificacion(factura);
                            }

                            CobroEdicion_BE.ImporteTotal = uC_txtSoloDecimalIMPORTE.ObtenerValorDecimal();
                            ComprobanteCobroAlquiler_.Modificacion(CobroEdicion_BE);


                            MessageBox.Show("¡Hecho!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            BE_ComprobanteCobroAlquiler cobro = new BE_ComprobanteCobroAlquiler();
                            cobro.NroComprobante = uC_txtSoloNumerosNUMERO.Obtener();
                            cobro.ClienteComprobante = Cliente_BE;
                            cobro.Fecha = dateTimePicker1.Value;
                            cobro.ImporteTotal = uC_txtSoloDecimalIMPORTE.ObtenerValorDecimal();
                            cobro.Medio = comboBoxMP.SelectedItem.ToString();
                            cobro.N_Factura = Factura;
                            ComprobanteCobroAlquiler_.Alta(cobro);

                            if (uC_txtSoloDecimalSaldo.ObtenerValorDecimal() == 0)
                            {
                                Factura.EstadoPagado = true;
                                ComprobanteFactura_.Modificacion(Factura);
                            }

                            if (MessageBox.Show($"¡El cobro N°: {cobro.NroComprobante} generado!", "Generado", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                this.Close();
                        }
                    }
                    else
                        MessageBox.Show("El importe no debe ser mayor al saldo");

                }
                else
                    MessageBox.Show("Seleccione una factura para gestionar el cobro", "Generar Cobro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void uC_txtSoloDecimalsub_Load(object sender, EventArgs e)
        {

        }

        private void uC_txtSoloDecimalsub_evento(object sender, EventArgs e)
        {
            try
            {
                var (iva, total) = ComprobanteFactura_.CalcularValores(uC_txtSoloDecimalsub.ObtenerValorDecimal(), uC_txtSoloDecimalAPLICADO.ObtenerValorDecimal(), radioButtonES.Checked);
                uC_txtSoloDecimaliva.Texto = iva.ToString();
                uC_txtSoloDecimalTOTAL.Texto = total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
