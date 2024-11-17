using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ms35;
using Zo3y;

namespace Tn2;

[StandardModule]
public sealed class k7X
{
	[CompilerGenerated]
	private sealed class c9M : IEnumerable<object>, IEnumerator<object>, IEnumerable, IDisposable, IEnumerator
	{
		public int _0024State;

		public object _0024Current;

		public int _0024InitialThreadId;

		internal IEnumerable<string> _0024VB_0024Local_classNames;

		internal IEnumerable<string> _0024P_classNames;

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

		public c9M(int _0024State)
		{
			this._0024State = _0024State;
			_0024InitialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerNonUserCode]
		private void b2D()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b2D
			this.b2D();
		}

		[CompilerGenerated]
		private bool Jz2()
		{
			if (_0024State != 0)
			{
				return false;
			}
			int num = (_0024State = -1);
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Jz2
			return this.Jz2();
		}

		[DebuggerNonUserCode]
		private IEnumerator<object> b3S()
		{
			c9M c9M;
			if (_0024State == -2 && _0024InitialThreadId == Environment.CurrentManagedThreadId)
			{
				_0024State = 0;
				c9M = this;
			}
			else
			{
				c9M = new c9M(0);
			}
			c9M._0024VB_0024Local_classNames = _0024P_classNames;
			return c9M;
		}

		IEnumerator<object> IEnumerable<object>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in b3S
			return this.b3S();
		}

		[DebuggerNonUserCode]
		private IEnumerator g0Y()
		{
			return b3S();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in g0Y
			return this.g0Y();
		}

		[DebuggerNonUserCode]
		private void Le8()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Le8
			this.Le8();
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class Xg2
	{
		public static readonly Xg2 _0024I;

		public static Zo3y.k3CR<object, object> _0024I7_002D0;

		public static Ms35.o4TK<object, object> _0024I7_002D1;

		public static Ms35.o4TK<object, object> _0024I7_002D2;

		static Xg2()
		{
			_0024I = new Xg2();
		}

		[SpecialName]
		internal object Yg5(object z4T)
		{
			object instance;
			object[] obj = new object[1] { NewLateBinding.LateGet(instance = NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null) };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object result = NewLateBinding.LateGet(z4T, null, "data", obj, null, null, obj2);
			if (array2[0])
			{
				NewLateBinding.LateSetComplex(instance, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
			}
			return result;
		}

		[SpecialName]
		internal object d2H(object Hd8)
		{
			return NewLateBinding.LateGet(Hd8, null, "Key", new object[0], null, null, null);
		}

		[SpecialName]
		internal object Ma4(object Lk9)
		{
			return NewLateBinding.LateGet(Lk9, null, "NodeIndex", new object[0], null, null, null);
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _NamesOf;

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

	[IteratorStateMachine(typeof(VB_0024StateMachine_4_ClassNameTuples))]
	public static IEnumerable<object> r9S(this IEnumerable<string> Az7)
	{
		//yield-return decompiler failed: Method not found
		c9M c9M = new c9M(-2);
		c9M._0024P_classNames = Az7;
		return c9M;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static object n6D(this object n3R, string[] Ad9, bool a5Y = true)
	{
		object[] obj = new object[2]
		{
			r9S(Ad9).ToArray(),
			a5Y
		};
		object[] array = obj;
		bool[] obj2 = new bool[2] { false, true };
		bool[] array2 = obj2;
		object result = NewLateBinding.LateGet(n3R, null, "ToVector", obj, null, null, obj2);
		if (array2[1])
		{
			a5Y = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(bool));
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static object Ac4(this IEnumerable<object> Xd9)
	{
		object result = default(object);
		return result;
	}

	public static object Cp9(this object Ef8, object d9T, bool p4X = true)
	{
		checked
		{
			double[] array = new double[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(d9T, null, "Length", new object[0], null, null, null), 1)) + 1];
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Ef8, null, "vertex", new object[0], null, null, null), null, "GroupBy", new object[1] { (Zo3y.k3CR<object, object>)([SpecialName] (object z4T) =>
			{
				object instance;
				object[] obj = new object[1] { NewLateBinding.LateGet(instance = NamesOf, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[0], null, null, null) };
				object[] array2 = obj;
				bool[] obj2 = new bool[1] { true };
				bool[] array3 = obj2;
				object result = NewLateBinding.LateGet(z4T, null, "data", obj, null, null, obj2);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(instance, null, "REFLECTION_ID_MAPPING_NODETYPE", new object[1] { array2[0] }, null, null, OptimisticSet: true, RValueBase: true);
				}
				return result;
			}) }, null, null, null), null, "ToDictionary", new object[2]
			{
				(Ms35.o4TK<object, object>)([SpecialName] (object Hd8) => NewLateBinding.LateGet(Hd8, null, "Key", new object[0], null, null, null)),
				(Ms35.o4TK<object, object>)([SpecialName] (object Lk9) => NewLateBinding.LateGet(Lk9, null, "NodeIndex", new object[0], null, null, null))
			}, null, null, null));
			object[] array4 = (object[])NewLateBinding.LateGet(NewLateBinding.LateGet(Ef8, null, "graphEdges", new object[0], null, null, null), null, "ToArray", new object[0], null, null, null);
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(d9T, null, "Length", new object[0], null, null, null), 1));
			for (int i = 0; i <= num; i++)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(d9T, new object[1] { i }, null));
				object[] array5 = new object[1];
				object instance2 = objectValue2;
				array5[0] = NewLateBinding.LateGet(instance2, null, "u_cls", new object[0], null, null, null);
				object[] array6 = array5;
				bool[] array7;
				object obj3 = NewLateBinding.LateGet(objectValue, null, "TryGetValue", array5, null, null, array7 = new bool[1] { true });
				if (array7[0])
				{
					NewLateBinding.LateSetComplex(instance2, null, "u_cls", new object[1] { array6[0] }, null, null, OptimisticSet: true, RValueBase: false);
				}
				object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
				object[] array8 = new object[1];
				instance2 = objectValue2;
				array8[0] = NewLateBinding.LateGet(instance2, null, "v_cls", new object[0], null, null, null);
				array6 = array8;
				obj3 = NewLateBinding.LateGet(objectValue, null, "TryGetValue", array8, null, null, array7 = new bool[1] { true });
				if (array7[0])
				{
					NewLateBinding.LateSetComplex(instance2, null, "v_cls", new object[1] { array6[0] }, null, null, OptimisticSet: true, RValueBase: false);
				}
				object objectValue4 = RuntimeHelpers.GetObjectValue(obj3);
				if (objectValue3 == null || objectValue4 == null)
				{
					array[i] = 0.0;
					continue;
				}
				object[] array9 = array4;
				for (int j = 0; j < array9.Length; j++)
				{
					object objectValue5 = RuntimeHelpers.GetObjectValue(array9[j]);
					if (Conversions.ToBoolean(Conversions.ToBoolean(LikeOperator.LikeObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "U", new object[0], null, null, null), null, "label", new object[0], null, null, null), objectValue3, CompareMethod.Binary)) && Conversions.ToBoolean(LikeOperator.LikeObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "V", new object[0], null, null, null), null, "label", new object[0], null, null, null), objectValue4, CompareMethod.Binary))))
					{
						ref double reference = ref array[i];
						reference = Conversions.ToDouble(Operators.AddObject(reference, NewLateBinding.LateGet(objectValue5, null, "weight", new object[0], null, null, null)));
					}
					if (!p4X && Conversions.ToBoolean(Conversions.ToBoolean(LikeOperator.LikeObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "V", new object[0], null, null, null), null, "label", new object[0], null, null, null), objectValue3, CompareMethod.Binary)) && Conversions.ToBoolean(LikeOperator.LikeObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "U", new object[0], null, null, null), null, "label", new object[0], null, null, null), objectValue4, CompareMethod.Binary))))
					{
						ref double reference2 = ref array[i];
						reference2 = Conversions.ToDouble(Operators.AddObject(reference2, NewLateBinding.LateGet(objectValue5, null, "weight", new object[0], null, null, null)));
					}
				}
			}
			return new object();
		}
	}
}
