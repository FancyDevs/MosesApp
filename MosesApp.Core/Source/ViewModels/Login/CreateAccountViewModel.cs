using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace MosesApp.Core.ViewModels.Login
{
	public class CreateAccountViewModel : MvxViewModel
	{
		public ICommand DoCreateHostAccount { get { return new MvxCommand(CreateHostAccount); } }
		public ICommand DoCreateAttendeeAccount { get { return new MvxCommand(CreateAttendeeAccount); } }

		void CreateHostAccount()
		{
		}

		void CreateAttendeeAccount()
		{
		}
	}
}
