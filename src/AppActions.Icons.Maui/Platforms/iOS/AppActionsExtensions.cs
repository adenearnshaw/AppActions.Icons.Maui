﻿using System.Reflection;
using Foundation;
using UIKit;

namespace Maui.AppActions.Icons.Platforms
{
    static class AppActionsExtensions
    {
        internal const string UIKitIconTypePrefix = "aauik_";
        internal const string SFSymbolIconTypePrefix = "aasfs_";
        private const string IconPropertyName = "Icon";

        internal static AppAction ToAppAction(this UIApplicationShortcutItem shortcutItem)
        {
            string id = null;
            if (shortcutItem.UserInfo.TryGetValue((NSString)"id", out var idObj))
                id = idObj?.ToString();

            string icon = null;
            if (shortcutItem.UserInfo.TryGetValue((NSString)"icon", out var iconObj))
                icon = iconObj?.ToString();

            return new AppAction(id, shortcutItem.LocalizedTitle, shortcutItem.LocalizedSubtitle, icon);
        }


        internal static UIApplicationShortcutItem ToShortcutItem(this AppAction action)
        {
            var keys = new List<NSString>();
            var values = new List<NSObject>();

            // id
            keys.Add((NSString)"id");
            values.Add((NSString)action.Id);

            // icon
            UIApplicationShortcutIcon icon = null;
            var iconValue = action.IconValue();
            if (!string.IsNullOrEmpty(iconValue))
            {
                keys.Add((NSString)"icon");
                values.Add((NSString)iconValue);

                if (iconValue.StartsWith(UIKitIconTypePrefix))
                {
                    var isIconKnownType = Enum.TryParse(iconValue.Substring(UIKitIconTypePrefix.Length), out UIApplicationShortcutIconType type);
                    if (isIconKnownType)
                        icon = UIApplicationShortcutIcon.FromType(type);
                }
                else if (iconValue.StartsWith(SFSymbolIconTypePrefix))
                {
                    icon = UIApplicationShortcutIcon.FromSystemImageName(iconValue.Substring(SFSymbolIconTypePrefix.Length));
                }

                if (icon is null && iconValue is not null)
                    UIApplicationShortcutIcon.FromTemplateImageName(iconValue);
            }

            return new UIApplicationShortcutItem(
                AppActionsImplementation.ShortcutType,
                action.Title,
                action.Subtitle,
                icon,
                new NSDictionary<NSString, NSObject>(keys.ToArray(), values.ToArray()));
        }

        internal static string IconValue(this AppAction appAction)
        {
            var iconProperty = typeof(AppAction).GetProperties(BindingFlags.Instance |
                            BindingFlags.NonPublic |
                            BindingFlags.Public).FirstOrDefault(p => p.Name == IconPropertyName);

            return iconProperty.GetValue(appAction) as string;
        }

        internal static AppAction IconValue(this AppAction appAction, string value)
        {
            var iconProperty = typeof(AppAction).GetProperties(BindingFlags.Instance |
                            BindingFlags.NonPublic |
                            BindingFlags.Public).FirstOrDefault(p => p.Name == IconPropertyName);

            iconProperty.SetValue(appAction, value);
            return appAction;
        }
    }
}

