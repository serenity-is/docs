# Language Fallbacks

## Neutral Language Fallback

When a translation is not found in `en-US`, it is acceptable to look for a translation in `en` language, as they are closely related.

Two letter language IDs (neutral languages) are implicitly language fallbacks of 4 letter country specific codes.

So `es` is language fallback of `es-AR` and `en` is language fallback of `en-US` and `en-GB`.

## Invariant Language Fallback

Invariant language with empty code is the final fallback of all languages implicitly.

## Implementation

Language fallback functionality should be implemented by the ILocalTextRegistry provider (e.g. LocalTextRegistry class).

Providers may also support setting language fallbacks explicitly, so you can set `en-US` as language fallback of `en-UK` if needed.

This is how looking up a translation for a local text key works:

- If current language has a translation for the key, return it.
- Check every explicitly defined language fallback for a translation.
- If language ID is a 4 letter country specific code, check neutral language for a translation.
- Check invariant language for a translation.
- Return the key itself or null for TryGet.

Let's say we set `en-US` as language fallback of `en-UK`.

If we search for a translation in `en-UK`, it is looked up in this order:

1. en-UK
2. en-US
3. en
4. invariant

