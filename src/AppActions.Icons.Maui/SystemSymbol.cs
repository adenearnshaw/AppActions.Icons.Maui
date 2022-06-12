namespace AppActions.Icons.Maui;

/// <summary>
/// A System Symbol
/// </summary>
public record struct SystemSymbol
{
	private readonly string _symbolName;

	/// <summary>
	/// Denotes string value is a System Symbol. In iOS this will resolve an SF Symbol.
	/// </summary>
	/// <param name="symbolName">SF Symbol name, on non-iOS platforms periods will be replaced with underscores</param>
	public SystemSymbol(string symbolName)
	{
#if IOS || MACCATALYST

		_symbolName = $"{IconPrefix_SFSymbol}{symbolName}";
#else
		_symbolName = symbolName.Replace('.', '_');
#endif
	}

	/// <summary>
	/// Implicitly operator of <see cref="SystemSymbol"/> to <see cref="String"/>
	/// </summary>
	/// <param name="s"><see cref="SystemSymbol"/> value</param>
	public static implicit operator string(SystemSymbol s) => s._symbolName;

	/// <summary>
	/// Explicit operator of <see cref="SystemSymbol"/>
	/// </summary>
	/// <param name="b"><see cref="SystemSymbol"/> value</param>
	public static explicit operator SystemSymbol(string b) => new SystemSymbol(b);

	/// <summary>
	/// Output the <see cref="SystemSymbol"/> value to string
	/// </summary>
	/// <returns><see cref="SystemSymbol"/> value</returns>
	public override string ToString() => $"{_symbolName}";
}
