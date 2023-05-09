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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            try
            {
                // Ruta del archivo que se desea leer.
                string rutaArchivo = Application.StartupPath + "\\datos.txt";

                // Crear un objeto StreamReader para leer el archivo.
                using (StreamReader lector = new StreamReader(rutaArchivo))
                {
                    int i = 0;
                    while (!lector.EndOfStream)
                    {
                        dataGridView1.Rows.Add();

                        DataGridViewCell headerCell = dataGridView1.Rows[i].HeaderCell;
                        headerCell.Value = (i + 1).ToString();

                        string linea = lector.ReadLine();
                        string[] palabrasLinea = linea.Split('-');

                        for (int j = 0; j < palabrasLinea.Length; j++)
                            dataGridView1[j, i].Value = palabrasLinea[j];
                        i++;
                    }
                }
            }
            catch
            {

            }
            
        }


        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                int n = dataGridView1.RowCount;
                try
                {
                    string dni = TxtDni.Text;
                    for (int i = 0; i < n; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value == null && dataGridView1.Rows.Count > 1)
                        {
                            MessageBox.Show("No se encuentra el empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Ingrese una cédula", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
