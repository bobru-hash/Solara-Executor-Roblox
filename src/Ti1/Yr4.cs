using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Ti1;

public class Yr4
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _initialPostion;

	public int neighborhoods { get; }

	public double[] size { get; set; }

	public double mass { get; set; }

	public object initialPostion
	{
		[CompilerGenerated]
		get
		{
			return _initialPostion;
		}
		[CompilerGenerated]
		set
		{
			_initialPostion = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public string origID { get; set; }

	public Point force { get; set; }

	public Brush color { get; set; }

	public double[] weights { get; set; }

	public int[] neighbours { get; set; }

	public double betweennessCentrality { get; set; }

	public Yr4()
	{
		mass = 1.0;
		initialPostion = null;
		origID = "";
	}

	public Yr4(Yr4 copy)
	{
		color = copy.color;
		force = copy.force;
		initialPostion = RuntimeHelpers.GetObjectValue(copy.initialPostion);
		mass = copy.mass;
		origID = copy.origID;
		size = ((copy.size == null) ? new double[0] : copy.size.ToArray());
	}

	public virtual Yr4 Cd7()
	{
		return new Yr4
		{
			betweennessCentrality = betweennessCentrality,
			color = color,
			force = force,
			initialPostion = RuntimeHelpers.GetObjectValue(new object()),
			mass = mass,
			origID = origID
		};
	}

	public float Lb8()
	{
		return (float)size[0];
	}

	public virtual string a7N()
	{
		return initialPostion.ToString();
	}
}
