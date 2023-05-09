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
    }
}
