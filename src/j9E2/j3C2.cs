using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using k7B1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace j9E2;

[StandardModule]
[HideModuleName]
public sealed class j3C2
{
	[CompilerGenerated]
	private sealed class Tn57 : IEnumerable<int>, IEnumerator<int>, IEnumerable, IDisposable, IEnumerator
	{
		public int _0024State;

		public int _0024Current;

		public int _0024InitialThreadId;

		internal object _0024VB_0024Local_g;

		internal object _0024P_g;

		internal string _0024VB_0024Local_node;

		internal string _0024P_node;

		internal IEnumerator _0024S0;

		internal Mq41 _0024VB_0024ResumableLocal_edge_00241;

		internal string _0024VB_0024ResumableLocal_connected_00242;

		private int Current
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

		public Tn57(int _0024State)
		{
			this._0024State = _0024State;
			_0024InitialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerNonUserCode]
		private void Ci70()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ci70
			this.Ci70();
		}

		[CompilerGenerated]
		private bool c8TY()
		{
			if (_0024State != 0)
			{
				return false;
			}
			int num = (_0024State = -1);
			try
			{
				_0024S0 = ((IEnumerable)NewLateBinding.LateGet(_0024VB_0024Local_g, null, "graphEdges", new object[0], null, null, null)).GetEnumerator();
				while (_0024S0.MoveNext())
				{
					_0024VB_0024ResumableLocal_edge_00241 = (Mq41)_0024S0.Current;
					if (string.IsNullOrEmpty(_0024VB_0024ResumableLocal_connected_00242))
					{
					}
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
			//ILSpy generated this explicit interface implementation from .override directive in c8TY
			return this.c8TY();
		}

		[DebuggerNonUserCode]
		private IEnumerator<int> Jc6x()
		{
			Tn57 tn;
			if (_0024State == -2 && _0024InitialThreadId == Environment.CurrentManagedThreadId)
			{
				_0024State = 0;
				tn = this;
			}
			else
			{
				tn = new Tn57(0);
			}
			tn._0024VB_0024Local_g = _0024P_g;
			tn._0024VB_0024Local_node = _0024P_node;
			return tn;
		}

		IEnumerator<int> IEnumerable<int>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Jc6x
			return this.Jc6x();
		}

		[DebuggerNonUserCode]
		private IEnumerator s6H4()
		{
			return Jc6x();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in s6H4
			return this.s6H4();
		}

		[DebuggerNonUserCode]
		private void x5KQ()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in x5KQ
			this.x5KQ();
		}
	}

	public static string[] f1N5(this IEnumerable<object> My58)
	{
		return (string[])My58;
	}

	public static void t3SQ(this ref object j9GM)
	{
		string text = j9GM.ToString();
		foreach (char c in text)
		{
		}
	}

	[IteratorStateMachine(typeof(VB_0024StateMachine_2_GetNeighbours))]
	public static IEnumerable<int> d0EJ(this object Xt4e, string r5G1)
	{
		//yield-return decompiler failed: Method not found
		Tn57 tn = new Tn57(-2);
		tn._0024P_g = Xt4e;
		tn._0024P_node = r5G1;
		return tn;
	}
}
