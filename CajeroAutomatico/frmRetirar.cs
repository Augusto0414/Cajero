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
    public partial class frmRetirar : Form
    {
        public frmRetirar()
        {
            InitializeComponent();
            btnRetirar.Visible = false;
            txtSaldo.Visible = false;
        }


        private int posX = 0;
        private int posY = 0;


        string historialTransacion = "historialTransaciones.txt";
        string historialBillete = "historialBillete.txt";
        //string rutaBilletes = "billetes.txt"; 

        int[] billetes = { 100000, 50000, 20000, 10000 };
        int[] cantidadDisponible = { 40, 40, 40, 40 };

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

        static void GuardarSaldoEnArchivo(string rutaArchivo, string data)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo, append: true))
            {
                sw.WriteLine(data);
            }
        }


        public void retirarSaldo(int cantidadRetirar)
        {
            int cantidad = cantidadRetirar;
            int[] billetesRetirados = new int[billetes.Length];
            Array.Fill(billetesRetirados, 0);


            while (cantidad > 0)
            {

                for (int i = 0; i < billetes.Length; i++)
                {

                    if (cantidad >= billetes[i] && cantidadDisponible[i] > 0)
                    {

                        cantidad -= billetes[i];
                        cantidadDisponible[i]--;
                        billetesRetirados[i]++;

                    }

                }
            }
            dataGridView1.Rows.Clear();
            List<string> valorRetirado = new List<string>();
            StringBuilder filas = new StringBuilder();

            for (int i = 0; i < billetes.Length; i++)
            {
                string denominacion = $"${billetes[i]}";
                string cantidadRetirada = billetesRetirados[i].ToString();

                valorRetirado.Add(denominacion);
                valorRetirado.Add(cantidadRetirada);

                string fila = $"{cantidadRetirada};";
                filas.Append(fila);
            }
            GuardarSaldoEnArchivo(historialTransacion, filas.ToString());

            // Agregar los datos a las filas del DataGridView
            for (int i = 0; i < valorRetirado.Count; i += 2)
            {
                string denominacion = valorRetirado[i];
                string cantidadRetirada = valorRetirado[i + 1];

                dataGridView1.Rows.Add(denominacion, cantidadRetirada);
            }
        }








        private void button9_Click(object sender, EventArgs e)
        {
            Form inicio
                = new frmPrincipal();
            inicio.Show();
            this.Close();
        }

        private void frmRetirar_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = 20000;
            retirarSaldo(cantidad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidad = 100000;
            retirarSaldo(cantidad);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cantidad = 300000;
            retirarSaldo(cantidad);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cantidad = 1000000;
            retirarSaldo(cantidad);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cantidad = 50000;
            retirarSaldo(cantidad);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int cantidad = 200000;
            retirarSaldo(cantidad);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int cantidad = 600000;
            retirarSaldo(cantidad);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnRetirar.Visible = true;
            txtSaldo.Visible = true;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSaldo.Text))
            {
                MessageBox.Show(" Digite valor a retirar ");

            }
            else if (Int32.Parse(txtSaldo.Text) < 10000)
            {

                MessageBox.Show("No es posible entregar la cantidad solicitada");
            }
            else
            {

                int saldo = Int32.Parse(txtSaldo.Text);
                retirarSaldo(saldo);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form historial = new frmHistorial();
            historial.Show();
            this.Close();
        }
    }
}
