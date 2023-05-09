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
    public partial class Form3VisualizaciónDataGridcs : Form
    {
        public Form3VisualizaciónDataGridcs()
        {
            InitializeComponent();
        }
            public Form3VisualizaciónDataGridcs(DataGridView datos)
        {
            InitializeComponent();

            dataGridView1.Rows.Clear();

            foreach (DataGridViewRow row in datos.Rows)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row.Index].Cells["Nombre"].Value = row.Cells[0].Value;
                dataGridView1.Rows[row.Index].Cells["Apellido"].Value = row.Cells[1].Value;
                dataGridView1.Rows[row.Index].Cells["Cedula"].Value = row.Cells[2].Value;
                dataGridView1.Rows[row.Index].Cells["Profesion"].Value = row.Cells[3].Value;
                dataGridView1.Rows[row.Index].Cells["NumHijos"].Value = row.Cells[4].Value;
                dataGridView1.Rows[row.Index].Cells["Residencia"].Value = row.Cells[5].Value;
                dataGridView1.Rows[row.Index].Cells["Sueldo"].Value = row.Cells[6].Value;
            }
        }

        private void Form3VisualizaciónDataGridcs_Load(object sender, EventArgs e)
        {
            dataGridView1.Show();
        }
    }
}
