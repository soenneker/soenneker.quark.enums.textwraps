using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Typed values for the CSS text-wrap property in .NET enumeration form.
/// </summary>
[EnumValue<string>]
public sealed partial class TextWrapKeyword
{
    public static readonly TextWrapKeyword Wrap = new("wrap");
    public static readonly TextWrapKeyword NoWrap = new("nowrap");

    public static implicit operator TextWrapKeyword(GlobalKeyword style) => new(style.Value);
}
