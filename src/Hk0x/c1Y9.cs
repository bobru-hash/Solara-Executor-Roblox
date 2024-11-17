using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using k7B1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ti1;

namespace Hk0x;

public class c1Y9
{
	[CompilerGenerated]
	private sealed class j2T : IEnumerable<c1Y9>, IEnumerator<c1Y9>, IEnumerable, IDisposable, IEnumerator
	{
		public int _0024State;

		public c1Y9 _0024Current;

		public int _0024InitialThreadId;

		internal c1Y9 _0024VB_0024Me;

		internal IEnumerator _0024S0;

		internal Mq41 _0024VB_0024ResumableLocal_edge_00241;

		private c1Y9 Current
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

		public j2T(int _0024State)
		{
			this._0024State = _0024State;
			_0024InitialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerNonUserCode]
		private void Ai5()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ai5
			this.Ai5();
		}

		[CompilerGenerated]
		private bool s8P()
		{
			if (_0024State != 0)
			{
				return false;
			}
			int num = (_0024State = -1);
			try
			{
				_0024S0 = ((IEnumerable)NewLateBinding.LateGet(_0024VB_0024Me.adjacencies, null, "EnumerateAllEdges", new object[0], null, null, null)).GetEnumerator();
				while (_0024S0.MoveNext())
				{
					_0024VB_0024ResumableLocal_edge_00241 = (Mq41)_0024S0.Current;
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
			//ILSpy generated this explicit interface implementation from .override directive in s8P
			return this.s8P();
		}

		[DebuggerNonUserCode]
		private IEnumerator<c1Y9> t6M()
		{
			j2T result;
			if (_0024State == -2 && _0024InitialThreadId == Environment.CurrentManagedThreadId)
			{
				_0024State = 0;
				result = this;
			}
			else
			{
				result = new j2T(0)
				{
					_0024VB_0024Me = _0024VB_0024Me
				};
			}
			return result;
		}

		IEnumerator<c1Y9> IEnumerable<c1Y9>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in t6M
			return this.t6M();
		}

		[DebuggerNonUserCode]
		private IEnumerator Wf2()
		{
			return t6M();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Wf2
			return this.Wf2();
		}

		[DebuggerNonUserCode]
		private void Fq0()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Fq0
			this.Fq0();
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _adjacencies;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _directedVertex;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _ID;

	public Yr4 data { get; set; }

	public object adjacencies
	{
		[CompilerGenerated]
		get
		{
			return _adjacencies;
		}
		[CompilerGenerated]
		set
		{
			_adjacencies = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object directedVertex
	{
		[CompilerGenerated]
		get
		{
			return _directedVertex;
		}
		[CompilerGenerated]
		set
		{
			_directedVertex = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public bool pinned { get; set; }

	public bool visited { get; set; }

	public string text { get; }

	public object ID
	{
		[CompilerGenerated]
		get
		{
			return _ID;
		}
		[CompilerGenerated]
		set
		{
			_ID = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public c1Y9(string iId, Yr4 iData = null)
	{
		if (iData != null)
		{
		}
		pinned = false;
	}

	public c1Y9()
		: this(null)
	{
	}

	public virtual int s1E()
	{
		return k7M().GetHashCode();
	}

	[IteratorStateMachine(typeof(VB_0024StateMachine_30_EnumerateAdjacencies))]
	public IEnumerable<c1Y9> k3K()
	{
		//yield-return decompiler failed: Method not found
		j2T j2T = new j2T(-2);
		j2T._0024VB_0024Me = this;
		return j2T;
	}

	public bool t1G(c1Y9 y7R)
	{
		return Conversions.ToBoolean(LikeOperator.LikeObject(y7R.k7M(), adjacencies, CompareMethod.Binary));
	}

	public virtual string Pd2()
	{
		string result = default(string);
		return result;
	}

	public virtual bool Ss2(object Hm5)
	{
		if (Hm5 == null)
		{
			return false;
		}
		return Sy6(Hm5 as c1Y9);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Sy6(c1Y9 q7A)
	{
		if (q7A == null)
		{
			return false;
		}
		return Operators.ConditionalCompareObjectEqual(k7M(), q7A.k7M(), TextCompare: false);
	}

	[SpecialName]
	public static bool By3(c1Y9 Yp9, c1Y9 Hm6)
	{
		if (Yp9 == null || Hm6 == null)
		{
			return false;
		}
		if (object.ReferenceEquals(Yp9, Hm6))
		{
			return true;
		}
		return Yp9.Sy6(Hm6);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SpecialName]
	public static bool Zk3(c1Y9 Cx5, c1Y9 p3S)
	{
		return !By3(Cx5, p3S);
	}

	public c1Y9 c4S()
	{
		c1Y9 c1Y10 = new c1Y9();
		c1Y10.ID = RuntimeHelpers.GetObjectValue(ID);
		c1Y10.pinned = pinned;
		c1Y10.visited = visited;
		c1Y10.adjacencies = RuntimeHelpers.GetObjectValue((adjacencies == null) ? new object() : NewLateBinding.LateGet(adjacencies, null, "Clone", new object[0], null, null, null));
		c1Y10.directedVertex = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(directedVertex, new object[1] { k7M() }, null));
		return c1Y10;
	}

	internal object k7M()
	{
		throw new NotImplementedException();
	}
}
