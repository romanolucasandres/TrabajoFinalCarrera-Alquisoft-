using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT.Controles
{
    public partial class UC_DGV : UserControl
    {
        public event EventHandler eventoSeleccionado;
        public DataGridViewSelectionMode ModoSeleccion { get => dgvPantallas.SelectionMode; set => dgvPantallas.SelectionMode = value; }
        public bool Multiseleccion { get => dgvPantallas.MultiSelect; set => dgvPantallas.MultiSelect = value; }
        public UC_DGV()
        {
            InitializeComponent();
        }
        public void Mostrar(object o)
        {
            dgvPantallas.DataSource = null;
            dgvPantallas.DataSource = o;
        }

        public object Seleccionado()
        {
            return dgvPantallas?.CurrentRow?.DataBoundItem;
        }

        private void dgvPantallas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eventoSeleccionado?.Invoke(sender, e);

        }
        public bool RowsMayor0()
        {

            if (dgvPantallas.Rows?.Count > 0)
            {
                return true;

            }
            return false;

        }

        public void Diseño(int indexcolumna, bool visible)
        {
            if (dgvPantallas.Columns.Count > indexcolumna && indexcolumna >= 0)
            {
                dgvPantallas.Columns[indexcolumna].Visible = visible;
            }
        }

        public void Diseño_conForeach(List<int> ListaColumnasIndex, bool visible)
        {
            foreach (int indexcolumna in ListaColumnasIndex)
            {
                Diseño(indexcolumna, visible);
            }

        }

        public void RenombrarColumnas(int indexcolumna, string cabezal)
        {

            if (dgvPantallas.Columns.Count > indexcolumna && indexcolumna >= 0)
            {
                dgvPantallas.Columns[indexcolumna].HeaderText = cabezal;
            }

        }

        public void Actualizar()
        {
            if (dgvPantallas.Columns?.Count > 0 && dgvPantallas.Rows?.Count > 0)
                dgvPantallas_CellClick(null, new DataGridViewCellEventArgs(dgvPantallas.CurrentCell.ColumnIndex, dgvPantallas.CurrentCell.ColumnIndex));
        }

        public DataGridViewSelectedRowCollection RowsSeleccionadas()
        {
            return dgvPantallas.SelectedRows;
        }
    }
}
