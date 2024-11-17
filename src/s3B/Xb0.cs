using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace s3B;

public class Xb0
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _Position;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _UP;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _Right;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _Matrix4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _MathHelper;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _Vector3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _GL;

	public object Position
	{
		[CompilerGenerated]
		get
		{
			return _Position;
		}
		[CompilerGenerated]
		set
		{
			_Position = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public float Pitch { get; set; }

	public float Yaw { get; set; }

	public float Roll { get; set; }

	public object At { get; }

	public object UP
	{
		[CompilerGenerated]
		get
		{
			return _UP;
		}
		[CompilerGenerated]
		set
		{
			_UP = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Right
	{
		[CompilerGenerated]
		get
		{
			return _Right;
		}
		[CompilerGenerated]
		set
		{
			_Right = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Matrix4
	{
		[CompilerGenerated]
		get
		{
			return _Matrix4;
		}
		[CompilerGenerated]
		set
		{
			_Matrix4 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object MathHelper
	{
		[CompilerGenerated]
		get
		{
			return _MathHelper;
		}
		[CompilerGenerated]
		set
		{
			_MathHelper = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object Vector3
	{
		[CompilerGenerated]
		get
		{
			return _Vector3;
		}
		[CompilerGenerated]
		set
		{
			_Vector3 = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public object GL
	{
		[CompilerGenerated]
		get
		{
			return _GL;
		}
		[CompilerGenerated]
		set
		{
			_GL = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public Xb0(float x, float y, float z)
	{
	}

	public Xb0(object pos, object at)
	{
		Position = RuntimeHelpers.GetObjectValue(pos);
		At = at;
	}

	public void Et4(float Jg9)
	{
		Pitch += Jg9;
		object instance = Matrix4;
		object[] array = new object[1];
		object instance2;
		object instance3 = (instance2 = MathHelper);
		float num;
		object[] obj = new object[1] { num = Pitch };
		object[] array2 = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array3 = obj2;
		object obj3 = NewLateBinding.LateGet(instance3, null, "DegreesToRadians", obj, null, null, obj2);
		if (array3[0])
		{
			Pitch = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(float));
		}
		array[0] = obj3;
		object[] array4 = array;
		bool[] array5;
		object obj4 = NewLateBinding.LateGet(instance, null, "CreateRotationY", array, null, null, array5 = new bool[1] { true });
		if (array5[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "DegreesToRadians", new object[2]
			{
				num,
				array4[0]
			}, null, null, OptimisticSet: true, RValueBase: true);
		}
		object objectValue = RuntimeHelpers.GetObjectValue(obj4);
		object instance4 = Vector3;
		object[] array6 = new object[2];
		ref object reference = ref At;
		array6[0] = reference;
		array6[1] = objectValue;
		array4 = array6;
		object obj5 = NewLateBinding.LateGet(instance4, null, "TransformVector", array6, null, null, array5 = new bool[2] { true, true });
		if (array5[0])
		{
			reference = RuntimeHelpers.GetObjectValue(array4[0]);
		}
		if (array5[1])
		{
			objectValue = RuntimeHelpers.GetObjectValue(array4[1]);
		}
		At = RuntimeHelpers.GetObjectValue(obj5);
	}

	public void f8P()
	{
		NewLateBinding.LateCall(GL, null, "Rotate", new object[4]
		{
			0f - Pitch,
			1,
			0,
			0
		}, null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(GL, null, "Rotate", new object[4]
		{
			0f - Yaw,
			0,
			1,
			0
		}, null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(GL, null, "Rotate", new object[4]
		{
			0f - Roll,
			0,
			0,
			1
		}, null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(GL, null, "Translate", new object[3]
		{
			Operators.NegateObject(NewLateBinding.LateGet(Position, null, "X", new object[0], null, null, null)),
			Operators.NegateObject(NewLateBinding.LateGet(Position, null, "Y", new object[0], null, null, null)),
			Operators.NegateObject(NewLateBinding.LateGet(Position, null, "Z", new object[0], null, null, null))
		}, null, null, null, IgnoreReturn: true);
	}

	public virtual string Gn3()
	{
		return Position.ToString();
	}

	public void Hi8(float y1S)
	{
	}
}
