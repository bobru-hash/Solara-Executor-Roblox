using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Li52T;

public class b6Z1X
{
	internal readonly object g;

	internal readonly object page;

	internal readonly Stream buffer;

	private readonly int height;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object _PaintOp;

	public CompositingMode CompositingMode { get; set; }

	public CompositingQuality CompositingQuality { get; set; }

	public InterpolationMode InterpolationMode { get; set; }

	public bool IsClipEmpty { get; }

	public bool IsVisibleClipEmpty { get; }

	public float PageScale { get; set; }

	public GraphicsUnit PageUnit { get; set; }

	public PixelOffsetMode PixelOffsetMode { get; set; }

	public Point RenderingOrigin { get; set; }

	public SmoothingMode SmoothingMode { get; set; }

	public int TextContrast { get; set; }

	public TextRenderingHint TextRenderingHint { get; set; }

	public object PaintOp
	{
		[CompilerGenerated]
		get
		{
			return _PaintOp;
		}
		[CompilerGenerated]
		set
		{
			_PaintOp = RuntimeHelpers.GetObjectValue(value);
		}
	}

	public b6Z1X(Size size, object page, Stream buffer)
	{
		this.buffer = buffer;
		this.page = RuntimeHelpers.GetObjectValue(page);
		g = RuntimeHelpers.GetObjectValue(b1Z3W(RuntimeHelpers.GetObjectValue(page)));
		height = size.Height;
	}

	private object b1Z3W(object He8d1)
	{
		throw new NotImplementedException();
	}

	public void Bw8o4(byte[] x9GXq)
	{
		throw new NotImplementedException();
	}

	protected void Lt45W(Color Es65T)
	{
		object instance = g;
		object[] obj = new object[1] { Es65T };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "SetColorNonStroking", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			Es65T = (Color)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Color));
		}
	}

	public void Bt5d4(Point f9X2A, Point c9JMw, Size b2CQn)
	{
		throw new NotImplementedException();
	}

	public void Tk2q5(Point k3TFx, Point Cc5a8, Size z9P4Z, CopyPixelOperation Fb65Z)
	{
		throw new NotImplementedException();
	}

	public void Qn3r5(int t6WDq, int Lj3n8, int Xc07R, int x1A0H, Size Bw7y9)
	{
		throw new NotImplementedException();
	}

	public void Mt63L(int Tz2f5, int Nx28L, int d5SLt, int r1ZEs, Size y8RWn, CopyPixelOperation r5CRk)
	{
		throw new NotImplementedException();
	}

	public void g5WLf()
	{
		throw new NotImplementedException();
	}

	public void c9LEq(Pen Fr30N, RectangleF Bn4z3, float Zo8j1, float Bi5f4)
	{
		throw new NotImplementedException();
	}

	public void w4Q3C(Pen j7F9G, Rectangle p3YMc, float j8HPe, float Zn79X)
	{
		throw new NotImplementedException();
	}

	public void q3N1M(Pen c4T7M, int Nd9j6, int Jg7b2, int x0AGa, int Sw8b6, int Yc12T, int c0BQm)
	{
		throw new NotImplementedException();
	}

	public void Eb7y2(Pen s4H6A, float n1ANe, float Mn50G, float n9BFd, float Bp3x1, float b2NRm, float z7XZt)
	{
		throw new NotImplementedException();
	}

	public void d7STc(Pen e4J9D, Point Cg58F, Point g5NKb, Point Ew7k3, Point k8BQs)
	{
		throw new NotImplementedException();
	}

	public void g8CJj(Pen Ep5n6, PointF s7QWc, PointF Br5j2, PointF Pn16F, PointF w7SYe)
	{
		throw new NotImplementedException();
	}

	public void Pa9x3(Pen x5N4R, float d7L1E, float p0APm, float Sn09P, float St35E, float s4Z1K, float f9H3N, float Nz0g8, float Xp28G)
	{
		throw new NotImplementedException();
	}

	public void r4XLy(Pen s8FEk, PointF[] Kd9e1)
	{
		throw new NotImplementedException();
	}

	public void z8L9Q(Pen Zq1z9, Point[] f9GTk)
	{
		throw new NotImplementedException();
	}

	public void Ng34E(Pen Gk29D, Point[] s8JBe)
	{
		throw new NotImplementedException();
	}

	public void a3T1J(Pen Wm18E, PointF[] k5K3X)
	{
		throw new NotImplementedException();
	}

	public void Gy95L(Pen y9D1E, Point[] m5BCx, float d0F2W, FillMode Ta38A)
	{
		throw new NotImplementedException();
	}

	public void Ex57W(Pen i4DMg, PointF[] Cg6n5, float Gt49P, FillMode Xk9q4)
	{
		throw new NotImplementedException();
	}

	public void Lb04S(Pen t6TPn, Point[] k2HTn)
	{
		throw new NotImplementedException();
	}

	public void Qp7q2(Pen Gq5d0, PointF[] Ko7n0)
	{
		throw new NotImplementedException();
	}

	public void y9KLg(Pen r8A2W, PointF[] Wc4f9, float Zx1j5)
	{
		throw new NotImplementedException();
	}

	public void e9W2A(Pen Fd3k8, Point[] No2q3, float y2PTb)
	{
		throw new NotImplementedException();
	}

	public void Pi4w1(Pen Ry1k5, PointF[] Yg7j6, int c0ZLg, int k0SMe)
	{
		throw new NotImplementedException();
	}

	public void Rt91Q(Pen Rd03Q, PointF[] e4RTy, int Dc6i5, int Gn35X, float To3e6)
	{
		throw new NotImplementedException();
	}

	public void Bx28Z(Pen o7DZy, Point[] q6B8Y, int s6FZo, int e8EPf, float Bq62F)
	{
		throw new NotImplementedException();
	}

	public void Gb9i0(Pen Pj1w3, Rectangle Ao17R)
	{
		throw new NotImplementedException();
	}

	public void Be65T(Pen b4K3Q, RectangleF e5S8C)
	{
		throw new NotImplementedException();
	}

	public void r1MGj(Pen Hp5j2, float z9GBq, float w6YKm, float y4JCi, float p7F9A)
	{
		throw new NotImplementedException();
	}

	public void Bx34D(Pen q7WJx, int s7W3X, int b0PAs, int Ap1w4, int Hm4e0)
	{
		throw new NotImplementedException();
	}

	public void k7S9F(Icon q5J2W, Rectangle m1Z5S)
	{
		throw new NotImplementedException();
	}

	public void m8YHz(Icon Bb5q8, int Nr8w5, int To86S)
	{
		throw new NotImplementedException();
	}

	public void r7LJa(Icon Tr61L, Rectangle m9GKo)
	{
		throw new NotImplementedException();
	}

	public void Sa19M(Image Jp39X, Point Kb92G)
	{
		f1Q8N(Jp39X, new Rectangle(Kb92G, Jp39X.Size));
	}

	public void b1DZy(Image St26Q, Point[] q4L7X)
	{
		throw new NotImplementedException();
	}

	public void z9E3D(Image Rd9w1, PointF[] j6DWb)
	{
		throw new NotImplementedException();
	}

	public void f1Q8N(Image w3G6C, Rectangle Gx51T)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		NewLateBinding.LateCall(g, null, "SaveGraphicsState", new object[0], null, null, null, IgnoreReturn: true);
		object instance = objectValue;
		object[] obj = new object[1] { w3G6C };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "LoadImage", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			w3G6C = (Image)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Image));
		}
		NewLateBinding.LateCall(g, null, "DrawImage", array = new object[4] { objectValue, Gx51T.X, Gx51T.Y, Gx51T.Width }, null, null, array2 = new bool[4] { true, true, true, true }, IgnoreReturn: true);
		if (array2[0])
		{
			objectValue = RuntimeHelpers.GetObjectValue(array[0]);
		}
		if (array2[1])
		{
			Gx51T.X = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(int));
		}
		if (array2[2])
		{
			Gx51T.Y = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(int));
		}
		if (array2[3])
		{
			Gx51T.Width = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(int));
		}
	}

	public void m0H4L(Image x2E4X, PointF Qk9x7)
	{
	}

	public void Tc60S(Image Fq63G, RectangleF Zq2o)
	{
		f1Q8N(Fq63G, checked(new Rectangle((int)Math.Round(Zq2o.X), (int)Math.Round(Zq2o.Y), (int)Math.Round(Zq2o.Width), (int)Math.Round(Zq2o.Height))));
	}

	public void Rm41(Image Hp13, int Tb5k, int Qc5i)
	{
		f1Q8N(Hp13, new Rectangle(Tb5k, Qc5i, Hp13.Width, Hp13.Height));
	}

	public void j2Q4(Image Mo34, float n8X6, float s4N7)
	{
		f1Q8N(Mo34, checked(new Rectangle((int)Math.Round(n8X6), (int)Math.Round(s4N7), Mo34.Width, Mo34.Height)));
	}

	public void Mn18(Image Ny68, RectangleF Cf7x, RectangleF Rp29, GraphicsUnit a6L2)
	{
		throw new NotImplementedException();
	}

	public void s8E9(Image w8CJ, Rectangle r3NT, Rectangle m3FC, GraphicsUnit c2S6)
	{
		throw new NotImplementedException();
	}

	public void d2BS(Image Np30, PointF[] k3SW, RectangleF Dd09, GraphicsUnit y7C9)
	{
		throw new NotImplementedException();
	}

	public void k2DZ(Image Si31, Point[] s7ZF, Rectangle Ng30, GraphicsUnit Aj1o)
	{
		throw new NotImplementedException();
	}

	public void Ri2m(Image Sw46, float r7G8, float r0TN, float Jt3o, float q0CM)
	{
		throw new NotImplementedException();
	}

	public void Tk37(Image i0L8, Point[] e2YK, Rectangle c6FH, GraphicsUnit Gq4e, ImageAttributes Ym68)
	{
		throw new NotImplementedException();
	}

	public void z8NZ(Image Dc79, int z9W5, int Kq5t, int a2MH, int t4F9)
	{
		throw new NotImplementedException();
	}

	public void Gn02(Image q3MQ, float Sq2x, float o7RP, RectangleF Jb7k, GraphicsUnit w3DJ)
	{
		throw new NotImplementedException();
	}

	public void j9ZP(Image Lp74, PointF[] b1XQ, RectangleF w3YB, GraphicsUnit Tb27, ImageAttributes Zx35)
	{
		throw new NotImplementedException();
	}

	public void x9MA(Image k6E3, int x8L0, int r5WZ, Rectangle z6YT, GraphicsUnit d0W9)
	{
		throw new NotImplementedException();
	}

	public void Ga36(Image t0G9, Point[] An5p, Rectangle c8F9, GraphicsUnit c4N2, ImageAttributes b5L8, Graphics.DrawImageAbort b5ZD)
	{
		throw new NotImplementedException();
	}

	public void Jo57(Image Yo4k, PointF[] Md6x, RectangleF Nz70, GraphicsUnit r6J9, ImageAttributes Lz7i, Graphics.DrawImageAbort Jr70)
	{
		throw new NotImplementedException();
	}

	public void q4K0(Image s6AP, Point[] Ag07, Rectangle z3XA, GraphicsUnit s9XC, ImageAttributes k0KE, Graphics.DrawImageAbort y4YA, int x8B2)
	{
		throw new NotImplementedException();
	}

	public void j8RE(Image x4WL, Rectangle y0T8, float Fx96, float Ac71, float f8X5, float Eo84, GraphicsUnit Pw32)
	{
		throw new NotImplementedException();
	}

	public void Ks1y(Image x6E3, Rectangle d6Z2, int Nk94, int r1WM, int c2DR, int p4TB, GraphicsUnit g3Z6)
	{
		throw new NotImplementedException();
	}

	public void d9MW(Image o2R8, PointF[] Mq2k, RectangleF Ma6s, GraphicsUnit Pc8t, ImageAttributes Ac7n, Graphics.DrawImageAbort j0R5, int Zf17)
	{
		throw new NotImplementedException();
	}

	public void q2X0(Image w1T9, Rectangle k6XM, float x6NG, float Sj53, float d1JX, float Wi15, GraphicsUnit y2ZJ, ImageAttributes n3TY)
	{
		throw new NotImplementedException();
	}

	public void p9L6(Image f2G4, Rectangle Wo5m, int z0EK, int Kb10, int g4HS, int g4R5, GraphicsUnit Qe39, ImageAttributes Wg27)
	{
		throw new NotImplementedException();
	}

	public void t2YP(Image x6JQ, Rectangle i4L1, int q9ZD, int Tw67, int To07, int Tb1k, GraphicsUnit Jp12, ImageAttributes d2NQ, Graphics.DrawImageAbort d2B7)
	{
		throw new NotImplementedException();
	}

	public void j7KC(Image t7MH, Rectangle k8X0, float Zj80, float Ep23, float x9X1, float s3H4, GraphicsUnit z7W1, ImageAttributes Tm7d, Graphics.DrawImageAbort o0MJ)
	{
		throw new NotImplementedException();
	}

	public void Jb52(Image Wx3a, Rectangle Wn17, float b6GQ, float a6YC, float e1N2, float d5Z3, GraphicsUnit Zx48, ImageAttributes f8R4, Graphics.DrawImageAbort Qd8p, IntPtr b8EM)
	{
		throw new NotImplementedException();
	}

	public void i7G5(Image Np35, Rectangle Tn5c, int j3Y9, int Br05, int Zt1p, int n3QY, GraphicsUnit Yy0b, ImageAttributes Xc6k, Graphics.DrawImageAbort Bq95, IntPtr Pp4r)
	{
		throw new NotImplementedException();
	}

	public void Wa84(Image Fp21, Rectangle p5HP)
	{
		throw new NotImplementedException();
	}

	public void m4CQ(Image y3B7, Point j0KF)
	{
		throw new NotImplementedException();
	}

	public void Dx46(Image Ba3m, int Xa51, int s6K3)
	{
		throw new NotImplementedException();
	}

	public void c0FM(Image z6G9, int Kj92, int Rj47, int Fk8s, int Yz15)
	{
		throw new NotImplementedException();
	}

	public void s8Y0(Image Mo67, Rectangle o8X1)
	{
		throw new NotImplementedException();
	}

	public void p9P8(Pen z2E1, PointF b2G1, PointF Rk5q)
	{
		Ka15(z2E1, b2G1.X, b2G1.Y, Rk5q.X, Rk5q.Y);
	}

	public void Wr12(Pen Kt4c, Point j0JL, Point g7GD)
	{
		w0T5(Kt4c, j0JL.X, j0JL.Y, g7GD.X, g7GD.Y);
	}

	public void w0T5(Pen d1HS, int b7LE, int i3N6, int o2WX, int d0DH)
	{
		Ka15(d1HS, b7LE, i3N6, o2WX, d0DH);
	}

	public void Ka15(Pen y4MS, float q3M4, float Gi9m, float Lf7c, float Xe1j)
	{
		object instance = g;
		object[] obj = new object[5]
		{
			q3M4,
			(float)height - Gi9m,
			Lf7c,
			(float)height - Xe1j,
			new object()
		};
		object[] array = obj;
		bool[] obj2 = new bool[5] { true, false, true, false, false };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "DrawLine", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			q3M4 = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(float));
		}
		if (array2[2])
		{
			Lf7c = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(float));
		}
	}

	public void z6ES(Pen f0FX, PointF[] Gp0o)
	{
		throw new NotImplementedException();
	}

	public void x5D8(Pen Dq97, Point[] r0XH)
	{
		throw new NotImplementedException();
	}

	public void p9HM(Pen d5EB, GraphicsPath Wd5z)
	{
		PointF[] pathPoints = Wd5z.PathPoints;
		object instance = g;
		Pen pen;
		object[] obj = new object[1] { (pen = d5EB).Color };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "SetColorNonStroking", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			pen.Color = (Color)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Color));
		}
	}

	public void We87(Pen Xd9p, Rectangle Xc2y, float Cc8y, float y0Z9)
	{
		throw new NotImplementedException();
	}

	public void x4C7(Pen i8NT, RectangleF t7X0, float Bw69, float Hd47)
	{
		throw new NotImplementedException();
	}

	public void Ff5e(Pen i7AR, int Rc2k, int y5A4, int Pf73, int Hf0q, int w6LN, int k2X1)
	{
		throw new NotImplementedException();
	}

	public void Ts1m(Pen Kd0e, float Nc50, float Gc7j, float Ep4e, float Hg15, float Rr6p, float z2ZT)
	{
		throw new NotImplementedException();
	}

	public void x5E7(PointF y2E4, Color j7W1, Pen Ft47, float r4Y3)
	{
		throw new NotImplementedException();
	}

	public void Sz1o(Pen Jm6r, PointF[] Nt8s)
	{
		throw new NotImplementedException();
	}

	public void Fe7j(Pen Zz3r, Point[] Jx39)
	{
		throw new NotImplementedException();
	}

	public void b0QD(Pen o2E8, Rectangle k1PS)
	{
		throw new NotImplementedException();
	}

	public void Eq24(Pen w4F0, RectangleF Cq2x)
	{
		throw new NotImplementedException();
	}

	public void g7ZD(Pen Ht0r, float Jw46, float r4K0, float c4HZ, float p2PB)
	{
		throw new NotImplementedException();
	}

	public void s8BS(Pen i7EP, int Xp6q, int Bb8d, int Az9e, int Nc17)
	{
		throw new NotImplementedException();
	}

	public void Ki3m(Pen Py3g, RectangleF[] Xb50)
	{
		foreach (RectangleF cq2x in Xb50)
		{
			Eq24(Py3g, cq2x);
		}
	}

	public void Aa42(Pen Mn3k, Rectangle[] Rj29)
	{
		foreach (Rectangle k1PS in Rj29)
		{
			b0QD(Mn3k, k1PS);
		}
	}

	public void s7HN(string y1DN, Font Qf83, Brush Kq2d, PointF w1DL)
	{
		Fd5e(y1DN, Qf83, Kq2d, w1DL.X, w1DL.Y);
	}

	public void f5G0(string d9Q6, Font Mt76, Brush k0GN, RectangleF t7ZN)
	{
		throw new NotImplementedException();
	}

	public void w8H6(string Ne32, Font Ee96, Brush Ht4s, RectangleF p0Z6, StringFormat Gz1c)
	{
		throw new NotImplementedException();
	}

	public void p2RY(string o8SJ, Font w4YP, Brush m1A4, PointF Jz49, StringFormat Gf34)
	{
		throw new NotImplementedException();
	}

	public void Fd5e(string d7XD, Font x1SK, Brush Bc8q, float e1GY, float Mn6e)
	{
		object obj = default(object);
		object instance = obj;
		object instance2;
		object[] obj2 = new object[3]
		{
			NewLateBinding.LateGet(instance2 = page, null, "Document", new object[0], null, null, null),
			x1SK.Name,
			x1SK.Style
		};
		object[] array = obj2;
		bool[] obj3 = new bool[3] { true, false, false };
		bool[] array2 = obj3;
		object obj4 = NewLateBinding.LateGet(instance, null, "CreatePdfFont", obj2, null, null, obj3);
		if (array2[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "Document", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
		}
		obj = RuntimeHelpers.GetObjectValue(obj4);
		Color color = ((SolidBrush)Bc8q).Color;
		NewLateBinding.LateCall(g, null, "SetColorNonStroking", array = new object[1] { color }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
		if (array2[0])
		{
			color = (Color)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Color));
		}
		NewLateBinding.LateCall(g, null, "DrawText", array = new object[5]
		{
			obj,
			x1SK.Size,
			e1GY,
			(float)height - Mn6e,
			d7XD
		}, null, null, array2 = new bool[5] { true, false, true, false, true }, IgnoreReturn: true);
		if (array2[0])
		{
			obj = RuntimeHelpers.GetObjectValue(array[0]);
		}
		if (array2[2])
		{
			e1GY = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(float));
		}
		if (array2[4])
		{
			d7XD = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[4]), typeof(string));
		}
	}

	public void Ra5d(string Rq70, Font z5EL, Brush Cb23, float Eo0t, float a5BN, StringFormat Pa5q)
	{
		throw new NotImplementedException();
	}

	public void Kp6t(GraphicsContainer Dx45)
	{
		throw new NotImplementedException();
	}

	public void Ge72(Metafile k4T5, Point[] q3CK, Graphics.EnumerateMetafileProc a7W9)
	{
		throw new NotImplementedException();
	}

	public void Wi7j(Metafile Lo7a, PointF[] j4SF, Graphics.EnumerateMetafileProc y2G1)
	{
		throw new NotImplementedException();
	}

	public void Sg29(Metafile Qa01, Rectangle Lc2p, Graphics.EnumerateMetafileProc Qo54)
	{
		throw new NotImplementedException();
	}

	public void Ht9z(Metafile Hd4z, RectangleF Yi06, Graphics.EnumerateMetafileProc Ld5a)
	{
		throw new NotImplementedException();
	}

	public void Bj8p(Metafile o1P0, Point Gp31, Graphics.EnumerateMetafileProc Lm81)
	{
		throw new NotImplementedException();
	}

	public void y3P5(Metafile q3B2, PointF p0G8, Graphics.EnumerateMetafileProc w3K0)
	{
		throw new NotImplementedException();
	}

	public void Sw26(Metafile b8E7, Point[] o1D6, Graphics.EnumerateMetafileProc Jq36, IntPtr Lo4z)
	{
		throw new NotImplementedException();
	}

	public void t4NL(Metafile Fe2j, PointF[] Ec0b, Graphics.EnumerateMetafileProc Dd6j, IntPtr Mr64)
	{
		throw new NotImplementedException();
	}

	public void k6MK(Metafile Lo4g, Rectangle z4YX, Graphics.EnumerateMetafileProc Pg8j, IntPtr t8CF)
	{
		throw new NotImplementedException();
	}

	public void r8XL(Metafile Jr1d, Point Dp95, Graphics.EnumerateMetafileProc Rk95, IntPtr Nn94)
	{
		throw new NotImplementedException();
	}

	public void w0CD(Metafile e0KC, PointF Zx1i, Graphics.EnumerateMetafileProc Pb95, IntPtr Fo2e)
	{
		throw new NotImplementedException();
	}

	public void r2AS(Metafile d6S7, RectangleF f4AP, Graphics.EnumerateMetafileProc s6L4, IntPtr Wb86)
	{
		throw new NotImplementedException();
	}

	public void n0HX(Metafile Do91, Rectangle Tg10, Rectangle r5K3, GraphicsUnit Ep3w, Graphics.EnumerateMetafileProc La19)
	{
		throw new NotImplementedException();
	}

	public void s1K8(Metafile Ec0y, PointF e4X1, Graphics.EnumerateMetafileProc Wa56, IntPtr Sw60, ImageAttributes k4MP)
	{
		throw new NotImplementedException();
	}

	public void o9Q7(Metafile k9G6, Point[] Lw2d, Graphics.EnumerateMetafileProc Rg6n, IntPtr o6KT, ImageAttributes i5TR)
	{
		throw new NotImplementedException();
	}

	public void b3AC(Metafile Tr2z, PointF x5KC, RectangleF Qd1j, GraphicsUnit Li13, Graphics.EnumerateMetafileProc m0A1)
	{
		throw new NotImplementedException();
	}

	public void o0A9(Metafile i6K0, Point Tb9t, Rectangle Ds70, GraphicsUnit p1MK, Graphics.EnumerateMetafileProc Dw17)
	{
		throw new NotImplementedException();
	}

	public void Fd94(Metafile s0GX, RectangleF Ko6s, Graphics.EnumerateMetafileProc Yq0s, IntPtr c3DX, ImageAttributes o0YQ)
	{
		throw new NotImplementedException();
	}

	public void t3QM(Metafile Nb7m, RectangleF Ac30, RectangleF b8M7, GraphicsUnit j0QJ, Graphics.EnumerateMetafileProc p2JE)
	{
		throw new NotImplementedException();
	}

	public void b8HW(Metafile He5c, PointF[] g0XT, Graphics.EnumerateMetafileProc r9BG, IntPtr Ti2f, ImageAttributes Bg8z)
	{
		throw new NotImplementedException();
	}

	public void Ce10(Metafile Ms86, PointF[] Ci30, RectangleF Zk9e, GraphicsUnit d3N7, Graphics.EnumerateMetafileProc w2D3)
	{
		throw new NotImplementedException();
	}

	public void Nb86(Metafile r3HP, Rectangle Pb20, Graphics.EnumerateMetafileProc i2TF, IntPtr Qw58, ImageAttributes i2GL)
	{
		throw new NotImplementedException();
	}

	public void g4BH(Metafile Mm1w, Point[] Jm96, Rectangle t2P1, GraphicsUnit Fb6y, Graphics.EnumerateMetafileProc Dr45)
	{
		throw new NotImplementedException();
	}

	public void e3D0(Metafile m5JM, Point j5MG, Graphics.EnumerateMetafileProc Re0o, IntPtr Ex36, ImageAttributes Zq39)
	{
		throw new NotImplementedException();
	}

	public void Rs63(Metafile Kb1o, Rectangle d1Z2, Rectangle Zp60, GraphicsUnit Ls35, Graphics.EnumerateMetafileProc z9KD, IntPtr g1G2)
	{
		throw new NotImplementedException();
	}

	public void Bz42(Metafile y7P3, RectangleF Wx47, RectangleF m5S7, GraphicsUnit e2WS, Graphics.EnumerateMetafileProc d0R3, IntPtr j2ND)
	{
		throw new NotImplementedException();
	}

	public void r4F0(Metafile c5X8, Point[] d5P0, Rectangle Gx9w, GraphicsUnit d8QS, Graphics.EnumerateMetafileProc Zt3o, IntPtr y1H7)
	{
		throw new NotImplementedException();
	}

	public void Cx8e(Metafile w4HB, Point c8B7, Rectangle Ze7y, GraphicsUnit Ga65, Graphics.EnumerateMetafileProc Nm61, IntPtr Lt4e)
	{
		throw new NotImplementedException();
	}

	public void Gb16(Metafile Ht8k, PointF y7QR, RectangleF j2KJ, GraphicsUnit Cb9f, Graphics.EnumerateMetafileProc Xe39, IntPtr Cj02)
	{
		throw new NotImplementedException();
	}

	public void Am12(Metafile z1QD, PointF[] w3JR, RectangleF e7RS, GraphicsUnit i7EJ, Graphics.EnumerateMetafileProc n8R0, IntPtr Sz0i)
	{
		throw new NotImplementedException();
	}

	public void Jx61(Metafile r8EL, Rectangle Gz5w, Rectangle n7D9, GraphicsUnit Wb6k, Graphics.EnumerateMetafileProc t2D5, IntPtr Fq4f, ImageAttributes Fk5q)
	{
		throw new NotImplementedException();
	}

	public void i5P3(Metafile Hc80, PointF[] Mp5w, RectangleF i0RW, GraphicsUnit y2K7, Graphics.EnumerateMetafileProc f0JS, IntPtr n9D5, ImageAttributes r3B5)
	{
		throw new NotImplementedException();
	}

	public void Zj90(Metafile Ky42, RectangleF e7MZ, RectangleF e7CB, GraphicsUnit Zo3m, Graphics.EnumerateMetafileProc Dn78, IntPtr Eq0r, ImageAttributes Nf9x)
	{
		throw new NotImplementedException();
	}

	public void Ai41(Metafile Mq24, Point[] Zy19, Rectangle t7Q1, GraphicsUnit Hb91, Graphics.EnumerateMetafileProc b4GW, IntPtr Jd74, ImageAttributes Aa87)
	{
		throw new NotImplementedException();
	}

	public void d8K1(Metafile Ap10, PointF Gp8g, RectangleF Xi1k, GraphicsUnit De53, Graphics.EnumerateMetafileProc Ps4t, IntPtr o0PR, ImageAttributes s3JS)
	{
		throw new NotImplementedException();
	}

	public void x0PE(Metafile Tz3o, Point Rs84, Rectangle Rf4d, GraphicsUnit Fg0j, Graphics.EnumerateMetafileProc f9YG, IntPtr Hp31, ImageAttributes Lg57)
	{
		throw new NotImplementedException();
	}

	public void w7QT(Rectangle n2L0)
	{
		throw new NotImplementedException();
	}

	public void Ad28(Region g5B8)
	{
		throw new NotImplementedException();
	}

	public void s5H6(Brush n4C5, PointF[] x7B5)
	{
		throw new NotImplementedException();
	}

	public void Sb71(Brush Jy17, Point[] f7P2)
	{
		throw new NotImplementedException();
	}

	public void Cg46(Brush e4X6, Point[] Lm4q, FillMode Kj41)
	{
		throw new NotImplementedException();
	}

	public void w4H6(Brush Pf0t, PointF[] Db60, FillMode Sp5b)
	{
		throw new NotImplementedException();
	}

	public void y5WE(Brush Jp2w, PointF[] Ws9y, FillMode Aw83, float t6KA)
	{
		throw new NotImplementedException();
	}

	public void e3HW(Brush n3HS, Point[] y3WR, FillMode Wp3b, float w3H0)
	{
		throw new NotImplementedException();
	}

	public void q4P5(Brush Rf59, Rectangle Mz7p)
	{
		a2AD(Rf59, new RectangleF(Mz7p.X, Mz7p.Y, Mz7p.Width, Mz7p.Height));
	}

	public void a2AD(Brush Co09, RectangleF Sz70)
	{
		double num = Sz70.X + Sz70.Width / 2f;
		double num2 = (float)height - (Sz70.Y + Sz70.Height / 2f);
		object instance = g;
		SolidBrush solidBrush;
		object[] obj = new object[1] { (solidBrush = (SolidBrush)Co09).Color };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "SetColorNonStroking", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			solidBrush.Color = (Color)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Color));
		}
		object instance2;
		NewLateBinding.LateCall(g, null, "DrawOval", array = new object[5]
		{
			num,
			num2,
			Sz70.Width,
			Sz70.Height,
			NewLateBinding.LateGet(instance2 = PaintOp, null, "Fill", new object[0], null, null, null)
		}, null, null, array2 = new bool[5] { true, true, true, true, true }, IgnoreReturn: true);
		if (array2[0])
		{
			num = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(double));
		}
		if (array2[1])
		{
			num2 = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(double));
		}
		if (array2[2])
		{
			Sz70.Width = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(float));
		}
		if (array2[3])
		{
			Sz70.Height = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(float));
		}
		if (array2[4])
		{
			NewLateBinding.LateSetComplex(instance2, null, "Fill", new object[1] { array[4] }, null, null, OptimisticSet: true, RValueBase: true);
		}
	}

	public void Ye4a(Brush k2DQ, float Tp59, float Qj6e, float z2P3, float b2Z6)
	{
		throw new NotImplementedException();
	}

	public void Hn4c(Brush Km6c, int Bx6c, int n1QZ, int Pn5k, int o0P4)
	{
		throw new NotImplementedException();
	}

	public void t7N3(Brush Rs63, GraphicsPath w8W1)
	{
		PointF[] pathPoints = w8W1.PathPoints;
		Pen pen = new Pen(Rs63, 1f);
		object instance = g;
		SolidBrush solidBrush;
		object[] obj = new object[1] { (solidBrush = (SolidBrush)Rs63).Color };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "SetColorNonStroking", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			solidBrush.Color = (Color)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Color));
		}
		object instance2;
		NewLateBinding.LateCall(g, null, "SetPaintOp", array = new object[1] { NewLateBinding.LateGet(instance2 = PaintOp, null, "Fill", new object[0], null, null, null) }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
		if (array2[0])
		{
			NewLateBinding.LateSetComplex(instance2, null, "Fill", new object[1] { array[0] }, null, null, OptimisticSet: true, RValueBase: true);
		}
	}

	public void r6A5(Brush Wz1j, Rectangle k5F7, float Bx9c, float Ct5p)
	{
		double num = (double)k5F7.X + (double)k5F7.Width / 2.0;
		double num2 = (double)height - ((double)k5F7.Y + (double)k5F7.Height / 2.0);
		object instance = g;
		SolidBrush solidBrush;
		object[] obj = new object[1] { (solidBrush = (SolidBrush)Wz1j).Color };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "SetColorNonStroking", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			solidBrush.Color = (Color)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Color));
		}
		object instance2;
		NewLateBinding.LateCall(g, null, "DrawOval", array = new object[5]
		{
			num,
			num2,
			k5F7.Width,
			k5F7.Height,
			NewLateBinding.LateGet(instance2 = PaintOp, null, "Fill", new object[0], null, null, null)
		}, null, null, array2 = new bool[5] { true, true, true, true, true }, IgnoreReturn: true);
		if (array2[0])
		{
			num = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(double));
		}
		if (array2[1])
		{
			num2 = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(double));
		}
		if (array2[2])
		{
			k5F7.Width = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(int));
		}
		if (array2[3])
		{
			k5F7.Height = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(int));
		}
		if (array2[4])
		{
			NewLateBinding.LateSetComplex(instance2, null, "Fill", new object[1] { array[4] }, null, null, OptimisticSet: true, RValueBase: true);
		}
	}

	public void Sz64(Brush t2WD, int m3J4, int o9DX, int Jg61, int Hk2s, int g2RW, int Hb4k)
	{
		throw new NotImplementedException();
	}

	public void o4DL(Brush Nj0b, float Gj6w, float n8QY, float c8EW, float w3MZ, float Ke5a, float t9H6)
	{
		throw new NotImplementedException();
	}

	public void f2EK(Brush n4R8, Point[] d0Z2)
	{
		throw new NotImplementedException();
	}

	public void j8PM(Brush b6B8, PointF[] p5G1)
	{
		throw new NotImplementedException();
	}

	public void c9XN(Brush Ty2a, Point[] b6A4, FillMode m6N1)
	{
		throw new NotImplementedException();
	}

	public void Za8c(Brush Qn2j, PointF[] Ee76, FillMode s8TD)
	{
		throw new NotImplementedException();
	}

	public void Zj9x(Brush f7T2, Rectangle n4Q8)
	{
		Td29(f7T2, new RectangleF(n4Q8.X, n4Q8.Y, n4Q8.Width, n4Q8.Height));
	}

	public void Td29(Brush n2M4, RectangleF Lb4a)
	{
		double num = (float)height - Lb4a.Y;
		object instance = g;
		object[] obj = new object[2] { Lb4a.X, num };
		object[] array = obj;
		bool[] obj2 = new bool[2] { true, true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(instance, null, "MoveTo", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			Lb4a.X = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(float));
		}
		if (array2[1])
		{
			num = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(double));
		}
		SolidBrush solidBrush;
		NewLateBinding.LateCall(g, null, "SetColorNonStroking", array = new object[1] { (solidBrush = (SolidBrush)n2M4).Color }, null, null, array2 = new bool[1] { true }, IgnoreReturn: true);
		if (array2[0])
		{
			solidBrush.Color = (Color)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Color));
		}
		object instance2;
		NewLateBinding.LateCall(g, null, "DrawRectangle", array = new object[5]
		{
			Lb4a.X,
			num,
			Lb4a.Width,
			Lb4a.Height,
			NewLateBinding.LateGet(instance2 = PaintOp, null, "Fill", new object[0], null, null, null)
		}, null, null, array2 = new bool[5] { true, true, true, true, true }, IgnoreReturn: true);
		if (array2[0])
		{
			Lb4a.X = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(float));
		}
		if (array2[1])
		{
			num = (double)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(double));
		}
		if (array2[2])
		{
			Lb4a.Width = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[2]), typeof(float));
		}
		if (array2[3])
		{
			Lb4a.Height = (float)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[3]), typeof(float));
		}
		if (array2[4])
		{
			NewLateBinding.LateSetComplex(instance2, null, "Fill", new object[1] { array[4] }, null, null, OptimisticSet: true, RValueBase: true);
		}
	}

	public void Ex5m(Brush q2M4, int d3WT, int y8AX, int Nx5a, int Ep0w)
	{
		throw new NotImplementedException();
	}

	public void Pi3g(Brush a9L1, float w3RZ, float t3WQ, float x3L2, float w9H2)
	{
		throw new NotImplementedException();
	}

	public void e2P9(Brush Hq0g, Region s8HK)
	{
		throw new NotImplementedException();
	}

	public void j6F4()
	{
		NewLateBinding.LateCall(g, null, "SaveGraphicsState", new object[0], null, null, null, IgnoreReturn: true);
	}

	public void y4Q5(FlushIntention g0YA)
	{
		throw new NotImplementedException();
	}

	public void Lx65(Region Qn9y)
	{
		throw new NotImplementedException();
	}

	public void Kc01(RectangleF p4C3)
	{
		throw new NotImplementedException();
	}

	public void Ja62(Rectangle Xe83)
	{
		throw new NotImplementedException();
	}

	public void i8D7(Matrix Hr84)
	{
		throw new NotImplementedException();
	}

	public void Px80(Matrix c5E7, MatrixOrder o1LG)
	{
		throw new NotImplementedException();
	}

	public void Wk49()
	{
		throw new NotImplementedException();
	}

	public void n2SL()
	{
		throw new NotImplementedException();
	}

	public void Ds71(float y7N5)
	{
		throw new NotImplementedException();
	}

	public void r3G9(float o9FM, MatrixOrder Rc17)
	{
		throw new NotImplementedException();
	}

	public void Wk13(float x1P5, float d8GK)
	{
		throw new NotImplementedException();
	}

	public void Tp64(float Lp9g, float Sg87, MatrixOrder Cf74)
	{
		throw new NotImplementedException();
	}

	public void Yf2i(RectangleF We5z)
	{
		throw new NotImplementedException();
	}

	public void Qb27(GraphicsPath y6T9)
	{
		throw new NotImplementedException();
	}

	public void r9M5(Rectangle Em1w)
	{
		throw new NotImplementedException();
	}

	public void o7LD(Graphics t9D2)
	{
		throw new NotImplementedException();
	}

	public void p1HD(Rectangle Xw9g, CombineMode Zk43)
	{
		throw new NotImplementedException();
	}

	public void Qw60(Region Yy5o, CombineMode Pa61)
	{
		throw new NotImplementedException();
	}

	public void Sz18(GraphicsPath r2M5, CombineMode Ss6a)
	{
		throw new NotImplementedException();
	}

	public void c3KN(RectangleF w3R6, CombineMode d7TR)
	{
		throw new NotImplementedException();
	}

	public void w4G5(Graphics k4NS, CombineMode j6F2)
	{
		throw new NotImplementedException();
	}

	public void e6G0(CoordinateSpace Ry21, CoordinateSpace e0B1, Point[] f4T8)
	{
		throw new NotImplementedException();
	}

	public void Mn34(CoordinateSpace d0F1, CoordinateSpace o2T0, PointF[] Cb2i)
	{
		throw new NotImplementedException();
	}

	public void Ne28(float Fp36, float Hx98)
	{
		throw new NotImplementedException();
	}

	public void Ay49(int La45, int Xw8y)
	{
		throw new NotImplementedException();
	}

	public void e3AC(float e8WD, float y7Z0)
	{
		throw new NotImplementedException();
	}

	public void Mx62(float Ha6c, float Cs59, MatrixOrder f3QB)
	{
		throw new NotImplementedException();
	}

	public GraphicsContainer m7X4()
	{
		throw new NotImplementedException();
	}

	public GraphicsContainer Ds2g(RectangleF Bb0q, RectangleF Ne1b, GraphicsUnit Dz9n)
	{
		throw new NotImplementedException();
	}

	public GraphicsContainer a0AE(Rectangle j4FK, Rectangle Ck27, GraphicsUnit s1XL)
	{
		throw new NotImplementedException();
	}

	public object c8YG()
	{
		throw new NotImplementedException();
	}

	public Color Fq15(Color Jw3q)
	{
		throw new NotImplementedException();
	}

	public bool Sa6p(Rectangle k1HN)
	{
		throw new NotImplementedException();
	}

	public bool o1QX(PointF Jd9j)
	{
		throw new NotImplementedException();
	}

	public bool Gg6f(RectangleF Mz6o)
	{
		throw new NotImplementedException();
	}

	public bool Jc94(Point a1AN)
	{
		throw new NotImplementedException();
	}

	public bool Jt6e(float Gq80, float n6QD)
	{
		throw new NotImplementedException();
	}

	public bool Ko80(int y9MF, int Mf9a)
	{
		throw new NotImplementedException();
	}

	public bool Ac2q(int Nr10, int Kp7x, int y1EZ, int Dn9t)
	{
		throw new NotImplementedException();
	}

	public bool x4H3(float Tp36, float m0NM, float r4WA, float z4HL)
	{
		throw new NotImplementedException();
	}

	public bool x6YP(Stream c5Q7, ImageFormat s1E4)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(new object());
		object[] obj = new object[1] { c5Q7 };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(objectValue, null, "Save", obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			c5Q7 = (Stream)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(Stream));
		}
		c5Q7.Flush();
		return true;
	}
}
