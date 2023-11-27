using System;

namespace Microsoft.MCI.Common.Model.FabricAPI
{
	public class CreateRequest: FabricRequestBase
    {
        public override bool isValid(FabricRequestBase request)
        {
            return base.isValid(request);
        }
    }
    public class CreateResponse: FabricErrorResposeBase
    {
        public FabricResource fabricResource { get; set;}
    }
}