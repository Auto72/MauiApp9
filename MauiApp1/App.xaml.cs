namespace MauiApp1;

public partial class App : Application
{
    private static Page? _mauiPage1 = null;
    private static Page? _mainPage = null;

    public App()
    {
        InitializeComponent();

        //MainPage = new NavigationPage(new MainPage());
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        _mainPage = new NavigationPage(new MainPage());
        return new Window(_mainPage);
    }

    public static Page GetPage1() 
    {
        _mauiPage1 ??= new MauiPage1();
        return _mauiPage1;
    }
}
