using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace f9H;

[StandardModule]
internal sealed class s7E
{
	public static double y6X(object Sp8, object o3J)
	{
		Dictionary<string, int> dictionary = (Dictionary<string, int>)NewLateBinding.LateGet(Sp8, null, "nodeGroupCounts", new object[0], null, null, null);
		Dictionary<string, int> dictionary2 = (Dictionary<string, int>)NewLateBinding.LateGet(o3J, null, "nodeGroupCounts", new object[0], null, null, null);
		object instance = default(object);
		object instance2 = NewLateBinding.LateGet(instance, null, "EnumerateMapKeys", new object[0], null, null, null);
		object[] obj = new object[1] { dictionary };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object obj3 = NewLateBinding.LateGet(instance2, null, "Select", obj, null, null, obj2);
		if (array2[0])
		{
			dictionary = (Dictionary<string, int>)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Dictionary<string, int>));
		}
		object objectValue = RuntimeHelpers.GetObjectValue(o1Q(RuntimeHelpers.GetObjectValue(obj3)));
		obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(instance, null, "EnumerateMapKeys", new object[0], null, null, null), null, "Select", array = new object[1] { dictionary2 }, null, null, array2 = new bool[1] { true });
		if (array2[0])
		{
			dictionary2 = (Dictionary<string, int>)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Dictionary<string, int>));
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(o1Q(RuntimeHelpers.GetObjectValue(obj3)));
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Length", new object[0], null, null, null), 1, TextCompare: false))
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet(objectValue, new object[1] { a7S() }, null), NewLateBinding.LateIndexGet(objectValue2, new object[1] { a7S() }, null), TextCompare: false))
			{
				return 1.0;
			}
			return 0.0;
		}
		if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Length", new object[0], null, null, null), 0, TextCompare: false))
		{
			return 0.0;
		}
		double result = default(double);
		return result;
	}

	private static object a7S()
	{
		throw new NotImplementedException();
	}

	internal static object o1Q(object o5G)
	{
		throw new NotImplementedException();
	}

	private static Dictionary<string, int> Qk0(this object Ki0)
	{
		Dictionary<string, int> result = default(Dictionary<string, int>);
		return result;
	}
}
