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
	public class CreateAccountView : BaseActivity<CreateAccountView, CreateAccountViewModel>
	{
		protected override int LayoutResId => Resource.Layout.CreateAccountView;

		Button hostButton;
		Button attendeeButton;

		protected override void OnInitializeComponents()
		{
			hostButton = FindViewById<Button>(Resource.Id.button_host);
			attendeeButton = FindViewById<Button>(Resource.Id.button_attendee);
		}

		protected override void SetupBindings(MvxFluentBindingDescriptionSet<CreateAccountView, CreateAccountViewModel> bindingSet)
		{
			bindingSet.Bind(hostButton).For(hostButton.ClickEvent()).To(vm => vm.DoCreateHostAccount);
			bindingSet.Bind(attendeeButton).For(attendeeButton.ClickEvent()).To(vm => vm.DoCreateAttendeeAccount);
		}
	}
}
