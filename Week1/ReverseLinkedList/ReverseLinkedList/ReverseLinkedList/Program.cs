namespace ReverseLinkedList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var reversed = ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
		}

		public static ListNode ReverseList(ListNode head)
		{
			ListNode node = null;

			while (head != null)
			{
				int currVal = head.val;

				if (node == null)
				{
					node = new ListNode(currVal);
				}
				else
				{
					ListNode tmp = new ListNode(currVal);
					tmp.next = node;
					node = tmp;
				}

				//iteration mechanism
				head = head.next;
			}

			return node;
		}
	}


	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
		}
	}
}
