using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Tn2;

namespace b4K;

[StandardModule]
public sealed class j0T
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class q3H
	{
		public static readonly q3H _0024I;

		public static Func<string, string, double> _0024I12_002D0;

		static q3H()
		{
			_0024I = new q3H();
		}

		[SpecialName]
		internal double e3L(string w9N, string s1T)
		{
			return (Operators.CompareString(w9N, s1T, TextCompare: false) == 0) ? 1 : 0;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _Scripting;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _ClassConnectivity;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _GraphTopology;

	public static object Scripting
	{
		[CompilerGenerated]
		get
		{
			return _Scripting;
		}
		[CompilerGenerated]
		set
		{
			_Scripting = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object ClassConnectivity
	{
		[CompilerGenerated]
		get
		{
			return _ClassConnectivity;
		}
		[CompilerGenerated]
		set
		{
			_ClassConnectivity = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object GraphTopology
	{
		[CompilerGenerated]
		get
		{
			return _GraphTopology;
		}
		[CompilerGenerated]
		set
		{
			_GraphTopology = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static double Pt1(object Gi0, object y4W, double Yr4 = 0.85, Func<string, string, double> k2R = null, bool e2B = false)
	{
		if (k2R == null)
		{
			k2R = [SpecialName] (string w9N, string s1T) => (Operators.CompareString(w9N, s1T, TextCompare: false) == 0) ? 1 : 0;
		}
		if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(Gi0, null, "size", new object[0], null, null, null), null, "vertex", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(y4W, null, "size", new object[0], null, null, null), null, "vertex", new object[0], null, null, null), TextCompare: false))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Gi0);
			Gi0 = RuntimeHelpers.GetObjectValue(y4W);
			y4W = RuntimeHelpers.GetObjectValue(objectValue);
		}
		int num3 = default(int);
		foreach (object item in (IEnumerable)NewLateBinding.LateGet(Gi0, null, "vertex", new object[0], null, null, null))
		{
			object objectValue2 = RuntimeHelpers.GetObjectValue(item);
			double num = -99999.0;
			foreach (object item2 in (IEnumerable)NewLateBinding.LateGet(y4W, null, "vertex", new object[0], null, null, null))
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(item2);
				double num2 = Kc4(RuntimeHelpers.GetObjectValue(objectValue2), RuntimeHelpers.GetObjectValue(objectValue3), k2R, e2B);
				if (num2 > num)
				{
					num = num2;
				}
			}
			if (num >= Yr4)
			{
				num3 = checked(num3 + 1);
			}
		}
		int num4 = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(num3, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Gi0, null, "vertex", new object[0], null, null, null), null, "Count", new object[0], null, null, null), num3)), Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(y4W, null, "vertex", new object[0], null, null, null), null, "Count", new object[0], null, null, null), num3)));
		return (double)num3 / (double)num4;
	}

	public static double Kc4(object Rk7, object Le9, Func<string, string, double> w8B, bool c8J = true)
	{
		string text = Scripting.ToString();
		object instance;
		object[] obj = new object[1] { NewLateBinding.LateGet(instance = k7X.NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null) };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object value = NewLateBinding.LateGet(Rk7, null, "data", obj, null, null, obj2);
		if (array2[0])
		{
			NewLateBinding.LateSetComplex(instance, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
		}
		string arg = Conversions.ToString(text[Conversions.ToInteger(value)]);
		string text2 = Scripting.ToString();
		value = NewLateBinding.LateGet(Le9, null, "data", array = new object[1] { NewLateBinding.LateGet(instance = k7X.NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null) }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			NewLateBinding.LateSetComplex(instance, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
		}
		string arg2 = Conversions.ToString(text2[Conversions.ToInteger(value)]);
		double num = w8B(arg, arg2);
		if (num == 0.0)
		{
			return 0.0;
		}
		return Mp8(RuntimeHelpers.GetObjectValue(Rk7), RuntimeHelpers.GetObjectValue(Le9), c8J) * num;
	}

	public static double Mp8(object r3N, object r7S, bool Lw7 = true)
	{
		object instance = ClassConnectivity;
		object[] obj = new object[2] { r3N, r7S };
		object[] array = obj;
		bool[] obj2 = new bool[2] { true, true };
		bool[] array2 = obj2;
		object value = NewLateBinding.LateGet(instance, null, "MeasureCosValue", obj, null, null, obj2);
		if (array2[0])
		{
			r3N = RuntimeHelpers.GetObjectValue(array[0]);
		}
		if (array2[1])
		{
			r7S = RuntimeHelpers.GetObjectValue(array[1]);
		}
		double num = Conversions.ToDouble(value);
		if (Lw7)
		{
			object left = num;
			object instance2 = GraphTopology;
			object[] obj3 = new object[2] { r3N, r7S };
			array = obj3;
			bool[] obj4 = new bool[2] { true, true };
			array2 = obj4;
			object right = NewLateBinding.LateGet(instance2, null, "TopologyCos", obj3, null, null, obj4);
			if (array2[0])
			{
				r3N = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (array2[1])
			{
				r7S = RuntimeHelpers.GetObjectValue(array[1]);
			}
			object left2 = Operators.MultiplyObject(left, right);
			object right2 = NewLateBinding.LateGet(GraphTopology, null, "VertexDistanceCos", array = new object[2] { r3N, r7S }, null, null, array2 = new bool[2] { true, true });
			if (array2[0])
			{
				r3N = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (array2[1])
			{
				r7S = RuntimeHelpers.GetObjectValue(array[1]);
			}
			return Conversions.ToDouble(Operators.MultiplyObject(left2, right2));
		}
		return num;
	}

	public static IEnumerable<string> Qm3(this object Ag3)
	{
		if (NewLateBinding.LateGet(Ag3, null, "adjacencies", new object[0], null, null, null) == null)
		{
			return new string[0];
		}
		IEnumerable<string> result = default(IEnumerable<string>);
		return result;
	}
}
