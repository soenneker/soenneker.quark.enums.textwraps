[![](https://img.shields.io/nuget/v/soenneker.quark.enums.textwraps.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.textwraps/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.textwraps/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.textwraps/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.textwraps/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.textwraps/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.textwraps.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.textwraps/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.textwraps/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.textwraps/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.TextWraps

Strongly typed Tailwind text-wrapping utility classes for Quark components.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.TextWraps
```

## Usage

```csharp
TextWrapEnum wrapping = TextWrapEnum.Balance;
string cssClass = wrapping.Value; // "text-balance"
```

The values are complete utility class names and can be appended directly to a class list.

## Values

| Member | Utility class | Intended use |
| --- | --- | --- |
| `Wrap` | `text-wrap` | Normal line wrapping. |
| `Balance` | `text-balance` | Balances line lengths, typically for headings. |
| `Pretty` | `text-pretty` | Favors more readable wrapping, typically for body copy. |

Balancing and pretty wrapping are browser layout hints; the final line breaks still depend on the available width, font metrics, language, and browser support.
