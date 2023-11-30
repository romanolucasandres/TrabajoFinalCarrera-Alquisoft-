using BLL;
using BE;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using FRONT.Controles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FRONT
{
    public partial class ABM_Usuarios : Form
    {

        BLL_Usuario Usuario;
        BLL_Empleado Empleado;
        BLL_Login Login;
        BLL_Rol Rol;
        BLL_Usuario_Rol Usuario_Rol;

        public ABM_Usuarios()
        {
            InitializeComponent();
            Inicio();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Alta_Modificar(ValidarTodo(), true);
                Vaciar();
                CargaCombosListBox();
                
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
                Alta_Modificar(ValidarTodo(), false);
                Vaciar();
                CargaCombosListBox();
                
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
                BE_Usuario usuario = new BE_Usuario();
                usuario = comboBoxusuarios.SelectedItem as BE_Usuario;
                if (usuario != null && MessageBox.Show($"¿Desea eliminar al usuario {usuario.Empleado.Apellido}, {usuario.Empleado.Nombre}?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Usuario.Baja(usuario);
                    Vaciar();
                    CargaCombosListBox() ;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Inicio()
        {
            Usuario = new BLL_Usuario();
            Empleado = new BLL_Empleado();
            Login = new BLL_Login();
            Rol = new BLL_Rol();
            Usuario_Rol = new BLL_Usuario_Rol();
            comboBoxusuarios.DataSourceChanged += EventoMouseClick;
            CargaCombosListBox();
           

        }

        private void CargaCombosListBox()
        {
            try
            {
                comboBoxempleado.DataSource = Empleado.Traer();
                comboBoxusuarios.DataSource = Usuario.Traer();
                listBoxRoles.DataSource = Rol.Traer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private bool ValidarTodo()
        {
            bool bool1 = false;
            try
            {
                if (comboBoxempleado.SelectedItem != null &&  !string.IsNullOrEmpty(textBox1.Text) &&  listBoxRoles.SelectedItems.Count > 0)
                    bool1 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return bool1;
        }

        private bool ValidarUsuario(int usuario)
        {
            bool bool1 = false;
            try
            {
                bool1 = Usuario.Traer().Exists(x => x.Empleado.N_Legajo.ToString().Trim() == usuario.ToString().Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return bool1;
        }
        private void Seleccionado(bool bool1)
        {
            try
            {
                BE_Usuario usuario = new BE_Usuario();

                usuario = comboBoxusuarios.SelectedItem as BE_Usuario;
                    if (usuario != null)
                    {
                       
                        foreach (BE_Empleado item in comboBoxempleado.Items)
                        {
                            if (item != null)
                            {
                                if (item.N_Legajo == usuario.Empleado.N_Legajo)
                                comboBoxempleado.SelectedItem = item;
                            }

                        }
                        textBox1.Text = usuario.Contraseña.ToString().Trim();
                        uC_DGV1.Mostrar(Usuario_Rol.ObtenerRoles(usuario.Empleado.N_Legajo));

                    }
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
                    List<S_Compuesto> seleccionados = new List<S_Compuesto>();
                    BE_Usuario usuario = new BE_Usuario();
                    usuario.Empleado = comboBoxempleado.SelectedItem as BE_Empleado;
                    usuario.Contraseña = textBox1.Text;
                    foreach (var item in listBoxRoles.SelectedItems)
                    {
                        seleccionados.Add((S_Compuesto)item);
                    }

                    if (bool2)
                    {
                        if (!ValidarUsuario(usuario.Empleado.N_Legajo))
                        {
                            Usuario.Alta(usuario);
                            Usuario_Rol.Alta(seleccionados, usuario.Empleado.N_Legajo);
                            Vaciar();
                        }
                        else
                        {

                            if (MessageBox.Show($"Número de Usuario {usuario?.Empleado?.N_Legajo} existente, desea actualizarlo?", "Actualización Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                string contraseña = Interaction.InputBox("Ingrese contraseña anterior para continuar: ", "Contraseña");
                                if (Login.  Validar(usuario, contraseña))
                                {
                                    Usuario.Modificacion(usuario);
                                    Usuario_Rol.Modificacion(seleccionados, usuario.Empleado.N_Legajo);
                                    Vaciar();
                                }
                            }
                        }
                    }
                    if (!bool2)
                    {

                        if (!ValidarUsuario(usuario.Empleado.N_Legajo))
                        {
                            if (MessageBox.Show($"Usuario {usuario.Empleado.N_Legajo} no existe, desea agregarlo?", "Nuevo Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Usuario.Alta(usuario);
                                Usuario_Rol.Alta(seleccionados, usuario.Empleado.N_Legajo);
                                Vaciar();
                            }
                        }
                        else
                        {
                            Usuario.Modificacion(usuario);
                            Usuario_Rol.Modificacion(seleccionados, usuario.Empleado.N_Legajo);
                            Vaciar();
                        }

                    }
                }

                else
                {
                    MessageBox.Show("Datos erróneos, por favor ingrese nuevamente los datos pedidos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void Vaciar()
        {
            textBox1.Text = "";
        }
        private void EventoMouseClick(object sender, EventArgs e)
        {
            try
            {
                Seleccionado(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    if (Login.Validar(Interaction.InputBox("Ingrese contraseña admin para autorizar: ")))
                        textBox1.PasswordChar = Convert.ToChar(0);
                    else
                        checkBox1.Checked = false;
                }
                else
                    textBox1.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonir_Click(object sender, EventArgs e)
        {
            BE_Usuario usuario = new BE_Usuario();
            usuario = comboBoxusuarios.SelectedItem as BE_Usuario;

            uC_DGV1.Mostrar(Usuario_Rol.ObtenerRoles(usuario.Empleado.N_Legajo));

        }
    }
}
