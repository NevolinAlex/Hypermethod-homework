using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DelegatesEventsInterfaces.Model;

namespace DelegatesEventsInterfaces
{
	public partial class PrimaryForm : Form
	{
		private Method Method { get; }

		private Algorythm dihitomiaAlgorythm = new Dihotimia();

		private Algorythm iterationAlgorythm = new Iteration();

		private Main main = new Main();

		public PrimaryForm(Method method)
		{
			Method = method;
			InitializeComponent();
			equationString.Text = Main.FunctionToString() + " = 0";
		}

		private void calculateIntegral_Click(object sender, EventArgs e)
		{
			try
			{
				int a = Int32.Parse(leftIntegralBorder.Text);
				int b = Int32.Parse(rightIntegralBorder.Text);
				resultIntegralLabel.Text = Method.OnIntegrateEvent(a, b).ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex < 0)
			{
				MessageBox.Show("Необходимо выбрать алгоритм нахождения корня", "Предупреждение", MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			try
			{
				Algorythm algorythm = null;
				switch (comboBox1.SelectedIndex)
				{
					case 0:
						algorythm = dihitomiaAlgorythm;
						break;
					case 1:
						algorythm = iterationAlgorythm;
						break;
				}

				resultEquationLabel.Text = main.Root(Main.Function, algorythm,
					Convert.ToDouble(leftEquationBorder.Text),
					Convert.ToDouble(rightEquationBorder.Text)).ToString("F6");
			}
			catch (Exception)
			{
				MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}
	}
}