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
    public partial class LOGIN : Form
    {
        BLL_Login Login_;
        UI_Menu menu_;
        bool bool1 = false;
        public LOGIN()
        {
            InitializeComponent();
            Inicio();
        }
        private void Inicio()
        {
            Login_ = new BLL_Login();
            comboBox1.DataSource = Login_.Traer();

        }
        private void buttonINGRESAR_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Usuario usuario = new BE_Usuario();
                if (comboBox1.SelectedItem != null && !string.IsNullOrEmpty(textBox1.Text?.Trim()))
                {
                    string contraseña = "";
                    usuario = comboBox1.SelectedItem as BE_Usuario;
                    contraseña = textBox1.Text.Trim();
                    if (!bool1 && Login_.Validar(usuario, contraseña))
                    {

                        menu_ = new UI_Menu(usuario);
                        menu_.Show();
                        this.Hide();

                    }
                    else if (bool1 && Login_.Validar(contraseña))
                    {
                        menu_ = new UI_Menu(usuario);
                        menu_.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Acceso denegado.", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonINGRESAR_Click(null, new EventArgs());
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    comboBox1.DataSource = Login_.Admin();
                    bool1 = true;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    comboBox1.DataSource = Login_.Traer();
                    bool1 = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSALIR_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
