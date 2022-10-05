using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.ULT_18_200_001.Model
{
	[DataContract]
	public class SendEmail : EntityAction<Email>
	{
		public SendEmail(Email entity) : base(entity)
		{ }
		public SendEmail() : base()
		{ }
	}
}
