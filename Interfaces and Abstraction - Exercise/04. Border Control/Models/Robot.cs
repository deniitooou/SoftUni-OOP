using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IIds
    {
       

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; }
        public string Id { get; }

        public bool IsValidId(string x)
        {
            if (this.Id.EndsWith(x)) return false;
            return true;
        }
    }
}
