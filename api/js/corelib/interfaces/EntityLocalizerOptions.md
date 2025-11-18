[@serenity-is/corelib](../README.md) / EntityLocalizerOptions

# Interface: EntityLocalizerOptions

Defined in: [src/ui/dialogs/entitylocalizer.tsx:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L4)

## Properties

### byId()

> **byId**: (`id`) => [`Fluent`](Fluent.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L5)

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](Fluent.md)

***

### getButton()

> **getButton**: () => [`Fluent`](Fluent.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L8)

#### Returns

[`Fluent`](Fluent.md)

***

### getEntity()

> **getEntity**: () => `any`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L9)

#### Returns

`any`

***

### getLanguages()

> **getLanguages**: () => [`LanguageList`](../type-aliases/LanguageList.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L10)

#### Returns

[`LanguageList`](../type-aliases/LanguageList.md)

***

### getPropertyGrid()

> **getPropertyGrid**: () => [`Fluent`](Fluent.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L11)

#### Returns

[`Fluent`](Fluent.md)

***

### getToolButtons()

> **getToolButtons**: () => `HTMLElement`[]

Defined in: [src/ui/dialogs/entitylocalizer.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L12)

#### Returns

`HTMLElement`[]

***

### idPrefix

> **idPrefix**: `string`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L6)

***

### isNew()

> **isNew**: () => `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L7)

#### Returns

`boolean`

***

### pgOptions

> **pgOptions**: [`PropertyGridOptions`](PropertyGridOptions.md)

Defined in: [src/ui/dialogs/entitylocalizer.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L13)

***

### retrieveLocalizations()

> **retrieveLocalizations**: () => `PromiseLike`\<\{\[`languageId`: `string`\]: `any`; \}\>

Defined in: [src/ui/dialogs/entitylocalizer.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L14)

#### Returns

`PromiseLike`\<\{\[`languageId`: `string`\]: `any`; \}\>

***

### validateForm()

> **validateForm**: () => `boolean`

Defined in: [src/ui/dialogs/entitylocalizer.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitylocalizer.tsx#L15)

#### Returns

`boolean`
