namespace AppActions.Icons.Maui;

/// <summary>
/// String container to hold platform independent values
/// </summary>
public class PlatformString
{
    private readonly string _stringValue;

    /// <summary>
    /// Declare a Platform Specific String
    /// </summary>
    /// <param name="defaultValue">Default value if platform variant not set</param>
    /// <param name="android">Android value</param>
    /// <param name="ios">iOS value</param>
    /// <param name="maccatalyst">Mac Catalyst value</param>
    /// <param name="win">Windows value</param>
    public PlatformString(string defaultValue, 
                          string android = null, 
                          string ios = null, 
                          string maccatalyst = null, 
                          string win = null)
    {
#if __ANDROID__
        _stringValue = android ?? defaultValue;
#elif IOS
        _stringValue = ios ?? defaultValue;
#elif MACCATALYST
        _stringValue = maccatalyst ?? defaultValue;
#elif WINDOWS
        _stringValue = win ?? defaultValue;
#else
        _stringValue = defaultValue;
#endif
    }

    /// <summary>
    /// Implicit Operator to convert <see cref="PlatformString"/> to <see cref="String"/>
    /// </summary>
    /// <param name="s"></param>
    public static implicit operator string(PlatformString s) => s._stringValue;

    /// <summary>
    /// Output Platform String Value
    /// </summary>
    /// <returns>Platform dependent value</returns>
    public override string ToString() => $"{_stringValue}";
}
