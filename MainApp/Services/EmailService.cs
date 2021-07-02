using MainApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Services
{
    public interface IEmailService
    {
        string SendEmail(string name);
    }
    public class EmailService : IEmailService
    {
        private readonly IDatabase database;
        public EmailService(IDatabase database)
        {
            this.database = database;
        }

        public string SendEmail(string name)
        {
            var email = database.GetEmail();
            return email;
        }
    }
}
