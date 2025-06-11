# Code-Review Refactor Notes

## JavaScript snippet

| Issue | Fix | Reason |
|-------|-----|--------|
| Vague function name `doThings` | Renamed to `sortCsv` | conveys intent |
| Accepts any type | Added type-guard | fail fast |
| Trims / empty tokens ignored | `.trim()` + `.filter(Boolean)` | robust parsing |
| Default `Array.sort` unstable on numbers | `localeCompare` | deterministic |

## C# snippet

| Issue | Fix |
|-------|-----|
| Instantiable class with no state | `static` class |
| Method mis-named `Parse` | `ReverseTokens` |
| Null risk | `ArgumentNullException.ThrowIfNull` |
| Wrong join delimiter | Preserve original `' '` |
| No docs | Added XML summary/param |
