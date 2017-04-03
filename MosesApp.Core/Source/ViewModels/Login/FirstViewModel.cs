using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace MosesApp.Core.ViewModels.Login
{
    public class FirstViewModel : MvxViewModel
    {
        public ICommand DoGoToLogin { get { return new MvxCommand(GoToLogin); } }
        public ICommand DoGoToRegister { get { return new MvxCommand(GoToRegister); } }

        void GoToLogin()
		{
			ShowViewModel<LoginViewModel>();
		}

        void GoToRegister()
        {
            ShowViewModel<RegisterViewModel>();
        }
    }
}
