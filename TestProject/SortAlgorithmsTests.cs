using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using QuickSort;
using TreeSort.Entities;

namespace TestProject
{
	[TestFixture]
	public class SortAlgorithmsTests
	{
		[Test]
		public void TreeSortTest1()
		{
			var expected = new List<int> {3, 5, 7, 9, 10, 10, 10, 13, 15, 18};
			var tree = new Tree<int>();
			tree.Add(10);
			tree.Add(10);
			tree.Add(15);
			tree.Add(5);
			tree.Add(7);
			tree.Add(9);
			tree.Add(3);
			tree.Add(13);
			tree.Add(18);
			tree.Add(10);
			var actual = tree.GetSorted();
			CollectionAssert.AreEqual(expected, actual);
		}

		[Test]
		public void TreeSortTest2()
		{
			var expected = new List<int>();
			var tree = new Tree<int>();

			Random rd = new Random();

			for (int i = 0; i < 100; i++)
			{
				var rdNumber = rd.Next(1, 101);
				expected.Add(rdNumber);
				tree.Add(rdNumber);
			}

			expected.Sort();
			CollectionAssert.AreEqual(expected, tree.GetSorted());
		}

		[Test]
		public void QuickSortTest1()
		{

			Random rd = new Random();

			var expected = new List<int>();
			var actual = new List<int>();
			for (int i = 0; i < 100000; i++)
			{
				var rdNumber = rd.Next(1, 101);
				expected.Add(rdNumber);
				actual.Add(rdNumber);
			}

			expected.Sort();
			QSort.Quicksort(actual, 0, actual.Count - 1);

			CollectionAssert.AreEqual(expected, actual);
		}
	}
}