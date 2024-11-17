using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Hk0x;
using Microsoft.VisualBasic.CompilerServices;
using q7W5;

namespace k7B1;

public class Mq41
{
	[CompilerGenerated]
	private sealed class y4X3 : IEnumerable<c1Y9>, IEnumerator<c1Y9>, IEnumerable, IDisposable, IEnumerator
	{
		public int _0024State;

		public c1Y9 _0024Current;

		public int _0024InitialThreadId;

		internal Mq41 _0024VB_0024Me;

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

		public y4X3(int _0024State)
		{
			this._0024State = _0024State;
			_0024InitialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerNonUserCode]
		private void r6M0()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in r6M0
			this.r6M0();
		}

		[CompilerGenerated]
		private bool Ak8r()
		{
			switch (_0024State)
			{
			default:
				return false;
			case 0:
			{
				int num = (_0024State = -1);
				_0024Current = _0024VB_0024Me.U;
				num = (_0024State = 1);
				return true;
			}
			case 1:
			{
				int num = (_0024State = -1);
				_0024Current = _0024VB_0024Me.V;
				num = (_0024State = 2);
				return true;
			}
			case 2:
			{
				int num = (_0024State = -1);
				return false;
			}
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Ak8r
			return this.Ak8r();
		}

		[DebuggerNonUserCode]
		private IEnumerator<c1Y9> w2NM()
		{
			y4X3 result;
			if (_0024State == -2 && _0024InitialThreadId == Environment.CurrentManagedThreadId)
			{
				_0024State = 0;
				result = this;
			}
			else
			{
				result = new y4X3(0)
				{
					_0024VB_0024Me = _0024VB_0024Me
				};
			}
			return result;
		}

		IEnumerator<c1Y9> IEnumerable<c1Y9>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in w2NM
			return this.w2NM();
		}

		[DebuggerNonUserCode]
		private IEnumerator Bw0k()
		{
			return w2NM();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Bw0k
			return this.Bw0k();
		}

		[DebuggerNonUserCode]
		private void Hk4b()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Hk4b
			this.Hk4b();
		}
	}

	private string uniqueID;

	private c1Y9 U;

	private c1Y9 V;

	public string ID { get; set; }

	public c9ZR data { get; set; }

	public bool isDirected { get; set; }

	private string m_source { get; set; }

	private string m_target { get; set; }

	private string m_interationtype { get; set; }

	public double weight { get; set; }

	public Mq41(string id, c1Y9 source, c1Y9 target, c9ZR data = null)
	{
		uniqueID = null;
		ID = id;
		this.data = data ?? new c9ZR();
		U = source;
		V = target;
		isDirected = false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Mq41()
		: this(null, null, null)
	{
	}

	public c1Y9 p1D7(c1Y9 t0C4)
	{
		if (U == t0C4)
		{
			return V;
		}
		return U;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual string Yc84()
	{
		return ID;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public virtual int Zw41()
	{
		return ID.GetHashCode();
	}

	public virtual bool w6H9(object Ra80)
	{
		if (Ra80 == null)
		{
			return false;
		}
		return r1JL(Ra80 as Mq41);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool r1JL(Mq41 g8B1)
	{
		if (g8B1 == null)
		{
			return false;
		}
		return Operators.CompareString(ID, g8B1.ID, TextCompare: false) == 0;
	}

	[SpecialName]
	public static bool e3HW(Mq41 k6QZ, Mq41 z2AF)
	{
		if (object.ReferenceEquals(k6QZ, z2AF))
		{
			return true;
		}
		if (k6QZ == null || z2AF == null)
		{
			return false;
		}
		return Operators.CompareString(k6QZ.ID, z2AF.ID, TextCompare: false) == 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SpecialName]
	public static bool Yj3c(Mq41 Ft79, Mq41 Qa6k)
	{
		return !e3HW(Ft79, Qa6k);
	}

	[IteratorStateMachine(typeof(VB_0024StateMachine_40_Iterate2Nodes))]
	public IEnumerable<c1Y9> o2XM()
	{
		//yield-return decompiler failed: Method not found
		y4X3 y4X = new y4X3(-2);
		y4X._0024VB_0024Me = this;
		return y4X;
	}

	public Mq41 o8NE()
	{
		Mq41 mq = new Mq41();
		mq.ID = ID;
		mq.isDirected = isDirected;
		mq.U = U;
		mq.V = V;
		mq.weight = weight;
		mq.data = new c9ZR
		{
			label = data.label,
			length = data.length,
			Properties = new Dictionary<string, string>(data.Properties),
			style = data.style
		};
		return mq;
	}
}
