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
    public partial class ABM_Empleado : Form
    {
        BLL_Empleado Empleado;

        public ABM_Empleado()
        {
            InitializeComponent();
            Inicio();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //buttom alta
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Alta_Modificar(Validar(), true);
                Vaciar();
                uC_DGV1.Mostrar(Empleado.Traer());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //button editar
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Alta_Modificar(Validar(), false);
                Vaciar();
                uC_DGV1.Mostrar(Empleado.Traer());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //button eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Empleado empleado = null;
                empleado = uC_DGV1.Seleccionado() as BE_Empleado;
                if (empleado != null) Empleado.Baja(empleado);
                Vaciar();
                uC_DGV1.Mostrar(Empleado.Traer());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //vaciar txt
        private void Vaciar()
        {
            txtSoloNumerosDNI.Vaciar();
            txtSoloTextoNombre.Vaciar();
            txtSoloTextoApellido.Vaciar();
        }
        // Metodo de alta y modificar
        private void Alta_Modificar(bool bool1, bool bool2)
        {
            try
            {
                if (bool1)
                {
                    BE_Empleado empleado = null;
                    if (cmbPuestoEmpleado.SeleccionarSectorEmpleado == cmbPuestoEmpleado.Administrativo)
                        empleado = new BE_EmpleadoAdministrativo();
                    else if (cmbPuestoEmpleado.SeleccionarSectorEmpleado == cmbPuestoEmpleado.Gerente)
                        empleado = new BE_EmpleadoGerente();
                    else if (cmbPuestoEmpleado.SeleccionarSectorEmpleado == cmbPuestoEmpleado.Vendedor)
                        empleado = new BE_EmpleadoVendedor();
                    else if (cmbPuestoEmpleado.SeleccionarSectorEmpleado == cmbPuestoEmpleado.Generico)
                        empleado = new BE_EmpleadoGenerico();
                    empleado.N_Legajo = Convert.ToInt32(txtSoloNumerosDNI.Texto.Trim());
                    empleado.Nombre = txtSoloTextoNombre.Texto;
                    empleado.Apellido = txtSoloTextoApellido.Texto;

                    if (bool2)
                    {
                        if (!ValidarEmpleado(empleado.N_Legajo))
                        {
                            Empleado.Alta(empleado);
                            Vaciar();
                        }
                        else
                        {

                            if (MessageBox.Show($"Ya existe el/la empleado/a {empleado?.N_Legajo} ¿Quiere actualizarlo?", "Actualización Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Empleado.Modificacion(empleado);
                                Vaciar();
                            }
                        }
                    }
                    if (!bool2)
                    {
                        if (!ValidarEmpleado(empleado.N_Legajo))
                        {
                            if (MessageBox.Show($"No existe el/la empleado/a {empleado?.N_Legajo} ¿Quiere actualizarlo?\"", "Nuevo Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Empleado.Alta(empleado);
                                Vaciar();
                            }
                        }
                        else
                        {
                            Empleado.Modificacion(empleado);
                            Vaciar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Los datos ingresados tienen errores, ingrese nuevamente los datos requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        //metodo para el inicio del abm
        private void Inicio()
        {
            Empleado = new BLL_Empleado();
            uC_DGV1.Mostrar(Empleado.Traer());
            uC_DGV1.eventoSeleccionado += EventoCellClick;
        }
        //evento para crear objeto y el "tipo" de empleado
        private void EventoCellClick(object sender, EventArgs e)
        {
            try
            {
                BE_Empleado empleado = null;
                if (uC_DGV1.RowsMayor0())
                {
                    empleado = uC_DGV1.Seleccionado() as BE_Empleado;
                    if (empleado != null)
                    {
                        txtSoloNumerosDNI.Texto = empleado.N_Legajo.ToString().Trim();
                        txtSoloTextoNombre.Texto = empleado.Nombre;
                        txtSoloTextoApellido.Texto = empleado.Apellido;
                        if (empleado is BE_EmpleadoAdministrativo)
                            cmbPuestoEmpleado.SeleccionarSectorEmpleado = cmbPuestoEmpleado.Administrativo;
                        else if (empleado is BE_EmpleadoGerente)
                            cmbPuestoEmpleado.SeleccionarSectorEmpleado = cmbPuestoEmpleado.Gerente;
                        else if (empleado is BE_EmpleadoVendedor)
                            cmbPuestoEmpleado.SeleccionarSectorEmpleado = cmbPuestoEmpleado.Vendedor;
                        else if (empleado is BE_EmpleadoGenerico)
                            cmbPuestoEmpleado.SeleccionarSectorEmpleado = cmbPuestoEmpleado.Generico;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        //metodo para validar empleado
        private bool ValidarEmpleado(int n_empleado)
        {
            bool bool1 = false;
            try
            {
                bool1 = Empleado.Traer().Exists(x => x.N_Legajo.ToString().Trim() == n_empleado.ToString().Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return bool1;
        }
        //validar REGEX
        private bool Validar()
        {
            bool bool1 = false;
            try
            {
                if (txtSoloNumerosDNI.Validar() && txtSoloTextoNombre.Validar() && txtSoloTextoApellido.Validar())
                    bool1 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return bool1;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
