using Ninject.Extensions.Interception;
using System;
using System.Diagnostics;

namespace CF1.Interceptors.Timing
{
    public class TimingInterceptor : SimpleInterceptor
    {
        private Stopwatch _stopWatch = new Stopwatch();

        protected override void BeforeInvoke(IInvocation invocation)
        {
            _stopWatch.Start();
        }

        protected override void AfterInvoke(IInvocation invocation)
        {
            _stopWatch.Stop();
            var message = string.Format("Execution of {0} took {1}.", invocation.Request.Method, _stopWatch.Elapsed);
            Console.WriteLine(message);
            _stopWatch.Reset();
        }

    }
}
