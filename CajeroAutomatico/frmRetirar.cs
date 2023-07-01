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


        int billete_100k = 2;
        int billete_50k = 3;
        int billete_20k = 5;
        int billete_10k = 10;


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


        public  void retirarSaldo(int cantidad)
        {
            int saldo =  LeerSaldoDesdeArchivo(rutaSaldo); 
            if (cantidad <= saldo)
            {
                
                if (cantidad <= (billete_100k * 100000) + (billete_50k * 50000) + (billete_20k * 20000) + (billete_10k * 10000))
                {
                    int billetes_restantes = cantidad;
                    while (billetes_restantes >= 100000 && billete_100k > 0)
                    {
                        billetes_restantes -= 100000;
                        billete_100k -= 1;
                    }
                    while (billetes_restantes >= 50000 && billete_50k > 0)
                    {
                        billetes_restantes -= 50000;
                        billete_50k -= 1;
                    }
                    while (billetes_restantes >= 20000 && billete_20k > 0)
                    {
                        billetes_restantes -= 20000;
                        billete_20k -= 1;
                    } while (billetes_restantes >= 10000 && billete_10k > 0)
                    {
                        billetes_restantes -= 10000;
                        billete_10k -= 1;
                    }
                    if (billetes_restantes == 0)
                    {
                        saldo -= cantidad;
                        MessageBox.Show($"saldo actual es {saldo}");
                        GuardarSaldoEnArchivo(rutaSaldo,saldo.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes billetes disponibles para realizar el retiro");
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficiente saldo disponible para realizar el retiro");
                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente.");
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

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
