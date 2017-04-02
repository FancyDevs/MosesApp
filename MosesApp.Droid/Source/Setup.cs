using Android.Content;
using Microsoft.WindowsAzure.MobileServices;
using MosesApp.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Platform.Platform;

namespace MosesApp.Droid
{
	public class Setup : MvxAndroidSetup
    {
		public static bool SetupComplete { get; set; }

		GlobalValues globalValues;

        public Setup(Context applicationContext) : base(applicationContext)
        {
			CurrentPlatform.Init();

			//Set up all the global values we want
			globalValues = GlobalValues.Instance;

			SetupComplete = true;
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
