using System;
using System.Reflection;

// Token: 0x02000084 RID: 132
internal class 10e6a946 : dc32a2c5
{
	// Token: 0x0600024C RID: 588 RVA: 0x00002838 File Offset: 0x00000A38
	public 10e6a946(object A_1, FieldInfo A_2)
	{
		this.a5bb1068 = A_1;
		this.876d6fed = A_2;
	}

	// Token: 0x0600024D RID: 589 RVA: 0x0001EA10 File Offset: 0x0001CC10
	public 1581069d 4109351f(33cd5b0d A_1, 7d18b560 A_2)
	{
		object obj = this.a5bb1068;
		bool flag = this.876d6fed.DeclaringType.IsValueType && this.a5bb1068 is dc32a2c5;
		if (flag)
		{
			obj = ((dc32a2c5)this.a5bb1068).4109351f(A_1, (7d18b560)4).c822b8e7(this.876d6fed.DeclaringType);
		}
		return 1581069d.99db5886(this.876d6fed.GetValue(obj), this.876d6fed.FieldType);
	}

	// Token: 0x0600024E RID: 590 RVA: 0x0001EA94 File Offset: 0x0001CC94
	public unsafe void 6517fff2(33cd5b0d A_1, 1581069d A_2, 7d18b560 A_3)
	{
		bool flag = this.876d6fed.DeclaringType.IsValueType && this.a5bb1068 is dc32a2c5;
		if (flag)
		{
			TypedReference obj;
			((dc32a2c5)this.a5bb1068).5f1317f4(A_1, f087c8e3.2b8998e6((void*)(&obj)), this.876d6fed.DeclaringType);
			this.876d6fed.SetValueDirect(obj, A_2.c822b8e7(this.876d6fed.FieldType));
		}
		else
		{
			this.876d6fed.SetValue(this.a5bb1068, A_2.c822b8e7(this.876d6fed.FieldType));
		}
	}

	// Token: 0x0600024F RID: 591 RVA: 0x0001EB38 File Offset: 0x0001CD38
	public dc32a2c5 ed435ea9(uint A_1)
	{
		return this;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0001EB4C File Offset: 0x0001CD4C
	public dc32a2c5 ed435ea9(ulong A_1)
	{
		return this;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002850 File Offset: 0x00000A50
	public void 5f1317f4(33cd5b0d A_1, f087c8e3 A_2, Type A_3)
	{
		de06eb40.7e105b43(A_1, this.a5bb1068, this.876d6fed, A_2);
	}

	// Token: 0x0400013C RID: 316
	private readonly FieldInfo 876d6fed;

	// Token: 0x0400013D RID: 317
	private readonly object a5bb1068;
}
