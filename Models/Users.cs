using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCRUD.Models
{
    public class Users
    {
        public string name;
        public string email;

        public Users(string n, string e)
        {
            this.name = n;
            this.email = e;
        }
    }
}
