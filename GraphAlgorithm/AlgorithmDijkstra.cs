using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphAlgorithm.Structure;

namespace GraphAlgorithm
{
	public class AlgorithmDijkstra
	{
		public static List<Node> Dijkstra(Graph graph, Node start, Node end)
		{
			var notVisited = graph.Nodes;
			var track = new Dictionary<Node, DijkstraData>
			{
				[start] = new DijkstraData {Price = 0, Previous = null}
			};

			while (true)
			{
				Node toOpen = null;
				var bestPrice = double.PositiveInfinity;
				foreach (var e in notVisited)
				{
					if (track.ContainsKey(e) && track[e].Price < bestPrice)
					{
						bestPrice = track[e].Price;
						toOpen = e;
					}
				}

				if (toOpen == null)
					return null;
				if (toOpen == end) break;

				foreach (var e in toOpen.IncidentEdges.Where(z => z.First == toOpen))
				{
					var currentPrice = track[toOpen].Price + e.Weight;
					var nextNode = e.OtherNode(toOpen);
					if (!track.ContainsKey(nextNode) || track[nextNode].Price > currentPrice)
					{
						track[nextNode] = new DijkstraData {Previous = toOpen, Price = currentPrice};
					}
				}
				
				notVisited.Remove(toOpen);
			}

			var result = new List<Node>();
			while (end != null)
			{
				result.Add(end);
				end = track[end].Previous;
			}

			result.Reverse();
			return result;
		}
	}
}