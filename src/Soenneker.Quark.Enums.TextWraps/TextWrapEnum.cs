using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a Tailwind text-wrapping utility class.
/// </summary>
[EnumValue<string>]
public sealed partial class TextWrapEnum
{
    /// <summary>
    /// Uses normal line wrapping.
    /// </summary>
    public static readonly TextWrapEnum Wrap = new("text-wrap");
    /// <summary>
    /// Balances line lengths, typically for headings.
    /// </summary>
    public static readonly TextWrapEnum Balance = new("text-balance");
    /// <summary>
    /// Favors more readable wrapping, typically for body copy.
    /// </summary>
    public static readonly TextWrapEnum Pretty = new("text-pretty");
}
