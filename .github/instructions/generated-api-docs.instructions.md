---
description: "Treat generated API reference files as read-only."
applyTo: "**/api/**"
---
Files under `api/` are auto-generated from XML (.NET) / JSDoc (TypeScript) comments. Do not edit, create, reformat, or delete them. Users will update them themselves through the generation workflow.