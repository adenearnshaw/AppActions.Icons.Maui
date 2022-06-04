using System;
using System.Reflection;

namespace Maui.AppActions.Icons
{
	public static class AppActions
	{
		static AppActions()
		{
#if __IOS__
			var currentImplField = typeof(Microsoft.Maui.ApplicationModel.AppActions)
					.GetFields(BindingFlags.Static|BindingFlags.NonPublic)
					.FirstOrDefault(p => p.Name == "currentImplementation");

			if (currentImplField is not null)
				currentImplField.SetValue(null, new Maui.AppActions.Icons.Platforms.AppActionsImplementation());
#endif
		}

		public static IEssentialsBuilder UseAppActionIcons(this IEssentialsBuilder essentialsBuilder) => essentialsBuilder;
	}
}

