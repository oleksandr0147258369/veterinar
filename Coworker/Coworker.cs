using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworker_namespace
{
    class Coworker
    {
        public string name { get; set; }
        public DateTime date { get; set; }
        public string number { set; get; }
        public string email { get; set; }
        public string position { get; set; }
        public string resps { get; set; }
        public int salary { get; set; }

        public Coworker()
        {
            name = "";
            date = DateTime.MinValue;
            number = "";
            email = "";
            position = "";
            resps = "";
            salary = 0;
        }

        public Coworker(string name, DateTime date, string number, string email, string position, string resps, int salary)
        {
            this.name = name;
            this.date = date;
            this.number = number;
            this.email = email;
            this.position = position;
            this.resps = resps;
            this.salary = salary;
        }

        public void SetNumber(string n) { number = n; }
        public void GetNumber() { Console.WriteLine(number); }
        public void SetName(string n) { name = n; }
        public void GetName() { Console.WriteLine("Name - {0}", name); }
        public void SetEmail(string n) { email = n; }
        public void GetEmail() { Console.WriteLine("Email - {0}", email); }
        public void SetPosition(string n) { position = n; }
        public void GetPosition() { Console.WriteLine("Position - {0}", position); }
        public void SetResps(string n) { resps = n; }
        public void GetResps() { Console.WriteLine("Responsibilities - {0}", resps); }
        public void SetDate(DateTime date) { this.date = date; }
        public void GetDate() { Console.WriteLine("Date of birth - {0}", date.ToShortDateString()); }
        public void SetSalary(int n) { salary = n; }
        public void GetSalary() { Console.WriteLine("Salary - {0}", salary); }

        public static Coworker operator +(Coworker t, int a)
        {
            t.salary += a;
            return t;
        }
        public static Coworker operator -(Coworker t, int a)
        {
            t.salary -= a;
            return t;
        }
        public static bool operator ==(Coworker a, Coworker b)
        {
            return a.salary == b.salary;
        }
        public static bool operator !=(Coworker a, Coworker b)
        {
            return a.salary != b.salary;
        }
        public static bool operator <(Coworker a, Coworker b)
        {
            return a.salary < b.salary;
        }
        public static bool operator >(Coworker a, Coworker b)
        {
            return a.salary > b.salary;
        }
    }
}
