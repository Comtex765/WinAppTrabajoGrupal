using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTrabajoGrupal
{
    public partial class DeleteForm : Form
    {
        public DeleteForm(DataGridView datagrid)
        {
            InitializeComponent();
            foreach (DataGridViewRow row in datagrid.Rows)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row.Index].Cells["Column1"].Value = row.Cells[0].Value;
            }
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n = dataGridView1.RowCount;
            try
            {
                string dni = TxtDni.Text;
                for (int i = 0; i < n; i++)
                {
                    if (dataGridView1.Rows[i].Cells[2].Value == null && dataGridView1.Rows.Count > 1)
                    {
                        MessageBox.Show("Ingrese un cédula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string cellValue = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        if (cellValue == dni)
                        {
                            dataGridView1.Rows.RemoveAt(dataGridView1.Rows[i].Index);
                            break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un cédula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteDni_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("Seleccione un empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
