using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IRobot : IIds
    {
        public string Model { get; }
    }
}
