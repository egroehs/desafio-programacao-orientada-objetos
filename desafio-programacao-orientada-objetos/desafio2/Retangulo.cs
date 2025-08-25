using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_programacao_orientada_objetos.desafio2
{
    class Retangulo
    {
        public Retangulo(double largura, double altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        public double Largura { get; }
        public double Altura { get; }

        public void CalcularArea()
        {
            double area = Largura * Altura;
            Console.WriteLine($"A área do retangulo é: {area} \n");
        }

        public void CalcularPerimetro()
        {
            double perimetro = (2 * Largura) + (2 * Altura);
            Console.WriteLine($"O perímetro do retangulo é: {perimetro} \n");
        }
    }
}
