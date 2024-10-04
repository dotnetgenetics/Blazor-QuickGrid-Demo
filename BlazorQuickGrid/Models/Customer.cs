using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public int BillToCustomerId { get; set; }

    public int CustomerCategoryId { get; set; }

    public int? BuyingGroupId { get; set; }

    public int PrimaryContactPersonId { get; set; }

    public int? AlternateContactPersonId { get; set; }

    public int DeliveryMethodId { get; set; }

    public int DeliveryCityId { get; set; }

    public int PostalCityId { get; set; }

    public decimal? CreditLimit { get; set; }

    public DateOnly AccountOpenedDate { get; set; }

    public decimal StandardDiscountPercentage { get; set; }

    public bool IsStatementSent { get; set; }

    public bool IsOnCreditHold { get; set; }

    public int PaymentDays { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string FaxNumber { get; set; } = null!;

    public string? DeliveryRun { get; set; }

    public string? RunPosition { get; set; }

    public string WebsiteUrl { get; set; } = null!;

    public string DeliveryAddressLine1 { get; set; } = null!;

    public string? DeliveryAddressLine2 { get; set; }

    public string DeliveryPostalCode { get; set; } = null!;

    public string PostalAddressLine1 { get; set; } = null!;

    public string? PostalAddressLine2 { get; set; }

    public string PostalPostalCode { get; set; } = null!;

    public int LastEditedBy { get; set; }

    public virtual Person? AlternateContactPerson { get; set; }

    public virtual Customer BillToCustomer { get; set; } = null!;

    public virtual BuyingGroup? BuyingGroup { get; set; }

    public virtual CustomerCategory CustomerCategory { get; set; } = null!;

    public virtual ICollection<CustomerTransaction> CustomerTransactions { get; set; } = new List<CustomerTransaction>();

    public virtual City DeliveryCity { get; set; } = null!;

    public virtual DeliveryMethod DeliveryMethod { get; set; } = null!;

    public virtual ICollection<Customer> InverseBillToCustomer { get; set; } = new List<Customer>();

    public virtual ICollection<Invoice> InvoiceBillToCustomers { get; set; } = new List<Invoice>();

    public virtual ICollection<Invoice> InvoiceCustomers { get; set; } = new List<Invoice>();

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual City PostalCity { get; set; } = null!;

    public virtual Person PrimaryContactPerson { get; set; } = null!;

    public virtual ICollection<SpecialDeal> SpecialDeals { get; set; } = new List<SpecialDeal>();

    public virtual ICollection<StockItemTransaction> StockItemTransactions { get; set; } = new List<StockItemTransaction>();
}
