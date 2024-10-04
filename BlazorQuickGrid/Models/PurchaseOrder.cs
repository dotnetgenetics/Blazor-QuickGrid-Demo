using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class PurchaseOrder
{
    public int PurchaseOrderId { get; set; }

    public int SupplierId { get; set; }

    public DateOnly OrderDate { get; set; }

    public int DeliveryMethodId { get; set; }

    public int ContactPersonId { get; set; }

    public DateOnly? ExpectedDeliveryDate { get; set; }

    public string? SupplierReference { get; set; }

    public bool IsOrderFinalized { get; set; }

    public string? Comments { get; set; }

    public string? InternalComments { get; set; }

    public int LastEditedBy { get; set; }

    public DateTime LastEditedWhen { get; set; }

    public virtual Person ContactPerson { get; set; } = null!;

    public virtual DeliveryMethod DeliveryMethod { get; set; } = null!;

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<StockItemTransaction> StockItemTransactions { get; set; } = new List<StockItemTransaction>();

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<SupplierTransaction> SupplierTransactions { get; set; } = new List<SupplierTransaction>();
}
