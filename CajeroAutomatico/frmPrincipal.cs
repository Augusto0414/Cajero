namespace CajeroAutomatico
{
    public partial class frmPrincipal : Form
    {



        public frmPrincipal()
        {
            InitializeComponent();

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MoverVentana(sender, e);
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form retirar = new frmRetirar();
            retirar.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmSaldo = new frmConsultarSaldo();
            frmSaldo.Show();
            Hide();
        }

   

        private void button3_Click(object sender, EventArgs e)
        {
            Form consignar = new frmConsignar();
            consignar.Show();
            Hide();
        }
    }
}