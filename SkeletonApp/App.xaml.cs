﻿using System.Windows;

namespace SkeletonApp;

public partial class App : Application
{
    private Bootstrapper _Bootstrapper;

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        _Bootstrapper = new Bootstrapper(Current);
    }

    protected override void OnExit(ExitEventArgs e)
    {
        _Bootstrapper.Dispose();

        base.OnExit(e);
    }
}