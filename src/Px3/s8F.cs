using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ao3d;
using Hk0x;
using k7B1;
using Microsoft.VisualBasic.CompilerServices;

namespace Px3;

[StandardModule]
public sealed class s8F
{
	public interface Yd7<r5M> where r5M : Gk26
	{
		r5M data { get; set; }
	}

	[CompilerGenerated]
	internal sealed class Tg5<Lf9, Lo3> where Lf9 : Gk26 where Lo3 : Yd7<Lf9>
	{
		public PropertyInfo _0024VB_0024Local_reader;

		[SpecialName]
		internal object e4P(Lo3 Lp5)
		{
			return _0024VB_0024Local_reader.GetValue(Lp5);
		}

		[SpecialName]
		internal object Xc8(Lo3 y6T)
		{
			return _0024VB_0024Local_reader.GetValue(y6T.data);
		}
	}

	public static Func<c1Y9, object> z3Y(this string Hy1, [Optional][DefaultParameterValue(null)] ref Type z2J)
	{
		if (Operators.CompareString(Hy1, "group", TextCompare: false) == 0 || Operators.CompareString(Hy1, "degree", TextCompare: false) == 0)
		{
		}
		Func<c1Y9, object> result = default(Func<c1Y9, object>);
		return result;
	}

	public static Func<c0Q, object> g6Q<Nz9, c0Q>(this string c2K, ref Type No3) where Nz9 : Gk26 where c0Q : Yd7<Nz9>
	{
		Tg5<Nz9, c0Q> tg = new Tg5<Nz9, c0Q>();
		object[] obj = new object[1] { c2K };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object instance = default(object);
		object value = NewLateBinding.LateGet(instance, null, "ContainsKey", obj, null, null, obj2);
		if (array2[0])
		{
			c2K = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		if (Conversions.ToBoolean(value))
		{
			tg._0024VB_0024Local_reader = (PropertyInfo)NewLateBinding.LateIndexGet(instance, new object[1] { c2K }, null);
			No3 = tg._0024VB_0024Local_reader.PropertyType;
			return tg._Lambda_0024__0;
		}
		object instance2 = default(object);
		value = NewLateBinding.LateGet(instance2, null, "ContainsKey", array = new object[1] { c2K }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			c2K = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		if (Conversions.ToBoolean(value))
		{
			tg._0024VB_0024Local_reader = (PropertyInfo)NewLateBinding.LateIndexGet(instance2, new object[1] { c2K }, null);
			No3 = tg._0024VB_0024Local_reader.PropertyType;
			return tg._Lambda_0024__1;
		}
		No3 = typeof(string);
		Func<c0Q, object> result = default(Func<c0Q, object>);
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Func<Mq41, object> Jm3(this string Nb8, [Optional][DefaultParameterValue(null)] ref Type i9P)
	{
		Func<Mq41, object> result = default(Func<Mq41, object>);
		return result;
	}
}
