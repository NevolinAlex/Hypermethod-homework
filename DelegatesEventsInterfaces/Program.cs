using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelegatesEventsInterfaces.Model;

namespace DelegatesEventsInterfaces
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new PrimaryForm(CreateMethod()));
		}

		private static double Function(double x)
		{
			return x * x;
		}

		private static Method CreateMethod()
		{
			return new Method(Function);
		}
	}
}
