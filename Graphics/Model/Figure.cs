using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Graphics.Model
{
	public class Figure
	{
		[XmlElement(typeof(Circle))]
		[XmlElement(typeof(Line))]
		[XmlElement(typeof(Rectangle))]
		public List<Base> Elements { set; get; }

		public Figure(List<Base> elements)
		{
			Elements = elements;
		}

		public Figure()
		{
			Elements = new List<Base>();
		}

		public void Add(Base el)
		{
			Elements.Add(el);
		}

		public void Show(System.Drawing.Graphics graphics)
		{
			Elements.ForEach(x => x.Show(graphics));
		}

		public void Move(System.Drawing.Graphics graphics, int dx, int dy)
		{
			Elements.ForEach(x => x.Move(graphics, dx, dy));
		}

		public void SetColor(Color color)
		{
			Elements.ForEach(x => x.Color = color);
		}
	}
}