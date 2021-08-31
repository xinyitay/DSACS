using System;
namespace LinkedList
{
    public class Node
    {
        public Node(string data)
        {
            Data = data;
            Next = null;
        }

        public string Data { get; set; }
        public Node Next { get; set; }
    }
}
