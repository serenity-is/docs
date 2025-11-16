[corelib](../README.md) / initFormType

# Function: initFormType()

> **initFormType**(`typ`, `nameWidgetPairs`): `void`

Defined in: [src/base/system.ts:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L367)

Initialize a form type. This is used in the XYZForm.ts files that are generated
by the Serenity server typings code generator. It defines getters that call this.w() to
initialize form fields on the prototype of a form class.

## Parameters

### typ

`Function`

Form type to initialize

### nameWidgetPairs

`any`[]

Array of name-widget pairs

## Returns

`void`
