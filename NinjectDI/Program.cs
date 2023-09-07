using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IService service=kernel.Get<IService>();
            BussinessLayer bs = new BussinessLayer(service);
            bs.GetMethods();
            Console.ReadLine();
        }
    }
}
