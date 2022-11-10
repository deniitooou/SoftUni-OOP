using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IIds
    {
        public string Id { get; }

        public bool IsValidId(string id);

    }
}
