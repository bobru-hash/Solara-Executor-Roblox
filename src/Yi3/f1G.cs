using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using a8J6;
using Em85;
using Hk0x;
using Jk5y;
using Microsoft.VisualBasic.CompilerServices;
using Tp6z;
using Zo3y;

namespace Yi3;

[StandardModule]
public sealed class f1G
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class d3P
	{
		public static readonly d3P _0024I;

		public static Tp6z.m9L0<object, object> _0024I9_002D0;

		public static Tp6z.m9L0<object, object> _0024I9_002D1;

		public static Zo3y.k3CR<object, object> _0024I12_002D0;

		public static Func<int, double> _0024I12_002D2;

		public static a8J6.a5NB<object, object[]> _0024I13_002D0;

		public static Em85.Am61<object, object> _0024I13_002D1;

		public static Em85.Am61<object, object> _0024I13_002D2;

		public static Jk5y.Nr8w<object, object> _0024I13_002D3;

		static d3P()
		{
			_0024I = new d3P();
		}

		[SpecialName]
		internal object q5L(object Xi9)
		{
			return NewLateBinding.LateGet(Xi9, null, "source", new object[0], null, null, null);
		}

		[SpecialName]
		internal object Gy4(object Qg9)
		{
			return NewLateBinding.LateGet(Qg9, null, "target", new object[0], null, null, null);
		}

		[SpecialName]
		internal object Xg9(object Ty9)
		{
			return NewLateBinding.LateGet(Ty9, null, "Key", new object[0], null, null, null);
		}

		[SpecialName]
		internal double q9P(int Ta1)
		{
			return Ta1;
		}

		[SpecialName]
		internal object[] x1C(object r0T)
		{
			return new object[2]
			{
				NewLateBinding.LateGet(NewLateBinding.LateGet(r0T, null, "U", new object[0], null, null, null), null, "label", new object[0], null, null, null),
				NewLateBinding.LateGet(NewLateBinding.LateGet(r0T, null, "V", new object[0], null, null, null), null, "label", new object[0], null, null, null)
			};
		}

		[SpecialName]
		internal object m2R(object t7M)
		{
			return t7M;
		}

		[SpecialName]
		internal object j3P(object To1)
		{
			return NewLateBinding.LateGet(To1, null, "Key", new object[0], null, null, null);
		}

		[SpecialName]
		internal object Fo5(object e0M)
		{
			return NewLateBinding.LateGet(e0M, null, "Count", new object[0], null, null, null);
		}
	}

	[CompilerGenerated]
	internal sealed class s7H
	{
		public int _0024VB_0024Local_base;

		public s7H(s7H arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_base = arg0._0024VB_0024Local_base;
			}
		}

		[SpecialName]
		internal object Cb9(object t0K)
		{
			return Operators.AddObject(NewLateBinding.LateGet(t0K, null, "Value", new object[0], null, null, null), _0024VB_0024Local_base);
		}
	}

	private static object edges;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _GraphNetwork;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _DijkstraRouter;

	public static object GraphNetwork
	{
		[CompilerGenerated]
		get
		{
			return _GraphNetwork;
		}
		[CompilerGenerated]
		set
		{
			_GraphNetwork = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object DijkstraRouter
	{
		[CompilerGenerated]
		get
		{
			return _DijkstraRouter;
		}
		[CompilerGenerated]
		set
		{
			_DijkstraRouter = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static object Mq4(this object c3P)
	{
		object instance = GraphNetwork;
		object[] obj = new object[3]
		{
			edges,
			(Tp6z.m9L0<object, object>)([SpecialName] (object Xi9) => NewLateBinding.LateGet(Xi9, null, "source", new object[0], null, null, null)),
			(Tp6z.m9L0<object, object>)([SpecialName] (object Qg9) => NewLateBinding.LateGet(Qg9, null, "target", new object[0], null, null, null))
		};
		object[] array = obj;
		bool[] array2;
		object result = NewLateBinding.LateGet(instance, null, "ComputeDegreeData", obj, null, null, array2 = new bool[3] { true, false, false });
		if (array2[0])
		{
			edges = RuntimeHelpers.GetObjectValue(array[0]);
		}
		return result;
	}

	public static Dictionary<string, int> n2D(this object Hb7)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		foreach (object item in (IEnumerable)NewLateBinding.LateGet(Hb7, null, "Out", new object[0], null, null, null))
		{
			KeyValuePair<string, int> keyValuePair = ((item != null) ? ((KeyValuePair<string, int>)item) : default(KeyValuePair<string, int>));
			object instance = objectValue;
			object[] array = new object[2];
			object obj = (array[0] = keyValuePair.Key);
			array[1] = Operators.AddObject(NewLateBinding.LateIndexGet(instance, new object[1] { obj }, null), Operators.AddObject(NewLateBinding.LateIndexGet(objectValue, new object[1] { keyValuePair.Key }, null), keyValuePair.Value));
			NewLateBinding.LateIndexSet(instance, array, null);
		}
		return (Dictionary<string, int>)objectValue;
	}

	public static Dictionary<string, int> n1C(this object y9Z, bool Fc8 = false)
	{
		object instance = DijkstraRouter;
		object[] obj = new object[2] { y9Z, Fc8 };
		object[] array = obj;
		bool[] obj2 = new bool[2] { true, true };
		bool[] array2 = obj2;
		object instance2 = NewLateBinding.LateGet(instance, null, "FromNetwork", obj, null, null, obj2);
		if (array2[0])
		{
			y9Z = RuntimeHelpers.GetObjectValue(array[0]);
		}
		if (array2[1])
		{
			Fc8 = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(bool));
		}
		return (Dictionary<string, int>)NewLateBinding.LateGet(instance2, null, "BetweennessCentrality", new object[0], null, null, null);
	}

	public static Dictionary<string, int> Nd2(this ref object c5J, int d2J = 0)
	{
		s7H arg = default(s7H);
		s7H CS_0024_003C_003E8__locals2 = new s7H(arg);
		CS_0024_003C_003E8__locals2._0024VB_0024Local_base = d2J;
		Dictionary<string, int> dictionary = (Dictionary<string, int>)NewLateBinding.LateGet(NewLateBinding.LateGet(c5J, null, "BetweennessCentrality", new object[0], null, null, null), null, "ToDictionary", new object[2]
		{
			(Zo3y.k3CR<object, object>)([SpecialName] (object Ty9) => NewLateBinding.LateGet(Ty9, null, "Key", new object[0], null, null, null)),
			(Zo3y.k3CR<object, object>)([SpecialName] (object t0K) => Operators.AddObject(NewLateBinding.LateGet(t0K, null, "Value", new object[0], null, null, null), CS_0024_003C_003E8__locals2._0024VB_0024Local_base))
		}, null, null, null);
		double num = ((IEnumerable<int>)dictionary.Values).Select((Func<int, double>)([SpecialName] (int Ta1) => Ta1)).Sum();
		foreach (c1Y9 item in (IEnumerable)NewLateBinding.LateGet(c5J, null, "vertex", new object[0], null, null, null))
		{
			item.data.betweennessCentrality = dictionary[Conversions.ToString(item.k7M())];
		}
		return dictionary;
	}

	public static Dictionary<string, int> Yo7(this object Kt3)
	{
		return (Dictionary<string, int>)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Kt3, null, "graphEdges", new object[0], null, null, null), null, "Select", new object[1] { (a8J6.a5NB<object, object[]>)([SpecialName] (object r0T) => new object[2]
		{
			NewLateBinding.LateGet(NewLateBinding.LateGet(r0T, null, "U", new object[0], null, null, null), null, "label", new object[0], null, null, null),
			NewLateBinding.LateGet(NewLateBinding.LateGet(r0T, null, "V", new object[0], null, null, null), null, "label", new object[0], null, null, null)
		}) }, null, null, null), null, "IteratesALL", new object[0], null, null, null), null, "GroupBy", new object[1] { (Em85.Am61<object, object>)([SpecialName] (object t7M) => t7M) }, null, null, null), null, "ToDictionary", new object[2]
		{
			(Em85.Am61<object, object>)([SpecialName] (object To1) => NewLateBinding.LateGet(To1, null, "Key", new object[0], null, null, null)),
			(Jk5y.Nr8w<object, object>)([SpecialName] (object e0M) => NewLateBinding.LateGet(e0M, null, "Count", new object[0], null, null, null))
		}, null, null, null);
	}

	public static Dictionary<string, int> c1B(this ref object w2D, int Jg3 = 0)
	{
		Dictionary<string, int> dictionary = (Dictionary<string, int>)NewLateBinding.LateGet(w2D, null, "ConnectedDegrees", new object[0], null, null, null);
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(w2D, null, "graphEdges", new object[0], null, null, null), null, "ComputeDegreeData", new object[0], null, null, null));
		double num = Conversions.ToDouble(Operators.AddObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Out", new object[0], null, null, null), null, "Values", new object[0], null, null, null), null, "Sum", new object[0], null, null, null), Operators.MultiplyObject(Jg3, NewLateBinding.LateGet(NewLateBinding.LateGet(w2D, null, "vertex", new object[0], null, null, null), null, "Count", new object[0], null, null, null))));
		double num2 = Conversions.ToDouble(Operators.AddObject(dictionary.Values.Sum(), Operators.MultiplyObject(Jg3, NewLateBinding.LateGet(NewLateBinding.LateGet(w2D, null, "vertex", new object[0], null, null, null), null, "Count", new object[0], null, null, null))));
		foreach (c1Y9 item in (IEnumerable)NewLateBinding.LateGet(w2D, null, "vertex", new object[0], null, null, null))
		{
			if (dictionary.ContainsKey(Conversions.ToString(item.k7M())))
			{
				int num3 = dictionary[Conversions.ToString(item.k7M())];
				if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "In", new object[0], null, null, null), null, "ContainsKey", new object[1] { item.k7M() }, null, null, null)))
				{
					num3 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "In", new object[1] { item.k7M() }, null, null, null));
				}
				if (Conversions.ToBoolean(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Out", new object[0], null, null, null), null, "ContainsKey", new object[1] { item.k7M() }, null, null, null)))
				{
					num3 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "Out", new object[1] { item.k7M() }, null, null, null));
				}
			}
		}
		return dictionary;
	}
}
