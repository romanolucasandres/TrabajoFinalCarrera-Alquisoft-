using BE;
using BLL;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FRONT
{
    public partial class CHART : Form
    {
        BLL_ComprobanteFactura Factura_;
        BLL_Alquiler Alquiler_;
        BLL_Unidad Unidad_;
        public CHART()
        {
            InitializeComponent();
            Factura_ = new BLL_ComprobanteFactura();
            Alquiler_ = new BLL_Alquiler();
            Unidad_ = new BLL_Unidad();
            this.MejoresClientes(Factura_.Traer());
            this.UnidadesMasAlquiladas(Alquiler_.Traer());
            this.UnidadMasCara(Unidad_.Traer());
            this.VendedorQueMasVendio(Alquiler_.Traer());

        }

        public void VendedorQueMasVendio(List<BE_Alquiler> lista)
        {
            try
            {
                if (lista?.Count > 0)
                {
                    var cantidadkayaksporturno = lista.GroupBy(f => f.Vendedor.ToString()).Select(g =>
                    new { Vendedor = g.Key, Cantidad = g.Count() })
                        .OrderByDescending(g => g.Cantidad).ToList();

                    chartVendedorVentas.Series[0].ChartType = SeriesChartType.Pie;
                    chartVendedorVentas.Series[0].IsValueShownAsLabel = true;
                    chartVendedorVentas.Series[0].Points.Clear();
                    foreach (var item in cantidadkayaksporturno)
                    {

                        chartVendedorVentas.Series[0].Points.AddXY(item.Vendedor, item.Cantidad);
                    }
                }
                else
                    chartVendedorVentas.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void UnidadMasCara(List<BE_Unidades> lista)
        {
            try
            {


                if (lista?.Count > 0)
                {
                  
                    List<BE_Unidades> MasCaros = lista.OrderByDescending(x => x.PrecioDia).ToList();

                    chartUnidadesCaras.Series[0].ChartType = SeriesChartType.Pie;
                    chartUnidadesCaras.Series[0].IsValueShownAsLabel = true;
                    chartUnidadesCaras.Series[0].Points.Clear();


                    chartUnidadesCaras.Series[0].Name = "Unidad mas cara";
                    foreach (var item in MasCaros)
                    {
                        chartUnidadesCaras.Series[0].Points.AddXY(item.Codigo, item.PrecioDia);
                    }
                }
                else
                    chartUnidadesCaras.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void UnidadesMasAlquiladas(List<BE_Alquiler> lista)
        {
            try
            {
                if (lista?.Count > 0)
                {
                    var unidades = lista.GroupBy(f => f.Unidad.ToString()).Select(g => new { Kayak = g.Key, Cantidad = g.Count() })
                        .OrderByDescending(g => g.Cantidad).ToList();

                    chartUnidadMasUtilizada.Series[0].LegendText = "Unidades mas utilizadas";
                    foreach (var item in unidades)
                    {
                        chartUnidadMasUtilizada.Series[0].Points.AddXY(item.Kayak, item.Cantidad);
                    }

                    chartUnidadMasUtilizada.Series[0].ChartType = SeriesChartType.Column;
                }
                else
                    chartUnidadMasUtilizada.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void MejoresClientes(List<BE_ComprobanteFactura> lista)
        {
            try
            {

                if (lista?.Count > 0)
                {
                    var cantidadPorCliente = lista.GroupBy(f => f.ClienteComprobante.ToString()).Select(c => new { Cliente = c.Key, Cantidad = c.Count() })
                        .OrderByDescending(c => c.Cantidad).ToList();

                    chartMejoresClientes.Series[0].LegendText = "Clientes más facturados";
                    foreach (var item in cantidadPorCliente)
                    {

                        chartMejoresClientes.Series[0].Points.AddXY(item.Cliente, item.Cantidad);
                    }

                    chartMejoresClientes.Series[0].ChartType = SeriesChartType.Column;
                }
                else
                    chartMejoresClientes.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
