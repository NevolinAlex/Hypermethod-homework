using System;
using System.Linq;
using GraphAlgorithm;
using GraphAlgorithm.Structure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.Algorithms.Lab3
{
	[TestClass]
	public class DijkstraTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			var graph = MakeGraphFromImage();
			var result = AlgorithmDijkstra.Dijkstra(graph, graph.Nodes[1], graph.Nodes[30]);
			var resultAsString = string.Join(", ", result.Select(x => x.Index).ToList());
			Console.WriteLine(resultAsString);
		}

		private Graph MakeGraphFromImage()
		{
			var graph = new Graph(31);
			graph.Connect(1, 2, 1);
			graph.Connect(1, 7, 6);

			graph.Connect(2, 3, 1);
			graph.Connect(2, 8, 6);

			graph.Connect(3, 4, 1);
			graph.Connect(3, 9, 6);

			graph.Connect(4, 5, 1);
			graph.Connect(4, 10, 6);

			graph.Connect(5, 6, 1);
			graph.Connect(5, 11, 6);

			graph.Connect(6, 12, 1);

			graph.Connect(12, 11, 1);
			graph.Connect(12, 18, 6);

			graph.Connect(11, 10, 1);
			graph.Connect(11, 17, 6);

			graph.Connect(10, 9, 6);
			graph.Connect(10, 16, 1);

			graph.Connect(9, 8, 6);
			graph.Connect(9, 15, 6);


			graph.Connect(8, 7, 6);
			graph.Connect(8, 14, 6);

			graph.Connect(7, 13, 6);
			graph.Connect(14, 13, 6);
			graph.Connect(19, 13, 6);

			graph.Connect(14, 15, 6);
			graph.Connect(14, 20, 6);

			graph.Connect(19, 20, 6);
			graph.Connect(19, 25, 6);

			graph.Connect(26, 25, 6);

			graph.Connect(15, 16, 6);
			graph.Connect(15, 21, 6);

			graph.Connect(16, 17, 6);
			graph.Connect(16, 22, 1);

			graph.Connect(17, 18, 6);
			graph.Connect(17, 23, 6);

			graph.Connect(18, 24, 6);

			graph.Connect(24, 23, 6);
			graph.Connect(24, 30, 6);

			graph.Connect(23, 29, 6);
			graph.Connect(23, 22, 6);

			graph.Connect(22, 21, 1);
			graph.Connect(22, 28, 6);

			graph.Connect(21, 20, 1);
			graph.Connect(21, 27, 6);

			graph.Connect(20, 26, 1);

			graph.Connect(26, 27, 1);

			graph.Connect(27, 28, 1);

			graph.Connect(28, 29, 1);

			graph.Connect(29, 30, 6);

			return graph;
		}
	}
}