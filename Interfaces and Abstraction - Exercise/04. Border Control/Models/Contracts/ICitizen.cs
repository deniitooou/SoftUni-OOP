using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface ICitizen : IIds
    {
        public string Name { get; }
        public int Age { get; }
    }
}
