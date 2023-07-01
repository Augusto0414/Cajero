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
    public partial class frmConsultarSaldo : Form
    {
        public frmConsultarSaldo()
        {
            string rutaArchivo = "saldo.txt";
            InitializeComponent();
            lblSaldo.Text = LeerSaldoDesdeArchivo(rutaArchivo).ToString();

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


        private int posX = 0;
        private int posY = 0;

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
        private void frmConsultarSaldo_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frmInicio = new frmPrincipal();
            frmInicio.Show();
            Hide();
        }

        private void frmConsultarSaldo_Load(object sender, EventArgs e)
        {

        }
    }
}
