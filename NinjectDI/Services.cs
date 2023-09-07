using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDI
{
    internal class Services : IService
    {
        public string GetString()
        {
            return "Hello";
        }
    }
}
