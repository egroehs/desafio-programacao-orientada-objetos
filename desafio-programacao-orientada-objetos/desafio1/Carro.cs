using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_programacao_orientada_objetos.desafio1
{
    class Carro
    {
        public string Marca { get; }
        public string Modelo { get; }
        public int Ano { get; }

        public Carro(string marca, string modelo, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }
    }
}
