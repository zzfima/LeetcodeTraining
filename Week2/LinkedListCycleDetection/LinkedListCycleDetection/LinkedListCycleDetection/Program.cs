namespace LinkedListCycleDetection
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ListNode n1 = new ListNode(1);
			ListNode n2 = new ListNode(2);
			ListNode n3 = new ListNode(3);
			ListNode n4 = new ListNode(4);

			n1.next = n2;
			n2.next = n3;
			n3.next = n4;
			n4.next = n2;

			bool isHasCycle = HasCycle(n1);

			Console.ReadLine();
		}
		static bool HasCycle(ListNode node)
		{

			HashSet<ListNode> visited = new();
			while (node != null)
			{
				if (visited.Contains(node))
					return true;
				visited.Add(node);
				node = node.next;
			}

			return false;
		}
	}
}
