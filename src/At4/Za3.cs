using System;
using System.Runtime.CompilerServices;
using Dx74P;

namespace At4;

public class Za3
{
	public double strength { get; set; }

	public double angle { get; set; }

	public string source { get; set; }

	public Za3 ByRef { get; set; }

	public Za3()
	{
	}

	public Za3(double F, double angle, [CallerMemberName] string trace = null)
	{
		strength = F;
		this.angle = angle;
		source = trace;
	}

	public void r0G()
	{
		strength = 0.0;
		angle = 0.0;
	}

	public virtual string c9Q()
	{
		string arg = default(string);
		return string.Format("a={0}, {1}N [{2}]", arg, strength.ToString("F2"), source);
	}

	[SpecialName]
	public static double e7E(Za3 e7F, double Fs0)
	{
		return Math.Pow(e7F.strength, Fs0);
	}

	[SpecialName]
	public static double z2X(double Es7, Za3 Nt7)
	{
		return Es7 * Nt7.strength;
	}

	[SpecialName]
	public static double w1Z(int Ho1, Za3 Rm2)
	{
		return (double)Ho1 * Rm2.strength;
	}

	[SpecialName]
	public static bool Wk9(Za3 Gd7, double m3C)
	{
		return Gd7.strength == m3C;
	}

	[SpecialName]
	public static bool i9P(Za3 Ne6, int Xj4)
	{
		return Math.Abs(Ne6.strength - (double)Xj4) <= 0.0001;
	}

	[SpecialName]
	public static bool Ga5(Za3 q7S, double d3R)
	{
		return !Wk9(q7S, d3R);
	}

	[SpecialName]
	public static bool a0W(Za3 g6C, int Mc9)
	{
		return !i9P(g6C, Mc9);
	}

	[SpecialName]
	public static bool i7G(double Js2, Za3 Wx6)
	{
		return Js2 > Wx6.strength;
	}

	[SpecialName]
	public static bool o9K(double i4X, Za3 Ce4)
	{
		return i4X < Ce4.strength;
	}

	[SpecialName]
	public static bool Jz5(Za3 g4F, Za3 j3S)
	{
		return g4F.strength > j3S.strength;
	}

	[SpecialName]
	public static bool p8A(Za3 Wc3, Za3 o1M)
	{
		return Wc3.strength < o1M.strength;
	}

	[SpecialName]
	public static Za3 k9X(Za3 e9W)
	{
		Za3 za = new Za3();
		za.strength = e9W.strength;
		za.angle = e9W.angle + (double)Mc3q4.PI;
		za.source = $"Reverse({e9W.source})";
		return za;
	}

	[SpecialName]
	public static Za3 Wn1(Za3 c0E, Za3 Dc4)
	{
		Za3 result = default(Za3);
		return result;
	}
}
