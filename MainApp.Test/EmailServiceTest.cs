using MainApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;

namespace MainApp.Test
{
    public class EmailServiceTest : Configuration
    {
        private readonly IEmailService emailService;
        public EmailServiceTest()
        {
            this.emailService = ServiceProvider.GetService<IEmailService>();
        }

        [Fact]
        public void SendMail_ReturnsTo()
        {
            var result = emailService.SendEmail("teste@teste.com");
            Assert.Equal("teste@teste.com", result);
        }

    }
}
