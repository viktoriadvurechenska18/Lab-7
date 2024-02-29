using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab7_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventSystem eventSystem = new EventSystem();
            Node node1 = new Node(1, eventSystem);
            Node node2 = new Node(2, eventSystem);

            eventSystem.RaiseEvent(1, "Hello from Node 1!");

            Node node3 = new Node(3, eventSystem);
            eventSystem.RaiseEvent(3, "Hello from Node 3!");

            eventSystem.MyEvent -= node2.HandleEvent;
            eventSystem.RaiseEvent(2, "Node 2 is no longer subscribed.");

            Console.ReadLine();
        }
    }
}
