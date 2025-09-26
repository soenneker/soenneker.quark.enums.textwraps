using Intellenum;
using Soenneker.Quark.Enums.GlobalKeywords;

namespace Soenneker.Quark;

/// <summary>
/// Typed values for the CSS text-wrap property in .NET enumeration form.
/// </summary>
[Intellenum<string>]
public sealed partial class TextWrap
{
    public static readonly TextWrap Wrap = new("wrap");
    public static readonly TextWrap NoWrap = new("nowrap");

    public static implicit operator TextWrap(GlobalKeyword style) => new(style.Value);
}
