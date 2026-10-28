E-commerce Order & Delivery Tracking System
===========================================
1. Open this folder in Visual Studio or VS Code.
2. Ensure SQL Server Express is running and EcommerceTrackingDB tables exist.
3. Open Helpers/DatabaseHelper.cs and edit the connection string if needed.
4. Open terminal in this folder and run:
   dotnet restore
   dotnet run

Connection string default:
Server=.\SQLEXPRESS;Database=EcommerceTrackingDB;Trusted_Connection=True;TrustServerCertificate=True;

Features included: list/add customers and products, create order with transaction/stock deduction/audit log,
list orders, create delivery record, update delivery status, order report, recent audit logs.
Update/deactivate methods are included in services/repositories for further use from menu.
