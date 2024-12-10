using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.Model;

public partial class ColorItem(string initName, Color initColor) : ObservableObject
{
    [ObservableProperty]
    private string name = initName;

    [ObservableProperty]
    private Color color = initColor;
}
