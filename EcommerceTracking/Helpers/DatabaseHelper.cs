using Microsoft.Data.SqlClient;
namespace EcommerceTracking.Helpers;
public static class DatabaseHelper
{
    // Change .\SQLEXPRESS if your SQL Server instance has a different name.
    private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=EcommerceTrackingDB;Trusted_Connection=True;TrustServerCertificate=True;";
    public static SqlConnection CreateConnection() => new(ConnectionString);
    public static async Task TestConnectionAsync()
    {
        await using var c = CreateConnection();
        await c.OpenAsync();
    }
}
