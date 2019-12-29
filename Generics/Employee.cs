using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

        public class Employee
        {
            public Employee()
            {
                name = "";
                surname = "";
                salary = 0.00;
            }
            public Employee(string aName, string aSurname, double aSalary)
            {
                this.name = aName;
                surname = aSurname;
                salary = aSalary;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            /* {
                 return name;
             }*/

            public void setName(string myName)
            {
                name = myName;
            }
            string Surname { get; set; }
            double Salary { get; set; }
            public virtual string Display()
            {
                return "Name: " + name + " " + "\t" + "Surname: " + surname + " " + "\t" + "Salary: " + salary;
            }
            internal virtual void AcceptInput()
            {
                Console.WriteLine("Enter name");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter surname");
                surname = Console.ReadLine().ToString();
                Console.WriteLine("Enter salary");
                salary = Convert.ToDouble(Console.ReadLine());

            }

            private string name;
            private string surname;
            private double salary;
        }
    

}
