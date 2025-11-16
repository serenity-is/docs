[corelib](../README.md) / TypeInfo

# Type Alias: TypeInfo\<TypeName\>

> **TypeInfo**\<`TypeName`\> = `object`

Defined in: [src/base/system-internal.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L29)

Type information for a registered type.

## Type Parameters

### TypeName

`TypeName`

## Properties

### customAttributes?

> `optional` **customAttributes**: [`CustomAttribute`](../classes/CustomAttribute.md)[]

Defined in: [src/base/system-internal.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L37)

Custom attributes

***

### enumFlags?

> `optional` **enumFlags**: `boolean`

Defined in: [src/base/system-internal.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L39)

Enum flags

***

### interfaces?

> `optional` **interfaces**: `any`[]

Defined in: [src/base/system-internal.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L35)

Implemented interfaces

***

### registered?

> `optional` **registered**: `boolean`

Defined in: [src/base/system-internal.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L41)

Registered flag

***

### typeKind

> **typeKind**: `"class"` \| `"enum"` \| `"interface"`

Defined in: [src/base/system-internal.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L31)

Type kind, can be "class", "enum", "interface"

***

### typeName

> **typeName**: [`StringLiteral`](StringLiteral.md)\<`TypeName`\> \| `string` & `object`

Defined in: [src/base/system-internal.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system-internal.ts#L33)

Registered type name
