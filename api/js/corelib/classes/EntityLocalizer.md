[@serenity-is/corelib](../README.md) / EntityLocalizer

# Class: EntityLocalizer

## Constructors

### new EntityLocalizer()

> **new EntityLocalizer**(`opt`): [`EntityLocalizer`](EntityLocalizer.md)

#### Parameters

##### opt

[`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

#### Returns

[`EntityLocalizer`](EntityLocalizer.md)

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L28)

## Properties

### grid

> `protected` **grid**: [`PropertyGrid`](PropertyGrid.md)\<[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)\>

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L21)

***

### lastValue

> `protected` **lastValue**: `any`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L23)

***

### pendingValue

> `protected` **pendingValue**: `any`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L22)

***

### targetLanguage

> `protected` **targetLanguage**: `HTMLSelectElement`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L24)

## Methods

### buttonClick()

> **buttonClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L153)

***

### clearValue()

> **clearValue**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L131)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L124)

***

### editSaveRequest()

> **editSaveRequest**(`req`): `void`

#### Parameters

##### req

[`SaveRequest`](../interfaces/SaveRequest.md)\<`any`\>

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L232)

***

### getLocalizationGridValue()

> `protected` **getLocalizationGridValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L219)

***

### getPendingLocalizations()

> `protected` **getPendingLocalizations**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L238)

***

### isEnabled()

> **isEnabled**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L136)

***

### isLocalizationMode()

> `protected` **isLocalizationMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L140)

***

### isLocalizationModeAndChanged()

> `protected` **isLocalizationModeAndChanged**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L144)

***

### loadLocalization()

> `protected` **loadLocalization**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L171)

***

### setLocalizationGridCurrentValues()

> `protected` **setLocalizationGridCurrentValues**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L198)

***

### updateInterface()

> **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitylocalizer.tsx:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L261)
