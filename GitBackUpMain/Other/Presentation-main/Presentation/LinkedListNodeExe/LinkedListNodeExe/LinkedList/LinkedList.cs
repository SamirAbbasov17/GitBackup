using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNodeExe.LinkedList
{
    public class LinkedLists
    {
        public Node? First { get; set; }

        public void InsertFirst(int data)
        {
            //Crate the node
            Node newNode = new();
            //Put the data in the node
            newNode.Data = data;
            //Put the old node in next
            newNode.Next = First;
            //Make the first the new node
            First = newNode;
        }

        public Node DeleteFirst()
        {
            //Assign the temporary variable
            Node temp = First;
            //Assign the next node
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            global::System.Console.WriteLine("Iterating thru list...");
            Node current = First;
            while(current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new();
            newNode.Data = data;
            current.Next = newNode;
        }

    }
}
