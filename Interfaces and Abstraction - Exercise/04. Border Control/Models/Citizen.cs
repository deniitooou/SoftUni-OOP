using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : ICitizen
    {
        public Citizen(string id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }


        public string Name { get; }
        public int Age { get; }

        public string Id { get; }

        public bool IsValidId(string id)
        {
            if (this.Id.EndsWith(id)) return false;
            return true;
        }
    }
}
