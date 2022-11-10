using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ISmartphone
    {
        public void Call(string phoneNumber);
        public void Browse(string website);
    }
}
