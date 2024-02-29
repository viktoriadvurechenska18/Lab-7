using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_task3
{
    internal class Operation
    {
        public string ThreadId { get; }
        public string Details { get; }
        public DateTime Timestamp { get; }

        public Operation(string threadId, string details)
        {
            ThreadId = threadId;
            Details = details;
            Timestamp = DateTime.Now;
        }

        public bool ConflictWith(Operation other)
        {
            return false;
        }

        public override string ToString()
        {
            return $"[{Timestamp}] Thread {ThreadId}: {Details}";
        }
    }
}
