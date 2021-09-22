using SkeletonApp.View;
using SkeletonApp.ViewModel;
using System;
using System.Windows;

namespace SkeletonApp
{
    internal class Bootstrapper : IDisposable
    {
        public Bootstrapper(Application current)
        {
            Register();

            current.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel()
            };

            current.MainWindow.Show();
        }

        public void Dispose()
        {
        }

        private void Register()
        {
        }
    }
}