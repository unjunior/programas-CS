using FigurasAbstrata.Entidades.Enumerados;

namespace FigurasAbstrata.Entidades
{
    abstract class Figura
    {
        public Cor Cor { get; set; }

        public Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();    
    }
    
}