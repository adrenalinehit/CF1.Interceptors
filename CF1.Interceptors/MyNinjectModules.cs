using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF1.Interceptors
{
    public class MyNinjectModules : NinjectModule
    {
        public override void Load()
        {
            Bind<ITestService>().To<TestInterceptors>();
        }
    }
}
