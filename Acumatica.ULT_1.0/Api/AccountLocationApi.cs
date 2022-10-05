using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.ULT_18_200_001.Model;

namespace Acumatica.ULT_18_200_001.Api
{
	public class AccountLocationApi : EntityAPI<AccountLocation>
	{
		public AccountLocationApi(Configuration configuration) : base(configuration)
		{ }
	}
}