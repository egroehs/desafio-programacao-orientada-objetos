using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_programacao_orientada_objetos.desafio1
{
    class Pessoa
    {
        string Nome;
        int Idade;
        string Profissao;


        public List<Carro> Carros { get; set; } = new List<Carro>();

        public Pessoa(string nome, int idade, string profissao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Profissao = profissao;
        }

        public void AdicionarCarro(Carro carro)
        {
            Carros.Add(carro);
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Profissão: {Profissao}");
            Console.WriteLine("Carros: ");
            if (Carros.Count == 0)
            {
                Console.WriteLine("Nenhum carro cadastrado.");
            }
            else
            {
                foreach (var carro in Carros)
                {
                    Console.WriteLine($"  {carro.Marca} {carro.Modelo} ({carro.Ano})");
                }
            }

            Console.ReadLine();
        }
    }
}
