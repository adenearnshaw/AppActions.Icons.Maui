using System;
namespace Maui.AppActions.Icons
{
	public class SystemSymbol
	{
		private readonly string _symbolName;

		public SystemSymbol(string symbolName)
		{
#if __IOS__
			_symbolName = $"aasfs_{symbolName}";
#else
			_symbolName = symbolName.Replace('.', '_');
#endif
		}

		public static implicit operator string(SystemSymbol s) => s._symbolName;
		public static explicit operator SystemSymbol(string b) => new SystemSymbol(b);

		public override string ToString() => $"{_symbolName}";
	}
}
