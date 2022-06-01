using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SuperSpoofer.Properties
{
	// Token: 0x02000015 RID: 21
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x0000EA44 File Offset: 0x0000CC44
		internal Resources()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (((Resources.resourceMan == null) ? 1U : 0U) != (uint)0)
				{
					Resources.resourceMan = new ResourceManager("SuperSpoofer.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040000A4 RID: 164
		private static ResourceManager resourceMan;

		// Token: 0x040000A5 RID: 165
		private static CultureInfo resourceCulture;
	}
}
