[corelib](../README.md) / registerInterface

# Function: registerInterface()

> **registerInterface**(`type`, `name`, `intf?`): `void`

Defined in: [src/base/system.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L285)

Register an interface with the type system. There is no runtime representation of interfaces
in JavaScript, so Serenity uses classes decorated with some special symbols to emulate
interfaces to some degree. This is used by the type system to support isAssignableFrom and 
isInstanceOfType functions for interfaces.

## Parameters

### type

`any`

Interface type to register

### name

`string`

Name to register the interface under

### intf?

[`InterfaceType`](../type-aliases/InterfaceType.md)[]

Optional interfaces the interface class implements

## Returns

`void`
