using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Login
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, int idade, string email, string senha)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
            Senha = senha;
        }
    }
}
