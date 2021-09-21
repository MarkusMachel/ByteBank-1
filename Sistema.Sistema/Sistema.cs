using System;
using Funcionarios.Common;

namespace Sistema.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema!");
                return true;
            }
            else 
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}

