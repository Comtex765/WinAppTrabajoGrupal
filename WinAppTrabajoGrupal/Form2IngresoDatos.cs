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
    public partial class Form2IngresoDatos : Form
    {
        public Form2IngresoDatos()
        {
            InitializeComponent();
        }

        private void Form2IngresoDatos_Load(object sender, EventArgs e)
        {
            textApe.Enabled = false;
            textCed.Enabled = false;
            textProf.Enabled = false;
            textCiudad.Enabled = false;
            numHijos.Enabled = false;
        }
    }
}
