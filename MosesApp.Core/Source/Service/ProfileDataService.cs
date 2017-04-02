using System;
using System.Collections;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace MosesApp.Core.Service
{
	public class ProfileDataService
	{
		AzureDataService azureService;

		public ProfileDataService(AzureDataService azureService)
		{
			this.azureService = azureService;
		}

		public async Task<IEnumerable> GetProfile(string id)
		{
			await SyncProfile();
			return await azureService.ProfileTable.Select(x => x.Id == id).ToEnumerableAsync();
		}

		public async Task AddProfile(string firstName, string lastName)
		{
			try
			{
				var profile = new Profile
				{
					first_name = firstName,
					last_name = lastName
				};

				await azureService.ProfileTable.InsertAsync(profile);
			}
			catch (Exception)
			{ 
				
			}
			finally
			{
				await SyncProfile();
			}

		}

		public async Task SyncProfile()
		{
			//pull down all latest changes and then push current coffees up
			await azureService.ProfileTable.PullAsync("allProfiles", azureService.ProfileTable.CreateQuery());
			await azureService.MobileService.SyncContext.PushAsync();
		}
	}
}
