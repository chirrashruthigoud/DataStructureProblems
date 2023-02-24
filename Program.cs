using DataStructureProblems;
using System.Collections;
using System.Collections.Generic;

namespace StackAndQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Queue queue1 = new Queue();
            queue1.Enqueue(56);
            queue1.Enqueue(30);
            queue1.Enqueue(70);

            foreach (int i in queue1)
            {
                list.Add(i);
            }
            Console.WriteLine("\nTop of the queue : {0}", queue1.Peek());
            Console.WriteLine("************************");
        }
    }
}
