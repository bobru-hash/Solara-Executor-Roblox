using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using De7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Si3e;
using Xq54;

namespace Yi39;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Ld08
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Rj74
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public y1S m_Form1;

		public y1S Form1
		{
			[DebuggerHidden]
			get
			{
				m_Form1 = Tp2y(m_Form1);
				return m_Form1;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Zf4a(ref m_Form1);
				}
			}
		}

		[DebuggerHidden]
		private static Mw17 Tp2y<Mw17>(Mw17 n5L3) where Mw17 : Form, new()
		{
			if (n5L3 == null || n5L3.IsDisposed)
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(Mw17)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(Mw17), null);
				try
				{
					return new Mw17();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError(ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(Mw17));
				}
			}
			return n5L3;
		}

		[DebuggerHidden]
		private void Zf4a<Xi51>(ref Xi51 t3A1) where Xi51 : Form
		{
			t3A1.Dispose();
			t3A1 = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Rj74()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Mt93(object z7Y3)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(z7Y3));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Yy7m()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type Cj1r()
		{
			return typeof(Rj74);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Hx3d()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Tr9a
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public bool Yn1b(object Aw25)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(Aw25));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public int Bk0o()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type a7HB()
		{
			return typeof(Tr9a);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public string Gj3y()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static i1JR Zr8s<i1JR>(i1JR c3ED) where i1JR : new()
		{
			if (c3ED == null)
			{
				return new i1JR();
			}
			return c3ED;
		}

		[DebuggerHidden]
		private void f2LF<Rp97>(ref Rp97 Na1c)
		{
			Na1c = default(Rp97);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Tr9a()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class k1FE<Sj2p> where Sj2p : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static Sj2p m_ThreadStaticValue;

		internal Sj2p GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new Sj2p();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public k1FE()
		{
		}
	}

	private static readonly k1FE<Mr3c> m_ComputerObjectProvider = new k1FE<Mr3c>();

	private static readonly k1FE<a6ZX> m_AppObjectProvider = new k1FE<a6ZX>();

	private static readonly k1FE<User> m_UserObjectProvider = new k1FE<User>();

	private static k1FE<Rj74> m_MyFormsObjectProvider = new k1FE<Rj74>();

	private static readonly k1FE<Tr9a> m_MyWebServicesObjectProvider = new k1FE<Tr9a>();

	[HelpKeyword("My.Computer")]
	internal static Mr3c Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static a6ZX Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static Rj74 Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Tr9a WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
