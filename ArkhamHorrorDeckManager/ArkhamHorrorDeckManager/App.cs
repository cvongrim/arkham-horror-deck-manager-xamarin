using ArkhamHorrorDeckManager.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace ArkhamHorrorDeckManager
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<DecksViewModel>());
        }
    }
}