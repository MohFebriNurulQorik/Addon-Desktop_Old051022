using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.ULT_18_200_001.Model
{
	[DataContract]
	public class ApproveExpenseClaim : EntityAction<ExpenseClaim>
	{
		public ApproveExpenseClaim(ExpenseClaim entity) : base(entity)
		{ }
		public ApproveExpenseClaim() : base()
		{ }
	}
}
