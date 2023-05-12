using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinkedList
{
    public class LinkedListDemo
    {
        public void MethodLinkedList()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            //Addlast
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            foreach (int o in linkedList)
            {
                Console.WriteLine($"{o}");
            }
            //AddFirst
            linkedList.AddFirst(6);
            linkedList.AddFirst(7);
            linkedList.AddFirst(8);
            //Remove
            linkedList.Remove(linkedList.First);
            linkedList.Remove(7);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            foreach (int i in linkedList)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("Count  " + linkedList.Count);
        }
    }
}
