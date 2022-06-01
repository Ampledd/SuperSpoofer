using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200002C RID: 44
internal class 1beaa6fd
{
	// Token: 0x06000133 RID: 307 RVA: 0x00002270 File Offset: 0x00000470
	private 1beaa6fd(16e0fedb A_1)
	{
		this.e6bfaf12 = A_1;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000228C File Offset: 0x0000048C
	public 16e0fedb 74973c38()
	{
		return this.e6bfaf12;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0001909C File Offset: 0x0001729C
	public static 1beaa6fd 4b935237(Module A_0)
	{
		bool flag = 1beaa6fd.3399855b == null;
		if (flag)
		{
			1beaa6fd.3399855b = new Dictionary<Module, 1beaa6fd>();
		}
		1beaa6fd 1beaa6fd;
		bool flag2 = !1beaa6fd.3399855b.TryGetValue(A_0, out 1beaa6fd);
		if (flag2)
		{
			1beaa6fd = new 1beaa6fd(16e0fedb.4b935237(A_0));
			1beaa6fd.3399855b[A_0] = 1beaa6fd;
			object obj = 1beaa6fd.c3ffafe;
			lock (obj)
			{
				bool flag3 = !1beaa6fd.dc7de645.ContainsKey(A_0);
				if (flag3)
				{
					1beaa6fd.a253381();
					1beaa6fd.dc7de645.Add(A_0, 1beaa6fd.dc7de645.Count);
				}
			}
		}
		return 1beaa6fd;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00019154 File Offset: 0x00017354
	public static 1beaa6fd 4b935237(int A_0)
	{
		foreach (KeyValuePair<Module, int> keyValuePair in 1beaa6fd.dc7de645)
		{
			bool flag = keyValuePair.Value == A_0;
			if (flag)
			{
				return 1beaa6fd.4b935237(keyValuePair.Key);
			}
		}
		return null;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x000191C4 File Offset: 0x000173C4
	public static int cd0b0a2a(Module A_0)
	{
		return 1beaa6fd.dc7de645[A_0];
	}

	// Token: 0x06000138 RID: 312 RVA: 0x000191E4 File Offset: 0x000173E4
	private void a253381()
	{
		62af8ce4 62af8ce = this.74973c38().cd7bd0c9((uint)867a1c12.93616210);
		ulong num = this.74973c38().aa571bc5() + 62af8ce.f3bff2f3;
		this.9a70f6ec(num, 62af8ce.d1b61bb6, 62af8ce.267edf9d, new object[0]);
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00019234 File Offset: 0x00017434
	public object 9a70f6ec(uint A_1, object[] A_2)
	{
		62af8ce4 62af8ce = this.74973c38().cd7bd0c9(A_1);
		ulong num = this.74973c38().aa571bc5() + 62af8ce.f3bff2f3;
		return this.9a70f6ec(num, 62af8ce.d1b61bb6, 62af8ce.267edf9d, A_2);
	}

	// Token: 0x0600013A RID: 314 RVA: 0x0001927C File Offset: 0x0001747C
	public object 9a70f6ec(ulong A_1, uint A_2, uint A_3, object[] A_4)
	{
		45263f4a 267edf9d = this.74973c38().cd7bd0c9(A_3).267edf9d;
		return this.9a70f6ec(A_1, A_2, 267edf9d, A_4);
	}

	// Token: 0x0600013B RID: 315 RVA: 0x000192AC File Offset: 0x000174AC
	public unsafe void 9a70f6ec(uint A_1, void*[] A_2, void* A_3)
	{
		62af8ce4 62af8ce = this.74973c38().cd7bd0c9(A_1);
		ulong num = this.74973c38().aa571bc5() + 62af8ce.f3bff2f3;
		this.9a70f6ec(num, 62af8ce.d1b61bb6, 62af8ce.267edf9d, A_2, A_3);
	}

	// Token: 0x0600013C RID: 316 RVA: 0x000192F4 File Offset: 0x000174F4
	public unsafe void 9a70f6ec(ulong A_1, uint A_2, uint A_3, void*[] A_4, void* A_5)
	{
		45263f4a 267edf9d = this.74973c38().cd7bd0c9(A_3).267edf9d;
		this.9a70f6ec(A_1, A_2, 267edf9d, A_4, A_5);
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00019324 File Offset: 0x00017524
	private object 9a70f6ec(ulong A_1, uint A_2, 45263f4a A_3, object[] A_4)
	{
		bool flag = this.a745f8bf != null;
		if (flag)
		{
			this.155022e0.Push(this.a745f8bf);
		}
		this.a745f8bf = new 33cd5b0d(this);
		object result;
		try
		{
			Debug.Assert(A_3.2ad1a621().Length == A_4.Length);
			this.a745f8bf.c544e0bc.83d7c013((uint)(A_4.Length + 1));
			uint num = 0U;
			while ((ulong)num < (ulong)((long)A_4.Length))
			{
				this.a745f8bf.c544e0bc.af836684(num + 1U, 1581069d.99db5886(A_4[(int)num], A_3.2ad1a621()[(int)num]));
				num += 1U;
			}
			f6dce402 c544e0bc = this.a745f8bf.c544e0bc;
			uint num2 = (uint)(A_4.Length + 1);
			1581069d 1581069d = default(1581069d);
			1581069d.6535f2d7(1UL);
			c544e0bc.af836684(num2, 1581069d);
			1581069d[] cd97a = this.a745f8bf.cd97a091;
			int 4b45f8d = (int)867a1c12.4b45f8d5;
			1581069d = default(1581069d);
			1581069d.eb3abd21(A_2);
			cd97a[4b45f8d] = 1581069d;
			1581069d[] cd97a2 = this.a745f8bf.cd97a091;
			int 98ef = (int)867a1c12.98ef7511;
			1581069d = default(1581069d);
			1581069d.eb3abd21(0U);
			cd97a2[98ef] = 1581069d;
			1581069d[] cd97a3 = this.a745f8bf.cd97a091;
			int d7e5ab3c = (int)867a1c12.d7e5ab3c;
			1581069d = default(1581069d);
			1581069d.eb3abd21((uint)(A_4.Length + 1));
			cd97a3[d7e5ab3c] = 1581069d;
			1581069d[] cd97a4 = this.a745f8bf.cd97a091;
			int 6e2e8d6b = (int)867a1c12.6e2e8d6b;
			1581069d = default(1581069d);
			1581069d.6535f2d7(A_1);
			cd97a4[6e2e8d6b] = 1581069d;
			a4d544eb.9a70f6ec(this.a745f8bf);
			Debug.Assert(this.a745f8bf.5c71f0c7.Count == 0);
			object obj = null;
			bool flag2 = A_3.2a7e890c() != typeof(void);
			if (flag2)
			{
				1581069d 1581069d2 = this.a745f8bf.cd97a091[(int)867a1c12.75938c49];
				bool flag3 = Type.GetTypeCode(A_3.2a7e890c()) == TypeCode.String && 1581069d2.c41a9534() == null;
				if (flag3)
				{
					obj = this.74973c38().f3c2d292(1581069d2.95ecf24a());
				}
				else
				{
					obj = 1581069d2.c822b8e7(A_3.2a7e890c());
				}
			}
			result = obj;
		}
		finally
		{
			this.a745f8bf.c544e0bc.92ecc9bd();
			bool flag4 = this.155022e0.Count > 0;
			if (flag4)
			{
				this.a745f8bf = this.155022e0.Pop();
			}
		}
		return result;
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00019590 File Offset: 0x00017790
	private unsafe void 9a70f6ec(ulong A_1, uint A_2, 45263f4a A_3, void*[] A_4, void* A_5)
	{
		bool flag = this.a745f8bf != null;
		if (flag)
		{
			this.155022e0.Push(this.a745f8bf);
		}
		this.a745f8bf = new 33cd5b0d(this);
		try
		{
			Debug.Assert(A_3.2ad1a621().Length == A_4.Length);
			this.a745f8bf.c544e0bc.83d7c013((uint)(A_4.Length + 1));
			uint num = 0U;
			1581069d 1581069d;
			while ((ulong)num < (ulong)((long)A_4.Length))
			{
				Type type = A_3.2ad1a621()[(int)num];
				bool isByRef = type.IsByRef;
				if (isByRef)
				{
					f6dce402 c544e0bc = this.a745f8bf.c544e0bc;
					uint num2 = num + 1U;
					1581069d = default(1581069d);
					1581069d.5b4f3f03(new c9a038a7(f087c8e3.2b8998e6(A_4[(int)num])));
					c544e0bc.af836684(num2, 1581069d);
				}
				else
				{
					TypedReference typedReference = *(TypedReference*)A_4[(int)num];
					this.a745f8bf.c544e0bc.af836684(num + 1U, 1581069d.99db5886(TypedReference.ToObject(typedReference), __reftype(typedReference)));
				}
				num += 1U;
			}
			f6dce402 c544e0bc2 = this.a745f8bf.c544e0bc;
			uint num3 = (uint)(A_4.Length + 1);
			1581069d = default(1581069d);
			1581069d.6535f2d7(1UL);
			c544e0bc2.af836684(num3, 1581069d);
			1581069d[] cd97a = this.a745f8bf.cd97a091;
			int 4b45f8d = (int)867a1c12.4b45f8d5;
			1581069d = default(1581069d);
			1581069d.eb3abd21(A_2);
			cd97a[4b45f8d] = 1581069d;
			1581069d[] cd97a2 = this.a745f8bf.cd97a091;
			int 98ef = (int)867a1c12.98ef7511;
			1581069d = default(1581069d);
			1581069d.eb3abd21(0U);
			cd97a2[98ef] = 1581069d;
			1581069d[] cd97a3 = this.a745f8bf.cd97a091;
			int d7e5ab3c = (int)867a1c12.d7e5ab3c;
			1581069d = default(1581069d);
			1581069d.eb3abd21((uint)(A_4.Length + 1));
			cd97a3[d7e5ab3c] = 1581069d;
			1581069d[] cd97a4 = this.a745f8bf.cd97a091;
			int 6e2e8d6b = (int)867a1c12.6e2e8d6b;
			1581069d = default(1581069d);
			1581069d.6535f2d7(A_1);
			cd97a4[6e2e8d6b] = 1581069d;
			a4d544eb.9a70f6ec(this.a745f8bf);
			Debug.Assert(this.a745f8bf.5c71f0c7.Count == 0);
			bool flag2 = A_3.2a7e890c() != typeof(void);
			if (flag2)
			{
				bool isByRef2 = A_3.2a7e890c().IsByRef;
				if (isByRef2)
				{
					object obj = this.a745f8bf.cd97a091[(int)867a1c12.75938c49].c41a9534();
					bool flag3 = !(obj is dc32a2c5);
					if (flag3)
					{
						throw new ExecutionEngineException();
					}
					((dc32a2c5)obj).5f1317f4(this.a745f8bf, f087c8e3.2b8998e6(A_5), A_3.2a7e890c().GetElementType());
				}
				else
				{
					1581069d 1581069d2 = this.a745f8bf.cd97a091[(int)867a1c12.75938c49];
					bool flag4 = Type.GetTypeCode(A_3.2a7e890c()) == TypeCode.String && 1581069d2.c41a9534() == null;
					object obj2;
					if (flag4)
					{
						obj2 = this.74973c38().f3c2d292(1581069d2.95ecf24a());
					}
					else
					{
						obj2 = 1581069d2.c822b8e7(A_3.2a7e890c());
					}
					de06eb40.1c6b5274(obj2, f087c8e3.2b8998e6(A_5));
				}
			}
		}
		finally
		{
			this.a745f8bf.c544e0bc.92ecc9bd();
			bool flag5 = this.155022e0.Count > 0;
			if (flag5)
			{
				this.a745f8bf = this.155022e0.Pop();
			}
		}
	}

	// Token: 0x04000135 RID: 309
	[ThreadStatic]
	private static Dictionary<Module, 1beaa6fd> 3399855b;

	// Token: 0x04000136 RID: 310
	private static readonly object c3ffafe = new object();

	// Token: 0x04000137 RID: 311
	private static readonly Dictionary<Module, int> dc7de645 = new Dictionary<Module, int>();

	// Token: 0x04000138 RID: 312
	private readonly Stack<33cd5b0d> 155022e0 = new Stack<33cd5b0d>();

	// Token: 0x04000139 RID: 313
	private 33cd5b0d a745f8bf;

	// Token: 0x0400013A RID: 314
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private readonly 16e0fedb e6bfaf12;
}
