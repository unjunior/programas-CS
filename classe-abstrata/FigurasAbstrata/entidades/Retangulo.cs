using FigurasAbstrata.Entidades.Enumerados;

namespace FigurasAbstrata.Entidades
{
    class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(Cor cor, double largura, double altura)
            :base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}