using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using MosesApp.Core.ViewModels;
using MosesApp.Droid.Source;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Views;

namespace MosesApp.Droid.Views
{
    [Activity(NoHistory = true
        , Theme = "@style/Theme.PreLogin"
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            var loginButton = FindViewById<Button> (Resource.Id.button_login);
            var registerButton = FindViewById<Button>(Resource.Id.button_register);

            var bindingSet = this.CreateBindingSet<FirstView, FirstViewModel>();
            bindingSet.Bind(loginButton).For(loginButton.ClickEvent()).To(vm => vm.GoToLogin);
            bindingSet.Bind(registerButton).For(loginButton.ClickEvent()).To(vm => vm.GoToRegister);

        }
    }
}
