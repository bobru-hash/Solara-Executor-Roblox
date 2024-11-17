using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Pp6a;

namespace Td3;

[StandardModule]
public sealed class q9S
{
	[CompilerGenerated]
	internal sealed class f4Y
	{
		public object _0024VB_0024Local_m;

		public PointF _0024VB_0024Local_offset;

		public object _0024VB_0024Local_a;

		public object _0024VB_0024Local_font;

		public f4Y(f4Y arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_m = arg0._0024VB_0024Local_m;
				_0024VB_0024Local_offset = arg0._0024VB_0024Local_offset;
				_0024VB_0024Local_a = arg0._0024VB_0024Local_a;
				_0024VB_0024Local_font = arg0._0024VB_0024Local_font;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class Nd8
	{
		public object _0024W2;

		public f4Y _0024VB_0024NonLocal__0024VB_0024Closure_3;

		public Nd8(Nd8 arg0)
		{
			if (arg0 != null)
			{
				_0024W2 = arg0._0024W2;
			}
		}

		[SpecialName]
		internal void Xo8(object i7Q, SolidBrush c0Q)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(i7Q, null, "Decomposition2D", new object[0], null, null, null));
			object instance = NewLateBinding.LateGet(Operators.AddObject(NewLateBinding.LateGet(_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_m, null, "Point", new object[0], null, null, null), objectValue), null, "Vector2D", new object[0], null, null, null);
			object[] obj = new object[1] { _0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_offset };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			object obj3 = NewLateBinding.LateGet(instance, null, "OffSet2D", obj, null, null, obj2);
			if (array2[0])
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_offset = (PointF)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(PointF));
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
			Pen pen = new Pen(c0Q.Color)
			{
				EndCap = LineCap.ArrowAnchor,
				Width = 8f
			};
			NewLateBinding.LateCall(_0024W2, null, "DrawLine", array = new object[3] { pen, _0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_a, objectValue2 }, null, null, array2 = new bool[3] { true, true, true }, IgnoreReturn: true);
			if (array2[0])
			{
				pen = (Pen)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Pen));
			}
			if (array2[1])
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_a = RuntimeHelpers.GetObjectValue(array[1]);
			}
			if (array2[2])
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(array[2]);
			}
			NewLateBinding.LateCall(_0024W2, null, "DrawString", array = new object[4]
			{
				i7Q.ToString(),
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_font,
				c0Q,
				objectValue2
			}, null, null, array2 = new bool[4] { false, true, true, true }, IgnoreReturn: true);
			if (array2[1])
			{
				_0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_font = RuntimeHelpers.GetObjectValue(array[1]);
			}
			if (array2[2])
			{
				c0Q = (SolidBrush)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(SolidBrush));
			}
			if (array2[3])
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(array[3]);
			}
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _FontFace;

	public static object FontFace
	{
		[CompilerGenerated]
		get
		{
			return _FontFace;
		}
		[CompilerGenerated]
		set
		{
			_FontFace = RuntimeHelpers.GetObjectValue(value);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static PointF i3C(this object w5J)
	{
		PointF result = default(PointF);
		return result;
	}

	public static void Lm2(this object La8, ref object q7L, IEnumerable<object> Ra5, PointF j6N = default(PointF))
	{
		f4Y arg = new f4Y(arg);
		arg._0024VB_0024Local_m = La8;
		arg._0024VB_0024Local_offset = j6N;
		f4Y f4Y = arg;
		object instance = NewLateBinding.LateGet(NewLateBinding.LateGet(arg._0024VB_0024Local_m, null, "Point", new object[0], null, null, null), null, "Vector2D", new object[0], null, null, null);
		object[] obj = new object[1] { arg._0024VB_0024Local_offset };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object obj3 = NewLateBinding.LateGet(instance, null, "OffSet2D", obj, null, null, obj2);
		if (array2[0])
		{
			arg._0024VB_0024Local_offset = (PointF)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(PointF));
		}
		f4Y._0024VB_0024Local_a = RuntimeHelpers.GetObjectValue(obj3);
		Nd8 arg2 = default(Nd8);
		Nd8 CS_0024_003C_003E8__locals14 = new Nd8(arg2);
		CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3 = arg;
		CS_0024_003C_003E8__locals14._0024W2 = q7L;
		NewLateBinding.LateCall(CS_0024_003C_003E8__locals14._0024W2, null, "DrawCircle", array = new object[3]
		{
			CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_a,
			10,
			Brushes.Black
		}, null, null, array2 = new bool[3] { true, false, false }, IgnoreReturn: true);
		if (array2[0])
		{
			CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_a = RuntimeHelpers.GetObjectValue(array[0]);
		}
		Pp6a.e2TS<object, SolidBrush> e2TS = [SpecialName] (object i7Q, SolidBrush c0Q) =>
		{
			object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(i7Q, null, "Decomposition2D", new object[0], null, null, null));
			object instance2 = NewLateBinding.LateGet(Operators.AddObject(NewLateBinding.LateGet(CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_m, null, "Point", new object[0], null, null, null), objectValue), null, "Vector2D", new object[0], null, null, null);
			object[] obj4 = new object[1] { CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_offset };
			object[] array3 = obj4;
			bool[] obj5 = new bool[1] { true };
			bool[] array4 = obj5;
			object obj6 = NewLateBinding.LateGet(instance2, null, "OffSet2D", obj4, null, null, obj5);
			if (array4[0])
			{
				CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_offset = (PointF)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(PointF));
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(obj6);
			Pen pen = new Pen(c0Q.Color)
			{
				EndCap = LineCap.ArrowAnchor,
				Width = 8f
			};
			NewLateBinding.LateCall(CS_0024_003C_003E8__locals14._0024W2, null, "DrawLine", array3 = new object[3]
			{
				pen,
				CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_a,
				objectValue2
			}, null, null, array4 = new bool[3] { true, true, true }, IgnoreReturn: true);
			if (array4[0])
			{
				pen = (Pen)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(Pen));
			}
			if (array4[1])
			{
				CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_a = RuntimeHelpers.GetObjectValue(array3[1]);
			}
			if (array4[2])
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(array3[2]);
			}
			NewLateBinding.LateCall(CS_0024_003C_003E8__locals14._0024W2, null, "DrawString", array3 = new object[4]
			{
				i7Q.ToString(),
				CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_font,
				c0Q,
				objectValue2
			}, null, null, array4 = new bool[4] { false, true, true, true }, IgnoreReturn: true);
			if (array4[1])
			{
				CS_0024_003C_003E8__locals14._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_font = RuntimeHelpers.GetObjectValue(array3[1]);
			}
			if (array4[2])
			{
				c0Q = (SolidBrush)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[2]), typeof(SolidBrush));
			}
			if (array4[3])
			{
				objectValue2 = RuntimeHelpers.GetObjectValue(array3[3]);
			}
		};
		foreach (object item in Ra5)
		{
			object objectValue3 = RuntimeHelpers.GetObjectValue(item);
			e2TS(RuntimeHelpers.GetObjectValue(objectValue3), (SolidBrush)Brushes.SkyBlue);
		}
	}
}
