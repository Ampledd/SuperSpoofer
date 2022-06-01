using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SuperSpoofer.Properties
{
	// Token: 0x02000016 RID: 22
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000EAF4 File Offset: 0x0000CCF4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000EB14 File Offset: 0x0000CD14
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000EB40 File Offset: 0x0000CD40
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string msgweb
		{
			get
			{
				return (string)this["msgweb"];
			}
			set
			{
				this["msgweb"] = value;
			}
		}

		// Token: 0x040000A6 RID: 166
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
