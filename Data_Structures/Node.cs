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
}