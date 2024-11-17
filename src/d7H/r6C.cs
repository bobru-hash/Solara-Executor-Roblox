using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace d7H;

public class r6C
{
	[CompilerGenerated]
	private sealed class Gg3 : IEnumerable<object>, IEnumerator<object>, IEnumerable, IDisposable, IEnumerator
	{
		public int _0024State;

		public object _0024Current;

		public int _0024InitialThreadId;

		internal r6C _0024VB_0024Me;

		internal IEnumerator _0024S0;

		internal object _0024VB_0024ResumableLocal_nodeV_00241;

		internal IEnumerator _0024S2;

		internal object _0024VB_0024ResumableLocal_edge_00243;

		private object Current
		{
			[DebuggerNonUserCode]
			get
			{
				return _0024Current;
			}
		}

		private object IEnumerator_002ECurrent
		{
			[DebuggerNonUserCode]
			get
			{
				return _0024Current;
			}
		}

		public Gg3(int _0024State)
		{
			this._0024State = _0024State;
			_0024InitialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerNonUserCode]
		private void x2A()
		{
			int num = _0024State;
			if (num == 1)
			{
				_0024State = -3;
			}
			else
			{
				_0024State = -1;
			}
			q4J();
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in x2A
			this.x2A();
		}

		[CompilerGenerated]
		private bool q4J()
		{
			int num = _0024State;
			switch (num)
			{
			default:
				return false;
			case 0:
				num = (_0024State = -1);
				break;
			case -3:
			case 1:
				break;
			}
			try
			{
				if (num == -3 || num == 1)
				{
					goto IL_0091;
				}
				_0024S0 = ((IEnumerable)NewLateBinding.LateGet(_0024VB_0024Me.adjacentNodes, null, "Values", new object[0], null, null, null)).GetEnumerator();
				goto IL_013c;
				IL_013c:
				if (_0024S0.MoveNext())
				{
					_0024VB_0024ResumableLocal_nodeV_00241 = RuntimeHelpers.GetObjectValue(_0024S0.Current);
					goto IL_0091;
				}
				goto end_IL_0037;
				IL_0091:
				try
				{
					switch (num)
					{
					case -3:
						num = (_0024State = -1);
						return true;
					default:
						_0024S2 = ((IEnumerable)_0024VB_0024ResumableLocal_nodeV_00241).GetEnumerator();
						break;
					case 1:
						num = (_0024State = -1);
						break;
					}
					if (_0024S2.MoveNext())
					{
						_0024VB_0024ResumableLocal_edge_00243 = RuntimeHelpers.GetObjectValue(_0024S2.Current);
						_0024Current = _0024VB_0024ResumableLocal_edge_00243;
						num = (_0024State = 1);
						return true;
					}
				}
				finally
				{
					if (num < 0 && _0024S2 is IDisposable)
					{
						(_0024S2 as IDisposable).Dispose();
					}
				}
				goto IL_013c;
				end_IL_0037:;
			}
			finally
			{
				if (num < 0 && _0024S0 is IDisposable)
				{
					(_0024S0 as IDisposable).Dispose();
				}
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in q4J
			return this.q4J();
		}

		[DebuggerNonUserCode]
		private IEnumerator<object> Ai5()
		{
			Gg3 result;
			if (_0024State == -2 && _0024InitialThreadId == Environment.CurrentManagedThreadId)
			{
				_0024State = 0;
				result = this;
			}
			else
			{
				result = new Gg3(0)
				{
					_0024VB_0024Me = _0024VB_0024Me
				};
			}
			return result;
		}

		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ai5
			return this.Ai5();
		}

		[DebuggerNonUserCode]
		private IEnumerator Nm1()
		{
			return Ai5();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Nm1
			return this.Nm1();
		}

		[DebuggerNonUserCode]
		private void j6Q()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in j6Q
			this.j6Q();
		}
	}

	private readonly object adjacentNodes;

	public string U { get; set; }

	public int Count => Conversions.ToInteger(NewLateBinding.LateGet(adjacentNodes, null, "Count", new object[0], null, null, null));

	public r6C()
	{
		adjacentNodes = RuntimeHelpers.GetObjectValue(new object());
	}

	public bool Ms9(object z7E)
	{
		return true;
	}

	public void Gm3(object y0Q)
	{
		object instance = adjacentNodes;
		object[] array = new object[1];
		object instance2 = y0Q;
		array[0] = NewLateBinding.LateGet(instance2, null, "target", new object[0], null, null, null);
		object[] array2 = array;
		bool[] obj = new bool[1] { true };
		bool[] array3 = obj;
		object operand = NewLateBinding.LateGet(instance, null, "ContainsKey", array, null, null, obj);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "target", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
		}
		if (Conversions.ToBoolean(Operators.NotObject(operand)))
		{
			object instance3 = adjacentNodes;
			object[] array4 = new object[2];
			instance2 = y0Q;
			array4[0] = NewLateBinding.LateGet(instance2, null, "target", new object[0], null, null, null);
			array4[1] = new object();
			array2 = array4;
			bool[] obj2 = new bool[2] { true, false };
			array3 = obj2;
			NewLateBinding.LateCall(instance3, null, "Add", array4, null, null, obj2, IgnoreReturn: true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "target", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
			}
		}
		NewLateBinding.LateCall(NewLateBinding.LateIndexGet(adjacentNodes, new object[1] { NewLateBinding.LateGet(y0Q, null, "target", new object[0], null, null, null) }, null), null, "Add", array2 = new object[1] { y0Q }, null, null, array3 = new bool[1] { true }, IgnoreReturn: true);
		if (array3[0])
		{
			y0Q = RuntimeHelpers.GetObjectValue(array2[0]);
		}
	}

	public void Wz0(string f4R)
	{
		object instance = adjacentNodes;
		object[] obj = new object[1] { f4R };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object value = NewLateBinding.LateGet(instance, null, "ContainsKey", obj, null, null, obj2);
		if (array2[0])
		{
			f4R = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
		}
		if (Conversions.ToBoolean(value))
		{
			object instance2 = adjacentNodes;
			object[] obj3 = new object[1] { f4R };
			array = obj3;
			bool[] obj4 = new bool[1] { true };
			array2 = obj4;
			NewLateBinding.LateCall(instance2, null, "Remove", obj3, null, null, obj4, IgnoreReturn: true);
			if (array2[0])
			{
				f4R = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
		}
	}

	[IteratorStateMachine(typeof(VB_0024StateMachine_11_EnumerateAllEdges))]
	public IEnumerable<object> Jt0()
	{
		//yield-return decompiler failed: Method not found
		Gg3 gg = new Gg3(-2);
		gg._0024VB_0024Me = this;
		return gg;
	}

	public IEnumerable<object> e8S(object i3S)
	{
		object instance = adjacentNodes;
		object[] array = new object[1];
		object instance2 = i3S;
		array[0] = NewLateBinding.LateGet(instance2, null, "Key", new object[0], null, null, null);
		object[] array2 = array;
		bool[] obj = new bool[1] { true };
		bool[] array3 = obj;
		object operand = NewLateBinding.LateGet(instance, null, "ContainsKey", array, null, null, obj);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "Key", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
		}
		if (Conversions.ToBoolean(Operators.NotObject(operand)))
		{
			return new object[0];
		}
		object instance3 = adjacentNodes;
		object[] array4 = new object[1];
		instance2 = i3S;
		array4[0] = NewLateBinding.LateGet(instance2, null, "Key", new object[0], null, null, null);
		array2 = array4;
		operand = NewLateBinding.LateGet(instance3, null, "TryGetValue", array4, null, null, array3 = new bool[1] { true });
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "Key", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
		}
		return (IEnumerable<object>)NewLateBinding.LateGet(operand, null, "AsEnumerable", new object[0], null, null, null);
	}

	public virtual string Fo3()
	{
		return string.Format("Node {0} have {1} adjacent nodes: {2}", U, Count, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(adjacentNodes, null, "Keys", new object[0], null, null, null), null, "ToArray", new object[0], null, null, null), null, "GetJson", new object[0], null, null, null)));
	}

	public object z6D()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		foreach (object item in (IEnumerable)adjacentNodes)
		{
			object objectValue2 = RuntimeHelpers.GetObjectValue(item);
			object instance = NewLateBinding.LateGet(objectValue, null, "adjacentNodes", new object[0], null, null, null);
			object[] array = new object[2];
			object instance2 = objectValue2;
			array[0] = NewLateBinding.LateGet(instance2, null, "Key", new object[0], null, null, null);
			object instance3 = objectValue2;
			array[1] = NewLateBinding.LateGet(instance3, null, "Value", new object[0], null, null, null);
			object[] array2 = array;
			bool[] array3;
			NewLateBinding.LateCall(instance, null, "Add", array, null, null, array3 = new bool[2] { true, true }, IgnoreReturn: true);
			if (array3[0])
			{
				NewLateBinding.LateSetComplex(instance2, null, "Key", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: false);
			}
			if (array3[1])
			{
				NewLateBinding.LateSetComplex(instance3, null, "Value", new object[1] { array2[1] }, null, null, OptimisticSet: true, RValueBase: false);
			}
		}
		return objectValue;
	}
}
