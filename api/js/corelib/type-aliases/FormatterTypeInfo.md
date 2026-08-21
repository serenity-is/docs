[@serenity-is/corelib](../README.md) / FormatterTypeInfo

# Type Alias: FormatterTypeInfo\<TypeName\>

> **FormatterTypeInfo**\<`TypeName`\> = [`TypeInfo`](TypeInfo.md)\<`TypeName`\>

Defined in: [src/base/system.ts:579](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L579)

TypeInfo for a formatter class. Like [ClassTypeInfo](ClassTypeInfo.md) but automatically includes [ISlickFormatter](../classes/ISlickFormatter.md).
This is one of the helper types that are used to make the type name available in declaration files, unlike decorators that does not show in .d.ts files.

## Type Parameters

### TypeName

`TypeName`

String-literal formatter type name.
