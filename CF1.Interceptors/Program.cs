using Ninject;
using System;

namespace CF1.Interceptors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var kernel = new StandardKernel(new[] { new MyNinjectModules()});

            var testing = kernel.Get<ITestService>();

            Console.WriteLine(testing.TestString());

            Console.ReadLine(); 

        }
    }
}
