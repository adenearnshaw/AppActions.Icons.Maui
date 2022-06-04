using System.Runtime.CompilerServices;

namespace Maui.AppActions.Icons
{
    public static class AppActionIcon
    {
        public static string Default { get; } = GetPlatformName();
        public static string Add { get; } = GetPlatformName();
        public static string Alarm { get; } = GetPlatformName();
        public static string Audio { get; } = GetPlatformName();
        public static string Bookmark { get; } = GetPlatformName();
        public static string CapturePhoto { get; } = GetPlatformName();
        public static string CaptureVideo { get; } = GetPlatformName();
        public static string Cloud { get; } = GetPlatformName();
        public static string Compose { get; } = GetPlatformName();
        public static string Confirmation { get; } = GetPlatformName();
        public static string Contact { get; } = GetPlatformName();
        public static string Date { get; } = GetPlatformName();
        public static string Favorite { get; } = GetPlatformName();
        public static string Home { get; } = GetPlatformName();
        public static string Invitation { get; } = GetPlatformName();
        public static string Location { get; } = GetPlatformName();
        public static string Love { get; } = GetPlatformName();
        public static string Mail { get; } = GetPlatformName();
        public static string MarkLocation { get; } = GetPlatformName();
        public static string Message { get; } = GetPlatformName();
        public static string Pause { get; } = GetPlatformName();
        public static string Play { get; } = GetPlatformName();
        public static string Prohibit { get; } = GetPlatformName();
        public static string Search { get; } = GetPlatformName();
        public static string Share { get; } = GetPlatformName();
        public static string Shuffle { get; } = GetPlatformName();
        public static string Task { get; } = GetPlatformName();
        public static string TaskCompleted { get; } = GetPlatformName();
        public static string Time { get; } = GetPlatformName();
        public static string Update { get; } = GetPlatformName();


        private static string GetPlatformName([CallerMemberName] string name = null)
        {
#if __ANDROID__
            return $"ic_plugin_sc_{name.ToLower()}";
#elif __IOS__
            return $"aauik_{name}";
#elif WINDOWS
            return $"icon_plugin_{name.ToLower()}_white";
#elif TIZEN
            return $"{name.ToLower()}";
#else
            return $"{name.ToLower()}";
#endif
        }
    }
}
