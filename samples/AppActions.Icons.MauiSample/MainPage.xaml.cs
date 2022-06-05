namespace AppActions.Icons.MauiSample;

[QueryProperty(nameof(LaunchAction), "action")]
public partial class MainPage : ContentPage
{
    private string _launchAction = "None";
    public string LaunchAction
    {
        get => _launchAction;
        set
        { 
            _launchAction = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }
}

