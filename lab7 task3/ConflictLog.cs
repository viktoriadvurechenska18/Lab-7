using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_task3
{
    internal class ConflictLog
    {
        private readonly object lockObject = new object();
        private readonly List<Operation> operations = new List<Operation>();

        public void AddOperation(string threadId, string operationDetails)
        {
            lock (lockObject)
            {
                Operation operation = new Operation(threadId, operationDetails);
                operations.Add(operation);
                Console.WriteLine($"Operation added: {operation}");
            }
        }

        public void DetectConflicts()
        {
            lock (lockObject)
            {
                for (int i = 0; i < operations.Count - 1; i++)
                {
                    for (int j = i + 1; j < operations.Count; j++)
                    {
                        if (operations[i].ConflictWith(operations[j]))
                        {
                            Console.WriteLine($"Conflict detected between {operations[i]} and {operations[j]}");
                        }
                    }
                }
            }
        }
    }
}
