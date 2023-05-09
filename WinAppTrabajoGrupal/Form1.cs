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
    public partial class Form1 : Form
    {
        string user = "administrador";
        string psw = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Credenciales incorrectas", "Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
