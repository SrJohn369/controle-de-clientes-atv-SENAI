using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controle_de_clientes_atv_SENAI.classes
{
    public class PessoaJuridica : Cliente
    {
        public string ? Cnpj {get; set;}
        public string ? Ie {get; set;}

        public override void Pagar_Imposto(float v) 
        {
            // polimorfismo
            this.Valor = v;
            this.Valor_Imposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.Valor_Imposto;
        }
    }
}