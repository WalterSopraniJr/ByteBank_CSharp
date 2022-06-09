using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(414, 14514215);

            Console.WriteLine("Verificando conta pela Biblioteca");
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
