using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace KeyAuth
{
	// Token: 0x02000009 RID: 9
	public class api
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00003E84 File Offset: 0x00002084
		public api(string name, string ownerid, string secret, string version)
		{
			uint num;
			if ((string.IsNullOrWhiteSpace(name) ? 1U : 0U) == (uint)0 && (string.IsNullOrWhiteSpace(ownerid) ? 1U : 0U) == (uint)0 && (string.IsNullOrWhiteSpace(secret) ? 1U : 0U) == (uint)0)
			{
				num = (string.IsNullOrWhiteSpace(version) ? 1U : 0U);
			}
			else
			{
				num = (uint)1;
			}
			if (num != (uint)0)
			{
				MessageBox.Show("Application not setup correctly. Please watch video link found in Login.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003F54 File Offset: 0x00002154
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			NameValueCollection nameValueCollection2 = nameValueCollection;
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			NameValueCollection nameValueCollection3 = nameValueCollection2;
			nameValueCollection2["ver"] = encryption.encrypt(this.version, this.secret, text);
			NameValueCollection nameValueCollection4 = nameValueCollection3;
			nameValueCollection3["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			NameValueCollection nameValueCollection5 = nameValueCollection4;
			nameValueCollection4["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			NameValueCollection nameValueCollection6 = nameValueCollection5;
			nameValueCollection5["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection6["init_iv"] = text;
			string text2 = (string)<Module>.__VMFUNCTION__517BA(nameValueCollection6);
			if (((text2 == "KeyAuth_Invalid") ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Developer error, servers down. (Alert:Extreme)");
				Environment.Exit(0);
			}
			string text3 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text3);
			if ((response_structure.success ? 1U : 0U) != (uint)0)
			{
				api.__VMFUNCTION__33499(this, response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else if (((response_structure.message == "invalidver") ? 1U : 0U) != (uint)0)
			{
				Process.Start(response_structure.download);
				MessageBox.Show("Version invalid, we have auto download latest version.", "SuperSpoofer - Auto Update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			else
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000413C File Offset: 0x0000233C
		public bool checkblack()
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				Environment.Exit(0);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = text;
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			NameValueCollection nameValueCollection3 = nameValueCollection2;
			nameValueCollection2["hwid"] = encryption.encrypt(value, this.enckey, text2);
			NameValueCollection nameValueCollection4 = nameValueCollection3;
			nameValueCollection3["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			NameValueCollection nameValueCollection5 = nameValueCollection4;
			nameValueCollection4["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			NameValueCollection nameValueCollection6 = nameValueCollection5;
			string text3 = text2;
			nameValueCollection5["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection6["init_iv"] = text3;
			return (this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection6), this.enckey, text3)).success ? 1U : 0U) != (uint)0;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000429C File Offset: 0x0000249C
		public bool register(string username, string pass, string key)
		{
			bool result;
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				NameValueCollection nameValueCollection2 = nameValueCollection;
				string text2 = text;
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
				NameValueCollection nameValueCollection3 = nameValueCollection2;
				string text3 = text2;
				nameValueCollection2["username"] = encryption.encrypt(username, this.enckey, text2);
				NameValueCollection nameValueCollection4 = nameValueCollection3;
				string text4 = text3;
				nameValueCollection3["pass"] = encryption.encrypt(pass, this.enckey, text3);
				NameValueCollection nameValueCollection5 = nameValueCollection4;
				string text5 = text4;
				nameValueCollection4["key"] = encryption.encrypt(key, this.enckey, text4);
				NameValueCollection nameValueCollection6 = nameValueCollection5;
				nameValueCollection5["hwid"] = encryption.encrypt(value, this.enckey, text5);
				NameValueCollection nameValueCollection7 = nameValueCollection6;
				nameValueCollection6["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				NameValueCollection nameValueCollection8 = nameValueCollection7;
				nameValueCollection7["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				NameValueCollection nameValueCollection9 = nameValueCollection8;
				string text6 = text5;
				nameValueCollection8["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection9["init_iv"] = text6;
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection9), this.enckey, text6));
				if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = false;
				}
				else
				{
					api.__VMFUNCTION__F800(this, response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004498 File Offset: 0x00002698
		public List<api.msg> chatget(string channelname)
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = text;
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			NameValueCollection nameValueCollection3 = nameValueCollection2;
			nameValueCollection2["channel"] = encryption.encrypt(channelname, this.enckey, text2);
			NameValueCollection nameValueCollection4 = nameValueCollection3;
			nameValueCollection3["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			NameValueCollection nameValueCollection5 = nameValueCollection4;
			nameValueCollection4["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			NameValueCollection nameValueCollection6 = nameValueCollection5;
			string text3 = text2;
			nameValueCollection5["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection6["init_iv"] = text3;
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection6), this.enckey, text3));
			List<api.msg> result;
			if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				result = null;
			}
			else
			{
				result = response_structure.messages;
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004618 File Offset: 0x00002818
		public bool chatsend(string msg, string channelname)
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = text;
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			NameValueCollection nameValueCollection3 = nameValueCollection2;
			string text3 = text2;
			nameValueCollection2["message"] = encryption.encrypt(msg, this.enckey, text2);
			NameValueCollection nameValueCollection4 = nameValueCollection3;
			nameValueCollection3["channel"] = encryption.encrypt(channelname, this.enckey, text3);
			NameValueCollection nameValueCollection5 = nameValueCollection4;
			nameValueCollection4["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			NameValueCollection nameValueCollection6 = nameValueCollection5;
			nameValueCollection5["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			NameValueCollection nameValueCollection7 = nameValueCollection6;
			string text4 = text3;
			nameValueCollection6["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection7["init_iv"] = text4;
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection7), this.enckey, text4));
			bool result;
			if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000047B0 File Offset: 0x000029B0
		public bool login(string username, string pass)
		{
			bool result;
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				NameValueCollection nameValueCollection2 = nameValueCollection;
				string text2 = text;
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
				NameValueCollection nameValueCollection3 = nameValueCollection2;
				string text3 = text2;
				nameValueCollection2["username"] = encryption.encrypt(username, this.enckey, text2);
				NameValueCollection nameValueCollection4 = nameValueCollection3;
				string text4 = text3;
				nameValueCollection3["pass"] = encryption.encrypt(pass, this.enckey, text3);
				NameValueCollection nameValueCollection5 = nameValueCollection4;
				nameValueCollection4["hwid"] = encryption.encrypt(value, this.enckey, text4);
				NameValueCollection nameValueCollection6 = nameValueCollection5;
				nameValueCollection5["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				NameValueCollection nameValueCollection7 = nameValueCollection6;
				nameValueCollection6["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				NameValueCollection nameValueCollection8 = nameValueCollection7;
				string text5 = text4;
				nameValueCollection7["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection8["init_iv"] = text5;
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection8), this.enckey, text5));
				if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = false;
				}
				else
				{
					api.__VMFUNCTION__F800(this, response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004988 File Offset: 0x00002B88
		public void upgrade(string username, string key)
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				NameValueCollection nameValueCollection2 = nameValueCollection;
				string text2 = text;
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
				NameValueCollection nameValueCollection3 = nameValueCollection2;
				string text3 = text2;
				nameValueCollection2["username"] = encryption.encrypt(username, this.enckey, text2);
				NameValueCollection nameValueCollection4 = nameValueCollection3;
				nameValueCollection3["key"] = encryption.encrypt(key, this.enckey, text3);
				NameValueCollection nameValueCollection5 = nameValueCollection4;
				nameValueCollection4["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				NameValueCollection nameValueCollection6 = nameValueCollection5;
				nameValueCollection5["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				NameValueCollection nameValueCollection7 = nameValueCollection6;
				string text4 = text3;
				nameValueCollection6["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection7["init_iv"] = text4;
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection7), this.enckey, text4));
				if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
				else
				{
					MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004B40 File Offset: 0x00002D40
		public bool license(string key)
		{
			bool result;
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				NameValueCollection nameValueCollection2 = nameValueCollection;
				string text2 = text;
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
				NameValueCollection nameValueCollection3 = nameValueCollection2;
				string text3 = text2;
				nameValueCollection2["key"] = encryption.encrypt(key, this.enckey, text2);
				NameValueCollection nameValueCollection4 = nameValueCollection3;
				nameValueCollection3["hwid"] = encryption.encrypt(value, this.enckey, text3);
				NameValueCollection nameValueCollection5 = nameValueCollection4;
				nameValueCollection4["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				NameValueCollection nameValueCollection6 = nameValueCollection5;
				nameValueCollection5["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				NameValueCollection nameValueCollection7 = nameValueCollection6;
				string text4 = text3;
				nameValueCollection6["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection7["init_iv"] = text4;
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection7), this.enckey, text4));
				if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
					result = false;
				}
				else
				{
					api.__VMFUNCTION__F800(this, response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004CFC File Offset: 0x00002EFC
		public void ban()
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				NameValueCollection nameValueCollection2 = nameValueCollection;
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
				NameValueCollection nameValueCollection3 = nameValueCollection2;
				nameValueCollection2["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				NameValueCollection nameValueCollection4 = nameValueCollection3;
				nameValueCollection3["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				NameValueCollection nameValueCollection5 = nameValueCollection4;
				string text2 = text;
				nameValueCollection4["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection5["init_iv"] = text2;
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection5), this.enckey, text2));
				if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004E48 File Offset: 0x00003048
		public string var(string varid)
		{
			string result;
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
				result = "";
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				NameValueCollection nameValueCollection2 = nameValueCollection;
				string text2 = text;
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
				NameValueCollection nameValueCollection3 = nameValueCollection2;
				nameValueCollection2["varid"] = encryption.encrypt(varid, this.enckey, text2);
				NameValueCollection nameValueCollection4 = nameValueCollection3;
				nameValueCollection3["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				NameValueCollection nameValueCollection5 = nameValueCollection4;
				nameValueCollection4["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				NameValueCollection nameValueCollection6 = nameValueCollection5;
				string text3 = text2;
				nameValueCollection5["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection6["init_iv"] = text3;
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection6), this.enckey, text3));
				if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = "";
				}
				else
				{
					result = response_structure.message;
				}
			}
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004FDC File Offset: 0x000031DC
		public string cwebhook(string webid, string param)
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("DEV ERR", "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = text;
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			NameValueCollection nameValueCollection3 = nameValueCollection2;
			string text3 = text2;
			nameValueCollection2["webid"] = encryption.encrypt(webid, this.enckey, text2);
			NameValueCollection nameValueCollection4 = nameValueCollection3;
			nameValueCollection3["params"] = encryption.encrypt(param, this.enckey, text3);
			NameValueCollection nameValueCollection5 = nameValueCollection4;
			nameValueCollection4["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			NameValueCollection nameValueCollection6 = nameValueCollection5;
			nameValueCollection5["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			NameValueCollection nameValueCollection7 = nameValueCollection6;
			string text4 = text3;
			nameValueCollection6["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection7["init_iv"] = text4;
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection7), this.enckey, text4));
			api.response_structure response_structure2 = JsonConvert.DeserializeObject<api.response_structure>(response_structure.response);
			string result;
			if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				result = "";
			}
			else
			{
				result = response_structure2.users;
			}
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000519C File Offset: 0x0000339C
		public string nwebhook(string webid, string param)
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("DEV ERR", "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = text;
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			NameValueCollection nameValueCollection3 = nameValueCollection2;
			string text3 = text2;
			nameValueCollection2["webid"] = encryption.encrypt(webid, this.enckey, text2);
			NameValueCollection nameValueCollection4 = nameValueCollection3;
			nameValueCollection3["params"] = encryption.encrypt(param, this.enckey, text3);
			NameValueCollection nameValueCollection5 = nameValueCollection4;
			nameValueCollection4["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			NameValueCollection nameValueCollection6 = nameValueCollection5;
			nameValueCollection5["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			NameValueCollection nameValueCollection7 = nameValueCollection6;
			string text4 = text3;
			nameValueCollection6["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection7["init_iv"] = text4;
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection7), this.enckey, text4));
			if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			return "";
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005344 File Offset: 0x00003544
		public string webhook(string webid, string param)
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("DEV ERR", "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = text;
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			NameValueCollection nameValueCollection3 = nameValueCollection2;
			string text3 = text2;
			nameValueCollection2["webid"] = encryption.encrypt(webid, this.enckey, text2);
			NameValueCollection nameValueCollection4 = nameValueCollection3;
			nameValueCollection3["params"] = encryption.encrypt(param, this.enckey, text3);
			NameValueCollection nameValueCollection5 = nameValueCollection4;
			nameValueCollection4["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			NameValueCollection nameValueCollection6 = nameValueCollection5;
			nameValueCollection5["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			NameValueCollection nameValueCollection7 = nameValueCollection6;
			string text4 = text3;
			nameValueCollection6["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection7["init_iv"] = text4;
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection7), this.enckey, text4));
			api.response_structure response_structure2 = JsonConvert.DeserializeObject<api.response_structure>(response_structure.response);
			string result;
			if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
				result = "";
			}
			else
			{
				result = response_structure2.used;
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005504 File Offset: 0x00003704
		public byte[] download(string fileid)
		{
			byte[] result;
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
				result = new byte[0];
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				NameValueCollection nameValueCollection2 = nameValueCollection;
				string text2 = text;
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
				NameValueCollection nameValueCollection3 = nameValueCollection2;
				nameValueCollection2["fileid"] = encryption.encrypt(fileid, this.enckey, text2);
				NameValueCollection nameValueCollection4 = nameValueCollection3;
				nameValueCollection3["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				NameValueCollection nameValueCollection5 = nameValueCollection4;
				nameValueCollection4["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				NameValueCollection nameValueCollection6 = nameValueCollection5;
				string text3 = text2;
				nameValueCollection5["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection6["init_iv"] = text3;
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(encryption.decrypt((string)<Module>.__VMFUNCTION__517BA(nameValueCollection6), this.enckey, text3));
				if ((((response_structure.success ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
				{
					MessageBox.Show(response_structure.message, "Super Cheats - Auth!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005688 File Offset: 0x00003888
		public void log(string message)
		{
			if ((((this.initzalized ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				NameValueCollection nameValueCollection2 = nameValueCollection;
				string text2 = text;
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
				NameValueCollection nameValueCollection3 = nameValueCollection2;
				string text3 = text2;
				nameValueCollection2["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text2);
				NameValueCollection nameValueCollection4 = nameValueCollection3;
				nameValueCollection3["message"] = encryption.encrypt(message, this.enckey, text3);
				NameValueCollection nameValueCollection5 = nameValueCollection4;
				nameValueCollection4["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				NameValueCollection nameValueCollection6 = nameValueCollection5;
				nameValueCollection5["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				NameValueCollection nameValueCollection7 = nameValueCollection6;
				nameValueCollection6["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection7["init_iv"] = text3;
				<Module>.__VMFUNCTION__517BA(nameValueCollection7);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000057C4 File Offset: 0x000039C4
		public static void __VMFUNCTION__33499(api A_0, api.app_data_structure A_1)
		{
			A_0.app_data.numUsers = A_1.numUsers;
			A_0.app_data.numOnlineUsers = A_1.numOnlineUsers;
			A_0.app_data.numKeys = A_1.numKeys;
			A_0.app_data.version = A_1.version;
			A_0.app_data.customerPanelLink = A_1.customerPanelLink;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00005830 File Offset: 0x00003A30
		public static void __VMFUNCTION__F800(api A_0, api.user_data_structure A_1)
		{
			A_0.user_data.username = A_1.username;
			A_0.user_data.ip = A_1.ip;
			A_0.user_data.subscriptions = A_1.subscriptions;
			A_0.user_data.createdate = A_1.createdate;
			A_0.user_data.lastlogin = A_1.lastlogin;
		}

		// Token: 0x04000014 RID: 20
		public string name;

		// Token: 0x04000015 RID: 21
		public string ownerid;

		// Token: 0x04000016 RID: 22
		public string secret;

		// Token: 0x04000017 RID: 23
		public string version;

		// Token: 0x04000018 RID: 24
		private string sessionid;

		// Token: 0x04000019 RID: 25
		private string enckey;

		// Token: 0x0400001A RID: 26
		private bool initzalized;

		// Token: 0x0400001B RID: 27
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400001C RID: 28
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400001D RID: 29
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x020000A3 RID: 163
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060002D8 RID: 728 RVA: 0x000231A8 File Offset: 0x000213A8
			// (set) Token: 0x060002D9 RID: 729 RVA: 0x000231C4 File Offset: 0x000213C4
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060002DA RID: 730 RVA: 0x000231E0 File Offset: 0x000213E0
			// (set) Token: 0x060002DB RID: 731 RVA: 0x000231FC File Offset: 0x000213FC
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060002DC RID: 732 RVA: 0x00023218 File Offset: 0x00021418
			// (set) Token: 0x060002DD RID: 733 RVA: 0x00023234 File Offset: 0x00021434
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060002DE RID: 734 RVA: 0x00023250 File Offset: 0x00021450
			// (set) Token: 0x060002DF RID: 735 RVA: 0x0002326C File Offset: 0x0002146C
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060002E0 RID: 736 RVA: 0x00023288 File Offset: 0x00021488
			// (set) Token: 0x060002E1 RID: 737 RVA: 0x000232A4 File Offset: 0x000214A4
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x000232C0 File Offset: 0x000214C0
			// (set) Token: 0x060002E3 RID: 739 RVA: 0x000232DC File Offset: 0x000214DC
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x000232F8 File Offset: 0x000214F8
			// (set) Token: 0x060002E5 RID: 741 RVA: 0x00023314 File Offset: 0x00021514
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x00023330 File Offset: 0x00021530
			// (set) Token: 0x060002E7 RID: 743 RVA: 0x0002334C File Offset: 0x0002154C
			public string key { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060002E8 RID: 744 RVA: 0x00023368 File Offset: 0x00021568
			// (set) Token: 0x060002E9 RID: 745 RVA: 0x00023384 File Offset: 0x00021584
			[DataMember]
			public string unused { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060002EA RID: 746 RVA: 0x000233A0 File Offset: 0x000215A0
			// (set) Token: 0x060002EB RID: 747 RVA: 0x000233BC File Offset: 0x000215BC
			[DataMember]
			public string used { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060002EC RID: 748 RVA: 0x000233D8 File Offset: 0x000215D8
			// (set) Token: 0x060002ED RID: 749 RVA: 0x000233F4 File Offset: 0x000215F4
			[DataMember]
			public string users { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060002EE RID: 750 RVA: 0x00023410 File Offset: 0x00021610
			// (set) Token: 0x060002EF RID: 751 RVA: 0x0002342C File Offset: 0x0002162C
			[DataMember]
			public string vars { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060002F0 RID: 752 RVA: 0x00023448 File Offset: 0x00021648
			// (set) Token: 0x060002F1 RID: 753 RVA: 0x00023464 File Offset: 0x00021664
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x00023480 File Offset: 0x00021680
			// (set) Token: 0x060002F3 RID: 755 RVA: 0x0002349C File Offset: 0x0002169C
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x020000A4 RID: 164
		public class msg
		{
			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060002F5 RID: 757 RVA: 0x000234D4 File Offset: 0x000216D4
			// (set) Token: 0x060002F6 RID: 758 RVA: 0x000234F0 File Offset: 0x000216F0
			public string message { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060002F7 RID: 759 RVA: 0x0002350C File Offset: 0x0002170C
			// (set) Token: 0x060002F8 RID: 760 RVA: 0x00023528 File Offset: 0x00021728
			public string author { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060002F9 RID: 761 RVA: 0x00023544 File Offset: 0x00021744
			// (set) Token: 0x060002FA RID: 762 RVA: 0x00023560 File Offset: 0x00021760
			public string timestamp { get; set; }
		}

		// Token: 0x020000A5 RID: 165
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060002FC RID: 764 RVA: 0x00023598 File Offset: 0x00021798
			// (set) Token: 0x060002FD RID: 765 RVA: 0x000235B4 File Offset: 0x000217B4
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060002FE RID: 766 RVA: 0x000235D0 File Offset: 0x000217D0
			// (set) Token: 0x060002FF RID: 767 RVA: 0x000235EC File Offset: 0x000217EC
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000300 RID: 768 RVA: 0x00023608 File Offset: 0x00021808
			// (set) Token: 0x06000301 RID: 769 RVA: 0x00023624 File Offset: 0x00021824
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000302 RID: 770 RVA: 0x00023640 File Offset: 0x00021840
			// (set) Token: 0x06000303 RID: 771 RVA: 0x0002365C File Offset: 0x0002185C
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000304 RID: 772 RVA: 0x00023678 File Offset: 0x00021878
			// (set) Token: 0x06000305 RID: 773 RVA: 0x00023694 File Offset: 0x00021894
			[DataMember]
			public string customerPanelLink { get; set; }
		}

		// Token: 0x020000A6 RID: 166
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000307 RID: 775 RVA: 0x000236CC File Offset: 0x000218CC
			// (set) Token: 0x06000308 RID: 776 RVA: 0x000236E8 File Offset: 0x000218E8
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000309 RID: 777 RVA: 0x00023704 File Offset: 0x00021904
			// (set) Token: 0x0600030A RID: 778 RVA: 0x00023720 File Offset: 0x00021920
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600030B RID: 779 RVA: 0x0002373C File Offset: 0x0002193C
			// (set) Token: 0x0600030C RID: 780 RVA: 0x00023758 File Offset: 0x00021958
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600030D RID: 781 RVA: 0x00023774 File Offset: 0x00021974
			// (set) Token: 0x0600030E RID: 782 RVA: 0x00023790 File Offset: 0x00021990
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600030F RID: 783 RVA: 0x000237AC File Offset: 0x000219AC
			// (set) Token: 0x06000310 RID: 784 RVA: 0x000237C8 File Offset: 0x000219C8
			[DataMember]
			public string ip { get; set; }
		}

		// Token: 0x020000A7 RID: 167
		public class app_data_class
		{
			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000312 RID: 786 RVA: 0x00023800 File Offset: 0x00021A00
			// (set) Token: 0x06000313 RID: 787 RVA: 0x0002381C File Offset: 0x00021A1C
			public string numUsers { get; set; }

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000314 RID: 788 RVA: 0x00023838 File Offset: 0x00021A38
			// (set) Token: 0x06000315 RID: 789 RVA: 0x00023854 File Offset: 0x00021A54
			public string numOnlineUsers { get; set; }

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000316 RID: 790 RVA: 0x00023870 File Offset: 0x00021A70
			// (set) Token: 0x06000317 RID: 791 RVA: 0x0002388C File Offset: 0x00021A8C
			public string numKeys { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000318 RID: 792 RVA: 0x000238A8 File Offset: 0x00021AA8
			// (set) Token: 0x06000319 RID: 793 RVA: 0x000238C4 File Offset: 0x00021AC4
			public string version { get; set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600031A RID: 794 RVA: 0x000238E0 File Offset: 0x00021AE0
			// (set) Token: 0x0600031B RID: 795 RVA: 0x000238FC File Offset: 0x00021AFC
			public string customerPanelLink { get; set; }
		}

		// Token: 0x020000A8 RID: 168
		public class user_data_class
		{
			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600031D RID: 797 RVA: 0x00023934 File Offset: 0x00021B34
			// (set) Token: 0x0600031E RID: 798 RVA: 0x00023950 File Offset: 0x00021B50
			public string username { get; set; }

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x0600031F RID: 799 RVA: 0x0002396C File Offset: 0x00021B6C
			// (set) Token: 0x06000320 RID: 800 RVA: 0x00023988 File Offset: 0x00021B88
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000321 RID: 801 RVA: 0x000239A4 File Offset: 0x00021BA4
			// (set) Token: 0x06000322 RID: 802 RVA: 0x000239C0 File Offset: 0x00021BC0
			public string createdate { get; set; }

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000323 RID: 803 RVA: 0x000239DC File Offset: 0x00021BDC
			// (set) Token: 0x06000324 RID: 804 RVA: 0x000239F8 File Offset: 0x00021BF8
			public string lastlogin { get; set; }

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000325 RID: 805 RVA: 0x00023A14 File Offset: 0x00021C14
			// (set) Token: 0x06000326 RID: 806 RVA: 0x00023A30 File Offset: 0x00021C30
			public string ip { get; set; }
		}

		// Token: 0x020000A9 RID: 169
		public class Data
		{
			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000328 RID: 808 RVA: 0x00023A68 File Offset: 0x00021C68
			// (set) Token: 0x06000329 RID: 809 RVA: 0x00023A84 File Offset: 0x00021C84
			public string subscription { get; set; }

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600032A RID: 810 RVA: 0x00023AA0 File Offset: 0x00021CA0
			// (set) Token: 0x0600032B RID: 811 RVA: 0x00023ABC File Offset: 0x00021CBC
			public string expiry { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600032C RID: 812 RVA: 0x00023AD8 File Offset: 0x00021CD8
			// (set) Token: 0x0600032D RID: 813 RVA: 0x00023AF4 File Offset: 0x00021CF4
			public string createdate { get; set; }

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600032E RID: 814 RVA: 0x00023B10 File Offset: 0x00021D10
			// (set) Token: 0x0600032F RID: 815 RVA: 0x00023B2C File Offset: 0x00021D2C
			public string lastlogin { get; set; }
		}
	}
}
