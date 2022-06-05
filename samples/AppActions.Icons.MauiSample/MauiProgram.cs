using AppActions.Icons.Maui;

namespace AppActions.Icons.MauiSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureEssentials(essentials =>
            {
				essentials
					.UseAppActionIcons()
					.AddAppAction("home_sc", "Home", icon: AppActionIcon.Home)
					.AddAppAction("record_sc", "Record", icon: new SystemSymbol("mic.circle.fill"))
					.AddAppAction("pause_sc", "Pause", icon: new SystemSymbol(new PlatformString(AppActionIcon.Pause, ios: "pause.circle.fill")))
					.AddAppAction("stop_sc", "Stop", icon: new PlatformString("quicklaunch_stop", android: "ic_app_action_stop", ios: "quickaction_stop"))
					.OnAppAction(App.HandleAppActions);
            });

		return builder.Build();
	}
}
