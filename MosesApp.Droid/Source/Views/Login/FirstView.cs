using Android.App;
using Android.Content.PM;
using Android.Widget;
using MosesApp.Core.ViewModels.Login;
using MosesApp.Droid.Source;
using MvvmCross.Binding.BindingContext;

namespace MosesApp.Droid.Views.Login
{
	[Activity(Theme = "@style/Theme.PreLogin"
        , ScreenOrientation = ScreenOrientation.Portrait)]
	public class FirstView : BaseActivity<FirstView, FirstViewModel>
    {
		protected override int LayoutResId => Resource.Layout.FirstView;

		Button loginButton;
		Button registerButton;

		protected override void OnInitializeComponents()
		{
			loginButton = FindViewById<Button>(Resource.Id.button_login);
			registerButton = FindViewById<Button>(Resource.Id.button_register);
		}

		protected override void SetupBindings(MvxFluentBindingDescriptionSet<FirstView, FirstViewModel> bindingSet)
		{
			bindingSet.Bind(loginButton).For(loginButton.ClickEvent()).To(vm => vm.DoGoToLogin);
			bindingSet.Bind(registerButton).For(loginButton.ClickEvent()).To(vm => vm.DoGoToRegister);
		}
	}
}
