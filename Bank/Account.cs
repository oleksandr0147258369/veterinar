using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Account_namespace
{
    class Account
    {
        public string username { set; get; }
        public int password { set; get; }
        public int number { set; get; }
        public Account()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            username = "";
            password = r.Next(100, 999);
            number = r.Next(1000, 9999);
        }
        public Account(string username)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            this.username = username;
            password = r.Next(100, 999);
            number = r.Next(1000, 9999);
        }
        public override string ToString()
        {
            return $"Username - {username}\nNumber - {number}\nPassword - ***";
        }
        public int GetPassword() { return password; }
        public bool CheckPassword(int p) { return password == p; }
    }
}
