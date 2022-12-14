namespace MauiApp3;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new MainViewModel
        {
            Title = "MyTitle"
        };
    }
}

