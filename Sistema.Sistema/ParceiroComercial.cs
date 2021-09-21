using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Sistema
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }   
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}