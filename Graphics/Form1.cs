using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Graphics.Model;

namespace Graphics
{
	public partial class Form1 : Form
	{
		private Figure _figure;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			System.Drawing.Graphics g = e.Graphics;
			g.Clear(Color.White);
			_figure?.Show(g);
			if (_figure == null)
				return;
			for (int i = 0; i < 200; i++)
			{
				Thread.Sleep(10);
				_figure?.Move(g, 1, 0);
			}
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Xml files|*.xml";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				_figure = SerializerHelper.DeSerializeObject<Figure>(openFileDialog1.FileName);
				Refresh();
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Title = "Save an Xml File";
			saveFileDialog1.Filter = "Xml files|*.xml";
			saveFileDialog1.ShowDialog(); 
			if (saveFileDialog1.FileName != "")
			{
				SerializerHelper.SerializeObject(_figure, saveFileDialog1.FileName);
			}
		}
	}
}