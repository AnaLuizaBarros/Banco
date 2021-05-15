using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
    public class Usuario
    {
        string nome;
        double valor;

        public Usuario() { }
        public Usuario(string Nome, double Valor) {
            nome = Nome;
            valor = Valor;
        }
        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
