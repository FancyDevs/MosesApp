using Android.App;
using Android.Content.PM;
using Android.Widget;
using MosesApp.Core.ViewModels.Login;
using MvvmCross.Binding.BindingContext;

namespace MosesApp.Droid.Source.Views.Login
{
	[Activity(Theme = "@style/Theme.PreLogin"
        , ScreenOrientation = ScreenOrientation.Portrait)]
	public class RegisterView : BaseActivity<RegisterView, RegisterViewModel>
    {
		protected override int LayoutResId => Resource.Layout.RegisterView;

		Button registerButton;

		protected override void OnInitializeComponents()
		{
			registerButton = FindViewById<Button>(Resource.Id.button_register);
		}

		protected override void SetupBindings(MvxFluentBindingDescriptionSet<RegisterView, RegisterViewModel> bindingSet)
		{
			bindingSet.Bind(registerButton).For(registerButton.ClickEvent()).To(vm => vm.DoRegisterProfile);
		}
	}
}