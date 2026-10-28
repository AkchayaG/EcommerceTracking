namespace EcommerceTracking.Models;
public sealed class Customer { public int CustomerId {get;set;} public string CustomerName {get;set;}=""; public string Email {get;set;}=""; public string? Phone {get;set;} public string Address {get;set;}=""; public bool IsActive {get;set;} public DateTime CreatedAt {get;set;} }
