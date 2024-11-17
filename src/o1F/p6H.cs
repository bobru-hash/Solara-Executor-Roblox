using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Zo3y;

namespace o1F;

public sealed class p6H
{
	private class Kr8
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int z7Q(object Ao4, object y5G)
		{
			object instance = NewLateBinding.LateGet(NewLateBinding.LateGet(y5G, null, "data", new object[0], null, null, null), null, "mass", new object[0], null, null, null);
			object instance2;
			object[] obj = new object[1] { NewLateBinding.LateGet(instance2 = NewLateBinding.LateGet(Ao4, null, "data", new object[0], null, null, null), null, "mass", new object[0], null, null, null) };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object value = NewLateBinding.LateGet(instance, null, "CompareTo", obj, null, null, obj2);
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "mass", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
			}
			return Conversions.ToInteger(value);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class i6E
	{
		public static readonly i6E _0024I;

		public static Zo3y.k3CR<object, object> _0024I14_002D0;

		static i6E()
		{
			_0024I = new i6E();
		}

		[SpecialName]
		internal object Pk0(object Fn8)
		{
			return NewLateBinding.LateGet(Fn8, null, "ID", new object[0], null, null, null);
		}
	}

	private int t;

	private List<int> scc;

	private int pass;

	private object deque;

	private List<object[]> subnetwork;

	private List<object> buffer;

	private static readonly object FORWARD_TRAVERSAL = RuntimeHelpers.GetObjectValue(new object());

	private static readonly object BACKWARD_TRAVERSAL = RuntimeHelpers.GetObjectValue(new object());

	public p6H()
	{
		scc = new List<int>();
		pass = 0;
		deque = RuntimeHelpers.GetObjectValue(new object());
		subnetwork = new List<object[]>();
		buffer = new List<object>();
	}

	public IEnumerable<object[]> j7N()
	{
		return subnetwork.AsEnumerable();
	}

	public static p6H Jd8(object f1K)
	{
		p6H p6H2 = new p6H();
		p6H2.z6Z(RuntimeHelpers.GetObjectValue(f1K), RuntimeHelpers.GetObjectValue(BACKWARD_TRAVERSAL));
		p6H2.r4W(RuntimeHelpers.GetObjectValue(f1K));
		p6H2.z6Z(RuntimeHelpers.GetObjectValue(f1K), RuntimeHelpers.GetObjectValue(FORWARD_TRAVERSAL));
		p6H2.r4W(RuntimeHelpers.GetObjectValue(f1K));
		return p6H2;
	}

	private void r4W(object d3C)
	{
		foreach (object item in (IEnumerable)NewLateBinding.LateGet(d3C, null, "vertex", new object[0], null, null, null))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			NewLateBinding.LateSet(objectValue, null, "visited", new object[1] { false }, null, null);
		}
	}

	private void z6Z(object q3K, object n6M)
	{
		ICollection<object> collection = ((pass != 0) ? new SortedSet<object>((IEnumerable<object>)NewLateBinding.LateGet(q3K, null, "vertex", new object[0], null, null, null), (IComparer<object>)new Kr8()) : ((ICollection<object>)NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(q3K, null, "vertex", new object[0], null, null, null), null, "OrderByDescending", new object[1] { (Zo3y.k3CR<object, object>)([SpecialName] (object Fn8) => NewLateBinding.LateGet(Fn8, null, "ID", new object[0], null, null, null)) }, null, null, null), null, "ToArray", new object[0], null, null, null)));
		foreach (object item in collection)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue, null, "visited", new object[0], null, null, null))))
			{
				NewLateBinding.LateSet(objectValue, null, "visited", new object[1] { true }, null, null);
				object instance = deque;
				object[] obj = new object[1] { objectValue };
				object[] array = obj;
				bool[] obj2 = new bool[1] { true };
				bool[] array2 = obj2;
				NewLateBinding.LateCall(instance, null, "AddHead", obj, null, null, obj2, IgnoreReturn: true);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				while (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(deque, null, "Empty", new object[0], null, null, null))))
				{
					objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(deque, null, "Peek", new object[0], null, null, null));
					Tk2(RuntimeHelpers.GetObjectValue(n6M), RuntimeHelpers.GetObjectValue(objectValue));
				}
				if (pass == 1)
				{
					scc.Add(t);
					t = 0;
				}
			}
		}
		checked
		{
			pass++;
		}
	}

	private void Tk2(object Cw0, object Yz5)
	{
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			object[] array = new object[1];
			array[0] = NewLateBinding.LateGet(Yz5, null, "directedVertex", new object[0], null, null, null);
			object[] array2 = array;
			bool[] obj = new bool[1] { true };
			bool[] array3 = obj;
			object obj2 = NewLateBinding.LateGet(Cw0, null, "edges", array, null, null, obj);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(Yz5, null, "directedVertex", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
			}
			enumerator = ((IEnumerable)obj2).GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				object obj3 = NewLateBinding.LateGet(Cw0, null, "vertex", array2 = new object[1] { objectValue }, null, null, array3 = new bool[1] { true });
				if (array3[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array2[0]);
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
				buffer.Add(RuntimeHelpers.GetObjectValue(objectValue));
				if (Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(objectValue2, null, "visited", new object[0], null, null, null))))
				{
					NewLateBinding.LateSet(objectValue2, null, "visited", new object[1] { true }, null, null);
					object instance = deque;
					object[] obj4 = new object[1] { objectValue2 };
					array2 = obj4;
					bool[] obj5 = new bool[1] { true };
					array3 = obj5;
					NewLateBinding.LateCall(instance, null, "AddHead", obj4, null, null, obj5, IgnoreReturn: true);
					if (array3[0])
					{
						objectValue2 = RuntimeHelpers.GetObjectValue(array2[0]);
					}
					return;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		checked
		{
			t++;
			if (pass == 0)
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Yz5, null, "data", new object[0], null, null, null), null, "mass", new object[1] { t }, null, null, OptimisticSet: false, RValueBase: true);
			}
			NewLateBinding.LateCall(deque, null, "RemoveHead", new object[0], null, null, null, IgnoreReturn: true);
		}
	}
}
