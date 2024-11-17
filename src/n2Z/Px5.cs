using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace n2Z;

public class Px5
{
	private Dictionary<string, object> _nodeSet;

	private Dictionary<string, object> _adjacencySet;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _NodeAccess;

	public object NodeAccess
	{
		[CompilerGenerated]
		get
		{
			return _NodeAccess;
		}
		[CompilerGenerated]
		set
		{
			_NodeAccess = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Px5()
	{
		_nodeSet = new Dictionary<string, object>();
		_adjacencySet = new Dictionary<string, object>();
	}

	public object r3Z(IEnumerable<object> p3K)
	{
		return this;
	}

	public object f8C(IEnumerable<object> Sj6)
	{
		foreach (object item in Sj6)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			Jo4(RuntimeHelpers.GetObjectValue(objectValue));
		}
		return this;
	}

	public void m4Z(object t5P)
	{
		if (_nodeSet.ContainsKey(Conversions.ToString(NewLateBinding.LateGet(t5P, null, "Key", new object[0], null, null, null))))
		{
			_nodeSet.Remove(Conversions.ToString(NewLateBinding.LateGet(t5P, null, "Key", new object[0], null, null, null)));
		}
		if (_adjacencySet.ContainsKey(Conversions.ToString(NewLateBinding.LateGet(t5P, null, "Key", new object[0], null, null, null))))
		{
			_adjacencySet.Remove(Conversions.ToString(NewLateBinding.LateGet(t5P, null, "Key", new object[0], null, null, null)));
		}
	}

	public void Hy1(object y8R)
	{
		if (_adjacencySet.ContainsKey(Conversions.ToString(NewLateBinding.LateGet(y8R, null, "source", new object[0], null, null, null))))
		{
			object objectValue = RuntimeHelpers.GetObjectValue(_adjacencySet[Conversions.ToString(NewLateBinding.LateGet(y8R, null, "source", new object[0], null, null, null))]);
			object[] array = new object[1];
			array[0] = NewLateBinding.LateGet(y8R, null, "target", new object[0], null, null, null);
			object[] array2 = array;
			bool[] obj = new bool[1] { true };
			bool[] array3 = obj;
			NewLateBinding.LateCall(objectValue, null, "Remove", array, null, null, obj, IgnoreReturn: true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(y8R, null, "target", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Count", new object[0], null, null, null), 0, TextCompare: false))
			{
				_adjacencySet.Remove(Conversions.ToString(NewLateBinding.LateGet(y8R, null, "source", new object[0], null, null, null)));
			}
		}
	}

	public void j4Z()
	{
		_nodeSet.Clear();
		_adjacencySet.Clear();
	}

	public object c3X(object Ma1)
	{
		_adjacencySet.Add(Conversions.ToString(NewLateBinding.LateGet(Ma1, null, "Key", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(new object()));
		return _adjacencySet[Conversions.ToString(NewLateBinding.LateGet(Ma1, null, "Key", new object[0], null, null, null))];
	}

	public IEnumerable<object> k4A(object Hx8, object f7G)
	{
		if (Hx8 == null || f7G == null || NewLateBinding.LateGet(Hx8, null, "Key", new object[0], null, null, null) == null || NewLateBinding.LateGet(f7G, null, "Key", new object[0], null, null, null) == null)
		{
			return null;
		}
		if (!_adjacencySet.ContainsKey(Conversions.ToString(NewLateBinding.LateGet(Hx8, null, "Key", new object[0], null, null, null))))
		{
			return null;
		}
		object[] array;
		bool[] array2;
		object obj = NewLateBinding.LateGet(_adjacencySet[Conversions.ToString(NewLateBinding.LateGet(Hx8, null, "Key", new object[0], null, null, null))], null, "EnumerateAllEdges", array = new object[1] { f7G }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			f7G = RuntimeHelpers.GetObjectValue(array[0]);
		}
		return (IEnumerable<object>)obj;
	}

	public IEnumerable<object> Kw6(string x6J)
	{
		if (!_adjacencySet.ContainsKey(x6J))
		{
			return new object[0];
		}
		return (IEnumerable<object>)NewLateBinding.LateGet(_adjacencySet[x6J], null, "EnumerateAllEdges", new object[0], null, null, null);
	}

	public object Jo4(object Dm9)
	{
		if (!_adjacencySet.ContainsKey(Conversions.ToString(NewLateBinding.LateGet(Dm9, null, "source", new object[0], null, null, null))))
		{
			_adjacencySet[Conversions.ToString(NewLateBinding.LateGet(Dm9, null, "source", new object[0], null, null, null))] = RuntimeHelpers.GetObjectValue(new object());
		}
		if (!_adjacencySet.ContainsKey(Conversions.ToString(NewLateBinding.LateGet(Dm9, null, "target", new object[0], null, null, null))))
		{
			_adjacencySet[Conversions.ToString(NewLateBinding.LateGet(Dm9, null, "target", new object[0], null, null, null))] = RuntimeHelpers.GetObjectValue(new object());
		}
		object objectValue = RuntimeHelpers.GetObjectValue(_adjacencySet[Conversions.ToString(NewLateBinding.LateGet(Dm9, null, "source", new object[0], null, null, null))]);
		object objectValue2 = RuntimeHelpers.GetObjectValue(_adjacencySet[Conversions.ToString(NewLateBinding.LateGet(Dm9, null, "target", new object[0], null, null, null))]);
		object[] array;
		bool[] array2;
		NewLateBinding.LateCall(_adjacencySet[Conversions.ToString(NewLateBinding.LateGet(Dm9, null, "source", new object[0], null, null, null))], null, "Add", array = new object[1] { Dm9 }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
		if (array2[0])
		{
			Dm9 = RuntimeHelpers.GetObjectValue(array[0]);
		}
		NewLateBinding.LateCall(_adjacencySet[Conversions.ToString(NewLateBinding.LateGet(Dm9, null, "target", new object[0], null, null, null))], null, "Add", array = new object[1] { Dm9 }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
		if (array2[0])
		{
			Dm9 = RuntimeHelpers.GetObjectValue(array[0]);
		}
		return null;
	}
}
