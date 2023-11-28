using System;

namespace Microsoft.MCI.Common.Model.FabricAPI
{
	public class FabricRequestBase
	{
		public string Token { get; set; }

		public string FabricBaseURI { get; set; }

		



		public virtual bool isValid(FabricRequestBase request)
		{
			bool isValid = false;
			return isValid;
		}


	}

}
