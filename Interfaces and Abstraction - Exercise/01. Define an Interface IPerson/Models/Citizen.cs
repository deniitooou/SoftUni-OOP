using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => this.name;

        public int Age => this.age;
    }
}
