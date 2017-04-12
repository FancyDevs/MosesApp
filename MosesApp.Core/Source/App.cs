using MosesApp.Core.ViewModels.Chat;
using MvvmCross.Platform.IoC;

namespace MosesApp.Core
{
	public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ChatViewModel>();
        }
    }
}
