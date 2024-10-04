using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class PackageType
{
    public int PackageTypeId { get; set; }

    public string PackageTypeName { get; set; } = null!;

    public int LastEditedBy { get; set; }

    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<StockItem> StockItemOuterPackages { get; set; } = new List<StockItem>();

    public virtual ICollection<StockItem> StockItemUnitPackages { get; set; } = new List<StockItem>();
}
