# Language Identifiers

A language ID is a code that assigns letters and/or numbers as identifiers or classifiers for languages.

Language IDs follow the RFC 1766 standard in the format `<languagecode2>-<country/regioncode2>`, where *languagecode2* is a lowercase two-letter code derived from ISO 639-1 and *country/regioncode2* is an uppercase two-letter code derived from ISO 3166.

Some sample language IDs:

- `en` : English
- `en-US` : English as used in the United States (US is the ISO 3166-1 country code)
- `en-GB` : English as used in the United Kingdom (GB is the ISO 3166-1 country code)
- `es` : Spanish
- `es-AR` : Spanish as used in Argentina

## Invariant Language

Similar to *CultureInfo.InvariantCulture*, invariant language is the default language with empty identifier.

Unless specified otherwise, embedded texts in your assemblies are considered to be written in invariant language.

Though it is usually considered to be English, you may assume your natural language as the invariant language.
