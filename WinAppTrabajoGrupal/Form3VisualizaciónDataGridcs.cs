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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;

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
        private void Form3VisualizaciónDataGridcs_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.ClearSelection();
        }
    }

}
