using Maui.AppActions.Icons;

namespace AppShortcuts.Maui.Icons;

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
            var page = appAction.Id switch
            {
                "home_sc" => new MainPage(),
                _ => default(Page)
            };

            if (page != null)
            {
                await Shell.Current.Navigation.PopToRootAsync();
                await Shell.Current.Navigation.PushAsync(page);
            }
        });
    }
}
