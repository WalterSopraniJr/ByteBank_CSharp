using Funcionarios_ByteBank.Funcionarios;
using Funcionarios_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {

            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor walter = new Diretor("222.222.222-22");
            walter.Nome = "Walter";
            walter.Senha = "12345";

            GerenteDeConta johnny = new GerenteDeConta("222.222.222-24");
            johnny.Nome = "Johnny";
            johnny.Senha = "salad";

            sistemaInterno.Logar(walter, "12345");
            sistemaInterno.Logar(johnny, "salad");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "comprar";
            sistemaInterno.Logar(parceiro, "comprar");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Diretor walter = new Diretor("222.222.222-22");
            walter.Nome = "Walter";

            Designer beatriz = new Designer("222.222.222-23");
            beatriz.Nome = "Beatriz";

            GerenteDeConta johnny = new GerenteDeConta("222.222.222-24");
            johnny.Nome = "Johnny";

            Auxiliar aldo = new Auxiliar("222.222.222-25");
            aldo.Nome = "Aldo";

            Desenvolvedor victor = new Desenvolvedor("222.222.222-26");
            victor.Nome = "Victor";

            gerenciadorBonificacao.Registrar(walter);
            gerenciadorBonificacao.Registrar(beatriz);
            gerenciadorBonificacao.Registrar(johnny);
            gerenciadorBonificacao.Registrar(aldo);
            gerenciadorBonificacao.Registrar(victor);

            Console.WriteLine("O total pago de bonificação foi de R$" + 
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
