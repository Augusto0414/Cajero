using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CajeroAutomatico
{
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
            consultar();
            contadorColumnas();
            lblConsignacion.Text = dataGridView1.RowCount.ToString();


        }

        private int posX = 0;
        private int posY = 0;
        string historialTransacion = "historialTransaciones.txt";
        private void MoverVentana(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left += (e.X - posX);
                Top += (e.Y - posY);
            }
        }

        private void frmValorRetiro_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form inicio
            = new frmRetirar();
            inicio.Show();
            this.Close();
        }

        private void consultar()
        {
            string filename = "historialTransaciones.txt";
            string[] lines = File.ReadAllLines(filename);

            dataGridView1.AllowUserToAddRows = false; // Evita que se agregue una fila en blanco al final

            // Configura el número de columnas
            dataGridView1.ColumnCount = lines[0].Split(';').Length - 1;

            // Limpia las filas existentes en el DataGridView
            dataGridView1.Rows.Clear();

            // Agrega las filas y asigna los valores de las celdas
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                dataGridView1.Rows.Add(values);
            }
        }

        private void contadorColumnas()
        {

            int numeroColumnas = dataGridView1.ColumnCount;
            int[] sumas = new int[numeroColumnas];

            for (int i = 0; i < numeroColumnas; i++)
            {
                sumas[i] += 0;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < numeroColumnas; i++)
                {
                    if (row.Cells[i].Value != null)
                    {
                        int valorCelda;
                        if (int.TryParse(row.Cells[i].Value.ToString(), out valorCelda))
                        {
                            sumas[i] += valorCelda;
                        }
                    }
                }
            }
            MostrarSumasEnDataGridView(sumas);

        }

        private void MostrarSumasEnDataGridView(int[] sumas)
        {

            dataGridView2.Rows.Clear();

            dataGridView2.Rows.Add();

            DataGridViewRow fila = dataGridView2.Rows[dataGridView2.Rows.Count - 1];

            for (int i = 0; i < sumas.Length; i++)
            {
                fila.Cells[i].Value = sumas[i];
            }
        }


    }
}
