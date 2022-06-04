using UIKit;

namespace AppActions.Icons.Maui.Platforms;

internal class AppActionsImplementation : IAppActions, IPlatformAppActions
{
#pragma warning disable CS1591 // Disable Missing XML comment warning
    public const string ShortcutType = "XE_APP_ACTION_TYPE";

    public bool IsSupported => true;

    public Task<IEnumerable<AppAction>> GetAsync()
        => Task.FromResult(UIApplication.SharedApplication.ShortcutItems.Select(s => s.ToAppAction()));

    public Task SetAsync(IEnumerable<AppAction> actions)
    {
        UIApplication.SharedApplication.ShortcutItems = actions.Select(a => a.ToShortcutItem()).ToArray();

        return Task.CompletedTask;
    }

    public event EventHandler<AppActionEventArgs> AppActionActivated;

    public void PerformActionForShortcutItem(UIApplication application, UIApplicationShortcutItem shortcutItem, UIOperationHandler completionHandler)
    {
        if (shortcutItem.Type == ShortcutType)
        {
            var appAction = shortcutItem.ToAppAction();
            AppActionActivated?.Invoke(null, new AppActionEventArgs(appAction));
        }
    }
#pragma warning restore CS1591 // Enable Missing XML comment warning
}
