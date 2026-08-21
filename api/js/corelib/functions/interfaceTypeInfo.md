[@serenity-is/corelib](../README.md) / interfaceTypeInfo

# Function: interfaceTypeInfo()

> **interfaceTypeInfo**\<`TypeName`\>(`typeName`, `intf?`): [`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`TypeName`\>

Defined in: [src/base/system.ts:667](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L667)

Creates [InterfaceTypeInfo](../type-aliases/InterfaceTypeInfo.md) for an interface.

## Type Parameters

### TypeName

`TypeName`

String-literal interface name.

## Parameters

### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

Fully-qualified interface name (e.g. `"MyApp.IMyInterface"`).

### intf?

[`InterfaceType`](../type-aliases/InterfaceType.md)[]

Optional base interfaces this interface extends.

## Returns

[`InterfaceTypeInfo`](../type-aliases/InterfaceTypeInfo.md)\<`TypeName`\>

An [InterfaceTypeInfo](../type-aliases/InterfaceTypeInfo.md) to assign to `[Symbol.typeInfo]`.
