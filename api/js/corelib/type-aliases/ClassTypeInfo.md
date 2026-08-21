[@serenity-is/corelib](../README.md) / ClassTypeInfo

# Type Alias: ClassTypeInfo\<TypeName\>

> **ClassTypeInfo**\<`TypeName`\> = [`TypeInfo`](TypeInfo.md)\<`TypeName`\>

Defined in: [src/base/system.ts:567](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L567)

TypeInfo for a class. Used with `static override [Symbol.typeInfo] = classTypeInfo("...")` to embed the type name in declaration files (decorators are erased in `.d.ts`).
This is one of the helper types that are used to make the type name available in declaration files, unlike decorators that does not show in .d.ts files.

## Type Parameters

### TypeName

`TypeName`

String-literal type of the fully-qualified class name.
