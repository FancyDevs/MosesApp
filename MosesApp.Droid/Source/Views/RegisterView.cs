
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using Android.Content.PM;
using MvvmCross.Binding.BindingContext;
using MosesApp.Core.ViewModels;

namespace MosesApp.Droid.Source.Views
{
    [Activity(Theme = "@style/Theme.PreLogin"
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class RegisterView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.RegisterView);

            var bindingSet = this.CreateBindingSet<RegisterView, RegisterViewModel>();

        }
    }
}