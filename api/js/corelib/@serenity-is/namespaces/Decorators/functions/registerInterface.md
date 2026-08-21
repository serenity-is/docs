[@serenity-is/corelib](../../../../README.md) / [Decorators](../README.md) / registerInterface

# ~~Function: registerInterface()~~

> **registerInterface**(`nameOrIntf?`, `intf2?`): (`target`, `_context?`) => `void`

Defined in: [src/types/decorators.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L33)

Registers an interface.

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
