using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Database
{
    public interface IDatabase
    {
        string GetEmail();
    }


    public class Database : IDatabase
    {
        public string GetEmail()
        {
            return "MainApp@MainApp.com";
        }
    }
}
