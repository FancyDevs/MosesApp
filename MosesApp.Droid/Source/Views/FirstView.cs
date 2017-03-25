using System.Threading.Tasks;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using MosesApp.Core;
using MosesApp.Core.ViewModels;
using MosesApp.Droid.Source;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Views;

namespace MosesApp.Droid.Views
{
    [Activity(Theme = "@style/Theme.PreLogin"
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class FirstView : MvxActivity
    {
		protected override void OnCreate(Bundle bundle)
		{
			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
			CreateAzure();

			base.OnCreate(bundle);
			SetContentView(Resource.Layout.FirstView);

			var loginButton = FindViewById<Button>(Resource.Id.button_login);
			var registerButton = FindViewById<Button>(Resource.Id.button_register);

			var bindingSet = this.CreateBindingSet<FirstView, FirstViewModel>();
			bindingSet.Bind(loginButton).For(loginButton.ClickEvent()).To(vm => vm.GoToLogin);
			bindingSet.Bind(registerButton).For(loginButton.ClickEvent()).To(vm => vm.GoToRegister);
			bindingSet.Apply();
		}

		public async Task CreateAzure()
		{
			AzureDataService azureService = new AzureDataService();
			await azureService.Initialize();
			await azureService.AddProfile();
		}
	}
}
