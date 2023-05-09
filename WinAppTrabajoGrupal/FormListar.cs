using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTrabajoGrupal
{
    public partial class FormListar : Form
    {
        public FormListar()
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
            catch{}
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            CargarDatos();
            textFiltro.Enabled = false;
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFiltro.SelectedItem.ToString() == "TODOS")
                Todos();
            else
                textFiltro.Enabled = true;
        }

        private void Filtro(int col, string valor)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1[col,i].Value.ToString() == valor)
                    dataGridView1.Rows[i].Visible = true;
                else
                    dataGridView1.Rows[i].Visible = false;
            }
        }

     

        private void Todos()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                dataGridView1.Rows[i].Visible = true;
        }


        private void textFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(textFiltro.Text.Length > 0)
                {
                    e.Handled = true;

                    switch (comboBoxFiltro.SelectedItem.ToString())
                    {
                        case "Nombre":
                            Filtro(0,textFiltro.Text);
                            break;
                        case "Apellido":
                            Filtro(1, textFiltro.Text);
                            break;
                        case "Profesión":
                            Filtro(3, textFiltro.Text);
                            break;
                        case "# hijos":
                            Filtro(4, textFiltro.Text);
                            break;
                        case "Residencia":
                            Filtro(5, textFiltro.Text);
                            break;
                        case "Área de Trabajo":
                            Filtro(6, textFiltro.Text);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Debes ingresar el valor con el que se comparará", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
