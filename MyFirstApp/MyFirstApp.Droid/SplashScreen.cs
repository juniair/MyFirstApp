using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace MyFirstApp.Droid
{
    [Activity(
        Label = "MyFirstApp.Droid"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , RoundIcon = "@mipmap/ic_launcher_round"
        , Theme = "@style/AppTheme.Splash"
        , NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
