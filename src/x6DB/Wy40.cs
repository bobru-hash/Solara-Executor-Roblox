using System.Runtime.CompilerServices;
using At4;
using Dx74P;
using Microsoft.VisualBasic.CompilerServices;
using r7WPy;

namespace x6DB;

[StandardModule]
public sealed class Wy40
{
	public static Za3 z7D4(Ym57T Pz1e, Ym57T i9DE, double n0Q8 = 9000000000.0)
	{
		object instance = Operators.SubtractObject(Pz1e.Point, i9DE.Point);
		double rg2p = Mc3q4.d4R2P(Pz1e.Charge, i9DE.Charge, Conversions.ToDouble(NewLateBinding.LateGet(instance, null, "SumMagnitude", new object[0], null, null, null)), n0Q8);
		Za3 za = Mc3q4.k3YRi(rg2p, RuntimeHelpers.GetObjectValue(Pz1e.Point), RuntimeHelpers.GetObjectValue(i9DE.Point));
		za.source = "CoulombsLaw";
		return za.ByRef;
	}
}
