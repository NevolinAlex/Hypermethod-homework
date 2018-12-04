using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TreeSort.Entities
{
	public class Tree<T> where T: IComparable
	{
		private Node<T> Root { get; set; }

		public void Add(T value)
		{
			if (Root == null)
				Root = new Node<T>(value);
			else
				Root.Insert(value);
		}

		public List<T> GetSorted()
		{
			var result = new List<T>();
			Root?.GetSorted(result);
			return result;
		}
	}
}
