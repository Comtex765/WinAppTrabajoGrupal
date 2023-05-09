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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Count > 0)
                panel2.Controls.RemoveAt(0);

            Form2IngresoDatos formIngreso = new Form2IngresoDatos();

            formIngreso.TopLevel = false;
            formIngreso.Dock = DockStyle.Fill;

            panel2.Controls.Add(formIngreso);
            panel2.Tag = formIngreso;

            formIngreso.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Controls.Count > 0)
                panel2.Controls.RemoveAt(0);

            Form3VisualizaciónDataGridcs formVer = new Form3VisualizaciónDataGridcs();

            formVer.TopLevel = false;
            formVer.Dock = DockStyle.Fill;

            panel2.Controls.Add(formVer);
            panel2.Tag = formVer;

            formVer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
