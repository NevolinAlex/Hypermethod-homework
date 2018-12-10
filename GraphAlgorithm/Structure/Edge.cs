using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm.Structure
{
	public class Edge
	{
		public Node First { get; set; }

		public Node Second { get; set; }

		public int Weight { get; set; }

		public Edge(Node first, Node second, int weight)
		{
			First = first;
			Second = second;
			Weight = weight;
		}

		public bool IsIncident(Node node)
		{
			return First == node || Second == node;
		}

		public Node OtherNode(Node node)
		{
			if (!IsIncident(node)) throw new ArgumentException();
			if (First == node) return Second;
			return First;
		}
	}
}