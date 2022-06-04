#if IOS
using System.Reflection;
#endif

namespace AppActions.Icons.Maui;

/// <summary>
/// Extensions for <see cref="IEssentialsBuilder"/>
/// </summary>
public static class EssentialsBuilderExtensions
{
    private const string CurrentImplementationFieldName = "currentImplementation";

    static EssentialsBuilderExtensions()
    {
#if IOS
        var currentImplField = typeof(Microsoft.Maui.ApplicationModel.AppActions)
					.GetFields(BindingFlags.Static|BindingFlags.NonPublic)
					.FirstOrDefault(p => p.Name == CurrentImplementationFieldName);

			if (currentImplField is not null)
				currentImplField.SetValue(null, new AppActions.Icons.Maui.Platforms.AppActionsImplementation());
#endif
    }

    /// <summary>
    /// Configure App Action Icons via the essentials builder
    /// </summary>
    /// <param name="essentialsBuilder"><see cref="IEssentialsBuilder"/> instance</param>
    /// <returns><see cref="IEssentialsBuilder"/></returns>
    public static IEssentialsBuilder UseAppActionIcons(this IEssentialsBuilder essentialsBuilder) => essentialsBuilder;
}

