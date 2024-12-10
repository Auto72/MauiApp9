using MauiApp1.Model;
using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MauiPage1 : ContentPage
{
    private readonly ObservableCollection<ColorItem> _colors = [];

    public MauiPage1()
    {
        InitializeComponent();

        LoadColors();

        ColorListView.ItemsSource = _colors;
    }

    private void LoadColors()
    {
        _colors.Add(new ColorItem("Red", Colors.Red));
        _colors.Add(new ColorItem("Green", Colors.Green));
        _colors.Add(new ColorItem("Blue", Colors.Blue));
        _colors.Add(new ColorItem("Yellow", Colors.Yellow));
        _colors.Add(new ColorItem("Purple", Colors.Purple));
        _colors.Add(new ColorItem("Orange", Colors.Orange));
        _colors.Add(new ColorItem("Pink", Colors.Pink));
        _colors.Add(new ColorItem("Brown", Colors.Brown));
        _colors.Add(new ColorItem("Gray", Colors.Gray));
        _colors.Add(new ColorItem("Cyan", Colors.Cyan));
    }

    private void ButtonClear_Clicked(object sender, EventArgs e)
    {
        _colors.Clear();
    }

    private void ButtonLoad_Clicked(object sender, EventArgs e)
    {
        LoadColors();
    }
}
