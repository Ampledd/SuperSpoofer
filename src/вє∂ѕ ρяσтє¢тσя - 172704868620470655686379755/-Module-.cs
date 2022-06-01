using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SuperSpoofer.Forms___Spoofer;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	static <Module>()
	{
		VM.VM();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002B2C File Offset: 0x00000D2C
	public static void __VMHELPER_INIT__()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002B3C File Offset: 0x00000D3C
	public static void __VMFUNCTION__47972()
	{
		List<int> list = new List<int>
		{
			8,
			12,
			16,
			20,
			24,
			28,
			36
		};
		List<int> list2 = new List<int>
		{
			26,
			27
		};
		List<int> list3 = new List<int>
		{
			4,
			22,
			24,
			64,
			66,
			68,
			70,
			72,
			74,
			76,
			92,
			94
		};
		IntPtr baseAddress = Process.GetCurrentProcess().MainModule.BaseAddress;
		uint num = (uint)Marshal.ReadInt32((IntPtr)((int)((uint)baseAddress.ToInt32() + (uint)60)));
		byte b = (byte)Marshal.ReadInt16((IntPtr)((int)((uint)baseAddress.ToInt32() + num + (uint)6)));
		uint num2 = (uint)0;
		while (((num2 < (uint)list3.Count) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__2667C((IntPtr)((int)((uint)baseAddress.ToInt32() + num + (uint)list3[(int)num2])), 1);
			num2 += (uint)1;
		}
		uint num3 = (uint)0;
		while (((num3 < (uint)list2.Count) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__2667C((IntPtr)((int)((uint)baseAddress.ToInt32() + num + (uint)list2[(int)num3])), 2);
			num3 += (uint)1;
		}
		uint num4 = (uint)0;
		uint num5 = (uint)0;
		while (((num4 > (uint)((int)b)) ? 1U : 0U) == (uint)0)
		{
			if (num5 == (uint)0)
			{
				<Module>.__VMFUNCTION__2667C((IntPtr)((int)((uint)baseAddress.ToInt32() + num + (uint)250 + (uint)40 * num4 + (uint)32)), 2);
			}
			num5 += (uint)1;
			if (((num5 == (uint)list.Count) ? 1U : 0U) != (uint)0)
			{
				num4 += (uint)1;
				num5 = (uint)0;
			}
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002DC0 File Offset: 0x00000FC0
	public static void __VMFUNCTION__A0E29(object A_0)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002057 File Offset: 0x00000257
	public static void __VMFUNCTION__516F1(object)
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002DD4 File Offset: 0x00000FD4
	public static void __VMFUNCTION__6C14A()
	{
		new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Assembly.GetExecutingAssembly().Location + "\"").WindowStyle = ProcessWindowStyle.Hidden;
		ProcessStartInfo startInfo;
		Component component = Process.Start(startInfo);
		if (component != null)
		{
			component.Dispose();
		}
		Process.GetCurrentProcess().Kill();
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002E3C File Offset: 0x0000103C
	public static void __VMFUNCTION__470BF()
	{
		new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Assembly.GetExecutingAssembly().Location + "\"").WindowStyle = ProcessWindowStyle.Hidden;
		ProcessStartInfo startInfo;
		Component component = Process.Start(startInfo);
		if (component != null)
		{
			component.Dispose();
		}
		Process.GetCurrentProcess().Kill();
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002EA4 File Offset: 0x000010A4
	public static void __VMFUNCTION__3613B()
	{
		new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Assembly.GetExecutingAssembly().Location + "\"").WindowStyle = ProcessWindowStyle.Hidden;
		ProcessStartInfo startInfo;
		Component component = Process.Start(startInfo);
		if (component != null)
		{
			component.Dispose();
		}
		Process.GetCurrentProcess().Kill();
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002F0C File Offset: 0x0000110C
	public static void __VMFUNCTION__699C2(object A_0)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002F20 File Offset: 0x00001120
	public static object __VMFUNCTION__517BA(NameValueCollection A_0)
	{
		HttpStatusCode httpStatusCode = (HttpStatusCode)0;
		HttpStatusCode httpStatusCode2 = (HttpStatusCode)0;
		object result;
		try
		{
			using (WebClient webClient = new WebClient())
			{
				byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", A_0);
				result = Encoding.Default.GetString(bytes);
			}
		}
		catch (WebException ex)
		{
			uint num = (uint)((HttpWebResponse)ex.Response).StatusCode;
			uint num2 = num;
			if (((num2 == (uint)429) ? 1U : 0U) == (uint)0)
			{
				MessageBox.Show("Could not connect to keyauth.win/api | Servers may be down or your client cannot connect. Please retry in 10 minutes or contact us for help!", "SuperSpoofer - Auth Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				result = "";
			}
			else
			{
				Thread.Sleep(1000);
				result = <Module>.__VMFUNCTION__517BA(A_0);
			}
		}
		return result;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00003020 File Offset: 0x00001220
	public static void __VMFUNCTION__2667C(IntPtr A_0, int A_1)
	{
		IntPtr intPtr = (IntPtr)A_1;
		IntPtr intPtr2 = 0;
		VM.Beds-Protector-rown-FoxᅠᅠᅠᅠᅠJumped-Over-The-Lazy-DogCThe-ᅠᅠᅠᅠQuick-Brown-ᅠᅠᅠᅠᅠᅠe-Lazy-DogCᅠᅠᅠᅠᅠThe-Quick--Over-The-Laᅠᅠᅠᅠzyᅠ(A_0, intPtr, (IntPtr)64, ref intPtr2);
		VM.Beds-Protector-rown-FoxᅠᅠᅠᅠᅠJumped-Over-The-Lazy-DogcThe-ᅠᅠᅠᅠQuick-Brown-ᅠᅠᅠᅠᅠᅠe-Lazy-DogcᅠᅠᅠᅠᅠThe-Quick--Over-The-Laᅠᅠᅠᅠzyᅠ(A_0, intPtr);
		IntPtr intPtr3 = 0;
		VM.Beds-Protector-rown-FoxᅠᅠᅠᅠᅠJumped-Over-The-Lazy-DogCThe-ᅠᅠᅠᅠQuick-Brown-ᅠᅠᅠᅠᅠᅠe-Lazy-DogCᅠᅠᅠᅠᅠThe-Quick--Over-The-Laᅠᅠᅠᅠzyᅠ(A_0, intPtr, intPtr2, ref intPtr3);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00003078 File Offset: 0x00001278
	public static void __VMFUNCTION__3D29B()
	{
		BinaryReader binaryReader = new BinaryReader(new StreamReader(typeof(VM).Assembly.Location).BaseStream);
		BinaryReader binaryReader2 = binaryReader;
		string a = (string)<Module>.__VMFUNCTION__8CD10(binaryReader.ReadBytes(File.ReadAllBytes(typeof(VM).Assembly.Location).Length + (int)(~(int)((uint)32)) + (int)((uint)1)));
		ulong num = (ulong)((long)((uint)32));
		binaryReader2.BaseStream.Position = (long)((ulong)binaryReader2.BaseStream.Length + ~(num | num) + (ulong)1L);
		if (((a != Encoding.ASCII.GetString(binaryReader2.ReadBytes(32))) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__1E569("START CMD /C \"ECHO File corrupted! This application has been manipulated. && PAUSE\" ");
			Process.GetCurrentProcess().Kill();
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003150 File Offset: 0x00001350
	public static void __VMFUNCTION__55E7A(object A_0)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00003164 File Offset: 0x00001364
	public static void __VMFUNCTION__362E4(object A_0)
	{
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		Application.Exit();
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000031C0 File Offset: 0x000013C0
	public static bool __VMFUNCTION__562AD(fivembuildchanger.<>c A_0, string A_1)
	{
		return (A_1.Contains("SavedBuildNumber") ? 1U : 0U) == (uint)0;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000031E8 File Offset: 0x000013E8
	public static object __VMFUNCTION__8CD10(byte[] A_0)
	{
		byte[] array = new MD5CryptoServiceProvider().ComputeHash(A_0);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		uint num = (uint)0;
		while (((num < (uint)array2.Length) ? 1U : 0U) != (uint)0)
		{
			stringBuilder.Append(((byte)Convert.ToUInt32(array2[(int)num])).ToString("x2").ToLower());
			num += (uint)1;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00003268 File Offset: 0x00001468
	public static void __VMFUNCTION__8BD7B(object A_0)
	{
		if ((((IntPtr)<Module>.__VMFUNCTION__95656("SbieDll.dll") != IntPtr.Zero) ? 1U : 0U) != (uint)0)
		{
			MessageBox.Show("Please fully uninstall sandboxie (EXITING...)", "SuperSpoofer - Protection!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Application.Exit();
		}
		if (((Process.GetProcessesByName("ida").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__85057(A_0);
		}
		if (((Process.GetProcessesByName("dnspy").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__1B15E(A_0);
		}
		if (((Process.GetProcessesByName("simpleassembly").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__7110D(A_0);
		}
		if (((Process.GetProcessesByName("peek").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__1A362(A_0);
		}
		if (((Process.GetProcessesByName("fiddler").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__58192(A_0);
		}
		if (((Process.GetProcessesByName("processhacker").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__516F1(A_0);
		}
		if (((Process.GetProcessesByName("ImportREC").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__8CB67(A_0);
		}
		if (((Process.GetProcessesByName("IMMUNITYDEBUGGER").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__6A893(A_0);
		}
		if (((Process.GetProcessesByName("MegaDumper").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__45568(A_0);
		}
		if (((Process.GetProcessesByName("reshacker").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__51828(A_0);
		}
		if (((Process.GetProcessesByName("cheat engine").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__6E91B(A_0);
		}
		if (((Process.GetProcessesByName("HTTP Debugger").Length == (int)((uint)0)) ? 1U : 0U) != (uint)0)
		{
			<Module>.__VMFUNCTION__A0E29(A_0);
		}
		else
		{
			<Module>.__VMFUNCTION__19DF3(A_0);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000034F4 File Offset: 0x000016F4
	public static void __VMFUNCTION__1E569(string A_0)
	{
		Process.Start(new ProcessStartInfo("cmd.exe", "/c " + A_0)
		{
			CreateNoWindow = true,
			UseShellExecute = false
		});
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00003534 File Offset: 0x00001734
	public static object __VMFUNCTION__95656(string A_0)
	{
		object obj = (object)Process.GetCurrentProcess().Modules.GetEnumerator();
		try
		{
			while ((((IEnumerator)obj).MoveNext() ? 1U : 0U) != (uint)0)
			{
				ProcessModule processModule = (ProcessModule)((IEnumerator)obj).Current;
				if ((processModule.ModuleName.ToLower().Contains(A_0.ToLower()) ? 1U : 0U) != (uint)0)
				{
					return processModule.BaseAddress;
				}
			}
		}
		finally
		{
			object obj2 = (object)(obj as IDisposable);
			if (obj2 != null)
			{
				((IDisposable)obj2).Dispose();
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002058 File Offset: 0x00000258
	public static void __VMFUNCTION__19DF3(object)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002059 File Offset: 0x00000259
	public static void __VMFUNCTION__6E91B(object)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000205A File Offset: 0x0000025A
	public static void __VMFUNCTION__51828(object)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0000205B File Offset: 0x0000025B
	public static void __VMFUNCTION__45568(object)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000205C File Offset: 0x0000025C
	public static void __VMFUNCTION__6A893(object)
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000205D File Offset: 0x0000025D
	public static void __VMFUNCTION__8CB67(object)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000205E File Offset: 0x0000025E
	public static void __VMFUNCTION__58192(object)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000205F File Offset: 0x0000025F
	public static void __VMFUNCTION__1A362(object)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002060 File Offset: 0x00000260
	public static void __VMFUNCTION__7110D(object)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002061 File Offset: 0x00000261
	public static void __VMFUNCTION__1B15E(object)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002062 File Offset: 0x00000262
	public static void __VMFUNCTION__85057(object)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003614 File Offset: 0x00001814
	public static void __VMFUNCTION__1E73D()
	{
		new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Assembly.GetExecutingAssembly().Location + "\"").WindowStyle = ProcessWindowStyle.Hidden;
		ProcessStartInfo startInfo;
		Component component = Process.Start(startInfo);
		if (component != null)
		{
			component.Dispose();
		}
		Process.GetCurrentProcess().Kill();
	}
}
