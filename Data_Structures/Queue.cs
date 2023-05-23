namespace Data_Structures
{
    public class Queue
    {
        MyLinkedList<int> myQueue = new MyLinkedList<int>();

        public void enqueue(Node<int> node)
        {
            myQueue.addFirst(node);
            Console.WriteLine("My Queue after enqueue");
            myQueue.printLikedList();
        }

        public void dequeue()
        {
            myQueue.deleteLast();
            Console.WriteLine("My Queue after dequeue");
            myQueue.printLikedList();
        }
    }
}