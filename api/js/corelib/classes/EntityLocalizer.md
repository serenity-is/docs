[corelib](../README.md) / EntityLocalizer

# Class: EntityLocalizer

Defined in: [src/ui/dialogs/entitylocalizer.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L18)

## Constructors

### Constructor

> **new EntityLocalizer**(`opt`): `EntityLocalizer`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L27)

#### Parameters

##### opt

[`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

#### Returns

`EntityLocalizer`

## Properties

### grid

> `protected` **grid**: [`PropertyGrid`](PropertyGrid.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L20)

***

### lastValue

> `protected` **lastValue**: `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L22)

***

### pendingValue

> `protected` **pendingValue**: `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L21)

***

### targetLanguage

> `protected` **targetLanguage**: `HTMLSelectElement`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L23)

## Methods

### buttonClick()

> **buttonClick**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L152)

#### Returns

`void`

***

### clearValue()

> **clearValue**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L130)

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L123)

#### Returns

`void`

***

### editSaveRequest()

> **editSaveRequest**(`req`): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L231)

#### Parameters

##### req

[`SaveRequest`](../interfaces/SaveRequest.md)\<`any`\>

#### Returns

`void`

***

### getLocalizationGridValue()

> `protected` **getLocalizationGridValue**(): `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L218)

#### Returns

`any`

***

### getPendingLocalizations()

> `protected` **getPendingLocalizations**(): `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L237)

#### Returns

`any`

***

### isEnabled()

> **isEnabled**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L135)

#### Returns

`boolean`

***

### isLocalizationMode()

> `protected` **isLocalizationMode**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L139)

#### Returns

`boolean`

***

### isLocalizationModeAndChanged()

> `protected` **isLocalizationModeAndChanged**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L143)

#### Returns

`boolean`

***

### loadLocalization()

> `protected` **loadLocalization**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L170)

#### Returns

`void`

***

### setLocalizationGridCurrentValues()

> `protected` **setLocalizationGridCurrentValues**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L197)

#### Returns

`void`

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L260)

#### Returns

`void`
