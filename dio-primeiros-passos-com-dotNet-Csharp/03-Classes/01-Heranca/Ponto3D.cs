namespace Classes.Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
            
        }

        public static void Calcular()
        {
            //Faz alguma coisa...
        }

        public override void CalcularDistancia3()
        {
            //Faz alguma coisa...
            base.CalcularDistancia3();
        }
    }
}