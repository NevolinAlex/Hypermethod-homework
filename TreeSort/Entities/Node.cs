using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace TreeSort.Entities
{
	public class Node<T> where T : IComparable
	{
		public T Value { get; set; }

		public Node<T> Left { get; set; }

		public Node<T> Right { get; set; }

		public Node(T value)
		{
			Value = value;
		}

		internal void Insert(T value)
		{
			var result = value.CompareTo(Value);
			if (result < 0)
			{
				if (Left == null)
					Left = new Node<T>(value);
				else
					Left.Insert(value);
			}
			else
			{
				if (Right == null)
					Right = new Node<T>(value);
				else
					Right.Insert(value);
			}
		}

		internal void GetSorted(List<T> result)
		{
			Left?.GetSorted(result);
			result.Add(Value);
			Right?.GetSorted(result);
		}
	}
}