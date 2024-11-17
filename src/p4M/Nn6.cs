using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace p4M;

public class Nn6
{
	[CompilerGenerated]
	private sealed class Ec0 : IEnumerator<object>, IDisposable, IEnumerator
	{
		public int _0024State;

		public object _0024Current;

		internal Nn6 _0024VB_0024Me;

		internal IEnumerator _0024S0;

		internal object _0024VB_0024ResumableLocal_edge_00241;

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

		public Ec0(int _0024State)
		{
			this._0024State = _0024State;
		}

		[DebuggerNonUserCode]
		private void x2S()
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
			p9R();
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in x2S
			this.x2S();
		}

		[CompilerGenerated]
		private bool p9R()
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
				switch (num)
				{
				case -3:
					num = (_0024State = -1);
					return true;
				default:
					_0024S0 = ((IEnumerable)_0024VB_0024Me.outgoingEdges).GetEnumerator();
					break;
				case 1:
					num = (_0024State = -1);
					break;
				}
				if (_0024S0.MoveNext())
				{
					_0024VB_0024ResumableLocal_edge_00241 = RuntimeHelpers.GetObjectValue(_0024S0.Current);
					_0024Current = _0024VB_0024ResumableLocal_edge_00241;
					num = (_0024State = 1);
					return true;
				}
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
			//ILSpy generated this explicit interface implementation from .override directive in p9R
			return this.p9R();
		}

		[DebuggerNonUserCode]
		private void w4C()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in w4C
			this.w4C();
		}
	}

	[CompilerGenerated]
	private sealed class Qb3 : IEnumerator<object>, IDisposable, IEnumerator
	{
		public int _0024State;

		public object _0024Current;

		internal Nn6 _0024VB_0024Me;

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

		public Qb3(int _0024State)
		{
			this._0024State = _0024State;
		}

		[DebuggerNonUserCode]
		private void Tt9()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Tt9
			this.Tt9();
		}

		[CompilerGenerated]
		private bool n5Q()
		{
			switch (_0024State)
			{
			default:
				return false;
			case 0:
			{
				int num = (_0024State = -1);
				_0024Current = _0024VB_0024Me.q3Y();
				num = (_0024State = 1);
				return true;
			}
			case 1:
			{
				int num = (_0024State = -1);
				return false;
			}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in n5Q
			return this.n5Q();
		}

		[DebuggerNonUserCode]
		private void Fw1()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Fw1
			this.Fw1();
		}
	}

	internal readonly object outgoingEdges;

	internal readonly object incomingEdges;

	public string label { get; }

	public Nn6(string label)
	{
		outgoingEdges = RuntimeHelpers.GetObjectValue(new object());
		incomingEdges = RuntimeHelpers.GetObjectValue(new object());
		this.label = label;
		if (Conversions.ToBoolean(label))
		{
			throw new ArgumentNullException("vertex label can not be empty!");
		}
	}

	public void Aa7(object w0S)
	{
		object instance = outgoingEdges;
		object[] obj = new object[1] { w0S };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "Add", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			w0S = RuntimeHelpers.GetObjectValue(array[0]);
		}
	}

	public void a5E(object Xf1)
	{
		object instance = incomingEdges;
		object[] obj = new object[1] { Xf1 };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "Add", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			Xf1 = RuntimeHelpers.GetObjectValue(array[0]);
		}
	}

	public void Me5(object Jo1)
	{
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Jo1, null, "U", new object[0], null, null, null), null, "label", new object[0], null, null, null), label, TextCompare: false))
		{
			Aa7(RuntimeHelpers.GetObjectValue(Jo1));
			return;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(Jo1, null, "V", new object[0], null, null, null), null, "label", new object[0], null, null, null), label, TextCompare: false))
		{
			a5E(RuntimeHelpers.GetObjectValue(Jo1));
			return;
		}
		throw new InvalidConstraintException(string.Format("the given edge({0} -> {1}) object is not connected to current vertex {2}!", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Jo1, null, "U", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Jo1, null, "V", new object[0], null, null, null)), label));
	}

	public object e0D(Nn6 Qe1)
	{
		foreach (object item in (IEnumerable)outgoingEdges)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(item);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "V", new object[0], null, null, null), null, "label", new object[0], null, null, null), Qe1.label, TextCompare: false))
			{
				return objectValue;
			}
		}
		return null;
	}

	public virtual string m3X()
	{
		return label;
	}

	[IteratorStateMachine(typeof(VB_0024StateMachine_11_GetEnumerator))]
	public IEnumerator<object> q3Y()
	{
		//yield-return decompiler failed: Method not found
		Ec0 ec = new Ec0(0);
		ec._0024VB_0024Me = this;
		return ec;
	}

	[IteratorStateMachine(typeof(VB_0024StateMachine_12_IEnumerable_GetEnumerator))]
	private IEnumerator f0Z()
	{
		//yield-return decompiler failed: Method not found
		Qb3 qb = new Qb3(0);
		qb._0024VB_0024Me = this;
		return qb;
	}
}
