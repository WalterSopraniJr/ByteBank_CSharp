using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBeatriz = new ContaCorrente();
            contaDaBeatriz.titular = "Beatriz";
            contaDaBeatriz.agencia = 112;
            contaDaBeatriz.numero = 86363;

            ContaCorrente contaDaBeatrizSoprani = new ContaCorrente();
            contaDaBeatrizSoprani.titular = "Beatriz Soprani";
            contaDaBeatrizSoprani.agencia = 112;
            contaDaBeatrizSoprani.numero = 86363;

            Console.WriteLine("As contas estão guardadas na mesma memória? " + (contaDaBeatriz == contaDaBeatrizSoprani));

            contaDaBeatriz = contaDaBeatrizSoprani;
            Console.WriteLine("As contas estão guardadas na mesma memória? " + (contaDaBeatriz == contaDaBeatrizSoprani));

            contaDaBeatriz.saldo = 300;
            Console.WriteLine(contaDaBeatriz.saldo);
            Console.WriteLine(contaDaBeatrizSoprani.saldo);


            Console.WriteLine();
            Console.WriteLine("Fim da aplicação. Tecle enter para encerrar...");
            Console.Read();
        }
    }
}
