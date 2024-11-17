using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using At4;
using Microsoft.VisualBasic.CompilerServices;
using r7WPy;

namespace Dx74P;

[StandardModule]
public sealed class Mc3q4
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class e2L8Z
	{
		public static readonly e2L8Z _0024I;

		public static Func<Za3, double> _0024I17_002D0;

		static e2L8Z()
		{
			_0024I = new e2L8Z();
		}

		[SpecialName]
		internal double p1XGj(Za3 Ao08K)
		{
			return Ao08K.strength;
		}
	}

	public const int X = 0;

	public const int Y = 1;

	public const int Z = 2;

	private static object stdNum;

	public static int PI { get; set; }

	public static object j8R6A(this Za3 Ew14G)
	{
		double num = Ew14G.strength;
		double num2 = Ew14G.angle;
		object[] array = new object[2];
		object left = num;
		object instance = stdNum;
		object[] obj = new object[1] { num2 };
		object[] array2 = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array3 = obj2;
		object right = NewLateBinding.LateGet(instance, null, "Cos", obj, null, null, obj2);
		if (array3[0])
		{
			num2 = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(double));
		}
		array[0] = Operators.MultiplyObject(left, right);
		array[1] = num * Ae86B(num2);
		return i3E1F(array);
	}

	private static double Ae86B(double Yn15C)
	{
		throw new NotImplementedException();
	}

	private static object i3E1F(object[] Tq8p6)
	{
		throw new NotImplementedException();
	}

	public static object b9AKo(this Za3 i5W4Z)
	{
		throw new NotImplementedException();
	}

	public static Za3 n1EGk(Za3 Xb2y5, Za3 e5BPz)
	{
		if (Za3.Wk9(Xb2y5, 0.0))
		{
			return e5BPz;
		}
		if (Za3.Wk9(e5BPz, 0.0))
		{
			return Xb2y5;
		}
		if (Za3.Wk9(Xb2y5, 0.0) && Za3.Wk9(e5BPz, 0.0))
		{
			return new Za3();
		}
		double num = Xb2y5.angle - e5BPz.angle;
		object left = Za3.e7E(Xb2y5, 2.0) + Za3.e7E(e5BPz, 2.0);
		object left2 = Za3.z2X(Za3.w1Z(2, Xb2y5), e5BPz);
		object[] array;
		bool[] array2;
		object right = NewLateBinding.LateGet(stdNum, null, "Cos", array = new object[1] { num }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			num = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(double));
		}
		object objectValue = RuntimeHelpers.GetObjectValue(j4HXy(Operators.AddObject(left, Operators.MultiplyObject(left2, right))));
		if (Operators.ConditionalCompareObjectEqual(objectValue, 0.0, TextCompare: false))
		{
			num = Bx89Y(e5BPz.angle, Xb2y5.angle);
		}
		else
		{
			object obj = Operators.DivideObject(Za3.z2X(Ae86B(num), Xb2y5), objectValue);
			num = ((!(n4XTe(RuntimeHelpers.GetObjectValue(obj)) <= 1E-12)) ? (c5G4K(RuntimeHelpers.GetObjectValue(obj)) + e5BPz.angle) : ((Operators.ConditionalCompareObjectGreater(objectValue, Xb2y5, TextCompare: false) && Operators.ConditionalCompareObjectGreater(objectValue, e5BPz, TextCompare: false)) ? Bx89Y(Xb2y5.angle, e5BPz.angle) : ((!Za3.Jz5(Xb2y5, e5BPz)) ? e5BPz.angle : Xb2y5.angle)));
		}
		return new Za3
		{
			strength = Conversions.ToDouble(objectValue),
			angle = num,
			source = "ParallelogramLaw"
		};
	}

	private static double c5G4K(object Go41Z)
	{
		throw new NotImplementedException();
	}

	private static double n4XTe(object Yx84D)
	{
		throw new NotImplementedException();
	}

	private static double Bx89Y(double b9J7S, double Sx35F)
	{
		throw new NotImplementedException();
	}

	private static object j4HXy(object o1B9G)
	{
		throw new NotImplementedException();
	}

	public static Za3 Qn47E(this IEnumerable<Za3> c5F0L)
	{
		Za3 za = new Za3();
		foreach (Za3 item in c5F0L.OrderBy([SpecialName] (Za3 Ao08K) => Ao08K.strength))
		{
			za = Za3.Wn1(za, item);
		}
		return za;
	}

	public static Za3 Gn0d8(Ym57T Hs39N, double n3R5C = 9.8)
	{
		double d2Z = Hs39N.Mass * n3R5C;
		double am = (double)PI + 0.5 * (double)PI;
		return new Za3
		{
			strength = d2Z,
			angle = am,
			source = "Gravity"
		};
	}

	public static Za3 Hc26E()
	{
		throw new NotImplementedException();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double d4R2P(double d0A6E, double We5z6, double Qa8z0, double w4T6C = 9000000000.0)
	{
		return w4T6C * d0A6E * We5z6 / Math.Pow(Qa8z0, 2.0);
	}

	public static Za3 f9F4X(Ym57T n6D3W, Ym57T Xb12F, double Zt89M = 9000000000.0)
	{
		object instance = Operators.SubtractObject(n6D3W.Point, Xb12F.Point);
		double rg2p = d4R2P(n6D3W.Charge, Xb12F.Charge, Conversions.ToDouble(NewLateBinding.LateGet(instance, null, "SumMagnitude", new object[0], null, null, null)), Zt89M);
		Za3 za = k3YRi(rg2p, RuntimeHelpers.GetObjectValue(n6D3W.Point), RuntimeHelpers.GetObjectValue(Xb12F.Point));
		za.source = "CoulombsLaw";
		return za.ByRef;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double o6A8R(object Xd5e6, object Bp8x0)
	{
		object[] obj = new object[1] { Bp8x0 };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object left = NewLateBinding.LateGet(Xd5e6, null, "DotProduct", obj, null, null, obj2);
		if (array2[0])
		{
			Bp8x0 = RuntimeHelpers.GetObjectValue(array[0]);
		}
		return Conversions.ToDouble(Operators.DivideObject(left, Operators.MultiplyObject(NewLateBinding.LateGet(Xd5e6, null, "SumMagnitude", new object[0], null, null, null), NewLateBinding.LateGet(Bp8x0, null, "SumMagnitude", new object[0], null, null, null))));
	}

	public static Za3 k3YRi(double Rg2p0, object n0E4A, object f7P5W)
	{
		object instance = Operators.SubtractObject(n0E4A, f7P5W);
		double ef0x = o6A8R(Operators.SubtractObject(n0E4A, f7P5W), new int[2] { 100, 0 });
		object obj = RuntimeHelpers.GetObjectValue(Tz7p4(ef0x));
		if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateIndexGet(instance, new object[1] { 1 }, null), 0, TextCompare: false))
		{
			obj = Operators.AddObject(PI, Operators.SubtractObject(PI, obj));
		}
		return new Za3
		{
			strength = Rg2p0,
			angle = Conversions.ToDouble(obj),
			source = "RepulsiveForce"
		};
	}

	private static object Tz7p4(double Ef0x2)
	{
		throw new NotImplementedException();
	}

	public static Za3 Lt27W(double w8Q5Y, object j3DWs, object o5H1E)
	{
		Za3 za = Za3.k9X(k3YRi(w8Q5Y, RuntimeHelpers.GetObjectValue(j3DWs), RuntimeHelpers.GetObjectValue(o5H1E)));
		za.source = "AttractiveForce";
		return za.ByRef;
	}
}
