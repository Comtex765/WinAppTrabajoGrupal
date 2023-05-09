using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void textNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if(textNom.Text.Length > 0) 
                {
                    textApe.Enabled = true;
                    textApe.Focus();
                }
                else
                {
                    MessageBox.Show("El nombre no puede ser un campo vacío", "ERROR");
                }
            }
        }

        private void textApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (textApe.Text.Length > 0)
                {
                    textCed.Enabled = true;
                    textCed.Focus();
                }
                else
                {
                    MessageBox.Show("El apellido no puede ser un campo vacío", "ERROR");
                }
            }
        }

        private void textCed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (textCed.Text.Length > 0)
                {
                    if(ValidarCedulaEcuatoriana(textCed.Text))
                    {
                        textProf.Enabled = true;
                        textProf.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La cédula no puede ser un campo vacío", "ERROR");
                }
            }
        }
        
        private bool ValidarCedulaEcuatoriana(string cedula)
        {
            if (cedula.Length != 10 || !int.TryParse(cedula, out int n))
            {
                // Si la cédula no tiene 10 dígitos o no es un número válido, retorna falso.
                MessageBox.Show("La cédula no tiene 10 dígitos", "ERROR");
                return false;
            }

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse(cedula[i].ToString());
                int coef = (i % 2 == 0) ? 2 : 1;
                int product = digit * coef;
                sum += (product >= 10) ? (product - 9) : product;
            }

            int lastDigit = int.Parse(cedula[9].ToString());
            int calculatedDigit = (sum % 10 == 0) ? 0 : (10 - (sum % 10));

            if (lastDigit == calculatedDigit)
                return true;
            else
            {
                MessageBox.Show("La cédula no cumple la validación","ERROR");
                return false;
            }
        }

        private void textProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (textProf.Text.Length > 0)
                {
                     textCiudad.Enabled = true;
                     textCiudad.Focus();
                }
                else
                {
                    MessageBox.Show("La profesión no puede ser un campo vacío", "ERROR");
                }
            }
        }

        private void textCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (textCiudad.Text.Length > 0)
                {
                    if (ValidarCedulaEcuatoriana(textCed.Text))
                    {
                        numHijos.Enabled = true;
                        numHijos.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La ciudad no puede ser un campo vacío", "ERROR");
                }
            }
        }

        private void GuardarAlArchivo()
        {
            string sueldo = CalcularSueldo();

            // Ruta del archivo donde se guardarán los datos.
            string rutaArchivo = Application.StartupPath + "\\datos.txt";

            // Crear un objeto StreamWriter para escribir en el archivo.
            using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
            {
                // Escribir los datos en el archivo.
                escritor.WriteLine(textNom.Text + 
                    "-" + textApe.Text + 
                    "-" + textCed.Text + 
                    "-" + textProf.Text + 
                    "-" + textCiudad.Text + 
                    "-" + numHijos.Text + 
                    "-" + sueldo
                );
            }


        }
        private void Reiniciar()
        {
            textNom.Focus();
            textNom.Clear();
            textApe.Clear();
            textProf.Clear();
            textCed.Clear();
            textCiudad.Clear();

            textApe.Enabled = false;
            textCed.Enabled = false;
            textProf.Enabled = false;
            textCiudad.Enabled = false;
            numHijos.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioAdmiFin.Checked || radioDesWeb.Checked || radioDisGraf.Checked || radioMarket.Checked || radioProgra.Checked)
            {
                GuardarAlArchivo();
                Reiniciar();
                MessageBox.Show("El empleado se ha guardado correctamente","INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            }
        }

        private string CalcularSueldo()
        {
            if (radioAdmiFin.Checked)
                return "Administración Financiera - $2000 /mes";
            else if (radioProgra.Checked)
                return "Programación - $5000 /mes";
            else if (radioDesWeb.Checked)
                return "Desarrollo Wev - $1500 /mes";
            else if (radioMarket.Checked)
                return "Marketing - $4200 /mes";
            else if (radioDisGraf.Checked)
                return "Diseño Gráfico - $1800 /mes";

            return "#####";

        }
    }
}
