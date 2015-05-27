using CF1.Interceptors.Timing;
using Ninject.Extensions.Interception.Attributes;
using System.Threading;

namespace CF1.Interceptors
{
    public class TestInterceptors : ITestService
    {
        //[DoNotIntercept]
        [Timed]
        public string TestString()
        {
            Thread.Sleep(3000);
            return "some string";
        }
    }
}
