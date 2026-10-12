[@serenity-is/corelib](../README.md) / EntityLocalizer

# Class: EntityLocalizer

Defined in: [src/ui/dialogs/entitylocalizer.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L43)

Manages the localization grid for an entity dialog, letting users edit
translations of localizable fields for each language.

## Constructors

### Constructor

> **new EntityLocalizer**(`opt`): `EntityLocalizer`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L56)

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

Defined in: [src/ui/dialogs/entitylocalizer.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L45)

***

### lastValue

> `protected` **lastValue**: `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L47)

***

### pendingValue

> `protected` **pendingValue**: `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L46)

***

### targetLanguage

> `protected` **targetLanguage**: `HTMLSelectElement`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L48)

## Methods

### buttonClick()

> **buttonClick**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L224)

Toggles localization mode and loads/saves localization values.

#### Returns

`void`

***

### clearValue()

> **clearValue**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L165)

Clears pending and last localization values.

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L155)

Destroys the localization grid.

#### Returns

`void`

***

### editSaveRequest()

> **editSaveRequest**(`req`): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L317)

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

Defined in: [src/ui/dialogs/entitylocalizer.tsx:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L300)

Returns the localization values from the grid, keyed by language and field.

#### Returns

`any`

The localization values.

***

### getPendingLocalizations()

> `protected` **getPendingLocalizations**(): `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:327](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L327)

Returns pending localizations grouped by language.

#### Returns

`any`

The pending localizations.

***

### isEnabled()

> **isEnabled**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L174)

Whether the localization grid is enabled (there are localizable fields).

#### Returns

`boolean`

True when enabled.

***

### isLocalizationMode()

> `protected` **isLocalizationMode**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L204)

Whether the dialog is currently in localization mode.

#### Returns

`boolean`

True when in localization mode.

***

### isLocalizationModeAndChanged()

> `protected` **isLocalizationModeAndChanged**(): `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L212)

Whether the localization values changed since the last save.

#### Returns

`boolean`

True when changed.

***

### loadLocalization()

> `protected` **loadLocalization**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L245)

Loads localization values into the grid.

#### Returns

`void`

***

### mapSourceItem()

> `protected` **mapSourceItem**(`item`): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L186)

Maps a source property item to the item used in the localization grid, using the
dialog supplied [EntityLocalizerOptions.mapSourceItem](../interfaces/EntityLocalizerOptions.md#mapsourceitem) callback. The callback
may return a modified item (e.g. with different permissions / insertable / updatable
flags, or `localizable: false` to skip it), or null/undefined to use the item as is.

#### Parameters

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

Source property item.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

The item to use.

***

### setLocalizationGridCurrentValues()

> `protected` **setLocalizationGridCurrentValues**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L275)

Copies current field values into the localization grid as hints.

#### Returns

`void`

***

### setMode()

> **setMode**(`mode`): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L196)

Applies the insert/update mode to the localization grid, so that insertable /
updatable flags and field level permissions are evaluated for the current operation.
The dialog calls this whenever the main property grid mode changes.

#### Parameters

##### mode

[`PropertyGridMode`](../enumerations/PropertyGridMode.md)

The property grid mode.

#### Returns

`void`

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L353)

Updates the UI to reflect the current localization mode.

#### Returns

`void`
