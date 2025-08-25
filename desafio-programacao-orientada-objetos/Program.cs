using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using desafio_programacao_orientada_objetos.desafio1;
using desafio_programacao_orientada_objetos.desafio2;
using desafio_programacao_orientada_objetos.desafio3;

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

            ContaBancaria conta1 = new ContaBancaria("Eduarda Groehs", 10000, "123");
            ContaBancaria conta2 = new ContaBancaria("Ana Banana", 1000, "113");
            ContaBancaria conta3 = new ContaBancaria("Gabriela Silva", 2500, "122");

            conta1.Sacar(500);
            conta1.Transferir(conta2, 500);
            conta1.VerExtrato(30);
            conta2.Depositar(1000);
            ContaBancaria.AplicarTaxaDeJuros(20);
            conta3.Sacar(10);
            conta3.VerExtrato(30);
            conta3.Transferir(conta1, 3000);
            ContaBancaria.ConsultarContasNegativadas();
            ContaBancaria.VerRelatorioDeContas();


            Console.ReadLine();

        }

    }
    
}
