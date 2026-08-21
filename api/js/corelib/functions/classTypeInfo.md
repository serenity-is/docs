[@serenity-is/corelib](../README.md) / classTypeInfo

# Function: classTypeInfo()

> **classTypeInfo**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/base/system.ts:601](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L601)

Creates [ClassTypeInfo](../type-aliases/ClassTypeInfo.md) for a class. Use as `static override [Symbol.typeInfo] = classTypeInfo("MyApp.MyClass")`.

## Type Parameters

### TypeName

`TypeName`

String-literal fully-qualified type name.

## Parameters

### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

Fully-qualified type name (e.g. `"MyApp.MyClass"`).

### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes the class implements / carries.

## Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

A [ClassTypeInfo](../type-aliases/ClassTypeInfo.md) object to assign to `[Symbol.typeInfo]`.
