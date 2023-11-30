using BLL;
using FRONT.Controles;
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
using System.Xml.Linq;
using System.Xml;

namespace FRONT
{
    public partial class PERMISOS : Form
    {
        BLL_Permiso Permiso;
        BLL_Menu Menu_;
        BLL_Rol Rol_;
        public PERMISOS()
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
                Permisos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void Inicio()
        {
            Permiso = new BLL_Permiso();
            Menu_ = new BLL_Menu();
            Rol_ = new BLL_Rol();
            CargarComboRol();
            CargarMenuArbol();
           
        }
        private void CargarComboRol()
        {
            comboBox1.DataSource = Rol_.Traer();
        }
        private void CargarMenuArbol()
        {
            try
            {
                S_Componente componente = null;

                if (comboBox1.SelectedItem != null)
                {
                    componente = (S_Compuesto)comboBox1.SelectedItem;
                    componente = Permiso.Traer(componente);
                }
                treeView1.Nodes.Clear();

                foreach (var menuPadre in Menu_.Traer().ObtenerLista())
                {
                    if (menuPadre.Numero.ToString().Trim().StartsWith("3"))
                    {
                        TreeNode Padre = new TreeNode();
                        Padre = treeView1.Nodes.Add(menuPadre.Nombre);
                        if (componente != null)
                        {
                            foreach (S_Hoja permiso in componente?.ObtenerLista())
                            {
                                if (Padre?.Text == permiso?.Nombre)
                                {
                                    Padre.Checked = permiso.Visible;
                                }
                            }
                        }

                        if (menuPadre.ObtenerLista()?.Count > 0)
                        {
                            foreach (var menuHijo in menuPadre.ObtenerLista())
                            {
                                Padre.Nodes.Add(menuHijo.Nombre);
                                if (componente != null)
                                {
                                    foreach (var hijo in componente?.ObtenerLista())
                                    {
                                        foreach (TreeNode item in Padre.Nodes)
                                        {
                                            if (hijo?.Nombre == item?.Text)
                                                item.Checked = hijo.Visible;
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

        private void Permisos()
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    S_Componente Rol = (S_Compuesto)comboBox1.SelectedItem;
                    S_Componente Componente = Permiso.Traer(Rol);
                    foreach (TreeNode TPadre in treeView1.Nodes)
                    {
                        if (Componente != null && Componente.ObtenerLista().Exists(x => x.Nombre.Trim() == TPadre.Text.Trim()))
                        {

                            foreach (S_Hoja item in Componente.ObtenerLista())
                            {
                                if (item.Nombre.Trim() == TPadre.Text.Trim())
                                    item.Cambiarvisible(TPadre.Checked);
                            }

                        }
                        else
                        {
                            S_Hoja nuevo = new S_Hoja(TPadre.Text.Trim(), TPadre.Checked);
                            Componente.AgregarNodo(nuevo);
                        }


                        foreach (TreeNode Hijo in TPadre.Nodes)
                        {
                            if (Componente != null && Componente.ObtenerLista().Exists(x => x.Nombre.Trim() == Hijo.Text))
                            {
                                foreach (S_Hoja item in Componente.ObtenerLista())
                                {
                                    if (item.Nombre == Hijo.Text)
                                        item.Cambiarvisible(Hijo.Checked);
                                }
                            }
                            else
                            {
                                S_Hoja nuevo = new S_Hoja(Hijo.Text, Hijo.Checked);
                                Componente.AgregarNodo(nuevo);
                            }
                        }

                    }
                    Permiso.Alta(Componente);
                    MessageBox.Show("Permiso otorgado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    CargarMenuArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
       
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                    CargarMenuArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
