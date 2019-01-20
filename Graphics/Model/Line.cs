using System.Drawing;

namespace Graphics.Model
{
	public class Line : Base
	{
		public int X1 { get; set; }
		public int Y1 { get; set; }

		public int X2 { get; set; }
		public int Y2 { get; set; }

		public Line()
		{
		}

		public Line(int x1, int y1, int x2, int y2)
		{
			X1 = x1;
			Y1 = y1;
			X2 = x2;
			Y2 = y2;
		}

		public override void Hide(System.Drawing.Graphics graphics)
		{
			Pen myPen = new Pen(Color.White);
			graphics.DrawLine(myPen, new Point(X1, Y1), new Point(X2, Y2));
		}

		public override void Show(System.Drawing.Graphics graphics)
		{
			Pen myPen = new Pen(Color);
			graphics.DrawLine(myPen, new Point(X1, Y1), new Point(X2, Y2));
		}

		public override void Move(System.Drawing.Graphics graphics, int dx, int dy)
		{
			Hide(graphics);
			X1 += dx;
			Y1 += dy;
			X2 += dx;
			Y2 += dy;
			Show(graphics);
		}
	}
}