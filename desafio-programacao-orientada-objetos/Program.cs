using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using desafio_programacao_orientada_objetos.desafio1;
using desafio_programacao_orientada_objetos.desafio2;

namespace desafio_programacao_orientada_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("João", 51, "Médico");

            Carro carro1 = new Carro("Toyota", "Corolla", 2020);
            Carro carro2 = new Carro("Honda", "Civic", 2018);

            pessoa1.AdicionarCarro(carro1);
            pessoa1.AdicionarCarro(carro2);

            pessoa1.ExibirInformacoes();

            Retangulo retangulo = new Retangulo(2, 4);
            retangulo.CalcularArea();
            retangulo.CalcularPerimetro();
               


            Console.ReadLine();

        }

    }
    
}
