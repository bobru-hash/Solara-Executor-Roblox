using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fg07;
using Hk0x;
using k7B1;
using Microsoft.VisualBasic.CompilerServices;
using t7R9;

namespace Kn26;

public class Gw8q
{
	private Dictionary<c1Y9, z8YQ> treeTable;

	public z8YQ[] Trees { get; }

	public object Count { get; }

	public Gw8q(Ly7p graph)
	{
		treeTable = new Dictionary<c1Y9, z8YQ>();
		Trees = Jx54(graph, ref treeTable);
	}

	public virtual string p5HC()
	{
		object instance = Count;
		return string.Format("Graph tree have {0} nodes and {1} edges.", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, null, "Nodes", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(instance, null, "Edges", new object[0], null, null, null)));
	}

	private static z8YQ[] Jx54(Ly7p z7WB, ref Dictionary<c1Y9, z8YQ> a3ZW)
	{
		List<z8YQ> list = new List<z8YQ>();
		return list.ToArray();
	}

	private static void Xb8m(z8YQ f3M7, Ly7p Gd6t, ref Dictionary<c1Y9, z8YQ> Dy58)
	{
		if (f3M7 == null || Dy58.ContainsKey(f3M7.Node))
		{
			return;
		}
		Dy58.Add(f3M7.Node, f3M7);
		c1Y9 yp = default(c1Y9);
		foreach (Mq41 item in Gd6t.k3NR())
		{
			z8YQ z8YQ = null;
			z8YQ z8YQ2 = f3M7;
			if (c1Y9.By3(yp, z8YQ2.Node))
			{
				z8YQ = new z8YQ();
				z8YQ.Parents.Add(f3M7);
				z8YQ2.Childs.Add(z8YQ);
			}
			z8YQ2 = null;
			if (z8YQ != null)
			{
				Xb8m(z8YQ, Gd6t, ref Dy58);
			}
		}
	}
}
