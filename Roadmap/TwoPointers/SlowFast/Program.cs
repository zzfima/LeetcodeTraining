namespace SlowFast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);

            LinkedListNode<int> node = FindMiddleOfLinkedList(list);
        }

        static LinkedListNode<int> FindMiddleOfLinkedList(LinkedList<int> values)
        {
            var slow = values.First;
            var fast = values.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}
