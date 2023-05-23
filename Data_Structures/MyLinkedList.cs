using System.Text;

namespace Data_Structures
{
    public class MyLinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public MyLinkedList() 
        {
            head = null;
            tail = null;
        }

        public void addFirst(Node<T> node)
        {
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                Node<T> tempNode = head;
                head = node;
                head.Next = tempNode;
            }
        }

        public void addLast(Node<T> node) 
        {
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                Node<T> tempNode = tail;
                tempNode.Next = node;
                tail = node;
            }
        }

        public void addAfter(Node<T> myNode, Node<T> newNode)
        {
            Node<T> tempNode = myNode;
            newNode.Next = myNode.Next;
            tempNode.Next = newNode;
        }

        public void deleteFirst()
        {
            head = head.Next;
        }

        public void deleteLast()
        {
            Node<T> tempNode = head;
            while (!tempNode.Next.Equals(tail)) 
            {
                tempNode = tempNode.Next;
            }

            tail = tempNode;
            tail.Next = null;
        }

        public void deleteAfter(Node<T> node)
        {
            Node<T> tempNode = node.Next;
            node.Next = tempNode.Next;
        }

        public void printLikedList()
        {
            StringBuilder myLinkedList = new StringBuilder();
            Node<T> tempNode = head;
            while (tempNode.Next != null) 
            {
                myLinkedList.Append(tempNode.Key);
                if (!tempNode.Equals(tail))
                    myLinkedList.Append("->");
                tempNode = tempNode.Next;
            }
            myLinkedList.Append(tempNode.Key);
            Console.WriteLine(myLinkedList);
        }
    }
}