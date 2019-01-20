using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Graphics.Model
{
	public class Rectangle : Base
	{
		public int X { get; set; }

		public int Y { get; set; }

		public int Width { get; set; }

		public int Height { get; set; }

		public Rectangle()
		{
		}

		public Rectangle(int x, int y, int width, int height)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}

		public override void Hide(System.Drawing.Graphics graphics)
		{
			SolidBrush myPen = new SolidBrush(Color.White);
			graphics.FillRectangle(myPen, X, Y, Width, Height);
		}

		public override void Show(System.Drawing.Graphics graphics)
		{
			SolidBrush myPen = new SolidBrush(Color);
			graphics.FillRectangle(myPen, X, Y, Width, Height);
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