  
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using ArkhamHorrorDeckManager.ViewModels;
using UIKit;

namespace ArkhamHorrorDeckManager.iOS.Views
{

    public partial class DecksView : MvxViewController
    {
        public DecksView() : base("DecksView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}