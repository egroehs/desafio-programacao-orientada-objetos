using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_programacao_orientada_objetos.desafio3
{
    class ContaBancaria
    {
        public string Titular { get; }
        public double Saldo { get; private set; }
        public string NumeroConta { get; }

        public static List<ContaBancaria> TodasAsContas = new List<ContaBancaria>();
        public List<Movimentacao> Extrato { get; private set; } = new List<Movimentacao>();


        public ContaBancaria(string titular, double saldo, string numeroConta)
        {
            Titular = titular;
            Saldo = saldo;
            NumeroConta = numeroConta;

            TodasAsContas.Add(this);
        }

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
                Console.WriteLine($"Depósito concluido. O valor total na conta é de R${Saldo}.");

                Extrato.Add(new Movimentacao
                {
                    Data = DateTime.Now,
                    Tipo = "Depósito",
                    Valor = valorDeposito
                });

            }
            else
            {
                Console.WriteLine("O valor para depósito deve ser maior que 0.");
            }


        }

        public void Sacar(double valorSaque)
        {
            if (valorSaque > 0 && valorSaque <= Saldo)
            {
                Saldo -= valorSaque;
                Console.WriteLine($"Saque concluido. O valor total na conta é de R${Saldo}.");

                Extrato.Add(new Movimentacao
                {
                    Data = DateTime.Now,
                    Tipo = "Saque",
                    Valor = valorSaque
                });

            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }

        }

        public bool Transferir(ContaBancaria contaDestino, double valorTransferencia)
        {
            if (valorTransferencia <= 0)
            {
                Console.WriteLine("Valor inválido para transferência.");
                return false;
            }
            if (Saldo >= valorTransferencia)
            {
                this.Saldo -= valorTransferencia;
                contaDestino.Saldo += valorTransferencia;
                Console.WriteLine($"Transferência de R${valorTransferencia} para {contaDestino.Titular} realizada com sucesso.");

                Extrato.Add(new Movimentacao
                {
                    Data = DateTime.Now,
                    Tipo = "Transferência",
                    Valor = valorTransferencia
                });

                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para a transferência.");
                return false;
            }
        }

        static public void VerRelatorioDeContas()
        {
            var numeroDeContas = TodasAsContas.Count();

            double totalSaldos = 0;

            foreach (ContaBancaria conta in TodasAsContas)
            {
                totalSaldos += conta.Saldo;

            }
            Console.WriteLine("=== Relatório de Contas ===");
            Console.WriteLine($"Número total de contas: {numeroDeContas}");
            Console.WriteLine($"Saldo total somado: R${totalSaldos:F2}\n");
        }

        static public void AplicarTaxaDeJuros(double taxaPercentual)
        {
            if(taxaPercentual < 0) {
                Console.WriteLine("A taxa não pode ser negativa.");
                return;
            }

            foreach (ContaBancaria conta in TodasAsContas)
            {
                double taxaAplicada = conta.Saldo * (taxaPercentual / 100);
                conta.Saldo -= taxaAplicada;

                Console.WriteLine($"Conta {conta.NumeroConta}: Taxa de R${taxaAplicada:F2} aplicada.");
            }

            Console.WriteLine($"\nTaxa de {taxaPercentual}% aplicada a todas as contas.");
        }

        static public void ConsultarContasNegativadas()
        {
            foreach (ContaBancaria conta in TodasAsContas)
            {
                if(conta.Saldo < 0)
                {
                    Console.WriteLine($"A conta {conta.NumeroConta} esta negativada. O saldo é de: R${conta.Saldo}");
                }                 
            }
        }

        public void VerExtrato(int dias)
        {
            if (dias != 30 && dias != 60 && dias != 90)
            {
                Console.WriteLine("Período inválido. Use 30, 60 ou 90 dias.");
                return;
            }

            Console.WriteLine($"Extrato da conta {NumeroConta} dos últimos {dias} dias:");
            DateTime limite = DateTime.Now.AddDays(-dias);

            foreach (var mov in Extrato.Where(m => m.Data >= limite))
            {
                Console.WriteLine($"{mov.Data:dd/MM/yyyy HH:mm} - {mov.Tipo} - R${mov.Valor:F2}");
            }
        }
    }
}
