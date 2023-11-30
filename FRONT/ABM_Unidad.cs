using BE;
using BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT
{
    public partial class ABM_Unidad : Form
    {
        BLL_Unidad Unidad;
        BLL_Alquiler alquiler;
        public ABM_Unidad()
        {
            InitializeComponent();
            Inicio();
            ObtenerUltimoCodigo();
        }
        //button alta
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Alta_Editar(Validar(), true);
                Vaciar();
                uC_DGV1.Mostrar(Unidad.Traer());
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
                uC_DGV1.Mostrar(Unidad.Traer());
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
                BE_Unidades unidad = new BE_Unidades();
                unidad = uC_DGV1.Seleccionado() as BE_Unidades;
                if (unidad != null)
                {
                    if (alquiler.ExisteUnidadAlquiler(unidad, null, null))
                        MessageBox.Show($"No se puede eliminar, la unidad {unidad.Codigo} tiene al menos un alquiler asignado.");
                    else
                        Unidad.Baja(unidad);
                }
                Vaciar();
                uC_DGV1.Mostrar(Unidad.Traer());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        // button cerrar
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ObtenerUltimoCodigo()
        {
            this.txtSoloNumerosCodigo.Texto = Unidad.ObtenerUltimoCodigo();
        }
        private void Inicio()
        {
            Unidad = new BLL_Unidad();
            alquiler = new BLL_Alquiler();
            uC_DGV1.Mostrar(Unidad.Traer());
            uC_DGV1.eventoSeleccionado += EventoCellClick;
        }
        private void Alta_Editar(bool bool1, bool bool2)
        {
            try
            {
                if (bool1)
                {
                    BE_Unidades unidad = new BE_Unidades();
                    unidad.Codigo = Convert.ToInt32(txtSoloNumerosCodigo.Texto.Trim());
                    unidad.Ciudad = txtSoloTextoCiudad.Texto.Trim();
                    unidad.Pais = txtSoloTextoPais.Texto.Trim();
                    unidad.Direccion = textBoxDireccion.Text.Trim();
                    unidad.Ambientes = Convert.ToInt32(txtSoloNumerosAmbientes.Texto.Trim());
                    unidad.Plaza= Convert.ToInt32(txtSoloNumerosPlazas.Texto.Trim());
                    unidad.PrecioDia= Convert.ToDecimal(uC_txtSoloDecimalPRECIO.Texto.Trim());
                    


                    if (bool2)
                    {
                        if (!ValidarUnidad(unidad.Codigo))
                        {
                            unidad.Estado = true;
                            Unidad.Alta(unidad);
                            Vaciar();
                        }
                        else
                        {
                            if (MessageBox.Show($"Ya existe el cliente {unidad?.Codigo} ¿Quiere actualizarlo?", "Actualización de Unidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                Unidad.Modificacion(unidad);
                                Vaciar();
                            }
                        }
                    }
                    if (!bool2)
                    {
                        if (!ValidarUnidad(unidad.Codigo))
                        {
                            if (MessageBox.Show($"No existe el cliente {unidad?.Codigo} ¿Desea darlo de alta?", "Nueva Unidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                unidad.Estado = true;
                                Unidad.Alta(unidad);
                                Vaciar();
                            }
                        }
                        else
                        {
                            Unidad.Modificacion(unidad);
                            Vaciar();
                        }
                    }
                }
                else
                    MessageBox.Show("Los datos ingresados tienen errores, ingrese nuevamente los datos requeridos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //validad unidad
        private bool ValidarUnidad(int codigo)
        {
            bool bool1 = false;
            try
            {
                bool1 = Unidad.Traer().Exists(x => x.Codigo.ToString().Trim() == codigo.ToString().Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return bool1;
        }
        //evento para el dgv
        private void EventoCellClick(object sender, EventArgs e)
        {
            try
            {
                BE_Unidades unidad = new BE_Unidades();
                if (uC_DGV1.RowsMayor0())
                {
                    unidad = uC_DGV1.Seleccionado() as BE_Unidades;
                    if (unidad != null)
                    {
                        txtSoloNumerosCodigo.Texto = unidad.Codigo.ToString().Trim();
                        txtSoloTextoCiudad.Texto = unidad.Ciudad.ToString().Trim();
                        txtSoloTextoPais.Texto = unidad.Pais.ToString().Trim();
                        textBoxDireccion.Text = unidad.Direccion.ToString().Trim();
                        txtSoloNumerosAmbientes.Texto=unidad.Ambientes.ToString().Trim();
                        txtSoloNumerosPlazas.Texto=unidad.Plaza.ToString().Trim();
                        uC_txtSoloDecimalPRECIO.Texto=unidad.PrecioDia.ToString().Trim();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        //metodo para vaciar txt
        private void Vaciar()
        {
            txtSoloTextoCiudad.Vaciar();
           
            txtSoloNumerosPlazas.Vaciar();
            txtSoloNumerosAmbientes.Vaciar();
            txtSoloTextoPais.Vaciar();
            textBoxDireccion.Text = string.Empty;
            uC_txtSoloDecimalPRECIO.VaciarTexto();
        }
        private bool Validar()
        {
            bool unidadValida = true;
            try
            {
                if (txtSoloNumerosCodigo.Validar() && txtSoloTextoCiudad.Validar() && txtSoloTextoPais.Validar() 
                    && txtSoloNumerosPlazas.Validar() && txtSoloTextoCiudad.Validar() && txtSoloNumerosAmbientes.Validar())
                    unidadValida = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return unidadValida;

        }
    }
}
