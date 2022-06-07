using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios_ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionário");

            Salario = salario;
            CPF = cpf;

            TotalDeFuncionarios++;
        }



        public abstract void AumentarSalario(); //método abstrato para que as classes filhas precisem implementar os métodos
        public abstract double GetBonificacao();

    }
}
