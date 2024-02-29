using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab7_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConflictLog conflictLog = new ConflictLog();

            Thread thread1 = new Thread(() => ExecuteOperations("Thread 1", conflictLog));
            Thread thread2 = new Thread(() => ExecuteOperations("Thread 2", conflictLog));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            conflictLog.DetectConflicts();

            Console.ReadLine();
        }

        static void ExecuteOperations(string threadId, ConflictLog conflictLog)
        {
            for (int i = 0; i < 5; i++)
            {
                conflictLog.AddOperation(threadId, $"Operation {i + 1}");
                Thread.Sleep(100); 
            }
        }
    }
}
