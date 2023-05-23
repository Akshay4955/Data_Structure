namespace Data_Structures;

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

        myLinkedList.addAfter(mySecondNode, myFourthNode);

        myLinkedList.deleteFirst();
        myLinkedList.deleteLast();

        myLinkedList.deleteAfter(mySecondNode);
   
        myLinkedList.printLikedList();
        
        Stack stack = new Stack();
        stack.push(myThirdNode);
        stack.push(myFourthNode);
        stack.push(myFifthNode);
        
        stack.pop();

        Queue queue = new Queue();
        queue.enqueue(myThirdNode);
        queue.enqueue(mySecondNode);
        queue.enqueue(myFirstNode);

        queue.dequeue();
    }
}