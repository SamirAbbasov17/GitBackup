namespace LinkedListNodeExe
{
    using LinkedList;
    internal class Program
    {
        static void Main(string[] args)
        {

            #region GenericLinkedListExemple

                //EXEMPLE 1
                    //// Create a linked list of integers
                    //LinkedList<int> list = new LinkedList<int>();

                    //// Add some nodes to the list
                    //LinkedListNode<int> node1 = list.AddLast(10);
                    //LinkedListNode<int> node2 = list.AddLast(20);
                    //LinkedListNode<int> node3 = list.AddLast(30);

                    //// Traverse the list and print the elements
                    //LinkedListNode<int> currentNode = list.First;
                    //while (currentNode != null)
                    //{
                    //    Console.WriteLine(currentNode.Value);
                    //    currentNode = currentNode.Next;
                    //}

                    //// Remove the second node
                    //list.Remove(node2);

                    //// Traverse the list again and print the elements
                    //currentNode = list.First;
                    //Console.WriteLine("Ikinci node silinenden sonra listin veziyyeti: ");
                    //while (currentNode != null)
                    //{
                    //    Console.WriteLine(currentNode.Value);
                    //    currentNode = currentNode.Next;
                    //}

            #endregion

            #region NodeExemple

                //EXEMPLE 2

                    //Node nodeA = new();
                    //nodeA.Data = 865;

                    //Node nodeB = new();
                    //nodeB.Data = 344;

                    //Node nodeC = new();
                    //nodeC.Data = 888;

                    //Node nodeD = new();
                    //nodeD.Data = 222;

                    //nodeA.Next = nodeB;
                    //nodeB.Next = nodeC;
                    //nodeC.Next = nodeD;

            #endregion

            #region LinkedListExemple
                //EXEMPLE 3
                    LinkedLists linkedList = new();
                    linkedList.InsertFirst(1);
                    linkedList.InsertFirst(2);
                    linkedList.InsertFirst(3);
                    linkedList.InsertFirst(4);

                    linkedList.DeleteFirst();
                    linkedList.DeleteFirst();

                    linkedList.InsertLast(546);
                    linkedList.InsertLast(3434);

                    linkedList.DisplayList(); 
            #endregion




        }
    }
}