namespace MauiApp1;

public partial class App : Application
{
    private static Page? _mauiPage1 = null;

    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }

    public static Page GetPage1() 
    {
        _mauiPage1 ??= new MauiPage1();
        return _mauiPage1;
    }
}
