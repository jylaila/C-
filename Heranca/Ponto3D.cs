namespace myApp.Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;
        private int distancia;

        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //something
        }


        public override void CalcularDistancia3()
        {
            //something
        }
    }
}