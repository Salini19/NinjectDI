using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDI
{
    public class NinjectMod : Ninject.Modules.NinjectModule 
    {
        public override void Load()
        {
            Bind<IService>().To<Services>();
        }
    }
}
