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

Defined in: [src/ui/dialogs/entitylocalizer.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L15)

Returns the localization toggle button.

#### Returns

[`Fluent`](Fluent.md)

***

### getEntity()

> **getEntity**: () => `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L17)

Returns the current entity.

#### Returns

`any`

***

### getLanguages()

> **getLanguages**: () => [`LanguageList`](../type-aliases/LanguageList.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L19)

Returns the list of available languages.

#### Returns

[`LanguageList`](../type-aliases/LanguageList.md)

***

### getPropertyGrid()

> **getPropertyGrid**: () => [`Fluent`](Fluent.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L21)

Returns the property grid element.

#### Returns

[`Fluent`](Fluent.md)

***

### getToolButtons()

> **getToolButtons**: () => `HTMLElement`[]

Defined in: [src/ui/dialogs/entitylocalizer.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L23)

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

### pgOptions

> **pgOptions**: [`PropertyGridOptions`](PropertyGridOptions.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L25)

Options for the localization property grid.

***

### retrieveLocalizations()

> **retrieveLocalizations**: () => `PromiseLike`\<\{\[`languageId`: `string`\]: `any`; \}\>

Defined in: [src/ui/dialogs/entitylocalizer.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L27)

Retrieves existing localizations for the entity.

#### Returns

`PromiseLike`\<\{\[`languageId`: `string`\]: `any`; \}\>

***

### validateForm()

> **validateForm**: () => `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L29)

Validates the main form before switching modes.

#### Returns

`boolean`
