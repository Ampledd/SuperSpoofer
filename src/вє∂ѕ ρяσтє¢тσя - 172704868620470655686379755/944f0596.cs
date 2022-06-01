using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Permissions;

// Token: 0x02000099 RID: 153
internal static class 944f0596
{
	// Token: 0x060002B5 RID: 693 RVA: 0x00021B90 File Offset: 0x0001FD90
	static 944f0596()
	{
		AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("Fish"), AssemblyBuilderAccess.Run);
		ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("Fish");
		CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(typeof(SecurityPermissionAttribute).GetConstructor(new Type[]
		{
			typeof(SecurityAction)
		}), new object[]
		{
			SecurityAction.Assert
		}, new PropertyInfo[]
		{
			typeof(SecurityPermissionAttribute).GetProperty("SkipVerification")
		}, new object[]
		{
			true
		});
		moduleBuilder.SetCustomAttribute(customAttribute);
		944f0596.cc51fffd = moduleBuilder.DefineType(" ").CreateType().Module;
	}

	// Token: 0x04000172 RID: 370
	public static readonly Module cc51fffd;
}
