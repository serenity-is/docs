# MultiTenancy

In this tutorial, we are going to turn Movie Tutorial into a multi-tenant application.

According to Wikipedia, multi-tenant software is defined as follows:

> Software Multitenancy refers to a software architecture in which a single instance of a software runs on a server and serves multiple tenants. A tenant is a group of users who share a common access with specific privileges to the software instance. With a multitenant architecture, a software application is designed to provide every tenant a dedicated share of the instance including its data, configuration, user management, tenant individual functionality and non-functional properties. Multitenancy contrasts with multi-instance architectures, where separate software instances operate on behalf of different tenants. ---Wikipedia

We will add a `TenantId` field to every table, including the `Users` table, and restrict users to view and modify only the records belonging to their tenant. This ensures that tenants operate in isolation, as if they are working with their own database.

Multi-tenant applications offer several advantages, such as reduced management costs. However, they also come with disadvantages. For instance, since all tenant data resides in a single database, a tenant cannot easily back up or migrate their data independently. Additionally, performance may be impacted due to the increased volume of records.

With the growing trend of cloud applications, reduced virtualization costs, and features like migration, setting up multi-instance applications has become more feasible.

While I personally recommend having a separate database for each customer, this tutorial will address the implementation of multitenancy due to user requests. It will also cover some advanced topics in Serenity as an added benefit.

### About the Tutorial Project

Previously, we followed the Movie Tutorial. For implementing multitenancy, we will continue using the Movie Tutorial project.