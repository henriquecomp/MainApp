using MainApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Application
    {
        private readonly IEmailService emailService;
        private readonly IPessoaService pessoaService;
        public Application(IEmailService emailService, IPessoaService pessoaService)
        {
            this.emailService = emailService;
            this.pessoaService = pessoaService;
        }

        public void Run()
        {
            emailService.SendEmail("xpto@mail.com");
        }
    }
}
