using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        public string FirstName = "Test";
        public string LastName = "Filed";
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Age is wrong");
                }
                else
                {
                    _age = value;
                }
            }
        }
    }
}
