using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using BLL;
using Microsoft.VisualBasic.Logging;
using System.Security.Policy;
using BE;

namespace FRONT
{
    public partial class UI_Menu : Form
    {
        #region forms
        ABM_Alquiler alquiler;
        ABM_Cliente cliente;
        ABM_Empleado empleado;
        ABM_Unidad unidades;
        ABM_Roles roles;
        ABM_Usuarios usuarios;
        Backup_Restore backup;
        BITACORA_Registros bitacora;
        BUSCAR_Cliente buscarc;
        BUSCAR_Cobros buscarcobros;
        BUSCAR_Facturaciones facturaciones;
        BUSCAR_Cliente control;
        PERMISOS permisos;
        CHART chart;
        ACTUALIZAR_Estados actualizar;
        REPORTEAlquileres reportEAlquileres;
        #endregion

        #region BLL
        BLL_Menu Menu_;
        BLL_Rol Rol_;
        BLL_Permiso Permiso_;
        BLL_Login Login_;
        BLL_Usuario_Rol Usuario_Rol_;
        #endregion

        public UI_Menu()
        {
            InitializeComponent();
            RecorrerMenu();
            usuariomenu.Text = "Lucas Romano - 01";
        }

        public UI_Menu(BE_Usuario usuario)
        {
            InitializeComponent();
            
            Rol_ = new BLL_Rol();
            Permiso_ = new BLL_Permiso();
            Login_ = new BLL_Login();
            Usuario_Rol_ = new BLL_Usuario_Rol();
            S_UsuarioLogueado.Usuario = $"{usuario?.Empleado?.N_Legajo}-{usuario.Empleado.Apellido}";
            RecorrerMenu();
            VisibilidadMenu_RolPermisos(usuario);
            this.toolTip1.SetToolTip(this.usuariomenu, $" Usuario:{S_UsuarioLogueado.Usuario}");
            usuariomenu.Text = $"{S_UsuarioLogueado.Usuario}";
            S_Registros.RegistrarSuceso("Inició sesión");
        }


      

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void GestionUnidades_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem2_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.ForeColor != Color.LightSalmon) {
                e.ClickedItem.BackColor = Color.LightSalmon; 
            }
        }

        

        private void CtaCte_Click(object sender, EventArgs e)
        {
            try
            {
                if (control != null)
                    control.BringToFront();
                else
                {
                    control = new BUSCAR_Cliente(true);
                    control.FormClosed += (o, args) => control = null;
                    control.MdiParent = this;
                    control.WindowState = FormWindowState.Normal;
                    control.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

     
      

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (roles != null)
                    roles.BringToFront();
                else
                {
                    roles = new ABM_Roles();
                    roles.FormClosed += (o, args) => roles = null;
                    roles.MdiParent = this;
                    roles.WindowState = FormWindowState.Normal;
                    roles.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void pERMISOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (permisos != null)
                    permisos.BringToFront();
                else
                {
                    permisos = new PERMISOS();
                    permisos.FormClosed += (o, args) => permisos = null;
                    permisos.MdiParent = this;
                    permisos.WindowState = FormWindowState.Normal;
                    permisos.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturaciones != null)
                    facturaciones.BringToFront();
                else
                {
                    facturaciones = new BUSCAR_Facturaciones(true);
                    facturaciones.FormClosed += (o, args) => facturaciones = null;
                    facturaciones.MdiParent = this;
                    facturaciones.WindowState = FormWindowState.Normal;
                    facturaciones.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void bUSCARCOBROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (buscarcobros != null)
                    buscarcobros.BringToFront();
                else
                {
                    buscarcobros = new BUSCAR_Cobros();
                    buscarcobros.FormClosed += (o, args) => buscarcobros = null;
                    buscarcobros.MdiParent = this;
                    buscarcobros.WindowState = FormWindowState.Normal;
                    buscarcobros.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

       
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                if (bitacora != null)
                    bitacora.BringToFront();
                else
                {
                    bitacora = new BITACORA_Registros();
                    bitacora.FormClosed += (o, args) => bitacora = null;
                    bitacora.MdiParent = this;
                    bitacora.WindowState = FormWindowState.Normal;
                    bitacora.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro que desea salir de Alquisoft?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                S_Registros.RegistrarSuceso("salida del sistema");
                Application.Exit();
            }
        }
        // tengo lista con permisos - // agarro la lista + for para matchearla 
        #region METODOS
        private void VisibilidadMenu_RolPermisos(BE_Usuario usuario_)
        {
            try
            {
                if (Login_.EsAdmin(usuario_))
                {
                    CargarTodoADMIN(usuario_);
                }
                else
                {
                    Rol_ = new BLL_Rol();
                    Permiso_ = new BLL_Permiso();
                    foreach (S_Componente rolasignado in Usuario_Rol_.ObtenerRoles(usuario_.Empleado.N_Legajo))
                    {

                        S_Componente Rol = Rol_.Traer(rolasignado.Numero);
                        if (Rol != null)
                        {
                            Rol = Permiso_.Traer(Rol);
                            if (Rol.ObtenerLista().Count > 0)
                            {
                                foreach (S_Hoja item in Rol.ObtenerLista())
                                {
                                    foreach (ToolStripMenuItem menupadre in menuStrip1.Items)
                                    {
                                        if (item != null && menupadre != null)
                                        {
                                            if (item.Visible && item?.Nombre == menupadre.ToString().Trim())
                                                menupadre.Visible = item.Visible;

                                            foreach (ToolStripMenuItem hijos in menupadre.DropDownItems)
                                            {
                                                if (item != null && hijos != null)
                                                {
                                                    if (item.Visible && item?.Nombre == hijos.ToString().Trim())
                                                        hijos.Visible = item.Visible;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



        }

        private void CargarTodoADMIN(BE_Usuario usuario_)
        {
            try
            {
                if (Login_.EsAdmin(usuario_))
                {
                    foreach (ToolStripMenuItem menupadre in menuStrip1.Items)
                    {
                        menupadre.Visible = true;
                        foreach (ToolStripMenuItem hijos in menupadre.DropDownItems)
                        {
                            hijos.Visible = true;
                        }
                    }
                }
                else
                {
                    foreach (ToolStripMenuItem menupadre in menuStrip1.Items)
                    {
                        menupadre.Visible = false;
                        foreach (ToolStripMenuItem hijos in menupadre.DropDownItems)
                        {
                            hijos.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }

        private void RecorrerMenu()
        {
            try
            {
                Menu_ = new BLL_Menu();
                S_Componente componente = new S_Compuesto("Menu");
                int indicecompuestos = 3000;
                int indicehojas = 10000;
                foreach (var item in menuStrip1.Items)
                {
                    if (item != null)
                    {

                        S_Componente Rama = new S_Compuesto(indicecompuestos++, item.ToString().Trim());
                        if (((ToolStripMenuItem)item)?.DropDownItems?.Count > 0)
                        {
                            foreach (var item2 in ((ToolStripMenuItem)item).DropDownItems)
                            {
                                S_Componente hoja = new S_Hoja(indicehojas++, item2.ToString());
                                Rama.AgregarNodo(hoja);
                            }
                        }

                        componente.AgregarNodo(Rama);
                    }

                }
                Menu_.Baja(componente);
                Menu_.Alta(componente);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void CambiarDeUsuario()
        {
            if (MessageBox.Show("¿Quiere cambiar de usuario?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                S_Registros.RegistrarSuceso("cierre sesión");
                this.Close();
                LOGIN frm_Login = new LOGIN();
                frm_Login.Show();
            }

        }

        #endregion

        private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (backup != null)
                    backup.BringToFront();
                else
                {
                    backup = new Backup_Restore(false);
                    backup.FormClosed += (o, args) => backup = null;
                    backup.MdiParent = this;
                    backup.WindowState = FormWindowState.Normal;
                    backup.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void rESTOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (backup != null)
                    backup.BringToFront();
                else
                {
                    backup = new Backup_Restore(true);
                    backup.FormClosed += (o, args) => backup = null;
                    backup.MdiParent = this;
                    backup.WindowState = FormWindowState.Normal;
                    backup.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cambiar de usuario?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                S_Registros.RegistrarSuceso("cierre sesión");
                this.Close();
                LOGIN frm = new LOGIN();
                
                frm.Show();
            }
        }

        private void gESTIONEMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (empleado != null)
                    empleado.BringToFront();
                else
                {
                    empleado = new ABM_Empleado();
                    empleado.FormClosed += (o, args) => empleado = null;
                    empleado.MdiParent = this;
                    empleado.WindowState = FormWindowState.Normal;
                    empleado.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void gESTIONUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuarios != null)
                    usuarios.BringToFront();
                else
                {
                    usuarios = new ABM_Usuarios();
                    usuarios.FormClosed += (o, args) => usuarios = null;
                    usuarios.MdiParent = this;
                    usuarios.WindowState = FormWindowState.Normal;
                    usuarios.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void UI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void cHARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (chart != null)
                    chart.BringToFront();
                else
                {
                    chart = new CHART();
                    chart.FormClosed += (o, args) => chart = null;
                    chart.MdiParent = this;
                    chart.WindowState = FormWindowState.Normal;
                    chart.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                if (unidades != null)
                    unidades.BringToFront();
                else
                {
                    unidades = new ABM_Unidad();
                    unidades.FormClosed += (o, args) => unidades = null;
                    unidades.MdiParent = this;
                    unidades.WindowState = FormWindowState.Normal;
                    unidades.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            try
            {
                if (actualizar != null)
                    actualizar.BringToFront();
                else
                {
                    actualizar = new ACTUALIZAR_Estados();
                    actualizar.FormClosed += (o, args) => unidades = null;
                    actualizar.MdiParent = this;
                    actualizar.WindowState = FormWindowState.Normal;
                    actualizar.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            try
            {
                if (reportEAlquileres != null)
                    reportEAlquileres.BringToFront();
                else
                {
                    reportEAlquileres = new REPORTEAlquileres();
                    reportEAlquileres.FormClosed += (o, args) => reportEAlquileres = null;
                    reportEAlquileres.MdiParent = this;
                    reportEAlquileres.WindowState = FormWindowState.Normal;
                    reportEAlquileres.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void aLQUILERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (alquiler != null)
                    alquiler.BringToFront();
                else
                {
                    alquiler = new ABM_Alquiler();
                    alquiler.FormClosed += (o, args) => alquiler = null;
                    alquiler.MdiParent = this;
                    alquiler.WindowState = FormWindowState.Normal;
                    alquiler.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void fACTURARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturaciones != null)
                    facturaciones.BringToFront();
                else
                {
                    facturaciones = new BUSCAR_Facturaciones(false);
                    facturaciones.FormClosed += (o, args) => facturaciones = null;
                    facturaciones.MdiParent = this;
                    facturaciones.WindowState = FormWindowState.Normal;
                    facturaciones.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void aBMCLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente != null)
                    cliente.BringToFront();
                else
                {
                    cliente = new ABM_Cliente();
                    cliente.FormClosed += (o, args) => cliente = null;
                    cliente.MdiParent = this;
                    cliente.WindowState = FormWindowState.Normal;
                    cliente.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void cOBROToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

      

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            try
            {
                if (buscarc != null)
                    buscarc.BringToFront();
                else
                {
                    buscarc = new BUSCAR_Cliente(false);
                    buscarc.FormClosed += (o, args) => buscarc = null;
                    buscarc.MdiParent = this;
                    buscarc.WindowState = FormWindowState.Maximized;
                    buscarc.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
