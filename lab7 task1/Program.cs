using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_task1
{
    internal class Program
    {
        static async Task Main()
        {
            DistributedSystemNode node1 = new DistributedSystemNode("Node1");
            DistributedSystemNode node2 = new DistributedSystemNode("Node2");

            node1.ConnectToNode(node2);
            node2.ConnectToNode(node1);

            var task1 = node1.StartAsync();
            var task2 = node2.StartAsync();

            await Task.Delay(5000);

            node1.Stop();

            await Task.WhenAll(task1, task2);
        }
    }
}
