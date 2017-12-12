using MyFirstApp.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;

namespace MyFirstApp.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    public class HomeFragment : BaseFragment<HomeViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_home;
    }
}