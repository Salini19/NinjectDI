using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDI
{
    internal class BussinessLayer
    {
        private readonly IService _service;
        public BussinessLayer(IService service)
        {
            _service = service;
        }
        public void GetMethods()
        {
            Console.WriteLine(_service.GetString()); 

        }
    }
}
