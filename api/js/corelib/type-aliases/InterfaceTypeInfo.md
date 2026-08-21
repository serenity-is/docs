[@serenity-is/corelib](../README.md) / InterfaceTypeInfo

# Type Alias: InterfaceTypeInfo\<TypeName\>

> **InterfaceTypeInfo**\<`TypeName`\> = [`TypeInfo`](TypeInfo.md)\<`TypeName`\>

Defined in: [src/base/system.ts:585](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L585)

TypeInfo for an interface. Used with `static [Symbol.typeInfo] = interfaceTypeInfo("...")`.
This is one of the helper types that are used to make the type name available in declaration files, unlike decorators that does not show in .d.ts files.

## Type Parameters

### TypeName

`TypeName`

String-literal interface name.
