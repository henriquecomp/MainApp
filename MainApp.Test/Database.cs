using MainApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Test
{
    public class DatabaseFake : IDatabase
    {
        public string GetEmail()
        {
            return "fakedb@fakedb.com";
        }
    }
}
