using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab7_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resourceCount = 5;
            ResourceManager resourceManager = new ResourceManager(resourceCount);

            for (int i = 0; i < 10; i++)
            {
                int threadId = i;
                Thread thread = new Thread(() =>
                {
                    Resource acquiredResource = resourceManager.AcquireResource(threadId);
                    if (acquiredResource != null)
                    {
                        Console.WriteLine($"Thread {threadId} acquired resource {acquiredResource.Id}");
                        Thread.Sleep(1000); // Робота з ресурсом
                        Console.WriteLine($"Thread {threadId} released resource {acquiredResource.Id}");
                        resourceManager.ReleaseResource(acquiredResource);
                    }
                });

                thread.Start();
            }
        }
    }
}
