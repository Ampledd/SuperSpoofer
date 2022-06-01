using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000B RID: 11
	public class json_wrapper
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00005CDC File Offset: 0x00003EDC
		public static bool is_serializable(Type to_check)
		{
			return (to_check.IsSerializable ? 1U : 0U) != (uint)0 || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005D20 File Offset: 0x00003F20
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if ((((json_wrapper.is_serializable(type) ? 1U : 0U) == (uint)0) ? 1U : 0U) != (uint)0)
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005D8C File Offset: 0x00003F8C
		public object string_to_object(string json)
		{
			object result;
			using (Stream stream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.serializer.ReadObject(stream);
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000221D File Offset: 0x0000041D
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400001E RID: 30
		private DataContractJsonSerializer serializer;

		// Token: 0x0400001F RID: 31
		private object current_object;
	}
}
