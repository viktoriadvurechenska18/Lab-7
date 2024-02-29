using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_task4
{
    internal class Node
    {
        private int nodeId;
        private EventSystem eventSystem;

        public Node(int nodeId, EventSystem eventSystem)
        {
            this.nodeId = nodeId;
            this.eventSystem = eventSystem;
            eventSystem.MyEvent += HandleEvent;
        }

        public void HandleEvent(object sender, MyEventArgs e)
        {
            Console.WriteLine($"Node {nodeId} received event: {e.Message} from Node {e.NodeId}");
        }
    }
}
