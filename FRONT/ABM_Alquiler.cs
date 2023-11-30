using BE;
using BLL;
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

namespace FRONT
{
    public partial class ABM_Alquiler : Form
    {
        BLL_Alquiler Alquiler;
        BLL_Cliente Cliente;
        BLL_Empleado Empleado;
        BLL_Unidad Unidad;
        public ABM_Alquiler()
        {
            InitializeComponent();
            Inicio();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Alta_Modificar(Validar(), true);
                Vaciar();
                Mostrar();
                this.ObtenerUltimoCodigoAlquiler();
                this.CargarComboUnidadesDisponible  ();
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
                Alta_Modificar(Validar(), true);
                Vaciar();
                Mostrar();
                this.ObtenerUltimoCodigoAlquiler();
                this.CargarComboUnidadesDisponible();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Alquiler alquiler = new BE_Alquiler();
                alquiler = uC_DGV1.Seleccionado() as BE_Alquiler;
                if (Alquiler != null)
                {
                    Alquiler.Baja(alquiler);
                }
                Vaciar();
                Mostrar();
                this.ObtenerUltimoCodigoAlquiler();
                this.CargarComboUnidadesDisponible();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Inicio()
        {
            Alquiler = new BLL_Alquiler();
            Cliente = new BLL_Cliente();
            Empleado = new BLL_Empleado();
            Unidad = new BLL_Unidad();
            uC_DGV1.Mostrar(Alquiler.Traer());
            uC_DGV1.eventoSeleccionado += EventoCellClick;
            CargarCombos();
            ObtenerUltimoCodigoAlquiler();
        }
        void ObtenerUltimoCodigoAlquiler()
        {
            this.txtSoloNumerosCodigo.Texto = Alquiler.ObtenerUltimoCodigoAlquiler();
        }
        private void EventoCellClick(object sender, EventArgs e)
        {
            try
            {
                BE_Alquiler alquiler = new BE_Alquiler();
                if (uC_DGV1.RowsMayor0())
                {
                    alquiler = uC_DGV1.Seleccionado() as BE_Alquiler;
                    if (alquiler != null)
                    {
                        txtSoloNumerosCodigo.Texto = alquiler.Codigo.ToString().Trim();
                        if (comboBoxVendedor.SelectedIndex > -1 && comboBoxVendedor.SelectedItem != null)
                        {
                            foreach (var item in comboBoxVendedor.Items)
                            {
                                if (item != null)
                                {
                                    BE_EmpleadoVendedor vendedor = item as BE_EmpleadoVendedor;
                                    if (vendedor != null)
                                    {
                                        if (vendedor.N_Legajo == alquiler.Vendedor.N_Legajo)
                                            comboBoxVendedor.SelectedItem = vendedor;
                                    }
                                }
                            }
                        }
                        comboBoxVendedor.SelectedItem = alquiler.Vendedor;
                        if (comboBoxCliente.SelectedIndex > -1 && comboBoxCliente.SelectedItem != null)
                        {
                            foreach (var item in comboBoxCliente.Items)
                            {
                                if (item != null)
                                {
                                    BE_Cliente cliente = item as BE_Cliente;
                                    if (cliente != null)
                                    {
                                        
                                            comboBoxCliente.SelectedItem = cliente;
                                    }
                                }
                            }
                        }
                        comboBoxCliente.SelectedItem = alquiler.Cliente;
                        if (comboBoxUnidad.SelectedIndex > -1 && comboBoxUnidad.SelectedItem != null)
                        {
                            foreach (var item in comboBoxUnidad.Items)
                            {
                                if (item != null)
                                {
                                    BE_Unidades unidad = item as BE_Unidades;
                                    if (unidad != null)
                                    {
                                        if (unidad.Codigo == alquiler.Unidad.Codigo)
                                            comboBoxCliente.SelectedItem = unidad;
                                    }
                                }
                            }
                        }
                        comboBoxUnidad.SelectedItem = alquiler.Unidad;
                        DateTime dateIngreso = alquiler.FechaIngreso;
                        DateTime dateEgreso = alquiler.FechaEgreso;
                        dateTimePickerIngreso.Value = dateIngreso.Date;
                        dateTimePickerEgreso.Value = dateEgreso.Date;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        private bool Validar()
        {
            bool valido = false;
            try
            {
                valido = txtSoloNumerosCodigo.Validar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return valido;

        }
        private void CargarCombos()
        {
            try
            {
                CargarComboUnidadesDisponible();
                comboBoxCliente.DataSource = Cliente.Traer();
                comboBoxVendedor.DataSource = Empleado.Traer().FindAll(x => x is BE_EmpleadoVendedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void CargarComboUnidadesDisponible()
        {
            try
            {
                List<BE_Unidades> lista = Unidad.ObtenerUnidadesDisponibles(dateTimePickerIngreso.Value, dateTimePickerEgreso.Value);
                comboBoxUnidad.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void Alta_Modificar(bool bool1, bool bool2)
        {
            try
            {
                if (bool1)
                {
                    if (comboBoxCliente.SelectedItem != null)
                    {
                        if (comboBoxUnidad.SelectedItem != null)
                        {
                            if (comboBoxVendedor.SelectedItem != null)
                            {
                                BE_Alquiler alquiler = new BE_Alquiler();
                                alquiler.Codigo = Convert.ToInt32(txtSoloNumerosCodigo.Texto.Trim());
                                alquiler.Cliente = comboBoxCliente.SelectedItem as BE_Cliente;
                                alquiler.Unidad = comboBoxUnidad.SelectedItem as BE_Unidades;
                                alquiler.Vendedor = comboBoxVendedor.SelectedItem as BE_EmpleadoVendedor;
                                DateTime date = dateTimePickerIngreso.Value;
                                date = date.Date;
                                alquiler.FechaIngreso = date;
                                DateTime date2 = dateTimePickerEgreso.Value;
                                date2 = date2.Date;
                                alquiler.FechaEgreso = date2;
                                TimeSpan diasSpan = date2 - date;
                                int dias = diasSpan.Days;
                                var total = alquiler.Unidad.PrecioDia * dias;
                                alquiler.Total= Convert.ToDecimal(total);
                                if (bool2)
                                {
                                    if (!Alquiler.ExisteObjeto(alquiler))
                                    {
                                        if (Alquiler.ExisteClienteAlquiler(alquiler.Cliente, alquiler.FechaIngreso, alquiler.FechaEgreso))
                                        {
                                            MessageBox.Show($"El cliente {alquiler.Cliente.DNI} ya tiene reservado una unidad para alguna o ambas fechas\rRevise y vuelva a cargar el alquiler", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else
                                        {
                                            Alquiler.Alta(alquiler);
                                            Vaciar();
                                        }
                                    }
                                    else
                                    {

                                        if (MessageBox.Show($"Ya existe el codigo {alquiler?.Codigo}. ¿Quiere actualizarlo?", "Actualización Turno", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                        {
                                            alquiler.IsFacturado = Alquiler.IsFacturado(alquiler);
                                            Alquiler.Modificacion(alquiler, true);
                                            Vaciar();
                                        }
                                    }
                                }
                                if (!bool2)
                                {
                                    if (!Alquiler.ExisteObjeto(alquiler))
                                    {
                                        if (MessageBox.Show($"Número de Turno {alquiler?.Codigo} no existe, desea agregarlo?", "Nuevo Turno", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                        {
                                            Alquiler.Alta(alquiler);
                                            Vaciar();
                                        }
                                    }
                                    else
                                    {
                                        alquiler.IsFacturado = Alquiler.IsFacturado(alquiler);
                                        Alquiler.Modificacion(alquiler, true);
                                        Vaciar();
                                    }
                                }
                            }
                            else
                                MessageBox.Show("Tiene que ingresar un Vendedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("No hay unidades disponible para alquilar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("No hay clientes seleccionado, verifíquelo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                    MessageBox.Show("Los datos ingresados tienen errores, ingrese nuevamente los datos requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        private void Vaciar()
        {
            txtSoloNumerosCodigo.Vaciar();
        }
        void Mostrar()
        {
            try
            {
                if (radioButtonTodos.Checked)
                    uC_DGV1.Mostrar(Alquiler.Traer(dateTimePickerIngreso.Value, dateTimePickerEgreso.Value, null));
                else if (radioButtonfacturados.Checked)
                    uC_DGV1.Mostrar(Alquiler.Traer(dateTimePickerIngreso.Value, dateTimePickerEgreso.Value, true));
                else if (radioButtonnofacturados.Checked)
                    uC_DGV1.Mostrar(Alquiler.Traer(dateTimePickerIngreso.Value, dateTimePickerEgreso.Value, false));
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
