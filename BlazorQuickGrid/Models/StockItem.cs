using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class StockItem
{
    public int StockItemId { get; set; }

    public string StockItemName { get; set; } = null!;

    public int SupplierId { get; set; }

    public int? ColorId { get; set; }

    public int UnitPackageId { get; set; }

    public int OuterPackageId { get; set; }

    public string? Brand { get; set; }

    public string? Size { get; set; }

    public int LeadTimeDays { get; set; }

    public int QuantityPerOuter { get; set; }

    public bool IsChillerStock { get; set; }

    public string? Barcode { get; set; }

    public decimal TaxRate { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal? RecommendedRetailPrice { get; set; }

    public decimal TypicalWeightPerUnit { get; set; }

    public string? MarketingComments { get; set; }

    public string? InternalComments { get; set; }

    public byte[]? Photo { get; set; }

    public string? CustomFields { get; set; }

    public string? Tags { get; set; }

    public string SearchDetails { get; set; } = null!;

    public int LastEditedBy { get; set; }

    public virtual Color? Color { get; set; }

    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<OrderLine> OrderLines { get; set; } = new List<OrderLine>();

    public virtual PackageType OuterPackage { get; set; } = null!;

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<SpecialDeal> SpecialDeals { get; set; } = new List<SpecialDeal>();

    public virtual StockItemHolding? StockItemHolding { get; set; }

    public virtual ICollection<StockItemStockGroup> StockItemStockGroups { get; set; } = new List<StockItemStockGroup>();

    public virtual ICollection<StockItemTransaction> StockItemTransactions { get; set; } = new List<StockItemTransaction>();

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual PackageType UnitPackage { get; set; } = null!;
}
