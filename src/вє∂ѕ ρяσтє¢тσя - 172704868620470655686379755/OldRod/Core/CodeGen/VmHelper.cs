using System;
using System.Reflection;

namespace OldRod.Core.CodeGen
{
	// Token: 0x020000A2 RID: 162
	public static class VmHelper
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x00022FC4 File Offset: 0x000211C4
		public static void UpdateFL(uint op1, uint op2, uint flResult, uint result, ref byte fl, byte mask)
		{
			byte b = 0;
			if (result == 0U)
			{
				b |= VmHelper.FL_ZERO;
			}
			if (((ulong)result & (ulong)-2147483648) != 0UL)
			{
				b |= VmHelper.FL_SIGN;
			}
			if (((ulong)((op1 ^ flResult) & (op2 ^ flResult)) & (ulong)-2147483648) != 0UL)
			{
				b |= VmHelper.FL_OVERFLOW;
			}
			if (((ulong)(op1 ^ ((op1 ^ op2) & (op2 ^ flResult))) & (ulong)-2147483648) != 0UL)
			{
				b |= VmHelper.FL_CARRY;
			}
			fl = ((fl & ~mask) | (b & mask));
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0002303C File Offset: 0x0002123C
		public static void UpdateFL(ulong op1, ulong op2, ulong flResult, ulong result, ref byte fl, byte mask)
		{
			byte b = 0;
			if (result == 0UL)
			{
				b |= VmHelper.FL_ZERO;
			}
			if ((result & (ulong)-2147483648) != 0UL)
			{
				b |= VmHelper.FL_SIGN;
			}
			if (((op1 ^ flResult) & (op2 ^ flResult) & (ulong)-2147483648) != 0UL)
			{
				b |= VmHelper.FL_OVERFLOW;
			}
			if (((op1 ^ ((op1 ^ op2) & (op2 ^ flResult))) & (ulong)-2147483648) != 0UL)
			{
				b |= VmHelper.FL_CARRY;
			}
			fl = ((fl & ~mask) | (b & mask));
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002A78 File Offset: 0x00000C78
		public static object ConvertToVmType(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			return VmHelper.ConvertToVmType(obj, obj.GetType());
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000230B0 File Offset: 0x000212B0
		public static object ConvertToVmType(object obj, Type type)
		{
			while (type.IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(type);
				obj = Convert.ChangeType(obj, underlyingType);
				type = underlyingType;
			}
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Boolean:
				return ((bool)obj) ? 1 : 0;
			case TypeCode.Char:
				return (char)obj;
			case TypeCode.SByte:
				return (byte)((sbyte)obj);
			case TypeCode.Int16:
				return (ushort)((short)obj);
			case TypeCode.Int32:
				return (uint)((int)obj);
			case TypeCode.Int64:
				return (ulong)((long)obj);
			}
			if (obj is Pointer)
			{
				return Pointer.Unbox(obj);
			}
			if (obj is IntPtr)
			{
				IntPtr intPtr = (IntPtr)obj;
				return intPtr;
			}
			if (obj is UIntPtr)
			{
				UIntPtr value = (UIntPtr)obj;
				return (ulong)value;
			}
			return obj;
		}

		// Token: 0x040001FF RID: 511
		private static readonly byte FL_OVERFLOW = 1;

		// Token: 0x04000200 RID: 512
		private static readonly byte FL_CARRY = 4;

		// Token: 0x04000201 RID: 513
		private static readonly byte FL_ZERO = 16;

		// Token: 0x04000202 RID: 514
		private static readonly byte FL_SIGN = 2;

		// Token: 0x04000203 RID: 515
		private static readonly byte FL_UNSIGNED = 32;

		// Token: 0x04000204 RID: 516
		private static readonly byte FL_BEHAV1 = 8;

		// Token: 0x04000205 RID: 517
		private static readonly byte FL_BEHAV2 = 64;

		// Token: 0x04000206 RID: 518
		private static readonly byte FL_BEHAV3 = 128;
	}
}
