namespace AppActions.Icons.MauiSample;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }

    public static void HandleAppActions(AppAction appAction)
    {
        App.Current.Dispatcher.Dispatch(async () =>
        {
            var action = appAction.Id switch
            {
                "home_sc" => "Home",
                "record_sc" => "Record",
                "pause_sc" => "Pause",
                "stop_sc" => "Stop",
                _ => "None"
            };

            await Shell.Current.GoToAsync($"../{nameof(MainPage)}?action={action}");
        });
    }
}
