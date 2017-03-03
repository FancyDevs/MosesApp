
using Android.App;
using Android.OS;
using Android.Content.PM;
using MvvmCross.Droid.Views;
using MvvmCross.Binding.BindingContext;
using MosesApp.Core.ViewModels;

namespace MosesApp.Droid.Source.Views
{
	[Activity(Theme = "@style/Theme.PreLogin"
	   , ScreenOrientation = ScreenOrientation.Portrait)]
	public class LoginView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.LoginView);

			var bindingSet = this.CreateBindingSet<LoginView, LoginViewModel>();

		}
	}
}