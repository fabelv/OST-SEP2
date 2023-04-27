using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface IWeatherData
    {
        void Attach (IView view);
        void Unattach (IView view);
    }
}
