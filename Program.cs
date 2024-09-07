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
                PessoaFisica pf = new()
                {
                    Nome = Nome,
                    Endereco = Endereco
                };
                Console.WriteLine("Digite o CPF do cliente: ");
                pf.Cpf = Console.ReadLine();
                Console.WriteLine("Digite o RG do cliente: ");
                pf.Rg = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                Valor_Pago = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(Valor_Pago);

                Console.WriteLine(@$"
                --------- Pessoa Fisica ----------
                    Nome .......... {pf.Nome} 
                    Endereço ...... {pf.Endereco} 
                    CPF ........... {pf.Cpf} 
                    RG ............ {pf.Rg} 
                    Valor Pago .... {pf.Valor.ToString("C")}
                    Valor Imposto . {pf.Valor_Imposto.ToString("C")} 
                    Total ......... {pf.Total.ToString("C")}");
            }
            else if (Tipo_Cliente == "pj")
            {
                PessoaJuridica pj = new()
                {
                    Nome = Nome,
                    Endereco = Endereco
                };
                Console.WriteLine("Digite o CNPJ do cliente: ");
                pj.Cnpj = Console.ReadLine();
                Console.WriteLine("Digite o IE do cliente: ");
                pj.Ie = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                Valor_Pago = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(Valor_Pago);

                Console.WriteLine(@$"
                --------- Pessoa Fisica ----------
                    Nome .......... {pj.Nome} 
                    Endereço ...... {pj.Endereco} 
                    CPF ........... {pj.Cnpj} 
                    RG ............ {pj.Ie} 
                    Valor Pago .... {pj.Valor.ToString("C")}
                    Valor Imposto . {pj.Valor_Imposto.ToString("C")} 
                    Total ......... {pj.Total.ToString("C")}");
            }

        }
    }
}

