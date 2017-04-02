using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace MosesApp.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public ICommand GoToLogin { get { return new MvxCommand(DoGoToLogin); } }
        public ICommand GoToRegister { get { return new MvxCommand(DoGoToRegister); } }

        void DoGoToLogin()
		{
			ShowViewModel<LoginViewModel>();
		}

        void DoGoToRegister()
        {
            ShowViewModel<RegisterViewModel>();
        }
    }
}
