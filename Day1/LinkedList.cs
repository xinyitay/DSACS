using System;
namespace LinkedList
{
    public class LinkedList
    {
        public Node Head { set; get; }
        private int numElem;

        public LinkedList()
        {
            Head = null;
            numElem = 0;
        }

        private Node GetAt(int index)
        {
            Node currNode = Head;

            for (int i = 0; i < index; i++)
            {
                currNode = currNode.Next;
            }

            return currNode;
        }

        public void AddString(string newElement)
        {
            Node newNode = new Node(newElement);

            if (numElem == 0)
            {
                Head = newNode;
                return;
            }

            Node lastNode = GetAt(numElem - 1);
            lastNode.Next = newNode;
            numElem++;
        }

        public void Insert(int index, string newElement)
        {
            // why index <= numElem not index > ?
            if (index >= 0 && index <= numElem)
            {
                Node newNode = new Node(newElement);

                if (index == 0)
                {
                    newNode.Next = Head;
                    Head = newNode;
                }

                Node nodeBefore = GetAt(index - 1);
                Node nodeAfter = nodeBefore.Next;

                nodeBefore.Next = newNode;
                newNode.Next = nodeAfter;
            }

            numElem++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= numElem)
            {
                return;
            }

            if (index == 0)
            {
                Head = Head.Next;
                return;
            }

            Node nodeBefore = GetAt(index - 1);
            Node nodeToRemove = GetAt(index);

            nodeBefore.Next = nodeToRemove.Next;

            numElem--;
        }

        public int Count()
        {
            return numElem;
        }

        public void Replace(int index, string newElement)
        {
            if (index < 0 || index >= numElem)
            {
                return;
            }

            if (index >= 0 && index < numElem)
            {
                Node newNode = new Node(newElement);

                if (index >= 0)
                {
                    newNode.Next = Head.Next;
                    Head = newNode;                    
                }

                Node nodeBefore = GetAt(index - 1);
                Node nodeAfter = GetAt(index).Next;

                nodeBefore.Next = newNode;
                newNode.Next = nodeAfter;
            }                         
        }

        public bool Contains(string element)
        {
            for (int i = 0; i < numElem; i++)
            {
                if (element == GetAt(i).Data)
                {
                    return true;
                }
            }
            return false;
        }        
    }
}
