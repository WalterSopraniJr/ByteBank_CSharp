using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBeatriz = new ContaCorrente();
            contaDaBeatriz.titular = "Beatriz Soprani";
            contaDaBeatriz.agencia = 112;
            contaDaBeatriz.numero = 86363;
            contaDaBeatriz.saldo = 1000;

            Console.WriteLine("Conta Corrente");
            Console.WriteLine("Titular: " + contaDaBeatriz.titular);
            Console.WriteLine("Agência: " + contaDaBeatriz.agencia);
            Console.WriteLine("Número: " + contaDaBeatriz.numero);
            Console.WriteLine("Saldo: R$" + contaDaBeatriz.saldo);




            Console.ReadLine();
        }
    }
}
