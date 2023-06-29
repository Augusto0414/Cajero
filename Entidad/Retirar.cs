namespace Entidad
{
    public class Retirar
    {
        public Retirar() { }
        public Retirar(int cantidadRetiro) {
        CantidadRetiro = cantidadRetiro;
        }


        int billete_100k = 2;
        int billete_50k = 3;
        int billete_20k = 5;
        int billete_10k = 10;


        public int CantidadRetiro { get; set; }
    }
}