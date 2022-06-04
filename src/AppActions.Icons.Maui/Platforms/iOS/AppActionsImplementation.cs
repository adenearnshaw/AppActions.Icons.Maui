using UIKit;

namespace Maui.AppActions.Icons.Platforms
{
    public class AppActionsImplementation : IAppActions, IPlatformAppActions
    {
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
    }

    
}

