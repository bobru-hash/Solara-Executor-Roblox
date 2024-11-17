using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Li52T;
using Microsoft.VisualBasic.CompilerServices;

namespace q5P6;

public class t3Y5
{
	private readonly b6Z1X image;

	private readonly MemoryStream pdf;

	public object Driver { get; }

	public long Scan0 { get; }

	public t3Y5(object img, Size size, Padding padding)
	{
		image = (b6Z1X)img;
		pdf = (MemoryStream)image.buffer;
		NewLateBinding.LateCall(NewLateBinding.LateGet(image.page, null, "Document", new object[0], null, null, null), null, "CreateFile", new object[0], null, null, null, IgnoreReturn: true);
		pdf.Seek(Scan0, SeekOrigin.Begin);
	}

	public object Lq4f()
	{
		using MemoryStream z6P = new MemoryStream();
		n5M8(z6P);
		return new object();
	}

	public bool x9TA(string c7A0)
	{
		bool result = default(bool);
		return result;
	}

	public bool n5M8(Stream z6P8)
	{
		pdf.CopyTo(z6P8);
		pdf.Seek(Scan0, SeekOrigin.Begin);
		z6P8.Flush();
		return true;
	}
}
