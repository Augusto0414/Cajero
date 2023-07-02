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
        }


        private int posX = 0;
        private int posY = 0;


        string rutaSaldo = "saldo.txt";
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


        static int LeerSaldoDesdeArchivo(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                string contenido = File.ReadAllText(rutaArchivo);
                int saldo;
                if (int.TryParse(contenido, out saldo))
                {
                    return saldo;
                }
            }

            return 0;
        }



        static void GuardarSaldoEnArchivo(string rutaArchivo, string saldo)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo, append: false))
            {
                sw.WriteLine(saldo);
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
            List<string> valorRetirado = new List<string>();

            for (int i = 0; i < billetes.Length; i++)
            {
                string denominacion = $"${billetes[i]}";
                string cantidadRetirada = billetesRetirados[i].ToString();

                valorRetirado.Add(denominacion);
                valorRetirado.Add(cantidadRetirada);
            }

            // Configurar las columnas del DataGridView
            dataGridView1.Columns.Add("Denominación", "Denominación");
            dataGridView1.Columns.Add("Cantidad retirada", "Cantidad retirada");

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
            Form frmRetiro = new frmValorRetiro();
            frmRetiro.Show();
            Hide();
        }
    }
}
