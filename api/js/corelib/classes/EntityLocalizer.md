[@serenity-is/corelib](../README.md) / EntityLocalizer

# Class: EntityLocalizer

Defined in: [src/ui/dialogs/entitylocalizer.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L36)

Manages the localization grid for an entity dialog, letting users edit
translations of localizable fields for each language.

## Constructors

### Constructor

> **new EntityLocalizer**(`opt`): `EntityLocalizer`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L49)

Creates a localizer and builds the localization grid.

#### Parameters

##### opt

[`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

Options for the localizer.

#### Returns

`EntityLocalizer`

## Properties

### grid

> `protected` **grid**: [`PropertyGrid`](PropertyGrid.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L38)

***

### lastValue

> `protected` **lastValue**: `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L40)

***

### pendingValue

> `protected` **pendingValue**: `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L39)

***

### targetLanguage

> `protected` **targetLanguage**: `HTMLSelectElement`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L41)

## Methods

### buttonClick()

> **buttonClick**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L195)

Toggles localization mode and loads/saves localization values.

#### Returns

`void`

***

### clearValue()

> **clearValue**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L158)

Clears pending and last localization values.

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L148)

Destroys the localization grid.

#### Returns

`void`

***

### editSaveRequest()

> **editSaveRequest**(`req`): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L288)

Adds pending localizations to a save request.

#### Parameters

##### req

[`SaveRequest`](../interfaces/SaveRequest.md)\<`any`\>

The save request to modify.

#### Returns

`void`

***

### getLocalizationGridValue()

> `protected` **getLocalizationGridValue**(): `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:271](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L271)

Returns the localization values from the grid, keyed by language and field.

#### Returns

`any`

The localization values.

***

### getPendingLocalizations()

> `protected` **getPendingLocalizations**(): `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L298)

Returns pending localizations grouped by language.

#### Returns

`any`

The pending localizations.

***

### isEnabled()

> **isEnabled**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L167)

Whether the localization grid is enabled (there are localizable fields).

#### Returns

`boolean`

True when enabled.

***

### isLocalizationMode()

> `protected` **isLocalizationMode**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L175)

Whether the dialog is currently in localization mode.

#### Returns

`boolean`

True when in localization mode.

***

### isLocalizationModeAndChanged()

> `protected` **isLocalizationModeAndChanged**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L183)

Whether the localization values changed since the last save.

#### Returns

`boolean`

True when changed.

***

### loadLocalization()

> `protected` **loadLocalization**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:216](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L216)

Loads localization values into the grid.

#### Returns

`void`

***

### setLocalizationGridCurrentValues()

> `protected` **setLocalizationGridCurrentValues**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L246)

Copies current field values into the localization grid as hints.

#### Returns

`void`

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L324)

Updates the UI to reflect the current localization mode.

#### Returns

`void`
