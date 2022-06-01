using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020000A1 RID: 161
internal class 10618832
{
	// Token: 0x060002CD RID: 717 RVA: 0x00022B0C File Offset: 0x00020D0C
	internal unsafe static 16e0fedb 3a88c9e9(Module A_0)
	{
		bool flag = !461c8a90.11736242;
		if (flag)
		{
			throw new PlatformNotSupportedException();
		}
		byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(A_0));
		string fullyQualifiedName = A_0.FullyQualifiedName;
		bool flag2 = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		bool flag3 = flag2;
		16e0fedb result;
		if (flag3)
		{
			result = new 16e0fedb(A_0, 10618832.2e253003(ptr));
		}
		else
		{
			result = new 16e0fedb(A_0, 10618832.6d950a34(ptr));
		}
		return result;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00022B80 File Offset: 0x00020D80
	private unsafe static void* 6d950a34(byte* A_0)
	{
		byte* ptr = A_0 + 60;
		ptr = A_0 + *(uint*)ptr;
		ptr += 6;
		ushort num = *(ushort*)ptr;
		ptr += 14;
		ushort num2 = *(ushort*)ptr;
		ptr = ptr + 4 + num2;
		byte* ptr2 = A_0 + *(uint*)(ptr - 16);
		byte* ptr3 = A_0 + *(uint*)(ptr2 + 8);
		ptr3 += 12;
		ptr3 += *(uint*)ptr3;
		ptr3 = (ptr3 + 7L & -4L);
		ptr3 += 2;
		ushort num3 = (ushort)(*ptr3);
		ptr3 += 2;
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < (int)num3; i++)
		{
			uint num4 = *(uint*)ptr3;
			uint num5 = *(uint*)(ptr3 + 4);
			ptr3 += 8;
			stringBuilder.Length = 0;
			for (int j = 0; j < 8; j++)
			{
				stringBuilder.Append((char)(*(ptr3++)));
				bool flag = *ptr3 == 0;
				if (flag)
				{
					ptr3 += 3;
					break;
				}
				stringBuilder.Append((char)(*(ptr3++)));
				bool flag2 = *ptr3 == 0;
				if (flag2)
				{
					ptr3 += 2;
					break;
				}
				stringBuilder.Append((char)(*(ptr3++)));
				bool flag3 = *ptr3 == 0;
				if (flag3)
				{
					ptr3++;
					break;
				}
				stringBuilder.Append((char)(*(ptr3++)));
				bool flag4 = *ptr3 == 0;
				if (flag4)
				{
					break;
				}
			}
			bool flag5 = stringBuilder.ToString() == "#Koi";
			if (flag5)
			{
				return 10618832.e0c5ef2d((void*)(A_0 + *(uint*)(ptr2 + 8) + num4), num5);
			}
		}
		return null;
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00022D18 File Offset: 0x00020F18
	private unsafe static void* 2e253003(byte* A_0)
	{
		byte* ptr = A_0 + 60;
		ptr = A_0 + *(uint*)ptr;
		ptr += 6;
		ushort num = *(ushort*)ptr;
		ptr += 14;
		ushort num2 = *(ushort*)ptr;
		ptr = ptr + 4 + num2;
		uint num3 = *(uint*)(ptr - 16);
		uint[] array = new uint[(int)num];
		uint[] array2 = new uint[(int)num];
		uint[] array3 = new uint[(int)num];
		for (int i = 0; i < (int)num; i++)
		{
			array[i] = *(uint*)(ptr + 12);
			array2[i] = *(uint*)(ptr + 8);
			array3[i] = *(uint*)(ptr + 20);
			ptr += 40;
		}
		for (int j = 0; j < (int)num; j++)
		{
			bool flag = array[j] <= num3 && num3 < array[j] + array2[j];
			if (flag)
			{
				num3 = num3 - array[j] + array3[j];
				break;
			}
		}
		byte* ptr2 = A_0 + num3;
		uint num4 = *(uint*)(ptr2 + 8);
		for (int k = 0; k < (int)num; k++)
		{
			bool flag2 = array[k] <= num4 && num4 < array[k] + array2[k];
			if (flag2)
			{
				num4 = num4 - array[k] + array3[k];
				break;
			}
		}
		byte* ptr3 = A_0 + num4;
		ptr3 += 12;
		ptr3 += *(uint*)ptr3;
		ptr3 = (ptr3 + 7L & -4L);
		ptr3 += 2;
		ushort num5 = (ushort)(*ptr3);
		ptr3 += 2;
		StringBuilder stringBuilder = new StringBuilder();
		for (int l = 0; l < (int)num5; l++)
		{
			uint num6 = *(uint*)ptr3;
			uint num7 = *(uint*)(ptr3 + 4);
			stringBuilder.Length = 0;
			ptr3 += 8;
			for (int m = 0; m < 8; m++)
			{
				stringBuilder.Append((char)(*(ptr3++)));
				bool flag3 = *ptr3 == 0;
				if (flag3)
				{
					ptr3 += 3;
					break;
				}
				stringBuilder.Append((char)(*(ptr3++)));
				bool flag4 = *ptr3 == 0;
				if (flag4)
				{
					ptr3 += 2;
					break;
				}
				stringBuilder.Append((char)(*(ptr3++)));
				bool flag5 = *ptr3 == 0;
				if (flag5)
				{
					ptr3++;
					break;
				}
				stringBuilder.Append((char)(*(ptr3++)));
				bool flag6 = *ptr3 == 0;
				if (flag6)
				{
					break;
				}
			}
			bool flag7 = stringBuilder.ToString() == "#Koi";
			if (flag7)
			{
				return 10618832.e0c5ef2d((void*)(A_0 + num4 + num6), num7);
			}
		}
		return null;
	}

	// Token: 0x060002D0 RID: 720
	[DllImport("kernel32.dll", EntryPoint = "CopyMemory")]
	private unsafe static extern void 15be9586(void*, void*, uint);

	// Token: 0x060002D1 RID: 721 RVA: 0x00022F9C File Offset: 0x0002119C
	private unsafe static void* e0c5ef2d(void* A_0, uint A_1)
	{
		void* ptr = (void*)Marshal.AllocHGlobal((int)A_1);
		10618832.15be9586(ptr, A_0, A_1);
		return ptr;
	}
}
