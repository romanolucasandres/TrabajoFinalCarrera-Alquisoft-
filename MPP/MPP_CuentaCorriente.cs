using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPP_CuentaCorriente
    {
        public List<BE_CuentaCorriente> ObtenerCuentaCorriente(List<BE_ComprobanteCobroAlquiler> cobros, List<BE_ComprobanteFactura> facturas)
        {
            List<BE_CuentaCorriente> CC = null;
            try
            {
                List<BE_Comprobante> listaComprobantes = new List<BE_Comprobante>();
                listaComprobantes.AddRange(cobros);
                listaComprobantes.AddRange(facturas);
                listaComprobantes = listaComprobantes.OrderBy(x => x?.Fecha).ToList();

                if (listaComprobantes?.Count > 0)
                {
                    CC = new List<BE_CuentaCorriente>();
                    foreach (BE_Comprobante item in listaComprobantes)
                    {
                        BE_CuentaCorriente cc = new BE_CuentaCorriente();
                        cc.Fecha = item.Fecha;
                        cc.NroComprobante = item.NroComprobante;

                        if (item is BE_ComprobanteFactura)
                        {
                            cc.TipoComprobante = BE_CuentaCorriente.factura;
                            cc.MontoFactura = item.ImporteTotal;
                        }
                        else if (item is BE_ComprobanteCobroAlquiler)
                        {
                            cc.TipoComprobante = BE_CuentaCorriente.CobroDeAlquiler;
                            cc.MontoCobro = (item.ImporteTotal * -1);
                        }

                        CC.Add(cc);
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return CC;
        }

        public decimal ObtenerSaldo(List<BE_CuentaCorriente> cuentacorriente)
        {
            try
            {
                decimal saldo = 0;
                if (cuentacorriente?.Count > 0)
                {
                    cuentacorriente.ForEach(cc => saldo += cc.MontoFactura + cc.MontoCobro);
                }
                return Math.Round(saldo, 2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
