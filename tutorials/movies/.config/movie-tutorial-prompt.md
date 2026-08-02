I want you to follow this tutorial like a junior developer with no prior Serenity experience, and 
check if the instructions works as expected, and any code blocks are as they were shown in the tutorial and if there are any grammar / readability issues.

As you don't have access to Visual Studio at the moment, you may create a project from the command line using `dotnet new serene -n MovieTutorial_yyMMdd_hhmm` where yyMMdd_hhmm should be replaced based on current date/time. Run this command under p:\internal\tutorial folder. This will create a web project under folder p:\internal\tutorial\MovieTutorial_yyMMdd_hhmm\MovieTutorial_yyMMdd_hhmm.Web. Apply further edits and run project in this folder. Note that as unlike the tutorial, the project won't be named MovieTutorial_yyMMdd_hhmm so when checking things like database adjust the names accordingly, e.g. MovieTutorial_Default_v1 database will be named MovieTutorial_yyMMdd_hhmm_Default_v1.

There are images and videos in the tutorial that you should skip checking for now. Only check the code blocks / outputs.

Note that when performing operations like saving, deleting, searching etc. in dialogs/grids, the operations are async so wait a few seconds before checking the browser state.

Tips from a previous run of this tutorial (applies to this project):
- Use the modern TypeScript registration style in any new/edited .tsx files (the tutorial's `@Decorators.*` style is deprecated): editors → `static override [Symbol.typeInfo] = this.registerEditor("Full.Name");`, dialogs/grids → `static override [Symbol.typeInfo] = this.registerClass("Full.Name")`, formatters (as no base class) → `static [Symbol.typeInfo] = formatterTypeInfo("Full.Name"); static { registerType(this); }`.
- For registration, PREFER the namespace constants from `Modules/ServerTypes/Namespaces.ts` (e.g. `import { nsMovieDB } from "../../ServerTypes/Namespaces"; static override [Symbol.typeInfo] = this.registerClass(nsMovieDB);`) — `nsMovieDB` already ends with a dot and the class name is auto-appended (a type full name can't end with a dot). Do NOT hardcode full names like `"Ns.Module.Class"`; the sergen trailing-dot string is acceptable but the ns constant is preferred (and survives namespace changes). (Any tutorial note that says to register with the full name is outdated.)
- In C#, use `[SkipNameCheck]` instead of the obsolete `[IgnoreName]`.
- `sergen` can be run non-interactively: `dotnet sergen g -cnk Default -tbl "dbo.TableName" -mod MovieDB -cls X -pms "Administration:General" -wtg "*"` (the `dbo.` schema prefix is required; `-wtg "RS"` = Row & Services only). Run it from the project dir (or prefix with `& { Set-Location '<project dir>'; ... }`, as the terminal cwd resets between commands).
- Adjust namespaces in every code block: `MovieTutorial.` → the actual project namespace (`MovieTutorial_<timestamp>.`). Database names follow the project name too.
- The grid quick search input is `.s-QuickSearchInput`; the sidebar search also has placeholder "search...", don't confuse the two.
- Verify DB with: `sqlcmd -S "(localdb)\MsSqlLocalDB" -d <ProjectName>_Default_v1 -Q "..." -W`
- Stop the running app before trying to build/run again: while the app is running the exe is locked, so `dotnet build`/`dotnet run` fails with MSB3026/MSB3027 (file in use). Kill the app process first.
- The browser is opened in VS Code's internal browser, which can be narrow in width, so the left navigation sidebar may be hidden/collapsed. If you don't see the navigation (e.g. the MovieDB section), either zoom out from the default zoom level or click the expander/hamburger button at the top-left of the page.
- Panel style dialog close button is `.panel-titlebar-close` (a toolbar/header button); pressing Escape does NOT close panel style dialogs.
- Form tabs: to activate a tab (e.g. a `[Tab(...)]` in a form), click the inner `a[href="#...TabN"]` link, not the `[role=tab]`/`.nav-item` wrapper. The tab panel stays `display:none` (and any grid inside it has 0 width) until the tab is actually active.
- Serenity uses a select2-style widget for dropdown editors (EnumEditor, LookupEditor, ServiceLookupEditor, etc.). To open/read such a dropdown, click the `.select2-choice` element; options appear in `.select2-drop .select2-results li` (a native `<select>` may not exist).
- Grid quick search has a ~500ms debounce (`typeDelay`). Playwright `fill()` doesn't trigger it — after setting the value, dispatch `execute-search` (immediate) or `change`/`keyup` (respects the 500ms debounce) on `.s-QuickSearchInput`, then wait ~600ms before reading the grid.
- run_in_terminal resets cwd between calls; use `& { Set-Location '<project dir>'; <cmd> }` to run in a specific dir.
- Run the dev server on a non-blocked port: the browser blocks port 5060 (`net::ERR_UNSAFE_PORT`, it's the SIP port), so use e.g. `dotnet run --urls http://localhost:8080`.
- Template name is case-sensitive: `dotnet new serene` (lowercase), not `Serene`.
- `dotnet new serene` creates the project in the terminal's CURRENT directory (and the terminal cwd resets between commands). `Set-Location` into the target folder first or pass `-o <folder>`.
- Toolbar buttons are divs (`.tool-button`): click the `.tool-button` element itself, not the inner `<span>` (Save, Delete, New Movie, Refresh, etc.). Clicking the span can time out.
- Serene template default login is `admin` / `serenity` (not admin/admin).
- Build/transform ordering gotcha: server typings read the COMPILED assembly.
- Interactive `dotnet sergen g` is a Spectre TUI: Enter to accept, `\u001b[B` for down arrow; a literal space is only delivered when sent mid-string (e.g. `"a b"`), whitespace-only sends become just Enter.
- MasterDetailRelation ColumnsType from a Row must be qualified: `typeof(Columns.MovieCastColumns)`.
- Generated clienttype attribute FILES are named after the full namespace: a formatter registered under a module (e.g. `nsMovieDB + "X"` → `MovieTutorial_<ts>.MovieDB.X`) generates `Imports/ClientTypes/MovieDB.XAttribute.cs` (module-prefixed filename), not `XAttribute.cs`. Search for the module-prefixed filename when looking for a generated attribute.
- Run `npx tsc --noEmit` (or `tsc`) in the project dir after TS edits to catch type errors — the esbuild watch does NOT type-check, so TS errors (e.g. missing `override` on overridden protected methods like `getQuickSearchFields`/`getQuickFilters`) can slip through. The tutorial's code blocks often omit the `override` modifier, so add it wherever a method overrides a base class member.
- Sample data dates in the tutorials are often DD.MM.YYYY (Turkish); with an en-US browser culture the date editor expects MM/DD/YYYY and can mangle input (e.g. 15.03.2004 → 03/03/2005).
- Form/dialog editor props declared as plain `int` FK fields render as IntegerEditors (numeric ID input), not dropdowns — add a lookup editor type for a dropdown.
- In master-detail setups, detail records only persist when the MASTER dialog's Save is clicked (not the detail dialog's).

After checking every chapter, fix identified issues and please pause and ask me to continue to next chapter.