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
    public partial class Form3VisualizaciónDataGridcs : Form
    {
        public Form3VisualizaciónDataGridcs()
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
                    // Leer todas las líneas del archivo.
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();

                        string[] palabrasLinea = linea.Split('-');

                        int con = dataGridView1.RowCount;
                        dataGridView1.Rows.Add(palabrasLinea);

                    }
                }
            }
            catch
            {

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3VisualizaciónDataGridcs_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.ClearSelection();
        }
    }

}
