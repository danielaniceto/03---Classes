namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;

        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        protected void CalcularDistancia()
        {
            //faz o calculo da distancia...
        }

        private void CalcularDistancia2()
        {
            //faz o calculo da distancia de novo...
        }

        public virtual void CalcularDistancia3()
        {
            //faz o calculo da distancia de novo de novo
        }
    }
}