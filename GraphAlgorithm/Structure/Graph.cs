using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithm.Structure
{
	public class Graph
	{
		public List<Node> Nodes { get; set; }

		public Graph(int nodesCount)
		{
			Nodes = Enumerable.Range(0, nodesCount).Select(z => new Node(z)).ToList();
		}

		public Node this[int index] => Nodes[index];


		public void Connect(int index1, int index2, int weight)
		{
			Connect(Nodes[index1], Nodes[index2], weight);
		}

		private void Connect(Node node1, Node node2, int weight)
		{
			if (!Nodes.Contains(node1) || !Nodes.Contains(node2)) throw new ArgumentException();
			var edge = new Edge(node1, node2, weight);
			node1.IncidentEdges.Add(edge);
			node2.IncidentEdges.Add(edge);
		}

		public static Graph MakeGraph(params int[] incidentNodes)
		{
			var graph = new Graph(incidentNodes.Max() + 1);
			for (int i = 0; i < incidentNodes.Length - 1; i += 2)
				graph.Connect(incidentNodes[i], incidentNodes[i + 1], 1);
			return graph;
		}
	}
}