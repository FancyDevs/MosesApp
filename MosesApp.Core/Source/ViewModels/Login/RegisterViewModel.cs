using System.Windows.Input;
using MosesApp.Core.Service;
using MvvmCross.Core.ViewModels;

namespace MosesApp.Core.ViewModels.Login
{
    public class RegisterViewModel : MvxViewModel
    {
		public ICommand DoRegisterProfile { get { return new MvxCommand(RegisterProfile); } }

		ProfileDataService profileService;

		public RegisterViewModel()
		{
			GlobalValues globalValues = GlobalValues.Instance;
			profileService = new ProfileDataService(globalValues.GetAzureDataService());
		}

		void RegisterProfile()
		{
			ShowViewModel<CreateAccountViewModel>();
		}
    }
}
