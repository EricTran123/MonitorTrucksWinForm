using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest.Model
{
    class User
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public DateTime createDate { get; set; }

        public User(String user, String password)
        {
            this.UserName = user;
            this.Password = password;
        }
    }
    
   
}
