using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal interface IPartnerState
    {
        void Talk();
        void Kiss();
        void Insult();
    }
}
