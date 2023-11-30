using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Alquiler
    {
        #region Propiedades
        private int codigo;
        private decimal total;
        private BE_Cliente cliente;
        private BE_Unidades stock;
        private BE_EmpleadoVendedor vendedor;
        private DateTime fechaIngreso;
        private DateTime fechaEgreso;
        //para saber si ya fue facturado
        private bool isfacturado = false;

        public int Codigo { get => codigo; set => codigo = value; }
        public decimal Total { get => total; set => total = value; }
        public BE_Cliente Cliente { get => cliente; set => cliente = value; }
        public BE_Unidades Unidad { get => stock; set => stock = value; }
        public BE_EmpleadoVendedor Vendedor { get => vendedor; set => vendedor = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaEgreso { get => fechaEgreso; set => fechaEgreso = value; }

        [Browsable(false)]
        public bool IsFacturado { get => isfacturado; set => isfacturado = value; }
        #endregion

        #region Constructor
        public BE_Alquiler()
        {
            Cliente = new BE_Cliente();
            Unidad = new BE_Unidades();
            Vendedor = new BE_EmpleadoVendedor();
        }
        #endregion

        //creo objeto


        public override string ToString()
        {
            return String.Format($"Alquiler {Codigo} Ingreso {FechaIngreso.ToString("yyyy-MM-dd")} - Egreso {FechaEgreso.ToString("yyyy-MM-dd")}");
        }
    }
}
