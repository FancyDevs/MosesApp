using Android.App;
using Android.Content.PM;
using MosesApp.Core;
using MvvmCross.Droid.Views;

namespace MosesApp.Droid
{
    [Activity(
        Label = "MosesApp.Droid"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
		public SplashScreen() : base(Resource.Layout.SplashScreen)
		{
		}
    }
}
