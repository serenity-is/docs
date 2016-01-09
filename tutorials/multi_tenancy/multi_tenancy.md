# Multi Tenancy

In this tutorial we are going to turn Norhwind into a multi-tenant application.

Here is a definition of multi-tenant sofware from Wikipedia:

> Software Multitenancy refers to a software architecture in which a single instance of a software runs on a server and serves multiple tenants. A tenant is a group of users who share a common access with specific privileges to the software instance. With a multitenant architecture, a software application is designed to provide every tenant a dedicated share of the instance including its data, configuration, user management, tenant individual functionality and non-functional properties. Multitenancy contrasts with multi-instance architectures, where separate software instances operate on behalf of different tenants. ---Wikipedia

We'll add a TenantId field to every table, including Users, and let user see and modify only records belonging to her tenant. So, tenants will work in isolation, as if they are working with their own database.

Multi tenant applications has some advantages like reduced cost of management. But they also have some disadvantages. For example, as all tenant data is in a single database, a tenant can't simply take or backup her data. And performance is usually reduced.

With increasing trend of cloud applications, decreased cost of virtualization, and with features like migration, its now easier to setup multi-instance apps. 

I'd personally avoid multi-tenant applications. It's better to have one database per customer in my opinion. 

But some users asked about how to implement this feature. This tutorial will help us explaining some advanced Serenity topics as a bonus, along with multi tenancy.