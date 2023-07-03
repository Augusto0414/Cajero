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
            consultar();
            lblTotal.Text = saldoTotalCajero().ToString();
        }


        private int posX = 0;
        private int posY = 0;


        string historialTransacion = "historialTransaciones.txt";
        string cantidaBillete = "cantidadBillete.txt";


        int[] billetes = { 100000, 50000, 20000, 10000 };


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

        private int[] cargarBillete(string cantidadBillete)
        {
            string[] lines = File.ReadAllText(cantidadBillete).Split(';');
            int[] billetesEnteros = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                int.TryParse(lines[i], out billetesEnteros[i]);
            }
            return billetesEnteros;
        }


        static void GuardarTransaciones(string rutaArchivo, string data)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo, append: true))
            {
                sw.WriteLine(data);
            }
        }

        private void GuardarBilletes(string cantidadBillete, int[] datosArray)
        {
            string datosString = string.Join(";", datosArray.Select(x => x.ToString()));
            File.WriteAllText(cantidadBillete, datosString);
        }


        public void retirarSaldo(int cantidadRetirar)
        {
            int[] cantidadDisponible = cargarBillete(cantidaBillete);
            int cantidad = cantidadRetirar;
            int[] billetesRetirados = new int[billetes.Length];
            Array.Fill(billetesRetirados, 0);
            int[] datosArray = new int[billetesRetirados.Length];

            while (cantidad > 0)
            {
                bool retirado = false;
                for (int i = 0; i < billetes.Length; i++)
                {

                    if (cantidad >= billetes[i] && cantidadDisponible[i] > 0)
                    {

                        cantidad -= billetes[i];
                        cantidadDisponible[i]--;
                        datosArray[i] = cantidadDisponible[i];
                        billetesRetirados[i]++;
                        retirado = true;
                        GuardarBilletes(cantidaBillete, cantidadDisponible);
                    }

                }
                if (!retirado)
                {
                    MessageBox.Show("No se puede retirar esa cantidad.");
                    return;
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

            GuardarTransaciones(historialTransacion, filas.ToString());

            // Agregar los datos a las filas del DataGridView
            for (int i = 0; i < valorRetirado.Count; i += 2)
            {
                string denominacion = valorRetirado[i];
                string cantidadRetirada = valorRetirado[i + 1];

                dataGridView1.Rows.Add(denominacion, cantidadRetirada);
            }
        }




        private void consultar()
        {
            string filename = "cantidadBillete.txt";
            string[] lines = File.ReadAllLines(filename);

            dataGridView2.AllowUserToAddRows = false; // Evita que se agregue una fila en blanco al final

            // Configura el número de columnas
            dataGridView2.ColumnCount = lines[0].Split(';').Length;

            // Limpia las filas existentes en el DataGridView
            dataGridView2.Rows.Clear();

            // Agrega las filas y asigna los valores de las celdas
            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                dataGridView2.Rows.Add(values);
            }
        }


        private int saldoTotalCajero() {

            int[] cantidadDisponible = cargarBillete(cantidaBillete);
            int[] billeteDisponible = new int[cantidadDisponible.Length];
            int sumaTotal = 0; 
            for (int i = 0; i < cantidadDisponible.Length; i++)
            {
                int valorMultiplicado; 
                switch ( i ) { 
                  
                    case 0 :
                        valorMultiplicado =  cantidadDisponible[i] * 100000; 
                        break;
                    case 1:
                        valorMultiplicado = cantidadDisponible[i] * 50000;
                        break;
                    case 2:
                        valorMultiplicado = cantidadDisponible[i] * 20000;
                        break;
                    case 3:
                        valorMultiplicado = cantidadDisponible[i] * 10000;
                        break;
                    default:
                        valorMultiplicado = cantidadDisponible[i]; 
                        break;
                }
                billeteDisponible[i] = valorMultiplicado;
                sumaTotal += valorMultiplicado; 
             
            }
            return sumaTotal; 

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
            consultar();
            lblTotal.Text = saldoTotalCajero().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidad = 100000;
            retirarSaldo(cantidad);
            consultar();
            lblTotal.Text = saldoTotalCajero().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cantidad = 300000;
            retirarSaldo(cantidad);
            consultar();
            lblTotal.Text = saldoTotalCajero().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cantidad = 1000000;
            retirarSaldo(cantidad);
            consultar();
            lblTotal.Text = saldoTotalCajero().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cantidad = 50000;
            retirarSaldo(cantidad);
            consultar();
            lblTotal.Text = saldoTotalCajero().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int cantidad = 200000;
            retirarSaldo(cantidad);
            consultar();
            lblTotal.Text = saldoTotalCajero().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int cantidad = 600000;
            retirarSaldo(cantidad);
            consultar();
            lblTotal.Text = saldoTotalCajero().ToString();
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
                consultar();
                lblTotal.Text = saldoTotalCajero().ToString();
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
