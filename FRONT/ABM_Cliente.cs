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
    public partial class ABM_Cliente : Form
    {
        BLL_Cliente cliente;
        BLL_Alquiler alquiler;
        public ABM_Cliente()
        {
            InitializeComponent();
            cliente = new BLL_Cliente();
            alquiler = new BLL_Alquiler();
            Inicio();
        }

        //button alta
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Alta_Editar(Validar(), true);
                Vaciar();
                uC_DGV1.Mostrar(cliente.Traer());
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
                Alta_Editar(Validar(), false);
                Vaciar();
                uC_DGV1.Mostrar(cliente.Traer());
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
                BE_Cliente Cliente = new BE_Cliente();
                Cliente = uC_DGV1.Seleccionado() as BE_Cliente;
                if (Cliente != null)
                {
                    if (alquiler.ExisteClienteAlquiler(Cliente, null,null))
                        MessageBox.Show($"No se puede eliminar, el cliente {Cliente.Apellido} tiene al menos un alquiler asignado.");
                    else
                        cliente.Baja(Cliente);
                }

                Vaciar();
                uC_DGV1.Mostrar(cliente.Traer());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //button cerrar ventana
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para que en el inicio cargue lista, los objetos y el dgv
        private void Inicio()
        {

            List<BE_Cliente> lista = cliente.Traer();
            uC_DGV1.Mostrar(lista);
           
        }

        //valido REGEX
        private bool Validar()
        {
            bool clienteValido = false;
            try
            {
                if (txtSoloNumerosDni.ValidarDni() && txtSoloTextoNombre.Validar() && txtSoloTextoApellido.Validar()  && txtSoloTextoPais.Validar() && txtSoloTextoCiudad.Validar() && txtSoloTextoTelefono.Validar())
                    clienteValido = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return clienteValido;

        }
        //metodo para vacias los txt
        private void Vaciar()
        {
            txtSoloNumerosDni.Vaciar();
            txtSoloTextoNombre.Vaciar();
            txtSoloTextoApellido.Vaciar();
            txtSoloTextoPais.Vaciar();
            txtSoloTextoCiudad.Vaciar();
            txtSoloTextoTelefono.Vaciar();
        }

        //metodo para dar de alta y editar
        private void Alta_Editar(bool bool1, bool bool2)
        {
            try
            {
                if (bool1)
                {
                    BE_Cliente Cliente = new BE_Cliente();
                    Cliente.DNI = txtSoloNumerosDni.Obtener();
                    Cliente.Nro_Cliente = txtSoloNumerosDni.Obtener();
                    Cliente.Nombre = txtSoloTextoNombre.Texto;
                    Cliente.Apellido = txtSoloTextoApellido.Texto;
                    Cliente.Pais = txtSoloTextoPais.Texto;
                    Cliente.Localidad = txtSoloTextoCiudad.Texto;
                    Cliente.Telefono = txtSoloTextoTelefono.Obtener();
                    if (bool2)
                    {
                        //si no existe el cliente, lo doy de alta
                        if (!ValidarCliente(Cliente.DNI))
                        {
                            cliente.Alta(Cliente);
                            Vaciar();
                        }
                        else
                        {
                            //sino, lo modifico
                            if (MessageBox.Show($"Ya existe el cliente {Cliente?.DNI} ¿Quiere actualizarlo?", "Actualización Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                cliente.Modificacion(Cliente);
                                Vaciar();
                            }
                        }
                    }
                    if (!bool2)
                    {
                        //en el caso de que se quiera modificar y no exista
                        if (!ValidarCliente(Cliente.DNI))
                        {
                            if (MessageBox.Show($"No existe el cliente {Cliente?.DNI} ¿Desea darlo de alta?", "Nuevo Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                cliente.Alta(Cliente);
                                Vaciar();
                            }
                        }
                        else
                        {
                            cliente.Modificacion(Cliente);
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

        //busco si existe el numero de cliente
        private bool ValidarCliente(int nrocliente)
        {
            bool bool1 = false;
            try
            {
                bool1 = cliente.Traer().Exists(x => x.DNI.ToString().Trim() == nrocliente.ToString().Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return bool1;
        }
        //evento para crear objeto cliente
        private void uC_DGV1_eventoSeleccionado(object sender, EventArgs e)
        {
            try
            {
                BE_Cliente Cliente = new BE_Cliente();
                if (uC_DGV1.RowsMayor0())
                {

                    Cliente = uC_DGV1.Seleccionado() as BE_Cliente;
                    if (Cliente != null)
                    {
                        txtSoloNumerosDni.Texto = Cliente.DNI.ToString().Trim();
                        txtSoloTextoNombre.Texto= Cliente.Nombre;
                        txtSoloTextoApellido.Texto=Cliente.Apellido;
                        txtSoloTextoPais.Texto=Cliente.Pais;
                        txtSoloTextoCiudad.Texto = Cliente.Localidad;
                        txtSoloTextoTelefono.Texto=Cliente.Telefono.ToString().Trim();
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
