using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNodeExe.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public void DisplayNode()
        {
            global::System.Console.WriteLine(Data);
        }
    }
}
