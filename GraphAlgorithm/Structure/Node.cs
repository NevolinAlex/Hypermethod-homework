using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm.Structure
{
	public class Node
	{
		public List<Edge> IncidentEdges { get; } = new List<Edge>();

		public int Index { get; set; }

		public Node(int number)
		{
			Index = number;
		}


		public static void Disconnect(Edge edge)
		{
			edge.First.IncidentEdges.Remove(edge);
			edge.Second.IncidentEdges.Remove(edge);
		}
	}
}