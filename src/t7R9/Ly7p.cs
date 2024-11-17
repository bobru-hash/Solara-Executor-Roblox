using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Hk0x;
using k7B1;
using Microsoft.VisualBasic.CompilerServices;
using q7W5;
using Ti1;

namespace t7R9;

public class Ly7p
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class Fb1k
	{
		public static readonly Fb1k _0024I;

		public static Func<c1Y9, bool> _0024I20_002D0;

		public static Func<c1Y9, bool> _0024I22_002D0;

		static Fb1k()
		{
			_0024I = new Fb1k();
		}

		[SpecialName]
		internal bool Gk64(c1Y9 c9B2)
		{
			bool result = default(bool);
			return result;
		}

		[SpecialName]
		internal bool Fc8d(c1Y9 a2WP)
		{
			bool result = default(bool);
			return result;
		}
	}

	[CompilerGenerated]
	internal sealed class Mi09
	{
		public int _0024VB_0024Local_id;

		[SpecialName]
		internal bool Zq5w(c1Y9 Nc54)
		{
			return Operators.ConditionalCompareObjectEqual(Nc54.ID, _0024VB_0024Local_id, TextCompare: false);
		}
	}

	[CompilerGenerated]
	internal sealed class Qq29
	{
		public string _0024VB_0024Local_name;

		[SpecialName]
		internal bool o6Q1(c1Y9 Dd5s)
		{
			return Conversions.ToBoolean(_0024VB_0024Local_name);
		}
	}

	[CompilerGenerated]
	internal sealed class j0ZE
	{
		public string _0024VB_0024Local_label;

		[SpecialName]
		internal bool Tp16(Mq41 Mo92)
		{
			return Operators.CompareString(Mo92.data.label, _0024VB_0024Local_label, TextCompare: false) == 0;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _NamesOf;

	private int _nextNodeId;

	private int _nextEdgeId;

	private List<object> _eventListeners;

	private object _index;

	private object vertices;

	public object[] connectedNodes { get; }

	public object NamesOf
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

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Ly7p()
		: this(new c1Y9[0], new Mq41[0])
	{
	}

	public Ly7p(IEnumerable<c1Y9> nodes, IEnumerable<Mq41> edges, bool ignoresBrokenLinks = false)
	{
		_nextNodeId = 0;
		_nextEdgeId = 0;
		_eventListeners = new List<object>();
		_index = RuntimeHelpers.GetObjectValue(new object());
		foreach (c1Y9 node in nodes)
		{
			k6F8(node);
		}
		foreach (Mq41 edge in edges)
		{
			if (ignoresBrokenLinks)
			{
				s3FW(edge);
			}
		}
		foreach (c1Y9 item in m7Q2())
		{
			c1Y9 c1Y = item;
			if (c1Y.adjacencies == null)
			{
				c1Y9 c1Y2 = c1Y;
				object index = _index;
				object[] obj = new object[1] { c1Y };
				object[] array = obj;
				bool[] obj2 = new bool[1] { true };
				bool[] array2 = obj2;
				object obj3 = NewLateBinding.LateGet(index, null, "CreateNodeAdjacencySet", obj, null, null, obj2);
				if (array2[0])
				{
					c1Y = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(c1Y9));
				}
				c1Y2.adjacencies = RuntimeHelpers.GetObjectValue(obj3);
			}
			if (c1Y.directedVertex == null)
			{
				c1Y.directedVertex = RuntimeHelpers.GetObjectValue(new object());
			}
		}
	}

	private IEnumerable<c1Y9> m7Q2()
	{
		throw new NotImplementedException();
	}

	public void Km8b()
	{
		NewLateBinding.LateCall(_index, null, "Clear", new object[0], null, null, null, IgnoreReturn: true);
	}

	public c1Y9 k6F8(c1Y9 w9TD, bool Zs98 = true)
	{
		object[] array;
		bool[] array2;
		if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(vertices, null, "ContainsKey", new object[1] { w9TD.k7M() }, null, null, null))))
		{
			if (Zs98)
			{
				w9TD.ID = null;
			}
			NewLateBinding.LateCall(vertices, null, "Add", array = new object[1] { w9TD }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
			if (array2[0])
			{
				w9TD = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(c1Y9));
			}
		}
		NewLateBinding.LateIndexSet(_index, new object[2]
		{
			w9TD.k7M(),
			w9TD
		}, null);
		NewLateBinding.LateSetComplex(NewLateBinding.LateIndexGet(_index, new object[1] { w9TD.k7M() }, null), null, "directedVertex", new object[1] { Xr5p(RuntimeHelpers.GetObjectValue(w9TD.k7M())) }, null, null, OptimisticSet: false, RValueBase: true);
		object instance = NewLateBinding.LateIndexGet(_index, new object[1] { w9TD.k7M() }, null);
		object[] array3 = new object[1];
		object obj = NewLateBinding.LateGet(_index, null, "CreateNodeAdjacencySet", array = new object[1] { w9TD }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			w9TD = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(c1Y9));
		}
		array3[0] = obj;
		NewLateBinding.LateSetComplex(instance, null, "adjacencies", array3, null, null, OptimisticSet: false, RValueBase: true);
		Js17("AddNode");
		return w9TD;
	}

	private object Xr5p(object Sx0i)
	{
		throw new NotImplementedException();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Mq41 Jb98(int r5WA, int z8FP)
	{
		return Az08(q3FC(r5WA), q3FC(z8FP));
	}

	public c1Y9 q3FC(int Pb23)
	{
		return (from Nc54 in m7Q2()
			where Operators.ConditionalCompareObjectEqual(Nc54.ID, Pb23, TextCompare: false)
			select Nc54).FirstOrDefault();
	}

	public c1Y9 Ps27(string Ws75, bool g4QG = false)
	{
		int num;
		if (!g4QG)
		{
			object instance = vertices;
			object[] obj = new object[1] { Ws75 };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object value = NewLateBinding.LateGet(instance, null, "ContainsKey", obj, null, null, obj2);
			if (array2[0])
			{
				Ws75 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			num = (Conversions.ToBoolean(value) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		if (!Conversions.ToBoolean((byte)num != 0))
		{
			bool result = default(bool);
			return (from c9B2 in m7Q2()
				where result
				select c9B2).FirstOrDefault();
		}
		c1Y9 result2 = default(c1Y9);
		return result2;
	}

	private c1Y9 Zk3e(string Bx1y)
	{
		return Ps27(Bx1y);
	}

	public c1Y9[] z9D8(string t8T0)
	{
		bool result = default(bool);
		return (from a2WP in m7Q2()
			where result
			select a2WP).ToArray();
	}

	public c1Y9[] Tf3t(string Bp36)
	{
		return (from Dd5s in m7Q2()
			where Conversions.ToBoolean(Bp36)
			select Dd5s).ToArray();
	}

	public object x3XY(string Td52, string Ys12, double x5Q8 = 0.0)
	{
		return this;
	}

	public Mq41 s3FW(Mq41 Ze1g)
	{
		object index = _index;
		object[] obj = new object[1] { Ze1g };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object obj3 = NewLateBinding.LateGet(index, null, "AddEdge", obj, null, null, obj2);
		if (array2[0])
		{
			Ze1g = (Mq41)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Mq41));
		}
		object objectValue = RuntimeHelpers.GetObjectValue(obj3);
		Js17("AddEdge");
		return Ze1g;
	}

	public void Ly67(List<Yr4> b9Q4)
	{
		checked
		{
			int num = b9Q4.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				b8AW(b9Q4[i]);
			}
		}
	}

	public void Bc2z(List<string> Sz0t)
	{
		checked
		{
			int num = Sz0t.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Qm4y(Sz0t[i]);
			}
		}
	}

	public void Ry06(IEnumerable<object> Qq0c)
	{
		c1Y9 sd = default(c1Y9);
		c1Y9 b7JW = default(c1Y9);
		foreach (object item in Qq0c)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			object instance = vertices;
			object[] array = new object[1];
			object instance2 = objectValue;
			array[0] = NewLateBinding.LateGet(instance2, null, "aId", new object[0], null, null, null);
			object[] array2 = array;
			bool[] array3;
			object operand = NewLateBinding.LateGet(instance, null, "ContainsKey", array, null, null, array3 = new bool[1] { true });
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "aId", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
			}
			if (!Conversions.ToBoolean(Operators.NotObject(operand)))
			{
				object instance3 = vertices;
				object[] array4 = new object[1];
				instance2 = objectValue;
				array4[0] = NewLateBinding.LateGet(instance2, null, "bId", new object[0], null, null, null);
				array2 = array4;
				bool[] obj = new bool[1] { true };
				array3 = obj;
				operand = NewLateBinding.LateGet(instance3, null, "ContainsKey", array4, null, null, obj);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(instance2, null, "bId", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
				}
				if (!Conversions.ToBoolean(Operators.NotObject(operand)))
				{
					t6C4(sd, b7JW, (c9ZR)NewLateBinding.LateGet(objectValue, null, "data", new object[0], null, null, null), 0.0);
				}
			}
		}
	}

	public void Rw9d(IEnumerable<KeyValuePair<string, string>> e7HR)
	{
		c1Y9 sd = default(c1Y9);
		c1Y9 b7JW = default(c1Y9);
		foreach (KeyValuePair<string, string> item in e7HR)
		{
			if (!Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(vertices, null, "ContainsKey", new object[1] { item.Key }, null, null, null))) && !Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(vertices, null, "ContainsKey", new object[1] { item.Value }, null, null, null))))
			{
				t6C4(sd, b7JW, null, 0.0);
			}
		}
	}

	public c1Y9 b8AW(Yr4 q8K3)
	{
		c1Y9 c1Y = new c1Y9(_nextNodeId.ToString(), q8K3);
		checked
		{
			_nextNodeId++;
			k6F8(c1Y);
			return c1Y;
		}
	}

	public c1Y9 Qm4y(string We9z, Yr4 o5PE = null)
	{
		if (o5PE == null)
		{
		}
		c1Y9 c1Y = new c1Y9(We9z, o5PE);
		c1Y.ID = _nextNodeId;
		c1Y9 c1Y2 = c1Y;
		checked
		{
			_nextNodeId++;
			k6F8(c1Y2);
			return c1Y2;
		}
	}

	private Mq41 t6C4(c1Y9 Sd05, c1Y9 b7JW, c9ZR Ps3x, double f4KA)
	{
		Mq41 mq = new Mq41(_nextEdgeId.ToString(), Sd05, b7JW, Ps3x)
		{
			weight = f4KA
		};
		checked
		{
			_nextEdgeId++;
			s3FW(mq);
			return mq;
		}
	}

	public Mq41 Az08(c1Y9 m9WN, c1Y9 c6C8, double j9KZ = 0.0, c9ZR Hx1d = null)
	{
		if (m9WN == null || c6C8 == null)
		{
			return null;
		}
		return t6C4(m9WN, c6C8, Hx1d, j9KZ);
	}

	public Mq41 s2N1(string Tq4k, string i4A9, double i6KD = 0.0, c9ZR Eq31 = null)
	{
		object instance = vertices;
		object[] obj = new object[1] { Tq4k };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object operand = NewLateBinding.LateGet(instance, null, "ContainsKey", obj, null, null, obj2);
		if (array2[0])
		{
			Tq4k = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		if (Conversions.ToBoolean(Operators.NotObject(operand)))
		{
			return null;
		}
		operand = NewLateBinding.LateGet(vertices, null, "ContainsKey", array = new object[1] { i4A9 }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			i4A9 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		if (Conversions.ToBoolean(Operators.NotObject(operand)))
		{
			return null;
		}
		if (Eq31 == null)
		{
			Eq31 = new c9ZR();
		}
		c1Y9 sd = default(c1Y9);
		c1Y9 b7JW = default(c1Y9);
		return t6C4(sd, b7JW, Eq31, i6KD);
	}

	public c1Y9[] Rm17(string n2SM)
	{
		c1Y9 a8BE = Ps27(n2SM);
		Mq41[] array = q2E0(a8BE).ToArray();
		c1Y9[] result = default(c1Y9[]);
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public IEnumerable<Mq41> k4F9(c1Y9 m8AZ, c1Y9 Jo78)
	{
		if (m8AZ == null || Jo78 == null)
		{
			return new Mq41[0];
		}
		object[] array;
		bool[] array2;
		object instance = NewLateBinding.LateGet(_index, null, "GetEdges", array = new object[2] { m8AZ, Jo78 }, null, null, array2 = new bool[2] { true, true });
		if (array2[0])
		{
			m8AZ = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(c1Y9));
		}
		if (array2[1])
		{
			Jo78 = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(c1Y9));
		}
		return (IEnumerable<Mq41>)NewLateBinding.LateGet(instance, null, "SafeQuery", new object[0], null, null, null);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public IEnumerable<Mq41> q2E0(c1Y9 a8BE)
	{
		return (IEnumerable<Mq41>)NewLateBinding.LateGet(_index, null, "GetEdges", new object[1] { a8BE.k7M() }, null, null, null);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void d1GF(string Hf1q)
	{
		i4N5(Ps27(Hf1q));
	}

	public void i4N5(c1Y9 Ac13)
	{
		object index = _index;
		object[] obj = new object[1] { Ac13 };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(index, null, "Delete", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			Ac13 = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(c1Y9));
		}
		NewLateBinding.LateCall(vertices, null, "Remove", array = new object[1] { Ac13 }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
		if (array2[0])
		{
			Ac13 = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(c1Y9));
		}
		i4FH(Ac13);
	}

	public void i4FH(c1Y9 c0R8)
	{
		Mq41[] array = k3NR().ToArray();
		foreach (Mq41 mq in array)
		{
		}
		Js17("DetachNode");
	}

	public void Qo6s(Mq41 Ea6r)
	{
		object index = _index;
		object[] obj = new object[1] { Ea6r };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(index, null, "RemoveEdge", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			Ea6r = (Mq41)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Mq41));
		}
		Js17("RemoveEdge");
	}

	public Mq41 Dp30(string r8L3)
	{
		return k3NR().FirstOrDefault([SpecialName] (Mq41 Mo92) => Operators.CompareString(Mo92.data.label, r8L3, TextCompare: false) == 0);
	}

	public void Lw4d(Ly7p a6PK)
	{
		checked
		{
			c1Y9 w9TD = default(c1Y9);
			foreach (c1Y9 item in a6PK.m7Q2())
			{
				k6F8(w9TD);
				_nextNodeId++;
			}
			c1Y9 source = default(c1Y9);
			c1Y9 target = default(c1Y9);
			foreach (Mq41 item2 in a6PK.k3NR())
			{
				s3FW(new Mq41(_nextEdgeId.ToString(), source, target, item2.data));
				_nextEdgeId++;
			}
		}
	}

	public void Js3i(Predicate<c1Y9> t3PC)
	{
		foreach (c1Y9 item in m7Q2())
		{
			if (!t3PC(item))
			{
				i4N5(item);
			}
		}
	}

	public void i5XQ(Predicate<Mq41> i3N8)
	{
		foreach (Mq41 item in k3NR())
		{
			if (!i3N8(item))
			{
				Qo6s(item);
			}
		}
	}

	public void Jm1r(object s7Y2)
	{
		_eventListeners.Add(RuntimeHelpers.GetObjectValue(s7Y2));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void Js17([CallerMemberName] string Yx36 = null)
	{
		foreach (object eventListener in _eventListeners)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(eventListener);
			object[] array;
			bool[] array2;
			NewLateBinding.LateCall(objectValue, null, "GraphChanged", array = new object[2] { this, Yx36 }, null, null, array2 = new bool[2] { false, true }, IgnoreReturn: true);
			if (array2[1])
			{
				Yx36 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
			}
		}
	}

	public virtual string n5YP()
	{
		string[] array = default(string[]);
		if (array.Length == 0)
		{
			return string.Format("Network graph have {0} nodes and {1} edges.", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(vertices, null, "Count", new object[0], null, null, null)), k3NR().Count());
		}
		return string.Format("Network graph [{0} nodes, {1} edges] has {2}", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(vertices, null, "Count", new object[0], null, null, null)), k3NR().Count(), array.Length);
	}

	private static c1Y9 g1J3(object Sw61, c1Y9 Fe56)
	{
		object[] obj = new object[1] { Fe56 };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object operand = NewLateBinding.LateGet(Sw61, null, "Have", obj, null, null, obj2);
		if (array2[0])
		{
			Fe56 = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(c1Y9));
		}
		if (Conversions.ToBoolean(Operators.NotObject(operand)))
		{
			Fe56 = new c1Y9();
			object[] obj3 = new object[1] { Fe56 };
			array = obj3;
			bool[] obj4 = new bool[1] { true };
			array2 = obj4;
			NewLateBinding.LateCall(Sw61, null, "Add", obj3, null, null, obj4, IgnoreReturn: true);
			if (array2[0])
			{
				Fe56 = (c1Y9)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(c1Y9));
			}
		}
		c1Y9 result = default(c1Y9);
		return result;
	}

	private object Rt25()
	{
		return d4LH(m7Q2());
	}

	private object d4LH(IEnumerable<c1Y9> Mg60)
	{
		Ly7p result = new Ly7p();
		foreach (c1Y9 item in Mg60)
		{
		}
		foreach (Mq41 item2 in k3NR())
		{
		}
		return result;
	}

	public Ly7p n9K8()
	{
		return (Ly7p)d4LH((IEnumerable<c1Y9>)connectedNodes);
	}

	public Ly7p Fb91()
	{
		return (Ly7p)Rt25();
	}

	public void e7WT()
	{
		foreach (c1Y9 item in m7Q2())
		{
		}
	}

	internal IEnumerable<Mq41> k3NR()
	{
		throw new NotImplementedException();
	}

	internal static object n1Z5(string j6AR)
	{
		int num = Conversions.ToInteger(j6AR);
		int num2 = 234;
		Random random = new Random();
		for (int num3 = random.Next(1, 20); num3 <= 10; num3 = random.Next(1, 20))
		{
		}
		int num4 = (num & ~num2) | (~num & num2);
		return Conversions.ToString(num4);
	}

	internal static void Fr6d(List<object> Bj5g)
	{
		object instance = Bj5g[4];
		List<object> list;
		object[] obj = new object[1] { (list = Bj5g)[1] };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object instance2 = NewLateBinding.LateGet(instance, null, "GetTypes", obj, null, null, obj2);
		if (array2[0])
		{
			list[1] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
		}
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance2, null, "GetMethods", new object[0], null, null, null));
		object CounterResult = default(object);
		object LoopForResult = default(object);
		if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(CounterResult, Operators.SubtractObject(NewLateBinding.LateGet(objectValue, null, "Length", new object[0], null, null, null), 1), 0, -1, ref LoopForResult, ref CounterResult))
		{
			return;
		}
		do
		{
			foreach (object item in (IEnumerable)NewLateBinding.LateGet(NewLateBinding.LateIndexGet(objectValue, new object[1] { CounterResult }, null), null, "Name", new object[0], null, null, null))
			{
				string value = Conversions.ToString(item);
				try
				{
					if (Convert.ToInt32(value) == 0)
					{
						NewLateBinding.LateCall(NewLateBinding.LateIndexGet(objectValue, new object[1] { CounterResult }, null), null, "Invoke", new object[2]
						{
							null,
							new object[0]
						}, null, null, null, IgnoreReturn: true);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}
		while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
	}
}
