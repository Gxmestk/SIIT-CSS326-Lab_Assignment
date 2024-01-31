using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_6422770345
{
    public class User
    {
        public string title { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string user_group { get; set; }

        public User(string title, string fname, string lname, string email, string password, string username, string user_group)
        {
            this.title = title;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.password = password;
            this.username = username;
            this.user_group = user_group;
        }
    }
}
