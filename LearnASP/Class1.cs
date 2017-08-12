using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnASP
{
    public class Customer
    {
        private int age;
        private string name;

        public Customer(string n,int a)
        {
            age = a;
            Name = n;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}