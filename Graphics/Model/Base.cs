using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Graphics.Helpers;

namespace Graphics.Model
{
	public abstract class Base
	{
		[XmlElement(Type = typeof(XmlColor))]
		public Color Color { get; set; }


		public abstract void Hide(System.Drawing.Graphics graphics);

		public abstract void Show(System.Drawing.Graphics graphics);

		public abstract void Move(System.Drawing.Graphics graphics, int dx, int dy);
	}
}