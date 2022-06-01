using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000A RID: 10
	public static class encryption
	{
		// Token: 0x06000060 RID: 96 RVA: 0x0000589C File Offset: 0x00003A9C
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * (int)((uint)2));
			uint num = (uint)0;
			while (((num < (uint)ba.Length) ? 1U : 0U) != (uint)0)
			{
				stringBuilder.AppendFormat("{0:x2}", (byte)Convert.ToUInt32(ba[(int)num]));
				num += (uint)1;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000590C File Offset: 0x00003B0C
		public static byte[] str_to_byte_arr(string hex)
		{
			uint num = (uint)hex.Length;
			byte[] array = new byte[(int)(num / (uint)2)];
			uint num2 = (uint)0;
			while (((num2 < num) ? 1U : 0U) != (uint)0)
			{
				array[(int)(num2 / (uint)2)] = (byte)((sbyte)Convert.ToByte(hex.Substring((int)num2, 2), 16));
				num2 += (uint)2;
			}
			return array;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005974 File Offset: 0x00003B74
		public static string encrypt_string(string plain_text, byte[] key, byte[] iv)
		{
			SymmetricAlgorithm symmetricAlgorithm = Aes.Create();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			string result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (object obj = (object)symmetricAlgorithm.CreateEncryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)obj, CryptoStreamMode.Write))
					{
						byte[] bytes = Encoding.Default.GetBytes(plain_text);
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.FlushFinalBlock();
						result = encryption.byte_arr_to_str(memoryStream.ToArray());
					}
				}
			}
			return result;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005A8C File Offset: 0x00003C8C
		public static string decrypt_string(string cipher_text, byte[] key, byte[] iv)
		{
			SymmetricAlgorithm symmetricAlgorithm = Aes.Create();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (object obj = (object)symmetricAlgorithm.CreateDecryptor())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)obj, CryptoStreamMode.Write))
					{
						byte[] array = encryption.str_to_byte_arr(cipher_text);
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.FlushFinalBlock();
						byte[] array2 = memoryStream.ToArray();
						@string = Encoding.Default.GetString(array2, 0, array2.Length);
					}
				}
			}
			return @string;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005BAC File Offset: 0x00003DAC
		public static string iv_key()
		{
			Guid guid = default(Guid);
			string text = Guid.NewGuid().ToString();
			return text.Substring(0, Guid.NewGuid().ToString().IndexOf("-", StringComparison.Ordinal));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005C0C File Offset: 0x00003E0C
		public static string sha256(string r)
		{
			return encryption.byte_arr_to_str(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(r)));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005C3C File Offset: 0x00003E3C
		public static string encrypt(string message, string enc_key, string iv)
		{
			return encryption.encrypt_string(message, Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(0, 32)), Encoding.Default.GetBytes(encryption.sha256(iv).Substring(0, 16)));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005C8C File Offset: 0x00003E8C
		public static string decrypt(string message, string enc_key, string iv)
		{
			return encryption.decrypt_string(message, Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(0, 32)), Encoding.Default.GetBytes(encryption.sha256(iv).Substring(0, 16)));
		}
	}
}
