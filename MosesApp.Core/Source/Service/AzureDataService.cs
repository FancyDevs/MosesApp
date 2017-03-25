using System;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

namespace MosesApp.Core
{
	public class AzureDataService
	{
		public MobileServiceClient MobileService { get; set; }
		IMobileServiceSyncTable<Profile> ProfileTable;

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

		public async Task<IEnumerable> GetProfile(string id)
		{
			await SyncProfile();
			return await ProfileTable.Select(x => x.Id == id).ToEnumerableAsync();
		}

		public async Task AddProfile()
		{
			var profile = new Profile
			{
				first_name = "Billy",
				last_name = "Billy"
			};

			try
			{
				await ProfileTable.InsertAsync(profile);
			}catch (Exception e)
			{
				int a = 0;
			}

			await SyncProfile();
		}

		public async Task SyncProfile()
		{
   			//pull down all latest changes and then push current coffees up
    		await ProfileTable.PullAsync("allProfiles", ProfileTable.CreateQuery());
			await MobileService.SyncContext.PushAsync();
		}
	}
}
