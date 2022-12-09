using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace trabalhopoopt2
{
    class Funcionario : IPessoa
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public Funcionario(string cpf, string Nome, string login, string password) 
        { 
            this.cpf= cpf;
            this.nome= nome;
            this.login= login;
            this.password= password;
        }
        public bool loginValido(string password2) { 
            return this.password == password2;
        }
    }
}
