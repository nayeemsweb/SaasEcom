
# SaasEcom

Minimalistic SaaS E-Commerce application.

## Demo

![TicketPurchaseSystem](./src/Ecommerce/Ecommerce.Web/wwwroot/LandingSite/images/SaasEcom-2.png?raw=true)

## Installation

Firstly, clone the project-
```
https://github.com/nayeemsweb/SaasEcom.git
```
Secondly, Open the project in Visual Studio by running the `Ecommerce.sln` solution file - 
```
cd SaasEcom/src/Ecommerce
```
Thirdly, go to `docs` folder - 
```
cd SaasEcom/docs
```
There you will find a batch file named `SaasEcom_Migration_Runner.bat`. Run that batch file
and `Apply Migration` to update database.

This will create a database named `EcommerceDb` in your SQL Server (actually SSMS) and
also the table(s) accordingly.

⚠️ ***Your must have `SQL Server` and* `SQL Server Management Studio` 
installed on your machine.***


    
## Environment Variables

In the `SaasEcom/src/Ecommerce/Ecommerce.Web` path 
there is a file named `appsettings.json`. 
If you face in updating the migration then configure this line - 
```
"DefaultConnection": "Server=.\\SQLEXPRESS;Database=EcommerceDb;Trusted_Connection=True;"
```
Remember to keep the same `DefaultConnection` value in the `appsettings.json` files of 
`SaasEcom/src/Ecommerce/Ecommerce.Worker` and 
`SaasEcom/src/Ecommerce/EcommerceSubDomain.Worker` projects. 
You may change the `Server` value according to your configuration.


## Tech Stack

**Backend:** ASP.NET (Core) 6, Worker Service, Entity Framework (Core), Sql Server, 
Store Procedure

**Logger:** Serilog

**Dependency Injection:** Autofac

**Object-Object Mapper:** AutoMapper

**Design Patterns:** Repository & Unit of Work

**Architecture:** Layered Architecture - 3-Tier Architecture -
(UI, Business Logic & Data Access Layer)




## Features

- Store Creation & Setup
- Product Management
- Category Management
- Inventory
- Role Based Authentication & Authorization
- Social Login


## Support

❤️ If you do like my work, hit the ⭐️ button above. ❤️


## License

[MIT](https://choosealicense.com/licenses/mit/)