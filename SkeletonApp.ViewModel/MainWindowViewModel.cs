using ReactiveUI;

namespace SkeletonApp.ViewModel
{
    public class MainWindowViewModel : ViewModelBase, IScreen
    {
        public RoutingState Router { get; } = new();
    }
}