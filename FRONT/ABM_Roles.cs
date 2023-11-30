using BLL;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT
{
    public partial class ABM_Roles : Form
    {
        BLL_Rol Rol;
       
        public ABM_Roles()
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
                Alta_Modificar(Validar(), true);
                Vaciar();
                //traigo el rol para mostrar en dgv
                uC_DGV1.Mostrar(Rol.Traer());
                //para ocultar la segunda columna
                uC_DGV1.Diseño(2, false);
              
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
                Alta_Modificar(Validar(), false);
                Vaciar();
                //traigo el rol para mostrar en dgv
                uC_DGV1.Mostrar(Rol.Traer());
                //para ocultar la segunda columna
                uC_DGV1.Diseño(2, false);
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
                S_Componente componente = new S_Compuesto();
                componente = uC_DGV1.Seleccionado() as S_Compuesto;
                if (componente != null) Rol.Baja(componente);
                Vaciar();
                //traigo el rol para mostrar en dgv
                uC_DGV1.Mostrar(Rol.Traer());
                //para ocultar la segunda columna
                uC_DGV1.Diseño(2, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void Inicio()
        {
            Rol = new BLL_Rol();
           
            uC_DGV1.eventoSeleccionado += EventoCellClick;
            //traigo el rol para mostrar en dgv
            uC_DGV1.Mostrar(Rol.Traer());
            //para ocultar la segunda columna
            uC_DGV1.Diseño(2, false);
        }

        private void Alta_Modificar(bool bool1, bool bool2)
        {
            try
            {
                if (bool1)
                {
                    S_Componente componente = new S_Compuesto(Convert.ToInt32(uC_txtSoloNumeros1.Texto), uC_txtSoloTexto1.Texto);

                    if (bool2)
                    {
                        if (!ValidarRol(componente.Numero))
                        {
                            Rol.Alta(componente);
                            Vaciar();
                        }
                        else
                        {
                            if (MessageBox.Show($"Rol {componente?.Numero} existente, desea actualizarlo?", "Actualización Rol", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Rol.Modificacion(componente);
                                Vaciar();
                            }
                        }
                    }
                    if (!bool2)
                    {
                        if (!ValidarRol(componente.Numero))
                        {
                            if (MessageBox.Show($"Rol {componente?.Numero} no existe, desea agregarlo?", "Nuevo Rol", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Rol.Alta(componente);
                                Vaciar();
                            }
                        }
                        else
                        {
                            Rol.Modificacion(componente);
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
        private bool Validar()
        {
            bool bool1 = false;
            try
            {
                if (uC_txtSoloNumeros1.Validar() && uC_txtSoloTexto1.Validar())
                    bool1 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            return bool1;
        }
        private bool ValidarRol(int rol)
        {
            bool bool1 = false;
            try
            {
                bool1 = Rol.Traer().Exists(x => x.Numero.ToString().Trim() == rol.ToString().Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return bool1;

        }
        private void EventoCellClick(object sender, EventArgs e)
        {
            try
            {
                S_Componente componente = null;
                if (uC_DGV1.RowsMayor0())
                {
                    componente = uC_DGV1.Seleccionado() as S_Compuesto;
                    if (componente != null)
                    {
                        uC_txtSoloNumeros1.Texto = componente.Numero.ToString().Trim();
                        uC_txtSoloTexto1.Texto = componente.Nombre;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        private void Vaciar()
        {
            uC_txtSoloNumeros1.Vaciar();
            uC_txtSoloTexto1.Vaciar();
        }
    }
}
