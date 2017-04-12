using Android.App;
using Android.Content.PM;
using MosesApp.Core.ViewModels.Chat;
using MvvmCross.Binding.BindingContext;

namespace MosesApp.Droid.Views.Chat
{
	[Activity(Theme = "@style/Theme.PostLogin"
		, ScreenOrientation = ScreenOrientation.Portrait)]
	public class ChatView : BaseActivity<ChatView, ChatViewModel>
	{
		protected override int LayoutResId => Resource.Layout.ChatView;


		protected override void OnInitializeComponents()
		{
		}

		protected override void SetupBindings(MvxFluentBindingDescriptionSet<ChatView, ChatViewModel> bindingSet)
		{
		}
	}
}
