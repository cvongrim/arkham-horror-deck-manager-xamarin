using Android.App;
using MvvmCross.Droid.Views;

namespace ArkhamHorrorDeckManager.Android.Views
{
    [Activity(Label = "Decks", MainLauncher = true)]
    public class DecksView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Main);
        }
    }
}