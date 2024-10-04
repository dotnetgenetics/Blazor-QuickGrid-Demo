using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class DeliveryMethod
{
    public int DeliveryMethodId { get; set; }

    public string DeliveryMethodName { get; set; } = null!;

    public int LastEditedBy { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
