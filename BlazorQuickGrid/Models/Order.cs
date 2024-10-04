using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public int SalespersonPersonId { get; set; }

    public int? PickedByPersonId { get; set; }

    public int ContactPersonId { get; set; }

    public int? BackorderOrderId { get; set; }

    public DateOnly OrderDate { get; set; }

    public DateOnly ExpectedDeliveryDate { get; set; }

    public string? CustomerPurchaseOrderNumber { get; set; }

    public bool IsUndersupplyBackordered { get; set; }

    public string? Comments { get; set; }

    public string? DeliveryInstructions { get; set; }

    public string? InternalComments { get; set; }

    public DateTime? PickingCompletedWhen { get; set; }

    public int LastEditedBy { get; set; }

    public DateTime LastEditedWhen { get; set; }

    public virtual Order? BackorderOrder { get; set; }

    public virtual Person ContactPerson { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Order> InverseBackorderOrder { get; set; } = new List<Order>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

    public virtual Person? PickedByPerson { get; set; }

    public virtual Person SalespersonPerson { get; set; } = null!;
}
