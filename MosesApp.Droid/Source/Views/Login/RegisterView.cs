using Android.App;
using Android.Content.PM;
using MosesApp.Core;
using MosesApp.Core.Service;
using MosesApp.Core.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace MosesApp.Droid.Source.Views.Login
{
	[Activity(Theme = "@style/Theme.PreLogin"
        , ScreenOrientation = ScreenOrientation.Portrait)]
	public class RegisterView : BaseActivity<RegisterView, RegisterViewModel>
    {
		protected override int LayoutResId => Resource.Layout.RegisterView;

		protected override void SetupBindings(MvxFluentBindingDescriptionSet<RegisterView, RegisterViewModel> bindingSet)
		{
			GlobalValues globalValues = GlobalValues.Instance;
			ProfileDataService profileService = new ProfileDataService(globalValues.GetAzureDataService());
			profileService.AddProfile("Joshua", "Davis");
		}
	}
}