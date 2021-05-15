using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    public class Dados
    {
        double valor;

        public Dados() { }
        public Dados(double Valor) {
            valor = Valor;
        }

        public double Valor {get;set;}
    }
}
