using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace b7N;

public class Yc7
{
	public virtual string j4B()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(b3X());
		if (Pn7() == 1)
		{
			return string.Format("[{0}, {1}]", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "source", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "target", new object[0], null, null, null)));
		}
		return string.Format("[{0}, {1}] have {2} duplicated connections.", RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "source", new object[0], null, null, null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "target", new object[0], null, null, null)), Pn7());
	}

	private int Pn7()
	{
		throw new NotImplementedException();
	}

	private object b3X()
	{
		throw new NotImplementedException();
	}
}
