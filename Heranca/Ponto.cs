namespace myApp.Heranca
{
    public class Ponto
    {
        public int x,y;
        private int distancia;

        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia(){
            //something
        }

        private void CalcularDistancia2(){
            //something
        }

        public virtual void CalcularDistancia3(){//virtual permite que a classe filha sobrescreva o método
            //something
        }
    }
}