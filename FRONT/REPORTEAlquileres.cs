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
    public partial class REPORTEAlquileres : Form
    {
        BLL_Reporte reporte;
        public REPORTEAlquileres()
        {
            InitializeComponent();
            reporte = new BLL_Reporte();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void REPORTEAlquileres_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                this.bEReporteBindingSource.DataSource = reporte.Traer().OrderBy(x => x.FechaI);
                this.reportViewer1.RefreshReport();
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Importante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
