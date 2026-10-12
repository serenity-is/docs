[@serenity-is/corelib](../README.md) / EntityLocalizerOptions

# Interface: EntityLocalizerOptions

Defined in: [src/ui/dialogs/entitylocalizer.tsx:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L7)

Options for the [EntityLocalizer](../classes/EntityLocalizer.md).

## Properties

### byId()

> **byId**: (`id`) => [`Fluent`](Fluent.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L9)

Resolves an element by id within the dialog.

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](Fluent.md)

***

### getButton()

> **getButton**: () => [`Fluent`](Fluent.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L22)

Returns the localization toggle button.

#### Returns

[`Fluent`](Fluent.md)

***

### getEntity()

> **getEntity**: () => `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L24)

Returns the current entity.

#### Returns

`any`

***

### getLanguages()

> **getLanguages**: () => [`LanguageList`](../type-aliases/LanguageList.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L26)

Returns the list of available languages.

#### Returns

[`LanguageList`](../type-aliases/LanguageList.md)

***

### getPropertyGrid()

> **getPropertyGrid**: () => [`Fluent`](Fluent.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L28)

Returns the property grid element.

#### Returns

[`Fluent`](Fluent.md)

***

### getToolButtons()

> **getToolButtons**: () => `HTMLElement`[]

Defined in: [src/ui/dialogs/entitylocalizer.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L30)

Returns the toolbar button elements.

#### Returns

`HTMLElement`[]

***

### idPrefix

> **idPrefix**: `string`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L11)

Id prefix used for generated elements.

***

### isNew()

> **isNew**: () => `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L13)

Whether the entity is new (no id).

#### Returns

`boolean`

***

### mapSourceItem()?

> `optional` **mapSourceItem**: (`item`) => [`PropertyItem`](PropertyItem.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L20)

Maps a source property item to the item used in the localization grid. The default
returns the item as is. Return an item with `localizable: false` to skip it, or a copy
with modified permissions / insertable / updatable flags to customize editability
(e.g. require a translation specific permission).

#### Parameters

##### item

[`PropertyItem`](PropertyItem.md)

#### Returns

[`PropertyItem`](PropertyItem.md)

***

### pgOptions

> **pgOptions**: [`PropertyGridOptions`](PropertyGridOptions.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L32)

Options for the localization property grid.

***

### retrieveLocalizations()

> **retrieveLocalizations**: () => `PromiseLike`\<\{\[`languageId`: `string`\]: `any`; \}\>

Defined in: [src/ui/dialogs/entitylocalizer.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L34)

Retrieves existing localizations for the entity.

#### Returns

`PromiseLike`\<\{\[`languageId`: `string`\]: `any`; \}\>

***

### validateForm()

> **validateForm**: () => `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L36)

Validates the main form before switching modes.

#### Returns

`boolean`
