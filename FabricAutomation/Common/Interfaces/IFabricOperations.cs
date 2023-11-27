using Microsoft.MCI.Common.Model.FabricAPI;
namespace Microsoft.MCI.Common.Interface.FabricAPI
{
	public interface IFabricOperations
	{
		public CreateResponse ValidateCreate(CreateRequest request);
		public CreateResponse Create(CreateRequest request);


	} 
}
