using System.Runtime.CompilerServices;

namespace AppActions.Icons.Maui;

/// <summary>
/// App Action Icon Collection
/// </summary>
public static class AppActionIcon
{
    /// <summary>
    /// Default Icon
    /// </summary>
    public static string Default { get; } = GetPlatformName();

    /// <summary>
    /// Add Icon
    /// </summary>
    public static string Add { get; } = GetPlatformName();

    /// <summary>
    /// Alarm Icon
    /// </summary>
    public static string Alarm { get; } = GetPlatformName();

    /// <summary>
    /// Audio Icon
    /// </summary>
    public static string Audio { get; } = GetPlatformName();

    /// <summary>
    /// Bookmark Icon
    /// </summary>
    public static string Bookmark { get; } = GetPlatformName();

    /// <summary>
    /// Capture Photo Icon
    /// </summary>
    public static string CapturePhoto { get; } = GetPlatformName();

    /// <summary>
    /// Capture Video Icon
    /// </summary>
    public static string CaptureVideo { get; } = GetPlatformName();

    /// <summary>
    /// Cloud Icon
    /// </summary>
    public static string Cloud { get; } = GetPlatformName();

    /// <summary>
    /// Compose  Icon
    /// </summary>
    public static string Compose { get; } = GetPlatformName();

    /// <summary>
    /// Confirmation Icon
    /// </summary>
    public static string Confirmation { get; } = GetPlatformName();

    /// <summary>
    /// Contact Icon
    /// </summary>
    public static string Contact { get; } = GetPlatformName();

    /// <summary>
    /// Date Icon
    /// </summary>
    public static string Date { get; } = GetPlatformName();

    /// <summary>
    /// Favorite Icon
    /// </summary>
    public static string Favorite { get; } = GetPlatformName();

    /// <summary>
    /// Home Icon
    /// </summary>
    public static string Home { get; } = GetPlatformName();

    /// <summary>
    /// Invitation Icon
    /// </summary>
    public static string Invitation { get; } = GetPlatformName();

    /// <summary>
    /// Location Icon
    /// </summary>
    public static string Location { get; } = GetPlatformName();

    /// <summary>
    /// Love Icon
    /// </summary>
    public static string Love { get; } = GetPlatformName();

    /// <summary>
    /// Mail Icon
    /// </summary>
    public static string Mail { get; } = GetPlatformName();

    /// <summary>
    /// Mark Location Icon
    /// </summary>
    public static string MarkLocation { get; } = GetPlatformName();

    /// <summary>
    /// Message Icon
    /// </summary>
    public static string Message { get; } = GetPlatformName();

    /// <summary>
    /// Pause Icon
    /// </summary>
    public static string Pause { get; } = GetPlatformName();

    /// <summary>
    /// Play Icon
    /// </summary>
    public static string Play { get; } = GetPlatformName();

    /// <summary>
    /// Prohibit Icon
    /// </summary>
    public static string Prohibit { get; } = GetPlatformName();

    /// <summary>
    /// Search Icon
    /// </summary>
    public static string Search { get; } = GetPlatformName();

    /// <summary>
    /// Share Icon
    /// </summary>
    public static string Share { get; } = GetPlatformName();

    /// <summary>
    /// Shuffle Icon
    /// </summary>
    public static string Shuffle { get; } = GetPlatformName();

    /// <summary>
    /// Task Icon
    /// </summary>
    public static string Task { get; } = GetPlatformName();

    /// <summary>
    /// Task Completed Icon
    /// </summary>
    public static string TaskCompleted { get; } = GetPlatformName();

    /// <summary>
    /// Time Icon
    /// </summary>
    public static string Time { get; } = GetPlatformName();

    /// <summary>
    /// Update Icon
    /// </summary>
    public static string Update { get; } = GetPlatformName();


    private static string GetPlatformName([CallerMemberName] string name = null)
    {
#if ANDROID
        return $"ic_plugin_sc_{name.ToLower()}";
#elif IOS
        return $"{IconPrefix_UIAppShortcutIcon}{name}";
#elif WINDOWS
        return $"icon_plugin_{name.ToLower()}_white";
#elif TIZEN
        return $"{name.ToLower()}";
#else
        return $"{name.ToLower()}";
#endif
    }
}
