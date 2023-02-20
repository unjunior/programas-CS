using System;
using FigurasAbstrata.Entidades.Enumerados;

namespace FigurasAbstrata.Entidades
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(Cor cor, double raio)
            :base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }



}