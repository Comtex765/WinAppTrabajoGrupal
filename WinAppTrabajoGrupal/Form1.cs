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
        string[] usCredentials = { "administrador", "12345" };
        string user = "";
        string psw = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (user == "" || psw == "" || user != usCredentials[0] || psw != usCredentials[1])
                {
                    user = TxtUser.Text;
                    psw = TxtPsw.Text;
                }
                if (user == usCredentials[0])
                {
                    if (psw == usCredentials[1])
                    {
                        MessageBox.Show("Inicio de sesión exitoso", "Iniciar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta", "Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto", "Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Credenciales incorrectas", "Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    user = TxtUser.Text;
                    if (user == "")
                    {
                        MessageBox.Show("Ingrese el usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        TxtPsw.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese el usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TxtPsw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    psw = TxtPsw.Text;
                    if (psw == "")
                        MessageBox.Show("Ingrese la contraseña", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        BtnLogin_Click(sender, e);
                }
                catch
                {
                    MessageBox.Show("Ingrese la contraseña", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2IngresoDatos prueba = new Form2IngresoDatos();
            prueba.ShowDialog();
        }
    }
}
