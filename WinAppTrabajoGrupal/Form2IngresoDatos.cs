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

        private void textNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if(textNom.Text.Length > 0) 
                {
                    textApe.Enabled = true;
                    textApe.Focus();

                    dataGridView1.Rows.Add(textNom.Text);
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
                    int fila = dataGridView1.RowCount - 2;
                    dataGridView1[1,fila].Value = textApe.Text;
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
                    if(ValidarCedulaEcuatoriana(textCed.Text) || true)
                    {
                        textProf.Enabled = true;
                        textProf.Focus();
                        int fila = dataGridView1.RowCount - 2;
                        dataGridView1[2, fila].Value = textCed.Text;
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
                    int fila = dataGridView1.RowCount - 2;
                    dataGridView1[3, fila].Value = textProf.Text;
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
                        int fila = dataGridView1.RowCount - 2;
                        dataGridView1[5, fila].Value = textCiudad.Text;
                    }
                }
                else
                {
                    MessageBox.Show("La ciudad no puede ser un campo vacío", "ERROR");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioAdmiFin.Checked || radioDesWeb.Checked || radioDisGraf.Checked || radioMarket.Checked || radioProgra.Checked)
            {
                MessageBox.Show("El empleado se ha agregado correctamente, verlo en el menú", "INFO");
                int fila = dataGridView1.RowCount - 2;
                CalcularSueldo();
                dataGridView1[4, fila].Value = numHijos.Value.ToString();

                Form3VisualizaciónDataGridcs a = new Form3VisualizaciónDataGridcs(dataGridView1);
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe ingresar su área de trabajo");
            }
        }

        private void CalcularSueldo()
        {
            int fila = dataGridView1.RowCount - 2;

            if (radioAdmiFin.Checked)
                dataGridView1[6,fila].Value = "$2000 /mes";
            else if (radioProgra.Checked)
                dataGridView1[6, fila].Value = "$5000 /mes";
            else if (radioDesWeb.Checked)
                dataGridView1[6, fila].Value = "$1500 /mes";
            else if (radioMarket.Checked)
                dataGridView1[6, fila].Value = "$4200 /mes";
            else if (radioDisGraf.Checked)
                dataGridView1[6, fila].Value = "$1800 /mes";


        }
    }
}
