using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using At4;
using Dx74P;
using Microsoft.VisualBasic.CompilerServices;
using r7WPy;

namespace Bq4t;

public class Jp35
{
	public enum j8N4 : byte
	{
		Plain2D = 2,
		Spatial3D
	}

	public delegate Za3 m3T5(Ym57T m1, Ym57T m2);

	public delegate void c8WY(IEnumerable<Ym57T> objs, Dictionary<string, List<Za3>> physX);

	[CompilerGenerated]
	internal sealed class p0W1
	{
		public Dictionary<string, object> _0024VB_0024Local_reactions;

		public Func<Ym57T, bool> _0024I1;

		public p0W1(p0W1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_reactions = arg0._0024VB_0024Local_reactions;
			}
		}

		[SpecialName]
		internal bool Fz0f(Ym57T Qg62)
		{
			return _0024VB_0024Local_reactions.ContainsKey(Qg62.ID);
		}
	}

	[CompilerGenerated]
	internal sealed class e7JE
	{
		public Random _0024VB_0024Local_rand;

		[SpecialName]
		internal object e8NW()
		{
			Thread.Sleep(1);
			lock (_0024VB_0024Local_rand)
			{
				Random random = _0024VB_0024Local_rand;
				return new object();
			}
		}
	}

	protected List<Ym57T> objects;

	protected Dictionary<string, Dictionary<string, object>> reactions;

	protected Dictionary<string, List<Za3>> forceSystem;

	protected c8WY outputs;

	protected virtual void Nm0t()
	{
		if (outputs != null)
		{
			outputs(objects, forceSystem);
		}
	}

	public Jp35(c8WY updates = null)
	{
		reactions = new Dictionary<string, Dictionary<string, object>>();
		forceSystem = new Dictionary<string, List<Za3>>();
		outputs = updates;
	}

	public void f7X4(string x2XW, string Gr3o, m3T5 Db7x, [CallerMemberName] string a7CL = null)
	{
		if (!reactions.ContainsKey(x2XW))
		{
		}
		Dictionary<string, object> dictionary = reactions[x2XW];
	}

	public void j7AD(uint r5GJ)
	{
		for (uint num = 0u; num <= r5GJ; num = checked(num + 1))
		{
			Ni4n();
			Nm0t();
		}
	}

	private void Ni4n()
	{
		foreach (List<Za3> value in forceSystem.Values)
		{
			value.Clear();
		}
		p0W1 p0W = default(p0W1);
		object instance = default(object);
		foreach (Ym57T item in objects.Where([SpecialName] (Ym57T He3a) => reactions.ContainsKey(He3a.ID)))
		{
			Ym57T ym57T = item;
			p0W = new p0W1(p0W);
			p0W._0024VB_0024Local_reactions = reactions[ym57T.ID];
			List<Za3> list = forceSystem[ym57T.ID];
			foreach (Ym57T item2 in objects.Where(p0W.Fz0f))
			{
				Ym57T ym57T2 = item2;
				object[] array;
				bool[] array2;
				object obj = NewLateBinding.LateGet(instance, null, "Value", array = new object[2] { ym57T, ym57T2 }, null, null, array2 = new bool[2] { true, true });
				if (array2[0])
				{
					ym57T = (Ym57T)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Ym57T));
				}
				if (array2[1])
				{
					ym57T2 = (Ym57T)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(Ym57T));
				}
				object instance2 = obj;
				NewLateBinding.LateSetComplex(instance2, null, "source", new object[1] { NewLateBinding.LateGet(instance, null, "Name", new object[0], null, null, null) }, null, null, OptimisticSet: false, RValueBase: true);
				list.Add((Za3)NewLateBinding.LateGet(instance2, null, "ByRef", new object[0], null, null, null));
				forceSystem[ym57T2.ID].Add((Za3)Operators.NegateObject(NewLateBinding.LateGet(instance2, null, "ByRef", new object[0], null, null, null)));
				instance2 = null;
			}
		}
		foreach (Ym57T @object in objects)
		{
			Ym57T current2 = Ym57T.Gb5y0(@object, Mc3q4.Qn47E(forceSystem[@object.ID]));
			current2.Dm43J();
		}
	}

	[SpecialName]
	public static Jp35 y5Q7(Jp35 n5GN, Ym57T Qc14)
	{
		n5GN.forceSystem.Add(Qc14.ID, new List<Za3>());
		if (Qc14.Acceleration == null)
		{
			Qc14.Acceleration = RuntimeHelpers.GetObjectValue(new object());
		}
		if (Qc14.Velocity == null)
		{
			Qc14.Velocity = RuntimeHelpers.GetObjectValue(new object());
		}
		return n5GN;
	}

	public static Func<object> Sf6e(Size f4JB)
	{
		Random random = new Random();
		int width = f4JB.Width;
		int height = f4JB.Height;
		return [SpecialName] () =>
		{
			Thread.Sleep(1);
			lock (random)
			{
				Random random2 = random;
				return new object();
			}
		};
	}

	[SpecialName]
	[CompilerGenerated]
	private bool w1LM(Ym57T He3a)
	{
		return reactions.ContainsKey(He3a.ID);
	}
}
