using System.Drawing;
using System.Xml.Serialization;

namespace Graphics.Model
{
	public class Circle : Base
	{
		public int Y { get; set; }

		public int X { get; set; }

		public int R { get; set; }

		public Circle()
		{
		}

		public Circle(int x, int y, int r)
		{
			X = x;
			Y = y;
			R = r;
		}

		public override void Hide(System.Drawing.Graphics graphics)
		{
			Pen myPen = new Pen(Brushes.White);
			graphics.DrawEllipse(myPen, X, Y, R, R);
		}

		public override void Show(System.Drawing.Graphics graphics)
		{
			Pen myPen = new Pen(Color);
			graphics.DrawEllipse(myPen, X, Y, R, R);
		}

		public override void Move(System.Drawing.Graphics graphics, int dx, int dy)
		{
			Hide(graphics);
			X += dx;
			Y += dy;
			Show(graphics);
		}
	}
}