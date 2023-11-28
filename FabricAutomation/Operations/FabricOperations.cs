using Microsoft.MCI.Common.Model.FabricAPI;
using Microsoft.MCI.Common.Interface.FabricAPI;

namespace Microsoft.MCI.Common.Fabric.Operations
{
    public class FabricOperations : IFabricOperations
    {
        public CreateResponse Create(CreateRequest request)
        {
            CreateResponse createResponse = null;

            ValidationError validationError = ValidateRequest(request);
            if (validationError != null) 
            {
                createResponse = new CreateResponse { validationError = validationError };
                return createResponse;
            }
            

            //TODO: Write the provisioning code

            return createResponse;
        }

        public CreateResponse ValidateCreate(CreateRequest request)
        {
            throw new NotImplementedException();
        }


        private ValidationError ValidateRequest(CreateRequest request)
        {
            ValidationError validationError = null;

            return validationError;
        }



    }
}

