using System.Collections.Generic;

namespace ConsoleApp1
{
	public class GenericList<T>
	{
		private Node head;

		public GenericList()
		{
			head = null;
		}
		// The nested class is also generic on T.
		private class Node
		{
			// T as private member data type.
			private T data;
			private Node next;

			// T used in non-generic constructor.
			public Node(T t)
			{
				next = null;
				data = t;
			}

			public Node Next
			{
				get { return next; }
				set { next = value; }
			}

			// T as return type of property.
			public T Data
			{
				get { return data; }
				set { data = value; }
			}
		}

		// T as method parameter type:
		public void AddHead(T t)
		{
			Node n = new Node(t);
			n.Next = head;
			head = n;
		}

		public IEnumerator<T> GetEnumerator()
		{
			Node current = head;

			while (current != null)
			{
				yield return current.Data;
				current = current.Next;
			}
		}
	}
}
