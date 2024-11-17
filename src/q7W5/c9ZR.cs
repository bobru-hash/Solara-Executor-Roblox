using System;
using System.Collections.Generic;
using System.Drawing;

namespace q7W5;

public class c9ZR
{
	internal string label;

	public double length { get; set; }

	public object[] bends { get; set; }

	public Pen style { get; set; }

	public Dictionary<string, string> Properties { get; set; }

	public c9ZR()
	{
		length = 1.0;
	}

	public c9ZR(c9ZR copy)
	{
		length = copy.length;
		Properties = new Dictionary<string, string>(copy.Properties);
	}

	public virtual string Yz6g()
	{
		return Jt13();
	}

	private string Jt13()
	{
		throw new NotImplementedException();
	}

	public c9ZR Rz82()
	{
		Pen a1CR = null;
		if (style != null)
		{
			a1CR = new Pen(style.Color, style.Width)
			{
				DashStyle = style.DashStyle
			};
		}
		c9ZR c9ZR2 = new c9ZR();
		object obj = default(object);
		c9ZR2.bends = (object[])obj;
		c9ZR2.style = a1CR;
		c9ZR2.length = length;
		c9ZR2.Properties = new Dictionary<string, string>(Properties);
		return c9ZR2;
	}
}
