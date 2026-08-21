[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / registerClass

# ~~Function: registerClass()~~

> **registerClass**(`nameOrIntf?`, `intf2?`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L23)

Registers a class with an optional full name and interfaces.

## Parameters

### nameOrIntf?

Full type name or interface list.

`string` | [`InterfaceType`](../../../../type-aliases/InterfaceType.md)[]

### intf2?

[`InterfaceType`](../../../../type-aliases/InterfaceType.md)[]

Additional interfaces.

## Returns

Class decorator.

> (`target`, `_context?`): `void`

### Parameters

#### target

`Function`

#### \_context?

`any`

### Returns

`void`
