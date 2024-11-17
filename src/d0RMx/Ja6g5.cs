using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace d0RMx;

[Serializable]
public class Ja6g5
{
	private class k1BMd
	{
		public void Dx2i7()
		{
		}
	}

	public interface Pa0q7
	{
		bool filter(object cell);
	}

	public class Zo6q3
	{
		protected internal object root;

		protected internal object previous;

		public Zo6q3()
			: this(null, null)
		{
		}

		public Zo6q3(Ja6g5 model, object root)
		{
		}

		public void Xp49P()
		{
			root = RuntimeHelpers.GetObjectValue(previous);
		}
	}

	public class x1PMr
	{
		protected internal object parent;

		protected internal object previous;

		protected internal object child;

		protected internal int index;

		protected internal int previousIndex;

		public x1PMr()
			: this(null, null, null, 0)
		{
		}

		public x1PMr(Ja6g5 model, object parent, object child)
			: this(model, RuntimeHelpers.GetObjectValue(parent), RuntimeHelpers.GetObjectValue(child), 0)
		{
		}

		public x1PMr(Ja6g5 model, object parent, object child, int index)
		{
		}

		protected internal object k5MBr(object Pi7f9, bool b1W2K)
		{
			object result = default(object);
			return result;
		}

		protected internal void Jw05X(object n1PWo, object k8H5G, bool t3XSz)
		{
			object[] obj = new object[2] { k8H5G, t3XSz };
			object[] array = obj;
			bool[] obj2 = new bool[2] { false, true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(n1PWo, null, "setTerminal", obj, null, null, obj2, IgnoreReturn: true);
			if (array2[1])
			{
				t3XSz = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(bool));
			}
		}

		protected internal void t3CQw(object Ww16K, bool m3CLf)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(k5MBr(RuntimeHelpers.GetObjectValue(Ww16K), b1W2K: true));
			object objectValue2 = RuntimeHelpers.GetObjectValue(k5MBr(RuntimeHelpers.GetObjectValue(Ww16K), b1W2K: false));
			if (objectValue == null || m3CLf)
			{
			}
			if (objectValue2 == null || m3CLf)
			{
			}
			Jw05X(RuntimeHelpers.GetObjectValue(Ww16K), RuntimeHelpers.GetObjectValue(objectValue), t3XSz: true);
			Jw05X(RuntimeHelpers.GetObjectValue(Ww16K), RuntimeHelpers.GetObjectValue(objectValue2), t3XSz: false);
			checked
			{
				int num = default(int);
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
				}
			}
		}

		protected internal int z7Y3F(object e0T7D, object Zs69B)
		{
			return Conversions.ToInteger((e0T7D is object && Zs69B is object) ? NewLateBinding.LateGet(e0T7D, null, "getIndex", new object[1] { Zs69B }, null, null, null) : ((object)0));
		}

		public void Eo8q0()
		{
			object obj = default(object);
			int num = z7Y3F(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(child));
			if (previous == null)
			{
				t3CQw(RuntimeHelpers.GetObjectValue(child), m3CLf: false);
			}
			if (previous != null)
			{
				t3CQw(RuntimeHelpers.GetObjectValue(child), m3CLf: true);
			}
			parent = RuntimeHelpers.GetObjectValue(previous);
			previous = RuntimeHelpers.GetObjectValue(obj);
			index = previousIndex;
			previousIndex = num;
		}
	}

	public class m0R9M
	{
		protected internal object cell;

		protected internal object terminal;

		protected internal object previous;

		protected internal bool source;

		public m0R9M()
			: this(null, null, null, source: false)
		{
		}

		public m0R9M(Ja6g5 model, object cell, object terminal, bool source)
		{
		}

		public void t1BYc()
		{
			terminal = RuntimeHelpers.GetObjectValue(previous);
		}
	}

	public class k5A8W
	{
		protected internal object cell;

		protected internal object value;

		protected internal object previous;

		public k5A8W()
			: this(null, null, null)
		{
		}

		public k5A8W(Ja6g5 model, object cell, object value)
		{
		}

		public void x9MYa()
		{
			value = RuntimeHelpers.GetObjectValue(previous);
		}
	}

	public class p7M9K
	{
		protected internal object cell;

		protected internal string style;

		protected internal string previous;

		public p7M9K()
			: this(null, null, null)
		{
		}

		public p7M9K(Ja6g5 model, object cell, string style)
		{
		}

		public void j2T9Y()
		{
			style = previous;
		}
	}

	public class Mo91G
	{
		protected internal object cell;

		protected internal object geometry;

		protected internal object previous;

		public Mo91G()
			: this(null, null, null)
		{
		}

		public Mo91G(Ja6g5 model, object cell, object geometry)
		{
		}

		public void Ds68A()
		{
			geometry = RuntimeHelpers.GetObjectValue(previous);
		}
	}

	public class Eg40Y
	{
		protected internal object cell;

		protected internal bool collapsed;

		protected internal bool previous;

		public Eg40Y()
			: this(null, null, collapsed: false)
		{
		}

		public Eg40Y(Ja6g5 model, object cell, bool collapsed)
		{
		}

		public void s9G6B()
		{
			collapsed = previous;
		}
	}

	public class s4D9Y
	{
		protected internal object cell;

		protected internal bool visible;

		protected internal bool previous;

		public s4D9Y()
			: this(null, null, visible: false)
		{
		}

		public s4D9Y(Ja6g5 model, object cell, bool visible)
		{
		}

		public void m3J0B()
		{
			visible = previous;
		}
	}

	protected internal object root;

	protected internal IDictionary<string, object> cells;

	protected internal bool maintainEdgeParent;

	protected internal bool createIds;

	protected internal int nextId;

	[NonSerialized]
	protected internal object currentEdit;

	[NonSerialized]
	protected internal int updateLevel;

	[NonSerialized]
	protected internal bool endingUpdate;

	private object mxCellPath;

	private static object java;

	public Ja6g5()
		: this(null)
	{
	}

	public Ja6g5(object root)
	{
		maintainEdgeParent = true;
		createIds = true;
		nextId = 0;
		updateLevel = 0;
		endingUpdate = false;
		currentEdit = RuntimeHelpers.GetObjectValue(d5R6E());
		if (root != null)
		{
			root = RuntimeHelpers.GetObjectValue(root);
		}
		else
		{
			f7GFn();
		}
	}

	public void f7GFn()
	{
		root = RuntimeHelpers.GetObjectValue(w0HGp());
	}

	public object w0HGp()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateCall(objectValue, null, "insert", new object[1]
		{
			new object()
		}, null, null, null, IgnoreReturn: true);
		return objectValue;
	}

	public object Ja5y4(string o2F9J)
	{
		object result = null;
		if (cells != null)
		{
			result = RuntimeHelpers.GetObjectValue(cells[o2F9J]);
		}
		return result;
	}

	public object x8S5Y(object f5LCp)
	{
		o0A4Z(new Zo6q3(this, RuntimeHelpers.GetObjectValue(f5LCp)));
		return f5LCp;
	}

	protected internal object Lb86J(object Ni8b3)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(root);
		root = RuntimeHelpers.GetObjectValue(Ni8b3);
		nextId = 0;
		cells = null;
		t2R9B(RuntimeHelpers.GetObjectValue(Ni8b3));
		return objectValue;
	}

	protected internal object d5R6E()
	{
		return new k1BMd();
	}

	public object[] Qi49L(object[] r4CJa, bool Mz7a1)
	{
		IDictionary<object, object> dictionary = new Dictionary<object, object>();
		checked
		{
			object[] array = new object[r4CJa.Length - 1 + 1];
			int num = r4CJa.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					array[i] = RuntimeHelpers.GetObjectValue(Ly19M(RuntimeHelpers.GetObjectValue(r4CJa[i]), dictionary, Mz7a1));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			int num2 = r4CJa.Length - 1;
			for (int j = 0; j <= num2; j++)
			{
				w7G9K(RuntimeHelpers.GetObjectValue(array[j]), RuntimeHelpers.GetObjectValue(r4CJa[j]), dictionary);
			}
			return array;
		}
	}

	protected internal object Ly19M(object r6K0Q, IDictionary<object, object> Kf61J, bool Be0i9)
	{
		checked
		{
			if (r6K0Q is object)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(r6K0Q, null, "clone", new object[0], null, null, null));
				Kf61J[RuntimeHelpers.GetObjectValue(r6K0Q)] = RuntimeHelpers.GetObjectValue(objectValue);
				if (Be0i9)
				{
					int num = Dc02F(RuntimeHelpers.GetObjectValue(r6K0Q));
					int num2 = num - 1;
					for (int i = 0; i <= num2; i++)
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(Ly19M(RuntimeHelpers.GetObjectValue(s2L8C(RuntimeHelpers.GetObjectValue(r6K0Q), i)), Kf61J, Be0i9: true));
						NewLateBinding.LateCall(objectValue, null, "insert", new object[1] { objectValue2 }, null, null, null, IgnoreReturn: true);
					}
				}
				return objectValue;
			}
			return null;
		}
	}

	protected internal void w7G9K(object s4R6D, object Xx2c0, IDictionary<object, object> Rd8a3)
	{
		if (s4R6D is object)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(s4R6D);
			object objectValue2 = RuntimeHelpers.GetObjectValue(Ho6z7(RuntimeHelpers.GetObjectValue(Xx2c0), Tt47E: true));
			if (objectValue2 is object)
			{
				object objectValue3 = RuntimeHelpers.GetObjectValue(Rd8a3[RuntimeHelpers.GetObjectValue(objectValue2)]);
				if (objectValue3 != null)
				{
					object[] obj = new object[2] { objectValue, true };
					object[] array = obj;
					bool[] obj2 = new bool[2] { true, false };
					bool[] array2 = obj2;
					NewLateBinding.LateCall(objectValue3, null, "insertEdge", obj, null, null, obj2, IgnoreReturn: true);
					if (array2[0])
					{
						objectValue = RuntimeHelpers.GetObjectValue(array[0]);
					}
				}
			}
			object objectValue4 = RuntimeHelpers.GetObjectValue(Ho6z7(RuntimeHelpers.GetObjectValue(Xx2c0), Tt47E: false));
			if (objectValue4 is object)
			{
				object objectValue5 = RuntimeHelpers.GetObjectValue(Rd8a3[RuntimeHelpers.GetObjectValue(objectValue4)]);
				if (objectValue5 != null)
				{
					object[] obj3 = new object[2] { objectValue, false };
					object[] array = obj3;
					bool[] obj4 = new bool[2] { true, false };
					bool[] array2 = obj4;
					NewLateBinding.LateCall(objectValue5, null, "insertEdge", obj3, null, null, obj4, IgnoreReturn: true);
					if (array2[0])
					{
						objectValue = RuntimeHelpers.GetObjectValue(array[0]);
					}
				}
			}
		}
		int num = Dc02F(RuntimeHelpers.GetObjectValue(s4R6D));
		checked
		{
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				w7G9K(RuntimeHelpers.GetObjectValue(s2L8C(RuntimeHelpers.GetObjectValue(s4R6D), i)), RuntimeHelpers.GetObjectValue(s2L8C(RuntimeHelpers.GetObjectValue(Xx2c0), i)), Rd8a3);
			}
		}
	}

	public bool Lr0e6(object Cr1e7, object Dw3f4)
	{
		while (Dw3f4 != null && Dw3f4 != Cr1e7)
		{
			Dw3f4 = RuntimeHelpers.GetObjectValue(Ci89F(RuntimeHelpers.GetObjectValue(Dw3f4)));
		}
		return Dw3f4 == Cr1e7;
	}

	public bool f0WBr(object t5WJi)
	{
		return Lr0e6(RuntimeHelpers.GetObjectValue(root), RuntimeHelpers.GetObjectValue(t5WJi));
	}

	public object Ci89F(object Sd5q2)
	{
		return (Sd5q2 is object) ? NewLateBinding.LateGet(Sd5q2, null, "Parent", new object[0], null, null, null) : null;
	}

	public object Mm94B(object Fo06K, object o9R8X, int z8LTf)
	{
		if (o9R8X != Fo06K && Fo06K != null && o9R8X != null)
		{
			bool flag = Fo06K != Ci89F(RuntimeHelpers.GetObjectValue(o9R8X));
			o0A4Z(new x1PMr(this, RuntimeHelpers.GetObjectValue(Fo06K), RuntimeHelpers.GetObjectValue(o9R8X), z8LTf));
			if (maintainEdgeParent && flag)
			{
				Jp9m2(RuntimeHelpers.GetObjectValue(o9R8X));
			}
		}
		return o9R8X;
	}

	protected internal void t2R9B(object Do15G)
	{
		if (!(Do15G is object))
		{
			return;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Do15G);
		if (NewLateBinding.LateGet(objectValue, null, "Id", new object[0], null, null, null) == null && createIds)
		{
			NewLateBinding.LateSet(objectValue, null, "Id", new object[1] { n0QRs(RuntimeHelpers.GetObjectValue(Do15G)) }, null, null);
		}
		if (NewLateBinding.LateGet(objectValue, null, "Id", new object[0], null, null, null) != null)
		{
			object objectValue2 = RuntimeHelpers.GetObjectValue(Ja5y4(Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Id", new object[0], null, null, null))));
			if (objectValue2 != Do15G)
			{
				while (objectValue2 != null)
				{
					NewLateBinding.LateSet(objectValue, null, "Id", new object[1] { n0QRs(RuntimeHelpers.GetObjectValue(Do15G)) }, null, null);
					objectValue2 = RuntimeHelpers.GetObjectValue(Ja5y4(Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Id", new object[0], null, null, null))));
				}
				if (cells == null)
				{
					cells = new Dictionary<string, object>();
				}
				cells[Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Id", new object[0], null, null, null))] = RuntimeHelpers.GetObjectValue(Do15G);
			}
		}
		try
		{
			int num = Convert.ToInt32(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "Id", new object[0], null, null, null)));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		int num2 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "ChildCount", new object[0], null, null, null));
		checked
		{
			int num3 = num2 - 1;
			for (int i = 0; i <= num3; i++)
			{
				object[] array;
				bool[] array2;
				object obj = NewLateBinding.LateGet(objectValue, null, "getChildAt", array = new object[1] { i }, null, null, array2 = new bool[1] { true });
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				t2R9B(RuntimeHelpers.GetObjectValue(obj));
			}
		}
	}

	public string n0QRs(object a5H3F)
	{
		string result = Convert.ToString(nextId);
		checked
		{
			nextId++;
			return result;
		}
	}

	public object q6QHp(object Ps43D)
	{
		if (Ps43D == root)
		{
			root = null;
		}
		else if (Ci89F(RuntimeHelpers.GetObjectValue(Ps43D)) != null)
		{
			o0A4Z(new x1PMr(this, null, RuntimeHelpers.GetObjectValue(Ps43D)));
		}
		return Ps43D;
	}

	protected internal void Qn9a5(object Jj54H)
	{
		if (!(Jj54H is object))
		{
			return;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Jj54H);
		int num = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, null, "ChildCount", new object[0], null, null, null));
		checked
		{
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				object[] array;
				bool[] array2;
				object obj = NewLateBinding.LateGet(objectValue, null, "getChildAt", array = new object[1] { i }, null, null, array2 = new bool[1] { true });
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				Qn9a5(RuntimeHelpers.GetObjectValue(obj));
			}
			if (cells != null && NewLateBinding.LateGet(objectValue, null, "Id", new object[0], null, null, null) == null)
			{
			}
		}
	}

	protected internal object q2R0B(object j9HDg, object m8Y3F, int p5MSf)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(j9HDg);
		object objectValue2 = RuntimeHelpers.GetObjectValue(Ci89F(RuntimeHelpers.GetObjectValue(j9HDg)));
		if (m8Y3F != null)
		{
			object[] array;
			bool[] array2;
			if (m8Y3F == objectValue2)
			{
				object[] obj = new object[1] { objectValue };
				array = obj;
				bool[] obj2 = new bool[1] { true };
				array2 = obj2;
				object left = NewLateBinding.LateGet(objectValue2, null, "getIndex", obj, null, null, obj2);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (!Operators.ConditionalCompareObjectNotEqual(left, p5MSf, TextCompare: false))
				{
					goto IL_0194;
				}
			}
			NewLateBinding.LateCall(m8Y3F, null, "insert", array = new object[2] { objectValue, p5MSf }, null, null, array2 = new bool[2] { true, true }, IgnoreReturn: true);
			if (array2[0])
			{
				objectValue = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (array2[1])
			{
				p5MSf = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
		}
		else if (objectValue2 != null)
		{
			object[] obj3 = new object[1] { objectValue };
			object[] array = obj3;
			bool[] obj4 = new bool[1] { true };
			bool[] array2 = obj4;
			object value = NewLateBinding.LateGet(objectValue2, null, "getIndex", obj3, null, null, obj4);
			if (array2[0])
			{
				objectValue = RuntimeHelpers.GetObjectValue(array[0]);
			}
			int num = Conversions.ToInteger(value);
			NewLateBinding.LateCall(objectValue2, null, "remove", array = new object[1] { num }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
			if (array2[0])
			{
				num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
		}
		goto IL_0194;
		IL_0194:
		if (!f0WBr(RuntimeHelpers.GetObjectValue(objectValue2)) && m8Y3F != null)
		{
			t2R9B(RuntimeHelpers.GetObjectValue(j9HDg));
		}
		else if (m8Y3F == null)
		{
			Qn9a5(RuntimeHelpers.GetObjectValue(j9HDg));
		}
		return objectValue2;
	}

	public int Dc02F(object b1PAr)
	{
		return Conversions.ToInteger((b1PAr is object) ? NewLateBinding.LateGet(b1PAr, null, "ChildCount", new object[0], null, null, null) : ((object)0));
	}

	public object s2L8C(object Nx5j4, int y7W8J)
	{
		object result;
		if (!(Nx5j4 is object))
		{
			result = null;
		}
		else
		{
			object[] obj = new object[1] { y7W8J };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object obj3 = NewLateBinding.LateGet(Nx5j4, null, "getChildAt", obj, null, null, obj2);
			if (array2[0])
			{
				y7W8J = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			result = obj3;
		}
		return result;
	}

	public object Ho6z7(object p8NEz, bool Tt47E)
	{
		object result;
		if (!(p8NEz is object))
		{
			result = null;
		}
		else
		{
			object[] obj = new object[1] { Tt47E };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object obj3 = NewLateBinding.LateGet(p8NEz, null, "getTerminal", obj, null, null, obj2);
			if (array2[0])
			{
				Tt47E = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(bool));
			}
			result = obj3;
		}
		return result;
	}

	public object f3XZw(object Cp43T, object a0T2G, bool y7JBn)
	{
		bool flag = a0T2G != Ho6z7(RuntimeHelpers.GetObjectValue(Cp43T), y7JBn);
		o0A4Z(new m0R9M(this, RuntimeHelpers.GetObjectValue(Cp43T), RuntimeHelpers.GetObjectValue(a0T2G), y7JBn));
		if (maintainEdgeParent && flag)
		{
			s6X5G(RuntimeHelpers.GetObjectValue(Cp43T), RuntimeHelpers.GetObjectValue(root));
		}
		return a0T2G;
	}

	protected internal object m1ZWx(object c5F2N, object Yt8q0, bool Jr4e9)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Ho6z7(RuntimeHelpers.GetObjectValue(c5F2N), Jr4e9));
		if (Yt8q0 != null)
		{
			object[] obj = new object[2] { c5F2N, Jr4e9 };
			object[] array = obj;
			bool[] obj2 = new bool[2] { false, true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(Yt8q0, null, "insertEdge", obj, null, null, obj2, IgnoreReturn: true);
			if (array2[1])
			{
				Jr4e9 = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(bool));
			}
		}
		else if (objectValue != null)
		{
			object[] obj3 = new object[2] { c5F2N, Jr4e9 };
			object[] array = obj3;
			bool[] obj4 = new bool[2] { false, true };
			bool[] array2 = obj4;
			NewLateBinding.LateCall(objectValue, null, "removeEdge", obj3, null, null, obj4, IgnoreReturn: true);
			if (array2[1])
			{
				Jr4e9 = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(bool));
			}
		}
		return objectValue;
	}

	public void Jp9m2(object w6JEd)
	{
		Pn43H(RuntimeHelpers.GetObjectValue(w6JEd), RuntimeHelpers.GetObjectValue(root));
	}

	public void Pn43H(object j9FMk, object Jc02S)
	{
		int num = Dc02F(RuntimeHelpers.GetObjectValue(j9FMk));
		checked
		{
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(s2L8C(RuntimeHelpers.GetObjectValue(j9FMk), i));
				Pn43H(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(Jc02S));
			}
			int num3 = b9NYo(RuntimeHelpers.GetObjectValue(j9FMk));
			IList<object> list = new List<object>(num3);
			int num4 = num3 - 1;
			for (int j = 0; j <= num4; j++)
			{
				list.Add(RuntimeHelpers.GetObjectValue(i5M0L(RuntimeHelpers.GetObjectValue(j9FMk), j)));
			}
			IEnumerator<object> enumerator = list.GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator.Current);
				if (Lr0e6(RuntimeHelpers.GetObjectValue(Jc02S), RuntimeHelpers.GetObjectValue(objectValue2)))
				{
					s6X5G(RuntimeHelpers.GetObjectValue(objectValue2), RuntimeHelpers.GetObjectValue(Jc02S));
				}
			}
		}
	}

	public void s6X5G(object d2HDt, object Dk87L)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Ho6z7(RuntimeHelpers.GetObjectValue(d2HDt), Tt47E: true));
		object objectValue2 = RuntimeHelpers.GetObjectValue(Ho6z7(RuntimeHelpers.GetObjectValue(d2HDt), Tt47E: false));
		object obj = null;
		while (Conversions.ToBoolean(objectValue != null && !a4M5B(RuntimeHelpers.GetObjectValue(objectValue)) && Zt37J(RuntimeHelpers.GetObjectValue(objectValue)) != null && Conversions.ToBoolean(NewLateBinding.LateGet(Zt37J(RuntimeHelpers.GetObjectValue(objectValue)), null, "Relative", new object[0], null, null, null))))
		{
			objectValue = RuntimeHelpers.GetObjectValue(Ci89F(RuntimeHelpers.GetObjectValue(objectValue)));
		}
		while (Conversions.ToBoolean(objectValue2 != null && !a4M5B(RuntimeHelpers.GetObjectValue(objectValue2)) && Zt37J(RuntimeHelpers.GetObjectValue(objectValue2)) != null && Conversions.ToBoolean(NewLateBinding.LateGet(Zt37J(RuntimeHelpers.GetObjectValue(objectValue2)), null, "Relative", new object[0], null, null, null))))
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(Ci89F(RuntimeHelpers.GetObjectValue(objectValue2)));
		}
		if (!Lr0e6(RuntimeHelpers.GetObjectValue(Dk87L), RuntimeHelpers.GetObjectValue(objectValue)) || !Lr0e6(RuntimeHelpers.GetObjectValue(Dk87L), RuntimeHelpers.GetObjectValue(objectValue2)))
		{
			return;
		}
		obj = ((objectValue != objectValue2) ? RuntimeHelpers.GetObjectValue(a0NQb(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2))) : RuntimeHelpers.GetObjectValue(Ci89F(RuntimeHelpers.GetObjectValue(objectValue))));
		if (obj != null && (Ci89F(RuntimeHelpers.GetObjectValue(obj)) != Dk87L || Lr0e6(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(d2HDt))) && Ci89F(RuntimeHelpers.GetObjectValue(d2HDt)) != obj)
		{
			object objectValue3 = RuntimeHelpers.GetObjectValue(Zt37J(RuntimeHelpers.GetObjectValue(d2HDt)));
			if (objectValue3 != null)
			{
				object objectValue4 = RuntimeHelpers.GetObjectValue(Wm53X(RuntimeHelpers.GetObjectValue(Ci89F(RuntimeHelpers.GetObjectValue(d2HDt)))));
				object objectValue5 = RuntimeHelpers.GetObjectValue(Wm53X(RuntimeHelpers.GetObjectValue(obj)));
				double num = Conversions.ToDouble(Operators.SubtractObject(NewLateBinding.LateGet(objectValue5, null, "X", new object[0], null, null, null), NewLateBinding.LateGet(objectValue4, null, "X", new object[0], null, null, null)));
				double num2 = Conversions.ToDouble(Operators.SubtractObject(NewLateBinding.LateGet(objectValue5, null, "Y", new object[0], null, null, null), NewLateBinding.LateGet(objectValue4, null, "Y", new object[0], null, null, null)));
				objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue3, null, "clone", new object[0], null, null, null));
				NewLateBinding.LateCall(objectValue3, null, "translate", new object[2]
				{
					0.0 - num,
					0.0 - num2
				}, null, null, null, IgnoreReturn: true);
				Px56Y(RuntimeHelpers.GetObjectValue(d2HDt), RuntimeHelpers.GetObjectValue(objectValue3));
			}
			Mm94B(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(d2HDt), Dc02F(RuntimeHelpers.GetObjectValue(obj)));
		}
	}

	public object Wm53X(object b0NYz)
	{
		object obj = null;
		if (b0NYz != null)
		{
			obj = RuntimeHelpers.GetObjectValue(Wm53X(RuntimeHelpers.GetObjectValue(Ci89F(RuntimeHelpers.GetObjectValue(b0NYz)))));
			if (!a4M5B(RuntimeHelpers.GetObjectValue(b0NYz)))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Zt37J(RuntimeHelpers.GetObjectValue(b0NYz)));
				if (objectValue != null)
				{
					NewLateBinding.LateSet(obj, null, "X", new object[1] { Operators.AddObject(NewLateBinding.LateGet(obj, null, "X", new object[0], null, null, null), NewLateBinding.LateGet(objectValue, null, "X", new object[0], null, null, null)) }, null, null);
					NewLateBinding.LateSet(obj, null, "Y", new object[1] { Operators.AddObject(NewLateBinding.LateGet(obj, null, "Y", new object[0], null, null, null), NewLateBinding.LateGet(objectValue, null, "Y", new object[0], null, null, null)) }, null, null);
				}
			}
		}
		else
		{
			obj = RuntimeHelpers.GetObjectValue(new object());
		}
		return obj;
	}

	public object a0NQb(object i6H4K, object Er31Q)
	{
		if (i6H4K != null && Er31Q != null)
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(mxCellPath, null, "create", new object[1] { Er31Q }, null, null, null));
			if (text != null && text.Length > 0)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(i6H4K);
				string text2 = Conversions.ToString(NewLateBinding.LateGet(mxCellPath, null, "create", new object[1] { objectValue }, null, null, null));
				while (objectValue != null)
				{
					object objectValue2 = RuntimeHelpers.GetObjectValue(Ci89F(RuntimeHelpers.GetObjectValue(objectValue)));
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(text, null, "IndexOf", new object[1] { Operators.AddObject(text2, NewLateBinding.LateGet(mxCellPath, null, "PATH_SEPARATOR", new object[0], null, null, null)) }, null, null, null), 0, TextCompare: false) && objectValue2 != null)
					{
						return objectValue;
					}
					object[] array;
					bool[] array2;
					object obj = NewLateBinding.LateGet(mxCellPath, null, "getParentPath", array = new object[1] { text2 }, null, null, array2 = new bool[1] { true });
					if (array2[0])
					{
						text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
					}
					text2 = Conversions.ToString(obj);
					objectValue = RuntimeHelpers.GetObjectValue(objectValue2);
				}
			}
		}
		return null;
	}

	public int b9NYo(object y1Y3K)
	{
		return Conversions.ToInteger((y1Y3K is object) ? NewLateBinding.LateGet(y1Y3K, null, "EdgeCount", new object[0], null, null, null) : ((object)0));
	}

	public object i5M0L(object Ef6g0, int Hc8f4)
	{
		object result;
		if (!(Ef6g0 is object))
		{
			result = null;
		}
		else
		{
			object[] obj = new object[1] { Hc8f4 };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object obj3 = NewLateBinding.LateGet(Ef6g0, null, "getEdgeAt", obj, null, null, obj2);
			if (array2[0])
			{
				Hc8f4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			result = obj3;
		}
		return result;
	}

	public bool y8RDb(object m4W1H)
	{
		return Conversions.ToBoolean((m4W1H is object) ? NewLateBinding.LateGet(m4W1H, null, "Vertex", new object[0], null, null, null) : ((object)false));
	}

	public bool a4M5B(object q1ACf)
	{
		return Conversions.ToBoolean((q1ACf is object) ? NewLateBinding.LateGet(q1ACf, null, "Edge", new object[0], null, null, null) : ((object)false));
	}

	public bool a5FGp(object Pe62S)
	{
		return Conversions.ToBoolean((Pe62S is object) ? NewLateBinding.LateGet(Pe62S, null, "Connectable", new object[0], null, null, null) : ((object)true));
	}

	public object p6B1Q(object n3N5E)
	{
		return (n3N5E is object) ? NewLateBinding.LateGet(n3N5E, null, "Value", new object[0], null, null, null) : null;
	}

	public object f1D5C(object Km50B, object e7NBs)
	{
		o0A4Z(new k5A8W(this, RuntimeHelpers.GetObjectValue(Km50B), RuntimeHelpers.GetObjectValue(e7NBs)));
		return e7NBs;
	}

	protected internal object Ee3w7(object Gg6d0, object s0QBm)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Gg6d0, null, "Value", new object[0], null, null, null));
		NewLateBinding.LateSetComplex(Gg6d0, null, "Value", new object[1] { s0QBm }, null, null, OptimisticSet: false, RValueBase: true);
		return objectValue;
	}

	public object Zt37J(object Jw6e3)
	{
		return (Jw6e3 is object) ? NewLateBinding.LateGet(Jw6e3, null, "Geometry", new object[0], null, null, null) : null;
	}

	public object Px56Y(object p3QKc, object Hr4n2)
	{
		if (Hr4n2 != Zt37J(RuntimeHelpers.GetObjectValue(p3QKc)))
		{
			o0A4Z(new Mo91G(this, RuntimeHelpers.GetObjectValue(p3QKc), RuntimeHelpers.GetObjectValue(Hr4n2)));
		}
		return Hr4n2;
	}

	protected internal object a0M3W(object Fp2r3, object f5YNj)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Zt37J(RuntimeHelpers.GetObjectValue(Fp2r3)));
		NewLateBinding.LateSetComplex(Fp2r3, null, "Geometry", new object[1] { f5YNj }, null, null, OptimisticSet: false, RValueBase: true);
		return objectValue;
	}

	public string Qy73C(object b8Z7P)
	{
		return Conversions.ToString((b8Z7P is object) ? NewLateBinding.LateGet(b8Z7P, null, "Style", new object[0], null, null, null) : null);
	}

	public string Lz9g4(object Cn7a2, string o6F4H)
	{
		if (o6F4H == null || !o6F4H.Equals(Qy73C(RuntimeHelpers.GetObjectValue(Cn7a2))))
		{
			o0A4Z(new p7M9K(this, RuntimeHelpers.GetObjectValue(Cn7a2), o6F4H));
		}
		return o6F4H;
	}

	protected internal string Hw35Y(object Xe81A, string St62G)
	{
		string result = Qy73C(RuntimeHelpers.GetObjectValue(Xe81A));
		NewLateBinding.LateSetComplex(Xe81A, null, "Style", new object[1] { St62G }, null, null, OptimisticSet: false, RValueBase: true);
		return result;
	}

	public bool Re58J(object q3T5D)
	{
		return Conversions.ToBoolean((q3T5D is object) ? NewLateBinding.LateGet(q3T5D, null, "Collapsed", new object[0], null, null, null) : ((object)false));
	}

	public bool Po16G(object d3R5Q, bool Rg2o5)
	{
		if (Rg2o5 != Re58J(RuntimeHelpers.GetObjectValue(d3R5Q)))
		{
			o0A4Z(new Eg40Y(this, RuntimeHelpers.GetObjectValue(d3R5Q), Rg2o5));
		}
		return Rg2o5;
	}

	protected internal bool Wg59N(object Kw4e2, bool Wk1a4)
	{
		bool result = Re58J(RuntimeHelpers.GetObjectValue(Kw4e2));
		NewLateBinding.LateSetComplex(Kw4e2, null, "Collapsed", new object[1] { Wk1a4 }, null, null, OptimisticSet: false, RValueBase: true);
		return result;
	}

	public bool Wp9x0(object q8AZj)
	{
		return Conversions.ToBoolean((q8AZj is object) ? NewLateBinding.LateGet(q8AZj, null, "Visible", new object[0], null, null, null) : ((object)false));
	}

	public bool j6Y2S(object Kx2i7, bool Yk4e0)
	{
		if (Yk4e0 != Wp9x0(RuntimeHelpers.GetObjectValue(Kx2i7)))
		{
			o0A4Z(new s4D9Y(this, RuntimeHelpers.GetObjectValue(Kx2i7), Yk4e0));
		}
		return Yk4e0;
	}

	protected internal bool Ej29K(object e3QSq, bool m7K8F)
	{
		bool result = Wp9x0(RuntimeHelpers.GetObjectValue(e3QSq));
		NewLateBinding.LateSetComplex(e3QSq, null, "Visible", new object[1] { m7K8F }, null, null, OptimisticSet: false, RValueBase: true);
		return result;
	}

	public void o0A4Z(object Zi91G)
	{
		NewLateBinding.LateCall(Zi91G, null, "execute", new object[0], null, null, null, IgnoreReturn: true);
		y6Z5L();
		object instance = currentEdit;
		object[] obj = new object[1] { Zi91G };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "add", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			Zi91G = RuntimeHelpers.GetObjectValue(array[0]);
		}
		Em35Q();
	}

	public void y6Z5L()
	{
		checked
		{
			updateLevel++;
			Fe19H(RuntimeHelpers.GetObjectValue(new object()));
		}
	}

	private void Fe19H(object x6XRj)
	{
		throw new NotImplementedException();
	}

	public void Em35Q()
	{
		checked
		{
			updateLevel--;
			if (endingUpdate)
			{
				return;
			}
			endingUpdate = updateLevel == 0;
			Fe19H(RuntimeHelpers.GetObjectValue(new object()));
			try
			{
				if (Conversions.ToBoolean(endingUpdate && Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(currentEdit, null, "Empty", new object[0], null, null, null)))))
				{
					Fe19H(RuntimeHelpers.GetObjectValue(new object()));
					object objectValue = RuntimeHelpers.GetObjectValue(currentEdit);
					currentEdit = RuntimeHelpers.GetObjectValue(d5R6E());
					NewLateBinding.LateCall(objectValue, null, "dispatch", new object[0], null, null, null, IgnoreReturn: true);
					Fe19H(RuntimeHelpers.GetObjectValue(new object()));
				}
			}
			finally
			{
				endingUpdate = false;
			}
		}
	}

	public void Bq8x6(object f4NBa, object t0Q5C, bool Je2m6)
	{
		y6Z5L();
		try
		{
			Dictionary<object, object> dictionary = new Dictionary<object, object>();
			Jy75T(RuntimeHelpers.GetObjectValue(f4NBa), RuntimeHelpers.GetObjectValue(t0Q5C), Je2m6, dictionary);
			IEnumerator<object> enumerator = dictionary.Keys.GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				object objectValue2 = RuntimeHelpers.GetObjectValue(dictionary[RuntimeHelpers.GetObjectValue(objectValue)]);
				object objectValue3 = RuntimeHelpers.GetObjectValue(Ho6z7(RuntimeHelpers.GetObjectValue(objectValue), Tt47E: true));
				if (objectValue3 != null)
				{
					objectValue3 = RuntimeHelpers.GetObjectValue(dictionary[RuntimeHelpers.GetObjectValue(objectValue3)]);
					f3XZw(RuntimeHelpers.GetObjectValue(objectValue2), RuntimeHelpers.GetObjectValue(objectValue3), y7JBn: true);
				}
				objectValue3 = RuntimeHelpers.GetObjectValue(Ho6z7(RuntimeHelpers.GetObjectValue(objectValue), Tt47E: false));
				if (objectValue3 != null)
				{
					objectValue3 = RuntimeHelpers.GetObjectValue(dictionary[RuntimeHelpers.GetObjectValue(objectValue3)]);
					f3XZw(RuntimeHelpers.GetObjectValue(objectValue2), RuntimeHelpers.GetObjectValue(objectValue3), y7JBn: false);
				}
			}
		}
		finally
		{
			Em35Q();
		}
	}

	protected internal void Jy75T(object Zw2f3, object x4ZMz, bool Zj6t0, Dictionary<object, object> Ay4o2)
	{
		y6Z5L();
		checked
		{
			try
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(Zw2f3, null, "ChildCount", new object[0], null, null, null));
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					object[] array;
					bool[] array2;
					object obj = NewLateBinding.LateGet(Zw2f3, null, "getChildAt", array = new object[1] { i }, null, null, array2 = new bool[1] { true });
					if (array2[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					string text = Conversions.ToString(NewLateBinding.LateGet(objectValue, null, "Id", new object[0], null, null, null));
					object objectValue2 = RuntimeHelpers.GetObjectValue((text != null && (!a4M5B(RuntimeHelpers.GetObjectValue(objectValue)) || !Zj6t0)) ? Ja5y4(text) : null);
					if (objectValue2 == null)
					{
						object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "clone", new object[0], null, null, null));
						NewLateBinding.LateSet(objectValue3, null, "Id", new object[1] { text }, null, null);
						object[] obj2 = new object[1] { objectValue3 };
						array = obj2;
						bool[] obj3 = new bool[1] { true };
						array2 = obj3;
						object obj4 = NewLateBinding.LateGet(x4ZMz, null, "insert", obj2, null, null, obj3);
						if (array2[0])
						{
							objectValue3 = RuntimeHelpers.GetObjectValue(array[0]);
						}
						objectValue2 = RuntimeHelpers.GetObjectValue(obj4);
						t2R9B(RuntimeHelpers.GetObjectValue(objectValue2));
					}
					Ay4o2[RuntimeHelpers.GetObjectValue(objectValue)] = RuntimeHelpers.GetObjectValue(objectValue2);
					Jy75T(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2), Zj6t0, Ay4o2);
				}
			}
			finally
			{
				Em35Q();
			}
		}
	}

	private void w5J6Q(object m3E5N)
	{
		NewLateBinding.LateCall(m3E5N, null, "defaultReadObject", new object[0], null, null, null, IgnoreReturn: true);
		currentEdit = RuntimeHelpers.GetObjectValue(d5R6E());
	}

	public static int n0F4M(object s8AEb, object Hp4t8, bool g9RZy)
	{
		return a6K1F(RuntimeHelpers.GetObjectValue(s8AEb), RuntimeHelpers.GetObjectValue(Hp4t8), g9RZy, null);
	}

	public static int a6K1F(object Hn1c0, object Bt29Z, bool Ja7j3, object Bg43F)
	{
		int num = 0;
		object[] obj = new object[1] { Bt29Z };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object value = NewLateBinding.LateGet(Hn1c0, null, "getEdgeCount", obj, null, null, obj2);
		if (array2[0])
		{
			Bt29Z = RuntimeHelpers.GetObjectValue(array[0]);
		}
		int num2 = Conversions.ToInteger(value);
		checked
		{
			int num3 = num2 - 1;
			for (int i = 0; i <= num3; i++)
			{
				object obj3 = NewLateBinding.LateGet(Hn1c0, null, "getEdgeAt", array = new object[2] { Bt29Z, i }, null, null, array2 = new bool[2] { true, true });
				if (array2[0])
				{
					Bt29Z = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (array2[1])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				object objectValue = RuntimeHelpers.GetObjectValue(obj3);
				if (objectValue != Bg43F)
				{
					object[] obj4 = new object[2] { objectValue, Ja7j3 };
					array = obj4;
					bool[] obj5 = new bool[2] { true, true };
					array2 = obj5;
					obj3 = NewLateBinding.LateGet(Hn1c0, null, "getTerminal", obj4, null, null, obj5);
					if (array2[0])
					{
						objectValue = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						Ja7j3 = (bool)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(bool));
					}
					if (obj3 == Bt29Z)
					{
						num++;
					}
				}
			}
			return num;
		}
	}

	public static object[] i0H1E(object Ri9q3, object Lc9f7)
	{
		return y8RGj(RuntimeHelpers.GetObjectValue(Ri9q3), RuntimeHelpers.GetObjectValue(Lc9f7), Dc5a6: true, Lq5o7: true, d3W2G: true);
	}

	public static object[] w9L7Q(object p9K1N, object n0B4D)
	{
		return y8RGj(RuntimeHelpers.GetObjectValue(p9K1N), RuntimeHelpers.GetObjectValue(n0B4D), Dc5a6: true, Lq5o7: true, d3W2G: false);
	}

	public static object[] c9Q4N(object o8MQq, object Fk20J)
	{
		return y8RGj(RuntimeHelpers.GetObjectValue(o8MQq), RuntimeHelpers.GetObjectValue(Fk20J), Dc5a6: true, Lq5o7: false, d3W2G: false);
	}

	public static object[] f5EMz(object w2Z9Q, object Lf3k7)
	{
		return y8RGj(RuntimeHelpers.GetObjectValue(w2Z9Q), RuntimeHelpers.GetObjectValue(Lf3k7), Dc5a6: false, Lq5o7: true, d3W2G: false);
	}

	public static object[] y8RGj(object Xq0t8, object Fi58A, bool Dc5a6, bool Lq5o7, bool d3W2G)
	{
		object[] obj = new object[1] { Fi58A };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object value = NewLateBinding.LateGet(Xq0t8, null, "getEdgeCount", obj, null, null, obj2);
		if (array2[0])
		{
			Fi58A = RuntimeHelpers.GetObjectValue(array[0]);
		}
		int num = Conversions.ToInteger(value);
		IList<object> list = new List<object>(num);
		checked
		{
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				object obj3 = NewLateBinding.LateGet(Xq0t8, null, "getEdgeAt", array = new object[2] { Fi58A, i }, null, null, array2 = new bool[2] { true, true });
				if (array2[0])
				{
					Fi58A = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (array2[1])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				object objectValue = RuntimeHelpers.GetObjectValue(obj3);
				object obj4 = NewLateBinding.LateGet(Xq0t8, null, "getTerminal", array = new object[2] { objectValue, true }, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(obj4);
				object obj5 = NewLateBinding.LateGet(Xq0t8, null, "getTerminal", array = new object[2] { objectValue, false }, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				object objectValue3 = RuntimeHelpers.GetObjectValue(obj5);
				if ((d3W2G && objectValue2 == objectValue3) || (objectValue2 != objectValue3 && ((Dc5a6 && objectValue3 == Fi58A) || (Lq5o7 && objectValue2 == Fi58A))))
				{
					list.Add(RuntimeHelpers.GetObjectValue(objectValue));
				}
			}
			return list.ToArray();
		}
	}

	public static object[] Tz96P(object d8WKp, object Ng9j3, object p0YHk)
	{
		return Ac49Z(RuntimeHelpers.GetObjectValue(d8WKp), RuntimeHelpers.GetObjectValue(Ng9j3), RuntimeHelpers.GetObjectValue(p0YHk), o5KAq: false);
	}

	public static object[] Ac49Z(object a6RXy, object p4K5P, object z0J5S, bool o5KAq)
	{
		object[] obj = new object[1] { p4K5P };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object value = NewLateBinding.LateGet(a6RXy, null, "getEdgeCount", obj, null, null, obj2);
		if (array2[0])
		{
			p4K5P = RuntimeHelpers.GetObjectValue(array[0]);
		}
		int num = Conversions.ToInteger(value);
		object value2 = NewLateBinding.LateGet(a6RXy, null, "getEdgeCount", array = new object[1] { z0J5S }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			z0J5S = RuntimeHelpers.GetObjectValue(array[0]);
		}
		int num2 = Conversions.ToInteger(value2);
		object objectValue = RuntimeHelpers.GetObjectValue(p4K5P);
		int num3 = num;
		if (num2 < num)
		{
			num3 = num2;
			objectValue = RuntimeHelpers.GetObjectValue(z0J5S);
		}
		IList<object> list = new List<object>(num3);
		checked
		{
			int num4 = num3 - 1;
			for (int i = 0; i <= num4; i++)
			{
				object obj3 = NewLateBinding.LateGet(a6RXy, null, "getEdgeAt", array = new object[2] { objectValue, i }, null, null, array2 = new bool[2] { true, true });
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (array2[1])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
				object obj4 = NewLateBinding.LateGet(a6RXy, null, "getTerminal", array = new object[2] { objectValue2, true }, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					objectValue2 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				object objectValue3 = RuntimeHelpers.GetObjectValue(obj4);
				object obj5 = NewLateBinding.LateGet(a6RXy, null, "getTerminal", array = new object[2] { objectValue2, false }, null, null, array2 = new bool[2] { true, false });
				if (array2[0])
				{
					objectValue2 = RuntimeHelpers.GetObjectValue(array[0]);
				}
				object objectValue4 = RuntimeHelpers.GetObjectValue(obj5);
				bool flag = objectValue3 == p4K5P && objectValue4 == z0J5S;
				bool flag2 = objectValue4 == p4K5P && objectValue3 == z0J5S;
				if (flag || (!o5KAq && flag2))
				{
					list.Add(RuntimeHelpers.GetObjectValue(objectValue2));
				}
			}
			return list.ToArray();
		}
	}

	public static object[] c6R0S(object w3E2H, object[] r5GBp, object n0ABf)
	{
		return Gg6c9(RuntimeHelpers.GetObjectValue(w3E2H), r5GBp, RuntimeHelpers.GetObjectValue(n0ABf), d4LAc: true, Fa17C: true);
	}

	public static object[] Gg6c9(object c7C0E, object[] p7SCe, object m2LNg, bool d4LAc, bool Fa17C)
	{
		IList<object> list = new List<object>();
		checked
		{
			if (p7SCe != null)
			{
				int num = p7SCe.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					object[] array2;
					object[] array;
					int num2;
					bool[] array3;
					object obj = NewLateBinding.LateGet(c7C0E, null, "getTerminal", array2 = new object[2]
					{
						(array = p7SCe)[num2 = i],
						true
					}, null, null, array3 = new bool[2] { true, false });
					if (array3[0])
					{
						array[num2] = RuntimeHelpers.GetObjectValue(array2[0]);
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					object obj2 = NewLateBinding.LateGet(c7C0E, null, "getTerminal", array2 = new object[2]
					{
						(array = p7SCe)[num2 = i],
						false
					}, null, null, array3 = new bool[2] { true, false });
					if (array3[0])
					{
						array[num2] = RuntimeHelpers.GetObjectValue(array2[0]);
					}
					object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
					if (Fa17C && objectValue == m2LNg && objectValue2 != null && objectValue2 != m2LNg)
					{
						list.Add(RuntimeHelpers.GetObjectValue(objectValue2));
					}
					else if (d4LAc && objectValue2 == m2LNg && objectValue != null && objectValue != m2LNg)
					{
						list.Add(RuntimeHelpers.GetObjectValue(objectValue));
					}
				}
			}
			return list.ToArray();
		}
	}

	public static void Zc10D(object d2CDa, object m2C7J, object Np6t7, object Ew7n8)
	{
		NewLateBinding.LateCall(d2CDa, null, "beginUpdate", new object[0], null, null, null, IgnoreReturn: true);
		try
		{
			object[] obj = new object[3] { m2C7J, Np6t7, true };
			object[] array = obj;
			bool[] obj2 = new bool[3] { true, true, false };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(d2CDa, null, "setTerminal", obj, null, null, obj2, IgnoreReturn: true);
			if (array2[0])
			{
				m2C7J = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (array2[1])
			{
				Np6t7 = RuntimeHelpers.GetObjectValue(array[1]);
			}
			NewLateBinding.LateCall(d2CDa, null, "setTerminal", array = new object[3] { m2C7J, Ew7n8, false }, null, null, array2 = new bool[3] { true, true, false }, IgnoreReturn: true);
			if (array2[0])
			{
				m2C7J = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (array2[1])
			{
				Ew7n8 = RuntimeHelpers.GetObjectValue(array[1]);
			}
		}
		finally
		{
			NewLateBinding.LateCall(d2CDa, null, "endUpdate", new object[0], null, null, null, IgnoreReturn: true);
		}
	}

	public static object[] Xm83C(object r8H9J, object s2H0L)
	{
		return b9QKy(RuntimeHelpers.GetObjectValue(r8H9J), RuntimeHelpers.GetObjectValue(s2H0L), o3X7A: false, Xd97L: false);
	}

	public static object[] e4ARc(object Cg2k8, object c6EYk)
	{
		return b9QKy(RuntimeHelpers.GetObjectValue(Cg2k8), RuntimeHelpers.GetObjectValue(c6EYk), o3X7A: true, Xd97L: false);
	}

	public static object[] Xr90A(object t6G3B, object Np2c3)
	{
		return b9QKy(RuntimeHelpers.GetObjectValue(t6G3B), RuntimeHelpers.GetObjectValue(Np2c3), o3X7A: false, Xd97L: true);
	}

	public static object[] b9QKy(object Hg5p4, object Ba79S, bool o3X7A, bool Xd97L)
	{
		object[] obj = new object[1] { Ba79S };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object value = NewLateBinding.LateGet(Hg5p4, null, "getChildCount", obj, null, null, obj2);
		if (array2[0])
		{
			Ba79S = RuntimeHelpers.GetObjectValue(array[0]);
		}
		int num = Conversions.ToInteger(value);
		IList<object> list = new List<object>(num);
		int num2 = checked(num - 1);
		for (int num3 = 0; num3 <= num2; num3 = checked(num3 + 1))
		{
			object obj3 = NewLateBinding.LateGet(Hg5p4, null, "getChildAt", array = new object[2] { Ba79S, num3 }, null, null, array2 = new bool[2] { true, true });
			if (array2[0])
			{
				Ba79S = RuntimeHelpers.GetObjectValue(array[0]);
			}
			if (array2[1])
			{
				num3 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
			}
			object objectValue = RuntimeHelpers.GetObjectValue(obj3);
			if (!Xd97L && !o3X7A)
			{
				goto IL_0160;
			}
			if (Xd97L)
			{
				object[] obj4 = new object[1] { objectValue };
				array = obj4;
				bool[] obj5 = new bool[1] { true };
				array2 = obj5;
				object value2 = NewLateBinding.LateGet(Hg5p4, null, "isEdge", obj4, null, null, obj5);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (Conversions.ToBoolean(value2))
				{
					goto IL_0160;
				}
			}
			int num4;
			if (o3X7A)
			{
				object[] obj6 = new object[1] { objectValue };
				array = obj6;
				bool[] obj7 = new bool[1] { true };
				array2 = obj7;
				object value3 = NewLateBinding.LateGet(Hg5p4, null, "isVertex", obj6, null, null, obj7);
				if (array2[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array[0]);
				}
				num4 = (Conversions.ToBoolean(value3) ? 1 : 0);
			}
			else
			{
				num4 = 0;
			}
			goto IL_0161;
			IL_0160:
			num4 = 1;
			goto IL_0161;
			IL_0161:
			if (Conversions.ToBoolean((byte)num4 != 0))
			{
				list.Add(RuntimeHelpers.GetObjectValue(objectValue));
			}
		}
		return list.ToArray();
	}

	public static object[] z2RXm(object Nb03Q, object[] Gz72H)
	{
		HashSet<object> hashSet = new HashSet<object>();
		checked
		{
			if (Gz72H != null)
			{
				int num = Gz72H.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					object[] array2;
					object[] array;
					int num2;
					bool[] array3;
					object obj = NewLateBinding.LateGet(Nb03Q, null, "getParent", array2 = new object[1] { (array = Gz72H)[num2 = i] }, null, null, array3 = new bool[1] { true });
					if (array3[0])
					{
						array[num2] = RuntimeHelpers.GetObjectValue(array2[0]);
					}
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					if (objectValue != null)
					{
						hashSet.Add(RuntimeHelpers.GetObjectValue(objectValue));
					}
				}
			}
			return hashSet.ToArray();
		}
	}

	public static object[] Fe34S(object[] Ej4b2, Pa0q7 Mc74F)
	{
		List<object> list = null;
		checked
		{
			if (Ej4b2 != null)
			{
				list = new List<object>(Ej4b2.Length);
				int num = Ej4b2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Mc74F.filter(RuntimeHelpers.GetObjectValue(Ej4b2[i])))
					{
						list.Add(RuntimeHelpers.GetObjectValue(Ej4b2[i]));
					}
				}
			}
			return list?.ToArray();
		}
	}

	public static ICollection<object> Ta70H(object Fp4j9, object w5KRk)
	{
		return m0X3Y(RuntimeHelpers.GetObjectValue(Fp4j9), null, RuntimeHelpers.GetObjectValue(w5KRk));
	}

	public static ICollection<object> Nk4y2(object f8TSt, Pa0q7 i1E6W)
	{
		return m0X3Y(RuntimeHelpers.GetObjectValue(f8TSt), i1E6W, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(f8TSt, null, "Root", new object[0], null, null, null)));
	}

	public static ICollection<object> m0X3Y(object Cy7d8, Pa0q7 Sd0i7, object d8KHo)
	{
		IList<object> list = new List<object>();
		if (Sd0i7 == null || Sd0i7.filter(RuntimeHelpers.GetObjectValue(d8KHo)))
		{
			list.Add(RuntimeHelpers.GetObjectValue(d8KHo));
		}
		object[] array;
		bool[] array2;
		object value = NewLateBinding.LateGet(Cy7d8, null, "getChildCount", array = new object[1] { d8KHo }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			d8KHo = RuntimeHelpers.GetObjectValue(array[0]);
		}
		int num = Conversions.ToInteger(value);
		checked
		{
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				object obj = NewLateBinding.LateGet(Cy7d8, null, "getChildAt", array = new object[2] { d8KHo, i }, null, null, array2 = new bool[2] { true, true });
				if (array2[0])
				{
					d8KHo = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (array2[1])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
				}
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
			}
			return list;
		}
	}

	public static object[] Cz62J(object Aq30T, object[] g7Z8R)
	{
		object instance = new HashSet<object>();
		object[] array = new object[1];
		object instance2;
		object instance3 = (instance2 = NewLateBinding.LateGet(NewLateBinding.LateGet(java, null, "util", new object[0], null, null, null), null, "Arrays", new object[0], null, null, null));
		object[] array2 = new object[1];
		object[] array3 = (object[])(array2[0] = g7Z8R);
		object[] array4 = array2;
		bool[] obj = new bool[1] { true };
		bool[] array5 = obj;
		object obj2 = NewLateBinding.LateGet(instance3, null, "asList", array2, null, null, obj);
		if (array5[0])
		{
			g7Z8R = (object[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(object[]));
		}
		array[0] = obj2;
		object[] array6 = array;
		bool[] array7;
		NewLateBinding.LateCall(instance, null, "addAll", array, null, null, array7 = new bool[1] { true }, IgnoreReturn: true);
		if (array7[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "asList", new object[2]
			{
				array3,
				array6[0]
			}, null, null, OptimisticSet: true, RValueBase: true);
		}
		IList<object> list = new List<object>(g7Z8R.Length);
		checked
		{
			int num = g7Z8R.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(g7Z8R[i]);
				bool flag = true;
				object obj3 = NewLateBinding.LateGet(Aq30T, null, "getParent", array3 = new object[1] { objectValue }, null, null, array7 = new bool[1] { true });
				if (array7[0])
				{
					objectValue = RuntimeHelpers.GetObjectValue(array3[0]);
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
				while (objectValue2 != null)
				{
					object value = NewLateBinding.LateGet(instance, null, "contains", array3 = new object[1] { objectValue2 }, null, null, array7 = new bool[1] { true });
					if (array7[0])
					{
						objectValue2 = RuntimeHelpers.GetObjectValue(array3[0]);
					}
					if (Conversions.ToBoolean(value))
					{
						flag = false;
						break;
					}
					object obj4 = NewLateBinding.LateGet(Aq30T, null, "getParent", array3 = new object[1] { objectValue2 }, null, null, array7 = new bool[1] { true });
					if (array7[0])
					{
						objectValue2 = RuntimeHelpers.GetObjectValue(array3[0]);
					}
					objectValue2 = RuntimeHelpers.GetObjectValue(obj4);
				}
				if (flag)
				{
					list.Add(RuntimeHelpers.GetObjectValue(objectValue));
				}
			}
			return list.ToArray();
		}
	}
}
