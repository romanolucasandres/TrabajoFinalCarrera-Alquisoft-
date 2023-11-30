using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT
{
    public partial class Backup_Restore : Form
    {
        BLL_BackupRestore BackupRestore_;
        bool esRestore;
        public Backup_Restore(bool restore)
        {
            InitializeComponent();
            BackupRestore_ = new BLL_BackupRestore();
            CargarListaArchivos();
            CargarForm(restore);
            esRestore = restore;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = BackupRestore_.ObtenerRutaBackup();
                if (!string.IsNullOrEmpty(s))
                {
                    Process.Start("explorer.exe", s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (esRestore)
                {
                    if (listBox1?.Items?.Count > 0)
                    {
                        string archivoseleccionado = listBox1.SelectedItem?.ToString();
                        if (!string.IsNullOrEmpty(archivoseleccionado))
                        {
                            string mensaje = BackupRestore_.RealizarRestore(archivoseleccionado);
                            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("El archivo seleccionado contiene errores", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                        MessageBox.Show("No existen archivos de backup para realizar restauración", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    string mensaje = BackupRestore_.RealizarBackup(DateTime.Now);
                    MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                CargarListaArchivos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void CargarListaArchivos()
        {
            try
            {
                listBox1.DataSource = BackupRestore_.ObtenerArchivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void CargarForm(bool esrestore)
        {
            if (esrestore)
            {
                button2.Text = "RESTORE";
                MessageBox.Show("Para restaurar, deberá seleccionar el nombre del archivo y hacer click en \"RESTORE\" ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
                MessageBox.Show("Para generar la copia de seguridad, haga clic en \"BACKUP\"", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
