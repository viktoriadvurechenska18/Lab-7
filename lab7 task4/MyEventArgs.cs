using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_task4
{
    public class MyEventArgs : EventArgs
    {
        public int NodeId { get; }
        public string Message { get; }

        public MyEventArgs(int nodeId, string message)
        {
            NodeId = nodeId;
            Message = message;
        }
    }
}
