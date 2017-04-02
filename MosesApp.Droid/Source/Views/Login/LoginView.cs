using Android.App;
using Android.Content.PM;
using MosesApp.Core.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace MosesApp.Droid.Source.Views.Login
{
	[Activity(Theme = "@style/Theme.PreLogin"
	   , ScreenOrientation = ScreenOrientation.Portrait)]
	public class LoginView : BaseActivity<LoginView, LoginViewModel>
	{
		protected override int LayoutResId => Resource.Layout.LoginView;

		protected override void SetupBindings(MvxFluentBindingDescriptionSet<LoginView, LoginViewModel> bindingSet)
		{
		}
	}
}