using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Services
{
    public interface IPessoaService
    {
        bool Add(string nome, string email);
        bool Get(string nome, string email);
    }
    public class PessoaService : IPessoaService
    {
        public bool Add(string nome, string email)
        {
            Console.WriteLine("Adicionei a pessoa");
            return true;
        }

        public bool Get(string nome, string email)
        {
            Console.WriteLine("Recuperei a pessoa");
            return true;
        }
    }
}
