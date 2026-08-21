[@serenity-is/corelib](../README.md) / EditorTypeInfo

# Type Alias: EditorTypeInfo\<TypeName\>

> **EditorTypeInfo**\<`TypeName`\> = [`TypeInfo`](TypeInfo.md)\<`TypeName`\>

Defined in: [src/base/system.ts:573](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L573)

TypeInfo for an editor class. Like [ClassTypeInfo](ClassTypeInfo.md) but automatically includes [EditorAttribute](../classes/EditorAttribute.md).
This is one of the helper types that are used to make the type name available in declaration files, unlike decorators that does not show in .d.ts files.

## Type Parameters

### TypeName

`TypeName`

String-literal editor type name.
