using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_task4
{
    internal class EventSystem
    {
        public event EventHandler<MyEventArgs> MyEvent;

        public void RaiseEvent(int nodeId, string message)
        {
            MyEvent?.Invoke(this, new MyEventArgs(nodeId, message));
        }
    }
}
