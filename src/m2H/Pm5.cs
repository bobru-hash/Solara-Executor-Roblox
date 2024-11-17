using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Fp60;
using Microsoft.VisualBasic.CompilerServices;
using o2NB;

namespace m2H;

public class Pm5
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class f0R
	{
		public static readonly f0R _0024I;

		public static o2NB.r2RA<object, object> _0024I9_002D0;

		public static o2NB.r2RA<object, object> _0024I9_002D1;

		static f0R()
		{
			_0024I = new f0R();
		}

		[SpecialName]
		internal object x4D(object e2N)
		{
			return NewLateBinding.LateGet(e2N, null, "label", new object[0], null, null, null);
		}

		[SpecialName]
		internal object Ro2(object Nn5)
		{
			object instance;
			object[] obj = new object[1] { NewLateBinding.LateGet(instance = NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null) };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object result = NewLateBinding.LateGet(Nn5, null, "data", obj, null, null, obj2);
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(instance, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
			}
			return result;
		}
	}

	[CompilerGenerated]
	internal sealed class t8H
	{
		public object _0024VB_0024Local_Cset;

		public double _0024VB_0024Local_m;

		public t8H(t8H arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_Cset = arg0._0024VB_0024Local_Cset;
				_0024VB_0024Local_m = arg0._0024VB_0024Local_m;
			}
		}

		[SpecialName]
		internal double b0D(object Qr2, object z4C)
		{
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(_0024VB_0024Local_Cset, null, "Length", new object[0], null, null, null), 1));
			double num4 = default(double);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(_0024VB_0024Local_Cset, new object[1] { i }, null));
				double num2 = 0.0;
				object[] array;
				bool[] array2;
				object value = NewLateBinding.LateGet(NewLateBinding.LateGet(Qr2, null, "adjacencies", new object[0], null, null, null), null, "hasNeighbor", array = new object[1] { objectValue }, null, null, array2 = new bool[1] { true });
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (Conversions.ToBoolean(value))
				{
					num2 = 1.0;
				}
				object left = Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Qr2, null, "degree", new object[0], null, null, null), null, "In", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(Qr2, null, "degree", new object[0], null, null, null), null, "Out", new object[0], null, null, null));
				object right = Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "degree", new object[0], null, null, null), null, "In", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(Qr2, null, "degree", new object[0], null, null, null), null, "Out", new object[0], null, null, null));
				double num3 = Conversions.ToDouble(Operators.SubtractObject(num2, Operators.DivideObject(Operators.MultiplyObject(left, right), 2.0 * _0024VB_0024Local_m)));
				num4 += num3;
			}
			return num4;
		}
	}

	[CompilerGenerated]
	internal sealed class b9M
	{
		public string _0024VB_0024Local_prefix;

		public b9M(b9M arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_prefix = arg0._0024VB_0024Local_prefix;
			}
		}

		[SpecialName]
		internal string Ss6(string o5E)
		{
			return $"{_0024VB_0024Local_prefix}{o5E}";
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _NamesOf;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _Louvain;

	public static object NamesOf
	{
		[CompilerGenerated]
		get
		{
			return _NamesOf;
		}
		[CompilerGenerated]
		set
		{
			_NamesOf = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object Louvain
	{
		[CompilerGenerated]
		get
		{
			return _Louvain;
		}
		[CompilerGenerated]
		set
		{
			_Louvain = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static Dictionary<string, string> Qq3(object g3K)
	{
		return (Dictionary<string, string>)NewLateBinding.LateGet(NewLateBinding.LateGet(g3K, null, "vertex", new object[0], null, null, null), null, "ToDictionary", new object[2]
		{
			(o2NB.r2RA<object, object>)([SpecialName] (object e2N) => NewLateBinding.LateGet(e2N, null, "label", new object[0], null, null, null)),
			(o2NB.r2RA<object, object>)([SpecialName] (object Nn5) =>
			{
				object instance;
				object[] obj = new object[1] { NewLateBinding.LateGet(instance = NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null) };
				object[] array = obj;
				bool[] obj2 = new bool[1] { true };
				bool[] array2 = obj2;
				object result = NewLateBinding.LateGet(Nn5, null, "data", obj, null, null, obj2);
				if (array2[0])
				{
					NewLateBinding.LateSetComplex(instance, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
				}
				return result;
			})
		}, null, null, null);
	}

	public static Dictionary<string, object> k0K(object Le3)
	{
		Dictionary<string, List<object>> dictionary = new Dictionary<string, List<object>>();
		foreach (object item in (IEnumerable)NewLateBinding.LateGet(Le3, null, "vertex", new object[0], null, null, null))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			object[] array;
			object instance;
			bool[] array2;
			object obj = NewLateBinding.LateGet(objectValue, null, "data", array = new object[1] { NewLateBinding.LateGet(instance = NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null) }, null, null, array2 = new bool[1] { true });
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(instance, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
			}
			string text = Conversions.ToString(obj);
			if (Conversions.ToBoolean(text))
			{
				text = "n/a";
			}
			if (!dictionary.ContainsKey(text))
			{
				dictionary.Add(text, new List<object>());
			}
			dictionary[text].Add(RuntimeHelpers.GetObjectValue(objectValue));
		}
		return null;
	}

	public static double z2Q(object Gd5, [Optional][DefaultParameterValue(null)] ref double[] Zd0)
	{
		double num = Conversions.ToDouble(Operators.DivideObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Gd5, null, "ComputeNodeDegrees", new object[0], null, null, null), null, "Values", new object[0], null, null, null), null, "Sum", new object[0], null, null, null), 2));
		List<double> list = new List<double>();
		Dictionary<string, object> dictionary = k0K(RuntimeHelpers.GetObjectValue(Gd5));
		foreach (KeyValuePair<string, object> item2 in dictionary)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item2.Value);
			double item = Ne3(RuntimeHelpers.GetObjectValue(objectValue), num);
			list.Add(item);
		}
		double num2 = list.Sum();
		double result = 1.0 / (2.0 * num) * num2;
		Zd0 = list.ToArray();
		return result;
	}

	private static double Ne3(object x3H, double s6Q)
	{
		t8H arg = default(t8H);
		t8H CS_0024_003C_003E8__locals6 = new t8H(arg);
		CS_0024_003C_003E8__locals6._0024VB_0024Local_Cset = x3H;
		CS_0024_003C_003E8__locals6._0024VB_0024Local_m = s6Q;
		return Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(CS_0024_003C_003E8__locals6._0024VB_0024Local_Cset, null, "AsParallel", new object[0], null, null, null), null, "Select", new object[1] { (Fp60.p4QE<object, object, double>)([SpecialName] (object Qr2, object z4C) =>
		{
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(CS_0024_003C_003E8__locals6._0024VB_0024Local_Cset, null, "Length", new object[0], null, null, null), 1));
			double num4 = default(double);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(CS_0024_003C_003E8__locals6._0024VB_0024Local_Cset, new object[1] { i }, null));
				double num2 = 0.0;
				object[] array;
				bool[] array2;
				object value = NewLateBinding.LateGet(NewLateBinding.LateGet(Qr2, null, "adjacencies", new object[0], null, null, null), null, "hasNeighbor", array = new object[1] { objectValue }, null, null, array2 = new bool[1] { true });
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (Conversions.ToBoolean(value))
				{
					num2 = 1.0;
				}
				object left = Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(Qr2, null, "degree", new object[0], null, null, null), null, "In", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(Qr2, null, "degree", new object[0], null, null, null), null, "Out", new object[0], null, null, null));
				object right = Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "degree", new object[0], null, null, null), null, "In", new object[0], null, null, null), NewLateBinding.LateGet(NewLateBinding.LateGet(Qr2, null, "degree", new object[0], null, null, null), null, "Out", new object[0], null, null, null));
				double num3 = Conversions.ToDouble(Operators.SubtractObject(num2, Operators.DivideObject(Operators.MultiplyObject(left, right), 2.0 * CS_0024_003C_003E8__locals6._0024VB_0024Local_m)));
				num4 += num3;
			}
			return num4;
		}) }, null, null, null), null, "Sum", new object[0], null, null, null));
	}

	public static object Fx2(ref object j6D, bool Qx9 = true)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		foreach (object item in (IEnumerable)NewLateBinding.LateGet(j6D, null, "graphEdges", new object[0], null, null, null))
		{
			object objectValue2 = RuntimeHelpers.GetObjectValue(item);
			object[] array;
			object instance;
			bool[] array2;
			NewLateBinding.LateCall(NewLateBinding.LateIndexGet(objectValue, new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "U", new object[0], null, null, null), null, "label", new object[0], null, null, null) }, null), null, "Add", array = new object[1] { NewLateBinding.LateGet(instance = NewLateBinding.LateGet(objectValue2, null, "V", new object[0], null, null, null), null, "label", new object[0], null, null, null) }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(instance, null, "label", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
			}
			NewLateBinding.LateCall(NewLateBinding.LateIndexGet(objectValue, new object[1] { NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "V", new object[0], null, null, null), null, "label", new object[0], null, null, null) }, null), null, "Add", array = new object[1] { NewLateBinding.LateGet(instance = NewLateBinding.LateGet(objectValue2, null, "U", new object[0], null, null, null), null, "label", new object[0], null, null, null) }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(instance, null, "label", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
			}
		}
		object objectValue3 = RuntimeHelpers.GetObjectValue(new object());
		object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, null, "Analysis", new object[0], null, null, null));
		objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue4, null, "Item1", new object[0], null, null, null));
		foreach (object item2 in (IEnumerable)NewLateBinding.LateGet(objectValue, null, "Keys", new object[0], null, null, null))
		{
			object objectValue5 = RuntimeHelpers.GetObjectValue(item2);
			foreach (object item3 in (IEnumerable)NewLateBinding.LateIndexGet(objectValue, new object[1] { objectValue5 }, null))
			{
				string text = Conversions.ToString(item3);
				object[] array;
				bool[] array2;
				object instance = NewLateBinding.LateGet(j6D, null, "GetElementByID", array = new object[1] { text }, null, null, array2 = new bool[1] { true });
				if (array2[0])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				NewLateBinding.LateSetComplex(instance, null, "data", new object[2]
				{
					NewLateBinding.LateGet(NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null),
					objectValue5
				}, null, null, OptimisticSet: false, RValueBase: true);
			}
		}
		return j6D;
	}

	public static object Xt9(ref object Ga0, double g9C = 1E-05, string Eq7 = null)
	{
		b9M arg = default(b9M);
		b9M CS_0024_003C_003E8__locals3 = new b9M(arg);
		CS_0024_003C_003E8__locals3._0024VB_0024Local_prefix = Eq7;
		object instance = NewLateBinding.LateGet(Louvain, null, "Builder", new object[0], null, null, null);
		object[] array = new object[2];
		array[1] = Ga0;
		array[0] = g9C;
		object[] array2;
		object[] arguments = (array2 = array);
		string[] argumentNames = new string[1] { "eps" };
		bool[] obj = new bool[2] { true, true };
		bool[] array3 = obj;
		object instance2 = NewLateBinding.LateGet(instance, null, "Load", arguments, argumentNames, null, obj);
		if (array3[1])
		{
			Ga0 = RuntimeHelpers.GetObjectValue(array2[1]);
		}
		if (array3[0])
		{
			g9C = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(double));
		}
		string[] array4 = (string[])NewLateBinding.LateGet(NewLateBinding.LateGet(instance2, null, "SolveClusters", new object[0], null, null, null), null, "GetCommunity", new object[0], null, null, null);
		if (~Conversions.ToLong(CS_0024_003C_003E8__locals3._0024VB_0024Local_prefix) != 0)
		{
			array4 = array4.Select([SpecialName] (string o5E) => $"{CS_0024_003C_003E8__locals3._0024VB_0024Local_prefix}{o5E}").ToArray();
		}
		foreach (object item in (IEnumerable)NewLateBinding.LateGet(Ga0, null, "vertex", new object[0], null, null, null))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			NewLateBinding.LateSet(objectValue, null, "data", new object[2]
			{
				NewLateBinding.LateGet(NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null),
				array4[Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "ID", new object[0], null, null, null))]
			}, null, null);
		}
		return Ga0;
	}
}
