﻿using AppActions.Icons.Maui;

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
					.AddAppAction("cloud_sc", "Online", icon: AppActionIcon.Cloud)
					.AddAppAction("trash_sc", "Trash", icon: new SystemSymbol(new PlatformString(AppActionIcon.Prohibit, ios: "trash.slash.square")))
					.OnAppAction(App.HandleAppActions);
            });

		return builder.Build();
	}
}
