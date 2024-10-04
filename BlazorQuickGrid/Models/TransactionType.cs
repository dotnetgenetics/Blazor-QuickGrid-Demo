using System;
using System.Collections.Generic;

namespace BlazorQuickGrid.Models;

public partial class TransactionType
{
    public int TransactionTypeId { get; set; }

    public string TransactionTypeName { get; set; } = null!;

    public int LastEditedBy { get; set; }

    public virtual ICollection<CustomerTransaction> CustomerTransactions { get; set; } = new List<CustomerTransaction>();

    public virtual Person LastEditedByNavigation { get; set; } = null!;

    public virtual ICollection<StockItemTransaction> StockItemTransactions { get; set; } = new List<StockItemTransaction>();

    public virtual ICollection<SupplierTransaction> SupplierTransactions { get; set; } = new List<SupplierTransaction>();
}
