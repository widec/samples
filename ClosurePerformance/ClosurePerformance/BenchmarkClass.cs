using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClosurePerformance
{
    public class BenchmarkClass
    {
        private int x;

        [Benchmark]
        public void ExecuteWithParameter()
        {
            int counter = 10;
            ExecuteAction(counter,
                (ct) =>
                {
                    x = ct + 2;
                });
        }

        [Benchmark]
        public void ExecuteWithLocalVariable()
        {
            int counter = 10;
            ExecuteAction(
               () =>
               {
                   x = counter + 2;
               });
        }

        public static void ExecuteAction(Action action)
        {
            action();
        }

        public static void ExecuteAction<T>(T actionObject, Action<T> action)
        {
            action(actionObject);
        }
    }
}
