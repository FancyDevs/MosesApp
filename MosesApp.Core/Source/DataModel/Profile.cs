using System;
namespace MosesApp.Core
{
	public class Profile
	{
		[Newtonsoft.Json.JsonProperty("Id")]
		public string Id { get; set; }

		[Microsoft.WindowsAzure.MobileServices.Version]
		public string AzureVersion { get; set; }

		public DateTime createdAt { get; set; }

		public DateTime updatedAt { get; set; }

		public bool deleted { get; set; }

		public string username { get; set; }

		public string password { get; set; }

		public string first_name { get; set; }

		public string last_name { get; set; }

		public string email { get; set; }

		public string information { get; set; }

		public string verses { get; set; }

		public DateTime date_of_birth { get; set; }

		public string image { get; set; }
	}
}
