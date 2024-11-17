using System.Diagnostics;
using System.Runtime.CompilerServices;
using At4;
using Bq4t;
using Dx74P;
using Microsoft.VisualBasic.CompilerServices;

namespace r7WPy;

public class Ym57T
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _Point;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _Velocity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _Acceleration;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _Physics;

	public double Mass { get; set; }

	public object Point
	{
		[CompilerGenerated]
		get
		{
			return _Point;
		}
		[CompilerGenerated]
		set
		{
			_Point = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public double Charge { get; set; }

	public object Velocity
	{
		[CompilerGenerated]
		get
		{
			return _Velocity;
		}
		[CompilerGenerated]
		set
		{
			_Velocity = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Acceleration
	{
		[CompilerGenerated]
		get
		{
			return _Acceleration;
		}
		[CompilerGenerated]
		set
		{
			_Acceleration = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Jp35.j8N4 World => (Jp35.j8N4)Conversions.ToByte(NewLateBinding.LateGet(Point, null, "Count", new object[0], null, null, null));

	public string ID { get; set; }

	public object Physics
	{
		[CompilerGenerated]
		get
		{
			return _Physics;
		}
		[CompilerGenerated]
		set
		{
			_Physics = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public void Dm43J()
	{
		Point = Operators.AddObject(Point, Velocity);
	}

	public virtual string r7T5P()
	{
		if (Operators.ConditionalCompareObjectEqual(World, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Physics, null, "World", new object[0], null, null, null), null, "Type", new object[0], null, null, null), null, "Plain2D", new object[0], null, null, null), TextCompare: false))
		{
			return NewLateBinding.LateGet(Point, null, "Vector2D", new object[0], null, null, null).ToString();
		}
		return Point.ToString();
	}

	[SpecialName]
	public static Ym57T Gb5y0(Ym57T o9WJc, Za3 a7K1A)
	{
		Ym57T ym57T = o9WJc;
		object objectValue = RuntimeHelpers.GetObjectValue(Mc3q4.j8R6A(a7K1A) ?? Mc3q4.b9AKo(a7K1A));
		object right = Operators.DivideObject(objectValue, ym57T.Mass);
		Ym57T ym57T2;
		(ym57T2 = ym57T).Acceleration = Operators.AddObject(ym57T2.Acceleration, right);
		ym57T = null;
		return o9WJc;
	}
}
