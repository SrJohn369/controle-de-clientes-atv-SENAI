using System;
using controle_de_clientes_atv_SENAI.classes;

namespace controle_de_clientes_atv_SENAI
{
    class Program
    {
        public static void Main(string[] args)
        {
            float Valor_Pago;
            Console.WriteLine("Digite o nome do cliente: ");
            string? Nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço do cliente: ");
            string? Endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Fisica(pf) ou Pessoa Juridica(pj)");
            string? Tipo_Cliente = Console.ReadLine();
            if (Tipo_Cliente == "pf")
            {
                PessoaFisica pf = new();
                Console.WriteLine("Digite o CPF do cliente: ");
                pf.Cpf = Console.ReadLine();
                Console.WriteLine("Digite o RG do cliente: ");
                pf.Rg = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                Valor_Pago = float.Parse(Console.ReadLine());
            }
        }
    }
}

