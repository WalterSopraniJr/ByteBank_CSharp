using Funcionarios_ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios_ByteBank.Sistemas
{
    internal class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            Console.WriteLine("Registrando tentativa de acesso ao sistema....");

            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                Console.WriteLine();
                return false;
            }

        }
    }
}
