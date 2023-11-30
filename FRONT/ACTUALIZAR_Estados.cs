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
    public partial class ACTUALIZAR_Estados : Form
    {
        BLL_Unidad Unidad;
        public ACTUALIZAR_Estados()
        {
            InitializeComponent();
            Unidad = new BLL_Unidad();
            comboBox1.DataSource = Unidad.Traer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarEstado(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActualizarEstado(false);
        }

        private void ActualizarEstado(bool disponible)
        {
            try
            {
                if (uC_DGV1.RowsMayor0())
                {
                    if (MessageBox.Show("¿Desea actualizar el estado de la Unidad?", "Importante Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow item in uC_DGV1.RowsSeleccionadas())
                        {
                            if (item != null)
                            {
                                BE_Unidades uni = item.DataBoundItem as BE_Unidades;
                                if (uni != null)
                                {
                                    uni.Estado = disponible;
                                    Unidad.Modificacion(uni);
                                    uC_DGV1.Refresh();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            uC_DGV1.Mostrar(Unidad.Traer(comboBox1.ToString()));
        }
    }
}
