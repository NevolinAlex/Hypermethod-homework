using System;
using System.Collections.Generic;

namespace QuickSort
{
	public class QSort
	{
		private static int Partition<T>(List<T> list, int from, int to)
			where T : IComparable<T>
		{
			int i = from;
			for (int j = from; j <= to; j++)
			{
				if (list[j].CompareTo(list[to]) <= 0)
				{
					T t = list[i]; 
					list[i] = list[j];
					list[j] = t; 
					i++; 
				}
			}

			return i - 1; 
		}

		public static void Quicksort<T>(List<T> list, int from, int to) where T : IComparable<T> 
		{
			if (from >= to) return;
			int c = Partition(list, from, to);
			Quicksort(list, from, c - 1);
			Quicksort(list, c + 1, to);
		}
	}
}