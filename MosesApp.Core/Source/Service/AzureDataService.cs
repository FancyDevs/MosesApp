using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace MosesApp.Core.Service
{
	public class AzureDataService
	{
		public MobileServiceClient MobileService { get; set; }
		public IMobileServiceSyncTable<Profile> ProfileTable;

		public async Task Initialize()
		{
			//Create our client
			MobileService = new MobileServiceClient("http://mosesapp.azurewebsites.net/");

			const string path = "syncstore.db";

			//setup our local sqlite store and intialize our table
			var store = new MobileServiceSQLiteStore(path);
			store.DefineTable<Profile>();
			await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());

			//Get our sync table that will call out to azure
			ProfileTable = MobileService.GetSyncTable<Profile>();
		}
	}
}
