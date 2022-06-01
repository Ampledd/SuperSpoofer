using System;
using System.Collections.Specialized;
using System.Net;

namespace SuperSpoofer
{
	// Token: 0x02000011 RID: 17
	internal class Http
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		public static byte[] Post(string uri, NameValueCollection pairs)
		{
			byte[] result;
			using (WebClient webClient = new WebClient())
			{
				result = webClient.UploadValues(uri, pairs);
			}
			return result;
		}
	}
}
