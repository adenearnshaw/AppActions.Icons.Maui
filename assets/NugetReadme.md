# AppActions.Icons.Maui

A .NET MAUI library that provides some default icons for AppActions without having to create your own.

## Features

Based on iOS' [Home Screen Quick Action Icons](https://developer.apple.com/design/human-interface-guidelines/ios/icons-and-images/system-icons#home-screen-quick-action-icons), this library provides similar icons for both Android & Windows, but styled towards the platforms default design style. Also supports the use of [SFSymbols](https://developer.apple.com/sf-symbols/) as Icons on iOS.

- Out-of-the-box icons available for Android, iOS & Windows
- Use SF Symbols on iOS
- Customise Android icons with brand colors
- Builds on top of the [Maui Essentials](https://docs.microsoft.com/en-us/dotnet/maui/platform-integration/appmodel/app-actions?tabs=android) api
- Specify different image names per platform


## Getting Started

1. Add the [AppActions.Icons.Maui](https://www.nuget.org/packages/AppActions.Icons.Maui/) nuget package to your MAUI project.
1. Setup you app actions as per the [Maui Documentation](https://docs.microsoft.com/en-us/dotnet/maui/platform-integration/appmodel/app-actions?tabs=android)
1. In your `MauiProgram.CreateMauiApp()`, add **`UseAppActionIcons()`** to your Essentials configuration builder.

    ```csharp
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureEssentials(essentials =>
            {
                essentials
                    .UseAppActionIcons() // Add this line
                    .AddAppAction("home_sc", "Home", icon: AppActionIcon.Home)
                    .OnAppAction(App.HandleAppActions);
            });

        return builder.Build();
    }
    ```

1. Now set the AppAction's icon property using one of the provided `AppActionIcon` options

___

For more examples of how to use and some troubleshooting tips, check the [Github Repository](https://github.com/adenearnshaw/AppActions.Icons.Maui)