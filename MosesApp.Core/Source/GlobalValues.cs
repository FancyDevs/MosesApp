using MosesApp.Core.Service;

namespace MosesApp.Core
{
	public class GlobalValues
	{
		static readonly GlobalValues _instance = new GlobalValues();
		public static GlobalValues Instance
		{
			get
			{
				return _instance;
			}
		}

		AzureDataService azureService;

		//Initialize our global variables
		GlobalValues()
		{
			azureService = new AzureDataService();
			azureService.Initialize();
		}

		//return the azure service
		public AzureDataService GetAzureDataService()
		{
			return azureService;
		}
	}
}
