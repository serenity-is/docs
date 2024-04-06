[@serenity-is/corelib](../README.md) / Decorators

# Namespace: Decorators

## Table of contents

### Functions

- [classType](Decorators.md#classtype)
- [closeButton](Decorators.md#closebutton)
- [dialogType](Decorators.md#dialogtype)
- [editor](Decorators.md#editor)
- [editorType](Decorators.md#editortype)
- [element](Decorators.md#element)
- [enumKey](Decorators.md#enumkey)
- [filterable](Decorators.md#filterable)
- [formatterType](Decorators.md#formattertype)
- [interfaceType](Decorators.md#interfacetype)
- [itemName](Decorators.md#itemname)
- [maximizable](Decorators.md#maximizable)
- [option](Decorators.md#option)
- [optionsType](Decorators.md#optionstype)
- [panel](Decorators.md#panel)
- [registerClass](Decorators.md#registerclass)
- [registerEditor](Decorators.md#registereditor)
- [registerEnum](Decorators.md#registerenum)
- [registerEnumType](Decorators.md#registerenumtype)
- [registerFormatter](Decorators.md#registerformatter)
- [registerInterface](Decorators.md#registerinterface)
- [registerType](Decorators.md#registertype)
- [resizable](Decorators.md#resizable)
- [responsive](Decorators.md#responsive)
- [service](Decorators.md#service)
- [staticPanel](Decorators.md#staticpanel)

## Functions

### classType

▸ **classType**\<`T`\>(`typeName`, `interfaces?`): [`ClassTypeInfo`](../README.md#classtypeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `typeName` | [`StringLiteral`](../README.md#stringliteral)\<`T`\> |
| `interfaces?` | `any`[] |

#### Returns

[`ClassTypeInfo`](../README.md#classtypeinfo)\<`T`\>

#### Defined in

[src/types/decorators.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L6)

___

### closeButton

▸ **closeButton**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L86)

___

### dialogType

▸ **dialogType**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L92)

___

### editor

▸ **editor**(): (`target`: `Function`) => `void`

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L98)

___

### editorType

▸ **editorType**\<`T`\>(`typeName`, `interfaces?`): [`EditorTypeInfo`](../README.md#editortypeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `typeName` | [`StringLiteral`](../README.md#stringliteral)\<`T`\> |
| `interfaces?` | `any`[] |

#### Returns

[`EditorTypeInfo`](../README.md#editortypeinfo)\<`T`\>

#### Defined in

[src/types/decorators.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L7)

___

### element

▸ **element**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L105)

___

### enumKey

▸ **enumKey**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L64)

___

### filterable

▸ **filterable**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L111)

___

### formatterType

▸ **formatterType**\<`T`\>(`typeName`, `interfaces?`): [`FormatterTypeInfo`](../README.md#formattertypeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `typeName` | [`StringLiteral`](../README.md#stringliteral)\<`T`\> |
| `interfaces?` | `any`[] |

#### Returns

[`FormatterTypeInfo`](../README.md#formattertypeinfo)\<`T`\>

#### Defined in

[src/types/decorators.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L9)

___

### interfaceType

▸ **interfaceType**\<`T`\>(`typeName`, `interfaces?`): [`InterfaceTypeInfo`](../README.md#interfacetypeinfo)\<`T`\>

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `typeName` | [`StringLiteral`](../README.md#stringliteral)\<`T`\> |
| `interfaces?` | `any`[] |

#### Returns

[`InterfaceTypeInfo`](../README.md#interfacetypeinfo)\<`T`\>

#### Defined in

[src/types/decorators.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L8)

___

### itemName

▸ **itemName**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L117)

___

### maximizable

▸ **maximizable**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L123)

___

### option

▸ **option**(): (`target`: `Object`, `propertyKey`: `string`) => `void`

#### Returns

`fn`

▸ (`target`, `propertyKey`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Object` |
| `propertyKey` | `string` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L70)

___

### optionsType

▸ **optionsType**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Function` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L129)

___

### panel

▸ **panel**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L135)

___

### registerClass

▸ **registerClass**(`nameOrIntf?`, `intf2?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nameOrIntf?` | `string` \| `any`[] |
| `intf2?` | `any`[] |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L17)

___

### registerEditor

▸ **registerEditor**(`nameOrIntf?`, `intf2?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nameOrIntf?` | `string` \| `any`[] |
| `intf2?` | `any`[] |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L36)

___

### registerEnum

▸ **registerEnum**(`target`, `enumKey?`, `name?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `any` |
| `enumKey?` | `string` |
| `name?` | `string` |

#### Returns

`void`

#### Defined in

[src/types/decorators.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L45)

___

### registerEnumType

▸ **registerEnumType**(`target`, `name?`, `enumKey?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `any` |
| `name?` | `string` |
| `enumKey?` | `string` |

#### Returns

`void`

#### Defined in

[src/types/decorators.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L51)

___

### registerFormatter

▸ **registerFormatter**(`nameOrIntf?`, `intf2?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nameOrIntf` | `string` \| `any`[] |
| `intf2` | `any`[] |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L55)

___

### registerInterface

▸ **registerInterface**(`nameOrIntf?`, `intf2?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nameOrIntf?` | `string` \| `any`[] |
| `intf2?` | `any`[] |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L26)

___

### registerType

▸ **registerType**(): (`target`: `Function` & \{ `typeInfo`: `any`  }) => `void`

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` & \{ `typeInfo`: `any`  } |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L11)

___

### resizable

▸ **resizable**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L141)

___

### responsive

▸ **responsive**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L147)

___

### service

▸ **service**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L153)

___

### staticPanel

▸ **staticPanel**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/types/decorators.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/types/decorators.ts#L159)
