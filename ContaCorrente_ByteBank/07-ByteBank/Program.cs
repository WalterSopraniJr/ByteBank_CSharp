using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(166,1648575);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento com problema: " + e.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção causada por saldo insuficiente.");
            }
            

            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("ERRO - Tentativa de divisão por 0");
            }
            catch (Exception e) // esse 'e' significa Exception
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Ocorreu um erro.");
            }

            Console.WriteLine("Fim da aplicação...");
            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(1);
        }
        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor " + divisor);
                throw; //lança a exceção que aconteceu no bloco (ao invés de usar return)
            }
        }
    }
}
