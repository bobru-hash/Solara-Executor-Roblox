using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Jo1;

[StandardModule]
public sealed class Hp3
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _PdfInfo;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static object _PdfDocument;

	public static object ImageDriver { get; }

	public static object PdfInfo
	{
		[CompilerGenerated]
		get
		{
			return _PdfInfo;
		}
		[CompilerGenerated]
		set
		{
			_PdfInfo = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public static object PdfDocument
	{
		[CompilerGenerated]
		get
		{
			return _PdfDocument;
		}
		[CompilerGenerated]
		set
		{
			_PdfDocument = RuntimeHelpers.GetObjectValue(value);
		}
	}

	static Hp3()
	{
		NewLateBinding.LateSetComplex(ImageDriver, null, "pdfDriver", new object[1] { c5N(new Size(25, 78)) }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(ImageDriver, null, "getPdfImage", new object[1] { m2K(58, new Size(1024, 768), default(Padding)) }, null, null, OptimisticSet: false, RValueBase: true);
	}

	private static object m2K(object Lt3, Size i8R, Padding Ht4)
	{
		return new object();
	}

	public static object c5N(Size Kf2)
	{
		MemoryStream memoryStream = new MemoryStream();
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		object instance = PdfInfo;
		object[] obj = new object[1] { objectValue };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		object obj3 = NewLateBinding.LateGet(instance, null, "CreatePdfInfo", obj, null, null, obj2);
		if (array2[0])
		{
			objectValue = RuntimeHelpers.GetObjectValue(array[0]);
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(obj3);
		DateTime dateTime = DateTime.Now;
		NewLateBinding.LateCall(objectValue2, null, "Title", new object[1] { "Article Example" }, null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue2, null, "Author", new object[1] { Environment.UserName }, null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue2, null, "Keywords", new object[1] { "PDF, .NET, C#, Library, Document Creator" }, null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue2, null, "Subject", new object[1] { "PDF File Writer C# Class Library (Version 1.15.0)" }, null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue2, null, "CreationDate", array = new object[1] { dateTime }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
		if (array2[0])
		{
			dateTime = (DateTime)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(DateTime));
		}
		NewLateBinding.LateCall(objectValue2, null, "ModDate", array = new object[1] { dateTime }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
		if (array2[0])
		{
			dateTime = (DateTime)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(DateTime));
		}
		NewLateBinding.LateCall(objectValue2, null, "Creator", new object[1] { Operators.ConcatenateObject("PdfFileWriter C# Class Library Version ", NewLateBinding.LateGet(PdfDocument, null, "RevisionNumber", new object[0], null, null, null)) }, null, null, null, IgnoreReturn: true);
		NewLateBinding.LateCall(objectValue2, null, "Producer", new object[1] { Operators.ConcatenateObject("PdfFileWriter C# Class Library Version ", NewLateBinding.LateGet(PdfDocument, null, "RevisionNumber", new object[0], null, null, null)) }, null, null, null, IgnoreReturn: true);
		object objectValue3 = RuntimeHelpers.GetObjectValue(new object());
		return RuntimeHelpers.GetObjectValue(new object());
	}

	public static void f5J()
	{
		Console.WriteLine();
	}
}
