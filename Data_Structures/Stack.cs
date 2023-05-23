namespace Data_Structures
{
    public class Stack
    {
        MyLinkedList<int> myStack = new MyLinkedList<int>();
        public void push(Node<int> node)
        {
            myStack.addFirst(node);
            Console.WriteLine("Linked list after push operation");
            myStack.printLikedList();
        }

        public void pop()
        {
            myStack.deleteFirst();
            Console.WriteLine("Linked list after pop operation");
            myStack.printLikedList();
        }
    }
}