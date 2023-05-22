using System.Text;

namespace Data_Structures
{
    public class Node<T>
    {
        public T Key
        { get; set; }
        public Node<T> Next
        { get; set; }

        public Node(T key)
        {
            Key = key;
        }
    }

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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structures...!!!");
            Node<int> myFirstNode = new Node<int>(70);
            Node<int> mySecondNode = new Node<int>(40);
            Node<int> myThirdNode = new Node<int>(30);
            Node<int> myFourthNode = new Node<int>(20);
            Node<int> myFifthNode = new Node<int>(50);
            
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            myLinkedList.addLast(myFirstNode);
            myLinkedList.addLast(mySecondNode);
            myLinkedList.addLast(myThirdNode);
            myLinkedList.addLast(myFifthNode);

            myLinkedList.addAfter(mySecondNode, myFourthNode);

            myLinkedList.deleteFirst();
            myLinkedList.deleteLast();

            myLinkedList.deleteAfter(mySecondNode);

            myLinkedList.printLikedList();

        }
    }
}