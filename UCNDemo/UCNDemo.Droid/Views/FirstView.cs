using Android.App;
using Android.OS;
using MvvmCross.Binding.Droid.Views;
using MvvmCross.Droid.Views;
using UCNDemo.Services;

namespace UCNDemo.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            //var list = new MvxListView(null,null);
        }
    }
}
