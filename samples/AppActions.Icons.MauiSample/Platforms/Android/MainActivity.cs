using Android.App;
using Android.Content.PM;
using Android.Content;

namespace AppActions.Icons.MauiSample;

[Activity(Theme = "@style/Maui.SplashTheme", 
          MainLauncher = true, 
          ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[IntentFilter(new[] { Platform.Intent.ActionAppAction },
              Categories = new[] { Intent.CategoryDefault })]
public class MainActivity : MauiAppCompatActivity
{
}
